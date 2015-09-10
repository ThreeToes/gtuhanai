using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gtuhanai.ViewModels;
using Microsoft.Win32;

namespace Gtuhanai.UiComponents.Controls
{
    /// <summary>
    /// Interaction logic for FileLockerControl.xaml
    /// </summary>
    public partial class FileLockerControl : UserControl
    {
        public IFileLockerViewModel ViewModel { get; private set; }

        public FileLockerControl(IFileLockerViewModel vm)
        {
            ViewModel = vm;
        }

        public FileLockerControl()
        {
            InitializeComponent();
        }


        private void OnAddClicked(object sender, RoutedEventArgs e)
        {
            var fob = new OpenFileDialog();
            var cont = fob.ShowDialog();
            if(!cont.HasValue || !cont.Value) return;
            ViewModel.LockFile(fob.FileName);
        }

        private void OnUnlockSelectedClick(object sender, RoutedEventArgs e)
        {
            ViewModel.UnlockSelected();
        }
    }
}
