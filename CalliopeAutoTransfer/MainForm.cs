using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CalliopeAutoTransfer
{
    public partial class MainForm : Form
    {
        private string _downloadFolder;
        private string _calliopeDrive;
        private List<string> _fileHashes = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _downloadFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads");
            downloadFolderTextbox.Text = _downloadFolder;
            _calliopeDrive = @"D:\";
            calliopeDriveDropdown.SelectedItem = _calliopeDrive;
            scanForHexFiles();
            timer.Enabled = true;
            timer_Tick(null, null);
        }

        private void ÜbernehmenButton_Click(object sender, EventArgs e)
        {
            _downloadFolder = downloadFolderTextbox.Text;
            _calliopeDrive = calliopeDriveDropdown.SelectedItem.ToString();
            _fileHashes.Clear();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            timer.Enabled = true;
            PrüfenLabel.Text = "Prüfen ...";
        }


        private bool _DateiWirdGeradeÜbertragen = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            if(_DateiWirdGeradeÜbertragen)
                return;
            try
            {
                var transferDatei = neuesteHexDatei();
                var übertragungsdateiVorhanden = false;
                if (String.IsNullOrEmpty(transferDatei))
                {
                    TransferDateiLabel.Text = "keine Übertragungsdatei";
                    TransferDateiLabel.BackColor = Color.DarkOrange;
                    übertragungsdateiVorhanden = true;
                }
                else
                {
                    TransferDateiLabel.Text = "Übertragungsdatei:\n" + Path.GetFileName(transferDatei);
                    TransferDateiLabel.BackColor = Color.LightGreen;
                }

                var angeschlossenUndBereit = calliopeAngeschlossenUndBereit();
                if (angeschlossenUndBereit)
                {
                    CalliopeVerbundenLabel.Text = "Calliope verbunden";
                    CalliopeVerbundenLabel.BackColor = Color.LightGreen;
                }
                else
                {
                    CalliopeVerbundenLabel.Text = "Calliope nicht verbunden";
                    CalliopeVerbundenLabel.BackColor = Color.DarkOrange;
                }


                if (übertragungsdateiVorhanden && angeschlossenUndBereit)
                {
                    übertragen(transferDatei);
                    PrüfenLabel.Text = $"Datei '{Path.GetFileName(transferDatei)}' wurde auf Deinen Calliope übertragen!\nWeiter mit [Ok]";
                    timer.Enabled = false;
                    TopMost = true;
                    WindowState = FormWindowState.Maximized;
                    Show();
                    TopMost = false;
                }
            }
            catch (Exception exception)
            {
                PrüfenLabel.Text = exception.Message;
            }
        }

        private void übertragen(string transferDatei)
        {
            _DateiWirdGeradeÜbertragen = true;
            try
            {
                File.Copy(
                    transferDatei, 
                    Path.Combine( _calliopeDrive, Path.GetFileName(transferDatei)));
                var checksum = GetChecksum(transferDatei);
                _fileHashes.Add(checksum);
            }
            catch
            {
                
            }
            _DateiWirdGeradeÜbertragen = false;
        }

        private bool calliopeAngeschlossenUndBereit()
        {
            try
            {
                return !Directory.GetFiles(_calliopeDrive, "*.hex").Any();
            }
            catch
            {
                return false;
            }
        }

        private void scanForHexFiles()
        {
            var dateiPfade = Directory.GetFiles(_downloadFolder, "*.hex");
            foreach (var pfad in dateiPfade)
            {
                var checksum = GetChecksum(pfad);
                if(!_fileHashes.Contains(checksum))
                    _fileHashes.Add(checksum);
            }
        }

        private static string GetChecksum(string pfad)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {
                    FileStream fileStream = new FileInfo(pfad).Open(FileMode.Open);
                    fileStream.Position = 0;
                    byte[] hashValue = mySHA256.ComputeHash(fileStream);
                    fileStream.Close();
                    return Convert.ToBase64String(hashValue);
                }
                catch 
                {
                    return String.Empty;
                }
            }
        }

        private string neuesteHexDatei()
        {
            var dateiPfade = Directory.GetFiles(_downloadFolder, "*.hex");
            foreach (var pfad in dateiPfade)
            {
                var checksum = GetChecksum(pfad);
                if (!_fileHashes.Contains(checksum))
                {
                    return pfad;
                }
            }
            return String.Empty;
        }
    }
}
