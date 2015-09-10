using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtuhanai.Library.FileUtils;

namespace Gtuhanai.ViewModels
{
    /// <summary>
    /// Default implementation of the view model
    /// </summary>
    public class FileLockerViewModel : IFileLockerViewModel
    {
        private readonly IFileLocker _fileLocker;

        public FileLockerViewModel(IFileLocker fileLocker)
        {
            _fileLocker = fileLocker;
            LockedFiles = new ObservableCollection<ILockedFile>();
        }

        public void Dispose()
        {
            foreach (var lockedFile in LockedFiles)
            {
                lockedFile.Dispose();
            }
            LockedFiles.Clear();
        }

        public ObservableCollection<ILockedFile> LockedFiles { get; private set; }

        public ILockedFile SelectedFile { get; set; } 

        public void LockFile(string path)
        {
            LockedFiles.Add(_fileLocker.LockFile(path));
        }

        public void UnlockSelected()
        {
            SelectedFile.Dispose();
            LockedFiles.Remove(SelectedFile);
        }
    }
}
