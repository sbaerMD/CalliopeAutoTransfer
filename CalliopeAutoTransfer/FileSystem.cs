using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
    

        private List<string> files = new List<string>();

        public FileSystem(string folder, Action<string> newFile = null, Action<IEnumerable<string>> newFileList = null)
        {
            Folder = folder;
            NewFile += newFile;
            NewFileList += newFileList;
            files = new List<string>(Files);
            NewFileList?.Invoke(files);
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
            var beforeList = files;
            var newList = new List<string>(Files);
            files = newList;

            var allBefore = String.Join(",", beforeList);
            var allNow = String.Join(",", newList);
            if(allBefore != allNow)
                NewFileList?.Invoke(newList);

            //jetzt noch die "neue" Datei
            var newFiles = newList.Where(i => !beforeList.Any(b => b == i)).OrderByDescending(b => new FileInfo(b).LastWriteTime);
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

        public void ForExisitingFile(string fileName, Action<string> fullPathActionIfExists)
        {
            if (String.IsNullOrEmpty(fileName))
                return;
            var fullFile = Path.Combine(Folder, fileName);
            if (File.Exists(fullFile))
                fullPathActionIfExists(fullFile);
        }

        private static string GetChecksum(string file)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {
                    var fileInfo = new FileInfo(file);
                    FileStream fileStream = fileInfo.Open(FileMode.Open);
                    fileStream.Position = 0;
                    byte[] hashValue = mySHA256.ComputeHash(fileStream);
                    fileStream.Close();
                    var writeTimestamp = fileInfo.LastWriteTime.ToString("O");
                    return Convert.ToBase64String(hashValue) + writeTimestamp;
                }
                catch
                {
                    return String.Empty;
                }
            }
        }
    }
}
