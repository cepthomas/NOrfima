using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrayEx
{
    /// <summary>Framework for running as a tray app.</summary>
    static class Program
    {
        /// <summary>The main entry point for the application. </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrayEx.TrayExApplicationContext());
        }
    }
}
