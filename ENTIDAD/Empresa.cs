using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Empresa
    {
        public string Nit { get; set; }
        public string Razon_Social { get; set;}
        public string Direccion { get; set;}
        public string Barrio { get; set;}  
        public string Telefono { get; set;}
        public string Correo { get; set;}

        public Empresa()
        {
        }

        public Empresa(string nit, string razon_Social, string direccion, string barrio, string telefono, string correo)
        {
            Nit = nit;
            Razon_Social = razon_Social;
            Direccion = direccion;
            Barrio = barrio;
            Telefono = telefono;
            Correo = correo;
        }

        public override string ToString()
        {
            return $"{Nit};{Razon_Social};{Direccion};{Barrio};{Telefono};{Correo}";
        }
    }
}
