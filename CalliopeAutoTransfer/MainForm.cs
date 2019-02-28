using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CalliopeAutoTransfer.model;

namespace CalliopeAutoTransfer
{
    public partial class MainForm : Form, IView
    {
        public event Action<Setting> ChangeSettings;
        public event Action End;

        public MainForm()
        {
            InitializeComponent();
        }

        #region IView
        public void ShowSettings(Setting setting)
        {
            doInUi(() =>
            {
                downloadFolderTextbox.Text = setting.DownloadFolder;
                calliopeDriveDropdown.SelectedItem = setting.CalliopeDrive;
                AutomaticON.Checked = setting.TransferNewFileAutomatic;
            });
        }
        public void ShowCalliopeStatus(CalliopeStatus status)
        {
            doInUi(() =>
            {
                switch (status)
                {
                    case CalliopeStatus.Connected:
                        CalliopeVerbundenLabel_.Text = TextFor.Connected;
                        calliopePicture.Image = Properties.Resources.Calliope;
                        CalliopeVerbundenLabel.ForeColor = Color.Green;
                        break;
                    case CalliopeStatus.AwaitingRestart:
                        CalliopeVerbundenLabel_.Text = TextFor.AwaitingRestart;
                        calliopePicture.Image = Properties.Resources.Calliope;
                        CalliopeVerbundenLabel.ForeColor = Color.DodgerBlue;
                        break;
                    case CalliopeStatus.Restarting:
                        CalliopeVerbundenLabel_.Text = TextFor.Restarting;
                        calliopePicture.Image = Properties.Resources.Calliope;
                        CalliopeVerbundenLabel.ForeColor = Color.DodgerBlue;
                        break;
                    case CalliopeStatus.Restarted:
                        CalliopeVerbundenLabel_.Text = TextFor.Restarted;
                        calliopePicture.Image = Properties.Resources.Calliope;
                        CalliopeVerbundenLabel.ForeColor = Color.Green;
                        break;

                    case CalliopeStatus.Disconnected:
                    default:
                        CalliopeVerbundenLabel_.Text = TextFor.Disconnected;
                        calliopePicture.Image = Properties.Resources.Calliope_sepia;
                        CalliopeVerbundenLabel.ForeColor = Color.DarkOrange;
                        break;

                }
            });
        }
        public void ShowTransferIndicator()
        {
            doInUi(() => transferPanel.Show());
        }
        public void HideTransferIndicator()
        {
            doInUi(() => transferPanel.Hide());
        }
        public void ShowTransferInformation(string info)
        {
            doInUi(() =>
            {
                PrüfenLabel.Text = info;
                PrüfenLabel.BackColor = !String.IsNullOrEmpty(info) ? Color.LightGreen : Color.Transparent;
            });
        }
        public void ShowFileStatus(string fileName)
        {
            doInUi(() =>
            {
                if (String.IsNullOrEmpty(fileName))
                {
                    TransferDateiLabel.Text = TextFor.NoProjectFileText;
                    filePicture.Image = Properties.Resources.Projekt_grau;
                }
                else
                {
                    TransferDateiLabel.Text = fileName;
                    filePicture.Image = Properties.Resources.Projekt_gruen;
                }
            });
        }
        public void ShowProjectFiles(IEnumerable<string> files, Action<string> clickCallback)
        {
            doInUi(() =>
            {
                filesPanel.Controls.Clear();
                foreach (var file in files)
                    addButtonFor(file, clickCallback);
            });
        }
        private void addButtonFor(string file, Action<string> clickCallback)
        {
            var button = new Button
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Size = new Size(200, 80),
                Text = Path.GetFileNameWithoutExtension(file),
                Font = new Font(Font.FontFamily, 12),
            };
            button.Click += (sender, args) => clickCallback?.Invoke(file);
            toolTip1.SetToolTip(button, file);
            filesPanel.Controls.Add(button);
        }
        public void ShowError(string message, string title)
        {
            doInUi(() => MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop));
        }
        public void EnsureVisible()
        {
            doInUi(() =>
            {
                TopMost = true;
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Maximized;
                Show();
                TopMost = false;
            });
        }
        private void doInUi(Action action)
        {
            if (InvokeRequired)
                BeginInvoke(action);
            else
                action();
        }
        #endregion

        #region UI handler
        private void ÜbernehmenButton_Click(object sender, EventArgs e)
        {
            ChangeSettings?.Invoke(new Setting
            {
                DownloadFolder = downloadFolderTextbox.Text,
                CalliopeDrive = calliopeDriveDropdown.SelectedItem.ToString()
            });
        }
        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = downloadFolderTextbox.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                downloadFolderTextbox.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            End?.Invoke();            
        }
        #endregion
    }
}
