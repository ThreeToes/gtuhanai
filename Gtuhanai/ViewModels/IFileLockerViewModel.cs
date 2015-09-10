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
    /// ViewModel for the file locker component
    /// </summary>
    public interface IFileLockerViewModel : IDisposable
    {
        /// <summary>
        /// The files locked by this process
        /// </summary>
        ObservableCollection<ILockedFile> LockedFiles { get; }
        /// <summary>
        /// File selected in the UI
        /// </summary>
        ILockedFile SelectedFile { get; set; }

        /// <summary>
        /// Lock a file and put it in the <see cref="LockedFiles"/> Collection
        /// </summary>
        /// <param name="path"></param>
        void LockFile(string path);

        /// <summary>
        /// Unlock a file and remove it from the list above
        /// </summary>
        void UnlockSelected();
    }
}
