using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        public string Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        public Usuario()
        {
        }

        public Usuario(string id_Usuario, string nombre, string apellidos, string direccion, string barrio, string correo,
            string telefono, string nombre_Usuario, string contrasena, TipoUsuario tipoUsuario)
        {
            Id_Usuario = id_Usuario;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Barrio = barrio;
            Correo = correo;
            Telefono = telefono;
            Nombre_Usuario = nombre_Usuario;
            Contrasena = contrasena;
            this.tipoUsuario = tipoUsuario;
        }

        public override string ToString()
        {
            return $"{Id_Usuario};{Nombre};{Apellidos};{Direccion};{Barrio};{Correo};{Telefono};" +
                $"{Nombre_Usuario};{Contrasena};{tipoUsuario.IdTipo}";
        }
    }
}
