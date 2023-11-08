using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public  class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Persona()
        {
            
        }

        public Persona(string cedula, string nombre, string apellidos, string direccion, string barrio, string correo, string telefono)
        {
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
            return $"{Cedula};{Nombre};{Apellidos};{Direccion};{Barrio};{Correo};{Telefono}";
        }
    }
}
