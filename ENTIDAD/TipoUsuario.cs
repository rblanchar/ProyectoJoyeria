using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class TipoUsuario
    {
        public string IdTipo {  get; set; }
        public string Nombre { get; set; }
        public TipoUsuario()
        {
        }

        public TipoUsuario(string nombre)
        {
            Nombre = nombre;
        }

        public TipoUsuario(string idRol, string tipoRol)
        {
            IdTipo = idRol;
            Nombre = tipoRol;
        }

        public override string ToString()
        {
            return $"{IdTipo};{Nombre}";
        }
    }
}
