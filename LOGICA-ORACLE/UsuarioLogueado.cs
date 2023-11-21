using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class UsuarioLogueado
    {
        public static string Usuario { get; set; }
        public static string idUsuario { get; set; }
        public static string Tipo {  get; set; }
        public UsuarioLogueado()
        {
            
        }



        public override string ToString()
        {
            return $"{Usuario};{idUsuario};{Tipo}";
        }
    }
}
