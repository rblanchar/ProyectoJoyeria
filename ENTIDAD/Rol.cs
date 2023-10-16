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

        public Rol(string IdRol, string TipoRol)
        {
            this.IdRol = IdRol;
            this.TipoRol = TipoRol;
        }

        public override string ToString()
        {
            return $"{IdRol};{TipoRol}";
        }
    }
}
