using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Cliente:Persona
    {
        public string Id_Cliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(string id_Cliente)
        {
            Id_Cliente = id_Cliente;
        }

        public override string ToString()
        {
            return $"{Id_Cliente}";
        }
    }
}
