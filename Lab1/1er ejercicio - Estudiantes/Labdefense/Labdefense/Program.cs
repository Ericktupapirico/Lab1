using Labdefense.Models;

namespace Labdefense
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           
            ApplicationConfiguration.Initialize();

            // Pasar el arreglo al crear la instancia de Form1
            Application.Run(new Form1());
        }
    }
}