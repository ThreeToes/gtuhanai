using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtuhanai.Library.FileUtils
{
    /// <summary>
    /// Interface to lock files
    /// </summary>
    public interface IFileLocker
    {
        /// <summary>
        /// Lock a file
        /// </summary>
        /// <param name="path">Path to the file to lock</param>
        /// <returns>The locked file object</returns>
        ILockedFile LockFile(string path);
    }
}
