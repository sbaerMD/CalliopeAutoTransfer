using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalliopeAutoTransfer
{
    public partial class MainForm : Form
    {
        private CalliopeConnection _calliopeConnection;
        private FileSystem _fileSystem;

        public MainForm()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                init();
                BeginInvoke(new Action(afterInit));
            });
        }


        #region calliope handling
        internal string CalliopeDrive
        {
            get => _calliopeConnection?.Drive;
            set
            {
                if(_calliopeConnection?.Drive == value)
                    return;
                newCalliopeConnection(value);
            }
        }

        private void newCalliopeConnection(string value)
        {
            if (_calliopeConnection != null)
            {
                _calliopeConnection.Close();
                _calliopeConnection.Connected -= CalliopeConnectionOnConnected;
                _calliopeConnection.Disconnected -= CalliopeConnectionOnDisconnected; 
            }

            _calliopeConnection =
                new CalliopeConnection(value, CalliopeConnectionOnConnected, CalliopeConnectionOnDisconnected);
        }

        private void CalliopeConnectionOnConnected()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(CalliopeConnectionOnConnected));
                return;
            }
            CalliopeVerbundenLabel_.Text = "verbunden";
            calliopePicture.Image = Properties.Resources.Calliope;
            CalliopeVerbundenLabel.ForeColor = Color.Green;

            if (!String.IsNullOrEmpty(_transferDatei))
            {
                transferPanel.Hide();
                PrüfenLabel.Text = $"Datei '{Path.GetFileName(_transferDatei)}' wurde auf Deinen Calliope übertragen!\nDu kannst den Calliope jetzt trennen.";
                PrüfenLabel.BackColor = Color.LightGreen;
                _transferDatei = String.Empty;
            }
        }

        private void CalliopeConnectionOnDisconnected()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(CalliopeConnectionOnDisconnected));
                return;
            }
            CalliopeVerbundenLabel_.Text = "nicht verbunden";
            calliopePicture.Image = Properties.Resources.Calliope_sepia;
            CalliopeVerbundenLabel.ForeColor = Color.DarkOrange;

            PrüfenLabel.Text = String.Empty;
            PrüfenLabel.BackColor = Color.Transparent;
        }
        #endregion

        #region folder handling
        internal string DownloadFolder
        {
            get => _fileSystem?.Folder;
            set
            {
                if (_fileSystem?.Folder == value)
                    return;
                newFileSystemHandler(value);
            }
        }

        private void newFileSystemHandler(string value)
        {
            if (_fileSystem != null)
            {
                _fileSystem.Close();
                _fileSystem.NewFile -= FileSystemOnNewFile;
                _fileSystem.NewFileList -= FileSystemOnNewFileList;
            }
            _fileSystem?.Close();
            _fileSystem = new FileSystem(value, FileSystemOnNewFile, FileSystemOnNewFileList);
        }

        private void FileSystemOnNewFile(string file)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(FileSystemOnNewFile), file);
                return;
            }

            _transferDatei = file;
            TransferDateiLabel.Text =  Path.GetFileName(_transferDatei);
            filePicture.Image = Properties.Resources.Projekt_gruen;
            transferPanel.Hide();
            PrüfenLabel.Text = String.Empty;
            PrüfenLabel.BackColor = Color.Transparent;
        }

        private void FileSystemOnNewFileList(IEnumerable<string> files)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<IEnumerable<string>>(FileSystemOnNewFileList), files);
                return;
            }
            filesPanel.Controls.Clear();
            foreach (var file in files)
            {
                addButtonFor(file);
            }
        }

        private void addButtonFor(string file)
        {
            var button = new Button
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Size = new Size(200,80),
                Text = Path.GetFileNameWithoutExtension(file),
                Font =  new Font(Font.FontFamily, 12),
            };
            button.Click += (sender, args) =>
            {
                _fileSystem?.ForExisitingFile(file, fullName =>
                {
                    if (!_calliopeConnection.Ready())
                    {
                        PrüfenLabel.Text =
                            $"Deinen Calliope ist nicht verbunden. Die Datei kann nicht übertragen werden.";
                        PrüfenLabel.BackColor = Color.OrangeRed;
                        return;
                    }

                    _transferDatei = fullName;
                    _calliopeConnection?.CopyFrom(fullName);
                    ShowCopyStart();
                });
            };
            toolTip1.SetToolTip(button, file);
            filesPanel.Controls.Add(button);
        }

        #endregion

        private void init()
        {
            DownloadFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads");
            CalliopeDrive = @"E:\";
        }

        private void afterInit()
        {
            downloadFolderTextbox.Text = DownloadFolder;
            calliopeDriveDropdown.SelectedItem = CalliopeDrive;
            timer.Enabled = true;
            CalliopeConnectionOnDisconnected();
        }

        private void ÜbernehmenButton_Click(object sender, EventArgs e)
        {
            DownloadFolder = downloadFolderTextbox.Text;
            CalliopeDrive = calliopeDriveDropdown.SelectedItem.ToString();
        }

        string _transferDatei = String.Empty;

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var übertragungsdateiNochVorhanden = File.Exists(_transferDatei);
                if (übertragungsdateiNochVorhanden)
                {
                    TransferDateiLabel.Text = Path.GetFileName(_transferDatei);
                    filePicture.Image = Properties.Resources.Projekt_gruen;
                }
                else
                {
                    TransferDateiLabel.Text = "keine (neue) Übertragungsdatei";
                    filePicture.Image = Properties.Resources.Projekt_grau;
                }

                var angeschlossenUndBereit = _calliopeConnection?.Ready() ?? false;

                if (übertragungsdateiNochVorhanden && angeschlossenUndBereit && AutomaticON.Checked)
                {
                    _calliopeConnection.CopyFrom(_transferDatei);
                    ShowCopyStart();
                    
                    ShowMe();
                }
            }
            catch (Exception exception)
            {
                PrüfenLabel.Text = exception.Message;
            }
        }

        private void ShowMe()
        {
            TopMost = true;
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Maximized;
            Show();
            TopMost = false;
        }

        private void ShowCopyStart()
        {
            transferPanel.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _calliopeConnection?.Close();
        }
    }
}
