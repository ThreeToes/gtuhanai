using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtuhanai.Library.FileUtils;
using NUnit.Framework;

namespace Gtuhanai.Tests.FileUtilTests
{
    [TestFixture]
    public class LockedFileTests
    {
        private string _tmpFile;

        [SetUp]
        public void SetUp()
        {
            _tmpFile = Path.GetTempFileName();
        }
        
        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_tmpFile))
            {
                File.Delete(_tmpFile);
            }
        }

        [Test, ExpectedException(typeof(IOException))]
        public void CheckFileLockRead()
        {
            using (var locked = new LockedFile(_tmpFile))
            {
                using (var f = File.Open(_tmpFile, FileMode.Open, FileAccess.Read)) { }
            }
        }

        [Test, ExpectedException(typeof(IOException))]
        public void CheckFileLockWrite()
        {
            using (var locked = new LockedFile(_tmpFile))
            {
                using (var f = File.Open(_tmpFile, FileMode.Open, FileAccess.Write)){};
            }
        }

        [Test, ExpectedException(typeof(IOException))]
        public void CheckFileLockReadWrite()
        {
            using (var locked = new LockedFile(_tmpFile))
            {
                using (var f = File.Open(_tmpFile, FileMode.Open, FileAccess.ReadWrite)){};
            }
        }

        [Test]
        public void CheckRelease()
        {
            try
            {
                using (var locked = new LockedFile(_tmpFile))
                {
                    File.Open(_tmpFile, FileMode.Open);
                }
            }
            catch (IOException)
            {
                using(var f = File.Open(_tmpFile, FileMode.Open)){}
                return;
            }
            throw new Exception("Unexpected code path!");
        }
    }
}
