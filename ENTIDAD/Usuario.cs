using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        public string Identificacion {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion {  get; set; }
        public string Correo { get; set; }
        public string NumTelefono { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public TipoUsuario tipoUsuario {  get; set; }

        public Usuario()
        {
        }

        public Usuario(string identificacion, string nombre, string apellido, string direccion, string correo,
            string numTelefono, string nombreUsuario, string contraseña, TipoUsuario tipoUsuario)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Correo = correo;
            NumTelefono = numTelefono;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            this.tipoUsuario = tipoUsuario;
        }

        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Apellido};{Direccion};{Correo};{NumTelefono};" +
                $"{NombreUsuario};{Contraseña};{tipoUsuario.IdTipo}";
        }
    }
}
