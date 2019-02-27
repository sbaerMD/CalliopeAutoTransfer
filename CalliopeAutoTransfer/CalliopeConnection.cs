using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CalliopeAutoTransfer
{
    internal class CalliopeConnection
    {
        
        public string Drive { get; }
        private bool _watch = true;
        private bool _connected;

        public event Action Connected;
        public event Action Disconnected;

        public CalliopeConnection(string drive, Action connected = null, Action disconnected = null)
        {
            Drive = drive;
            Connected += connected;
            Disconnected += disconnected;
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
            if (_connected != state)
            {
                if(_connected)
                    Connected?.Invoke();
                else
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
            Task.Factory.StartNew(() =>
            {
                try
                {
                    File.Copy(
                        file,
                        Path.Combine(Drive, Path.GetFileName(file)));
                }
                catch
                {
                }
            });
        }

        public void Close()
        {
            _watch = false;
        }
    }
}
