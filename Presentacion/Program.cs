using System;
using System.Globalization;
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

            CultureInfo culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FrmInicioSesion
            //FrmGestionUsuario
            //FrmListarUsuarios
            //FrmGestionProducto
            //FrmRegistrarMaterial

            FrmGestionCliente main = new FrmGestionCliente();
            main.Show();
            Application.Run();

        }

    }
}
