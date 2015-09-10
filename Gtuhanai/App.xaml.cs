using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Castle.Windsor;
using Gtuhanai.WindsorConfig;

namespace Gtuhanai
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IWindsorContainer _container;
        private void OnStart(object sender, StartupEventArgs e)
        {
            _container = GetIocContainer();
            var mainWindow = _container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private IWindsorContainer GetIocContainer()
        {
            var container = new WindsorContainer();
            container.Install(new FileUtilsConfig(), new UiConfig());
            return container;
        }
    }
}
