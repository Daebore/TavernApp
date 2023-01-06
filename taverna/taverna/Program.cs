using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Aquí indicamos que ventana será la primera página que aparecerá al ejecutar el programa
            new ventana().Show();
            Application.Run();
        }

        public static void cerrar()
        {
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
