using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Gtuhanai.UiComponents;
using Gtuhanai.ViewModels;

namespace Gtuhanai.WindsorConfig
{
    /// <summary>
    /// Configures the UI classes
    /// </summary>
    class UiConfig : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
            container.Register(Component.For<MainWindow>()
                .ImplementedBy<MainWindow>()
                .LifestyleSingleton());
            container.Register(Component.For<IFileLockerViewModel>()
                .ImplementedBy<FileLockerViewModel>()
                .LifestyleSingleton());
            container.Register(Component.For<IUiTool>()
                .ImplementedBy<FileLockerTool>()
                .LifestyleSingleton());
            container.Register(Component.For<IMainWindowViewModel>()
                .ImplementedBy<MainWindowViewModel>()
                .LifestyleSingleton());
        }
    }
}
