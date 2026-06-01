using Administration_RRHH.UI;
using System.Windows.Forms;
using WinFormsApp = System.Windows.Forms.Application;

namespace Administration_RRHH.UI

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            WinFormsApp.Run(new FrmContainerApps());

        }
    }
}