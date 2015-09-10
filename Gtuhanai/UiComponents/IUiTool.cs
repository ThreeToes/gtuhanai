using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gtuhanai.UiComponents
{
    /// <summary>
    /// Interface for tools in the GUI
    /// </summary>
    public interface IUiTool
    {
        /// <summary>
        /// Get the control for this tool
        /// </summary>
        /// <returns>This tool's control</returns>
        FrameworkElement Control { get; }

        string ToolName { get; }
    }
}
