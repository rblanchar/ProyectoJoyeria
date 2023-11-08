using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario: Persona
    {
        public string Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        public Usuario()
        {
        }

        public Usuario(string id_Usuario, string nombre_Usuario, string contrasena, TipoUsuario tipoUsuario)
        {
            Id_Usuario = id_Usuario;
            Nombre_Usuario = nombre_Usuario;
            Contrasena = contrasena;
            this.tipoUsuario = tipoUsuario;
        }

        public override string ToString()
        {
            return $"{Id_Usuario};{Nombre_Usuario};{Contrasena};{tipoUsuario.IdTipo}";
        }
    }
}
