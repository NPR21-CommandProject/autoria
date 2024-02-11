using AutoriaWinForm.Data;
using AutoriaWinForm.Forms;

namespace AutoriaWinForm
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
            //Application.Run(new LoginForm());
           // Application.Run(new MainForm());
           // SeedDatabase seedDatabase = new SeedDatabase();
           // seedDatabase.SeedCar();

            Application.Run(new ItemForm());

            
        }
    }
}