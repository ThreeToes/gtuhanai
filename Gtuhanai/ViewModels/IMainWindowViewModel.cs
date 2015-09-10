using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Gtuhanai.UiComponents;

namespace Gtuhanai.ViewModels
{
    /// <summary>
    /// Main window view model
    /// </summary>
    public interface IMainWindowViewModel
    {
        /// <summary>
        /// Individual tools available
        /// </summary>
        ObservableCollection<IUiTool> Tools { get; }

        IUiTool SelectedTool { get; set; }
    }
}
