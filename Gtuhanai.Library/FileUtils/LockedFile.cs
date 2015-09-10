using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtuhanai.Library.FileUtils
{
    public class LockedFile : ILockedFile
    {
        private readonly FileStream _stream;
        public LockedFile(string path)
        {
            Path = path;
            _stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }

        public void Dispose()
        {
            _stream.Dispose();
        }

        public string Path { get; private set; }
    }
}
