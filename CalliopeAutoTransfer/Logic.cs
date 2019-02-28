using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CalliopeAutoTransfer.externalSystems;
using CalliopeAutoTransfer.model;

namespace CalliopeAutoTransfer
{
    internal class Logic
    {
        private readonly SettingsStore _settingsStore;
        private CalliopeConnection _calliopeConnection;
        private FileSystem _fileSystem;
        private readonly IView _view;
        private string _newTransferFile;

        public Logic(SettingsStore settingsStore, IView view)
        {
            _settingsStore = settingsStore;

            _view = view;
            _view.ChangeSettings += ViewOnChangeSettings;
            _view.End += ViewOnEnd;
        }


        private void ViewOnChangeSettings(Setting settings)
        {
            var beforeSave = _settingsStore.Load();
            _settingsStore.Save(settings);
            var afterSave = _settingsStore.Load();
            
            _view.ShowSettings(afterSave);

            if(beforeSave.CalliopeDrive != afterSave.CalliopeDrive)
                newCalliopeConnection(afterSave.CalliopeDrive);

            if(beforeSave.DownloadFolder != afterSave.DownloadFolder)
                newFileSystemHandler(afterSave.DownloadFolder);
        }

        private void ViewOnEnd()
        {
            _calliopeConnection?.Close();
            _fileSystem?.Close();
        }

        public void Start()
        {
            var setting = _settingsStore.Load();
            _view.ShowSettings(setting);
            _view.HideTransferIndicator();
            newCalliopeConnection(setting.CalliopeDrive);
            newFileSystemHandler(setting.DownloadFolder);
            _view.ShowProjectFiles(_fileSystem.Files, startManualTransfer);
        }

        private void newCalliopeConnection(string value)
        {
            _calliopeConnection?.Close();
            _calliopeConnection =
                new CalliopeConnection(value, calliopeConnectionOnConnected, calliopeConnectionOnDisconnected, statusChanged);
        }

        private void statusChanged(CalliopeStatus status)
        {
            _view.ShowCalliopeStatus(status);
            Debug.WriteLine($"Status: {status}");
        }

        private void calliopeConnectionOnConnected()
        {
            if (_calliopeConnection.Status == CalliopeStatus.Restarted)
            {
                _view.HideTransferIndicator();
                var fileName = Path.GetFileName(_newTransferFile);
                _view.ShowTransferInformation(TextFor.TransferSuccess(fileName));
                _newTransferFile = String.Empty;
                return;
            }
            checkForTransfer();         
        }

        private void calliopeConnectionOnDisconnected()
        {
            if (_calliopeConnection.Status == CalliopeStatus.Restarting)
            {
                _view.HideTransferIndicator();
            }
            if(_calliopeConnection.Status == CalliopeStatus.Disconnected)
                _view.ShowTransferInformation(String.Empty);
        }
        private void initTransfer(string file)
        {
            _newTransferFile = file;
            _calliopeConnection?.CopyFrom(file);
            _view.ShowTransferIndicator();
            _view.EnsureVisible();
        }

        private void newFileSystemHandler(string value)
        {
            _fileSystem?.Close();
            _fileSystem = new FileSystem(value, FileSystemOnNewFile, FileSystemOnNewFileList);
        }

        private void FileSystemOnNewFile(string file)
        {
            _newTransferFile = file;
            _view.ShowFileStatus(Path.GetFileName(_newTransferFile));
            _view.HideTransferIndicator();
            _view.ShowTransferInformation(String.Empty);
            checkForTransfer();
        }

        private void FileSystemOnNewFileList(IEnumerable<string> files)
        {
            _view.ShowProjectFiles(files, startManualTransfer);
        }

        private void startManualTransfer(string file)
        {
            if (String.IsNullOrEmpty(file) || !File.Exists(file))
                return;
            if (!_calliopeConnection.Ready())
            {
                _view.ShowError(TextFor.CalliopeNotConnectedErrorMessage, TextFor.CalliopeNotConnectedErrorTitle);
                return;
            }
            initTransfer(file);
        }

        private void checkForTransfer()
        {
            try
            {
                var fileExists = File.Exists(_newTransferFile);
                _view.ShowFileStatus(
                    fileExists 
                        ? Path.GetFileName(_newTransferFile) 
                        : String.Empty);

                var calliopeReady = _calliopeConnection?.Ready() ?? false;

                if (
                    fileExists && 
                    calliopeReady &&
                    _settingsStore.Load().TransferNewFileAutomatic)
                {
                    initTransfer(_newTransferFile);
                }
            }
            catch (Exception exception)
            {
                _view.ShowError(exception.Message, TextFor.ErrorDialogTitle);
            }
        }
    }
}
