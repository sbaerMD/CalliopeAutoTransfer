using System;
using System.Collections.Generic;
using CalliopeAutoTransfer.model;

namespace CalliopeAutoTransfer
{
    public interface IView
    {
        event Action<Setting> ChangeSettings;
        event Action End;
        void ShowSettings(Setting setting);
        void ShowCalliopeStatus(CalliopeStatus status);
        void HideTransferIndicator();
        void ShowTransferIndicator();
        void ShowTransferInformation(string info);
        void ShowFileStatus(string fileName);
        void ShowProjectFiles(IEnumerable<string> files, Action<string> clickCallback);
        void ShowError(string message, string title);
        void EnsureVisible();
    }
}