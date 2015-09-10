using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtuhanai.Library.FileUtils
{
    /// <summary>
    /// Interface for locked file objects
    /// </summary>
    public interface ILockedFile : IDisposable
    {
        /// <summary>
        /// Path to the file that's locked
        /// </summary>
        string Path { get; }
    }
}
