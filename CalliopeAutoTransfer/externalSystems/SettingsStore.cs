using System;
using System.IO;
using CalliopeAutoTransfer.model;

namespace CalliopeAutoTransfer.externalSystems
{
    internal class SettingsStore
    {
        public void Save(Setting setting)
        {
            Properties.Settings.Default.DownloadFolder = setting.DownloadFolder;
            Properties.Settings.Default.CalliopeDrive = setting.CalliopeDrive;
            Properties.Settings.Default.Save();
        }

        public Setting Load()
        {
            var userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var defaultFolder = Path.Combine(userProfilePath, "Downloads");
            var defaultDrive = @"E:\";

            var folder = Properties.Settings.Default.DownloadFolder;
            if (String.IsNullOrEmpty(folder))
                folder = defaultFolder;
            var drive = Properties.Settings.Default.CalliopeDrive ?? defaultDrive;
            if (String.IsNullOrEmpty(drive))
                drive = defaultDrive;
            return new Setting
            {
                DownloadFolder = folder,
                CalliopeDrive = drive,
                TransferNewFileAutomatic = Properties.Settings.Default.TransferNewFileAutomatic
            };
        }
    }
}
