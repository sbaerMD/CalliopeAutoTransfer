using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CalliopeAutoTransfer.model;

namespace CalliopeAutoTransfer.externalSystems
{
    internal class CalliopeConnection
    {
        
        public string Drive { get; }

        public CalliopeStatus Status { get; private set; }
        private bool _watch = true;
        private bool _connected;

        public event Action Connected;
        public event Action Disconnected;
        public event Action<CalliopeStatus> StatusChanged;

        public CalliopeConnection(string drive, Action connected = null, Action disconnected = null, Action<CalliopeStatus> statusChanged=null)
        {
            Status = CalliopeStatus.Disconnected;
            Drive = drive;
            Connected += connected;
            Disconnected += disconnected;
            StatusChanged += statusChanged;
            Task.Factory.StartNew(() =>
            {
                while (_watch)
                {
                    watch();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            });
        }

        internal void watch()
        {
            var state = _connected;
            _connected = Ready();

            if (_connected == state)
                return;
            if (_connected)
            {
                Status = 
                    Status == CalliopeStatus.Restarting 
                        ? CalliopeStatus.Restarted 
                        : CalliopeStatus.Connected;

                StatusChanged?.Invoke(Status);
                Connected?.Invoke();
            }
            else
            {
                if (Status == CalliopeStatus.AwaitingRestart)
                    Status = CalliopeStatus.Restarting;
                else
                    Status = CalliopeStatus.Disconnected;
                StatusChanged?.Invoke(Status);
                Disconnected?.Invoke();
            }
        }

        internal bool Ready()
        {
            var driveInfo = DriveInfo.GetDrives().SingleOrDefault(d => d.Name == Drive);
            return driveInfo?.IsReady ?? false;
        }


        internal void CopyFrom(string file)
        {
            if(!Ready())
                return;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    Status = CalliopeStatus.AwaitingRestart;
                    StatusChanged?.Invoke(Status);
                    File.Copy(
                        file,
                        Path.Combine(Drive, Path.GetFileName(file)));

                }
                catch
                {
                    // ignored
                }
            });
        }

        public void Close()
        {
            _watch = false;
        }
    }
}
