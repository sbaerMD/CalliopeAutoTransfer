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
            CalliopeVerbundenLabel.Text = "Calliope verbunden";
            CalliopeVerbundenLabel.BackColor = Color.LightGreen;

            if (!String.IsNullOrEmpty(_transferDatei))
            {

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
            CalliopeVerbundenLabel.Text = "Calliope nicht verbunden";
            CalliopeVerbundenLabel.BackColor = Color.DarkOrange;

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
            ProjectFiles.SelectedItem = Path.GetFileName(file);
            TransferDateiLabel.Text = "Übertragungsdatei:\n" + Path.GetFileName(_transferDatei);
            TransferDateiLabel.BackColor = Color.LightGreen;
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
            ProjectFiles.BeginUpdate();
            var itemsToDelete = new List<string>();
            foreach (string item in ProjectFiles.Items)
            {
                if(!files.Any(f => Path.GetFileName(f) == item))
                    itemsToDelete.Add(item);
            }
            itemsToDelete.ForEach(ProjectFiles.Items.Remove);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                if (!ProjectFiles.Items.Contains(fileName))
                    ProjectFiles.Items.Add(fileName);
            }
            ProjectFiles.EndUpdate();
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        string _transferDatei = String.Empty;

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var übertragungsdateiNochVorhanden = File.Exists(_transferDatei);
                if (übertragungsdateiNochVorhanden)
                {
                    TransferDateiLabel.Text = "Übertragungsdatei:\n" + Path.GetFileName(_transferDatei);
                    TransferDateiLabel.BackColor = Color.LightGreen;
                }
                else
                {
                    TransferDateiLabel.Text = "keine (neue) Übertragungsdatei";
                    TransferDateiLabel.BackColor = Color.DarkOrange;
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
            PrüfenLabel.Text =
                $"Datei '{Path.GetFileName(_transferDatei)}' wird auf Deinen Calliope übertragen!";
            PrüfenLabel.BackColor = Color.Yellow;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _calliopeConnection?.Close();
        }

        private void Übertragen_Click(object sender, EventArgs e)
        {
            _fileSystem?.ForExisitingFile(ProjectFiles.SelectedItem?.ToString(), fullName =>
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
        }
    }
}
