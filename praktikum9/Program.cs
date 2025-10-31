using DotNetEnv;
using praktikum9.Models;

namespace praktikum9
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
            Env.Load();
            LoginContext context = new LoginContext();
            Application.Run(new Hallogin(context));
        }
    }
}