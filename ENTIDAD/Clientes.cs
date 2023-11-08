using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Clientes
    {
        public string Id_Cliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set;}
        public string Correo { get; set;}
        public string Telefono { get; set; }

        public Clientes()
        {
        }

        public Clientes(string id_Cliente, string cedula, string nombre, string apellidos, string direccion, string barrio, string correo, string telefono)
        {
            Id_Cliente = id_Cliente;
            Cedula = cedula;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Barrio = barrio;
            Correo = correo;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Id_Cliente}; {Cedula}; {Nombre}; {Apellidos}; {Direccion}; {Barrio}; {Correo}; {Telefono}";
        }
    }
}
