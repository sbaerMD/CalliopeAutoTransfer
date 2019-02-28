using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CalliopeAutoTransfer
{
    internal class FileSystem
    {
        private bool _watch = true;
        public string Folder { get; }
        public event Action<string> NewFile; 
        public event Action<IEnumerable<string>> NewFileList; 
    

        private List<string> _files;

        public FileSystem(string folder, Action<string> newFile = null, Action<IEnumerable<string>> newFileList = null)
        {
            Folder = folder;
            NewFile += newFile;
            NewFileList += newFileList;
            _files = new List<string>(Files);
            NewFileList?.Invoke(_files);
            Task.Factory.StartNew(() =>
            {
                while (_watch)
                {
                    watch();
                    Thread.Sleep(TimeSpan.FromSeconds(0.5));
                }
            });
        }

        internal void watch()
        {
            var beforeList = _files;
            var newList = new List<string>(Files);
            _files = newList;

            var allBefore = String.Join(",", beforeList);
            var allNow = String.Join(",", newList);
            if(allBefore != allNow)
                NewFileList?.Invoke(newList);

            var newFiles = newList.Where(i => beforeList.All(b => b != i)).OrderByDescending(b => new FileInfo(b).LastWriteTime);
            var newestFile = newFiles.FirstOrDefault();
            if(newestFile!=null)
                NewFile?.Invoke(newestFile);

        }

        public IEnumerable<string> Files
            => Directory.GetFiles(Folder, "*.hex");
        

        public void Close()
        {
            _watch = false;
        }
    }
}
