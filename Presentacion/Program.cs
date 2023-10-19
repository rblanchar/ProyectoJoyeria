using System;
using System.Windows.Forms;

namespace Presentacion
{

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FrmInicioSesion
            //FrmGestionUsuario
            //FrmListarUsuarios
            FrmGestionUsuario main = new FrmGestionUsuario();
            main.Show();
            Application.Run();
        }

    }
}
