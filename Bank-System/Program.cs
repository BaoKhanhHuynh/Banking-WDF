using Bank_System.Models;
using Bank_System.Views;
using WindowsFormsApp1;

namespace Bank_System
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
            //Application.Run(new BranchView());
            Application.Run(new Login());
        }
    }
}