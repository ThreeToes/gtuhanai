using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Gtuhanai.Annotations;
using Gtuhanai.UiComponents;

namespace Gtuhanai.ViewModels
{
    /// <summary>
    /// Default implementation for the main window view model
    /// </summary>
    public class MainWindowViewModel : IMainWindowViewModel, INotifyPropertyChanged
    {
        private IUiTool _selectedTool;

        public MainWindowViewModel(IEnumerable<IUiTool> tools)
        {
            Tools = new ObservableCollection<IUiTool>(tools);
        }
        public ObservableCollection<IUiTool> Tools { get; private set; }

        public IUiTool SelectedTool
        {
            get { return _selectedTool; }
            set
            {
                _selectedTool = value;
                OnPropertyChanged("SelectedTool");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
