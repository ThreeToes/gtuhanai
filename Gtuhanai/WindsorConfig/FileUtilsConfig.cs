using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Gtuhanai.Library.FileUtils;

namespace Gtuhanai.WindsorConfig
{
    /// <summary>
    /// Configures the file utilities
    /// </summary>
    class FileUtilsConfig : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IFileLocker>()
                .ImplementedBy<FileLocker>()
                .LifestyleSingleton());
        }
    }
}
