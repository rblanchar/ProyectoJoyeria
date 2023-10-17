using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Rol
    {
        public string IdRol {  get; set; }
        public string TipoRol { get; set; }
        public Rol()
        {
        }

        public Rol(string idRol, string tipoRol)
        {
            IdRol = idRol;
            TipoRol = tipoRol;
        }

        public override string ToString()
        {
            return $"{IdRol};{TipoRol}";
        }
    }
}
