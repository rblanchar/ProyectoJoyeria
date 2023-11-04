using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS_ORACLE;
using ENTIDAD;

namespace PruebaConexion
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseDatosORACLE baseDatos = new BaseDatosORACLE();
            RepositorioTipoUsuarioOracle repositorioTipoUsuarioOracle = new RepositorioTipoUsuarioOracle();

            // Llama al método InsertarUsuario para intentar insertar un registro
            string resultado = repositorioTipoUsuarioOracle.InsertarUsuario(new TipoUsuario { Nombre = "PROBANDO" });

            Console.WriteLine(resultado);

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
