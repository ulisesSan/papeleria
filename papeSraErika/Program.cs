using System;
using System.Windows.Forms;

namespace papeSraErika
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SystemQuerys.principalQuery("describe productos");
            SystemQuerys.Copia();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Usuarios());
        }
    }
}
