using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Gtuhanai.UiComponents.Controls;
using Gtuhanai.ViewModels;

namespace Gtuhanai.UiComponents
{
    class FileLockerTool : IUiTool
    {
        private readonly FileLockerControl _control;

        public string ToolName { get { return "File Locker"; } }

        public FileLockerTool(IFileLockerViewModel viewModel)
        {
            _control = new FileLockerControl(viewModel);
        }

        public FrameworkElement Control
        {
            get { return _control; }
        }
    }
}
