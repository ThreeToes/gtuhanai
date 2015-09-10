using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtuhanai.Library.FileUtils
{
    /// <summary>
    /// Default class to lock files
    /// </summary>
    public class FileLocker : IFileLocker
    {
        public ILockedFile LockFile(string path)
        {
            return new LockedFile(path);
        }
    }
}
