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

            Student[] students = new Student[0]; // O el tama�o que desees

            // Inicializar la aplicaci�n
            ApplicationConfiguration.Initialize();

            // Pasar el arreglo al crear la instancia de Form1
            Application.Run(new Form1(ref students));
        }
    }
}