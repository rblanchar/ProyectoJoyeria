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
        public Rol rol {  get; set; }

        public Usuario()
        {
        }

        public Usuario(string identificacion, string nombre, string apellido, string direccion, string correo,
            string numTelefono, string nombreUsuario, string contraseña, Rol rol)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Correo = correo;
            NumTelefono = numTelefono;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            this.rol = rol;
        }

        public override string ToString()
        {
            return $"{Identificacion};{Nombre};{Apellido};{Direccion};{Correo};{NumTelefono};" +
                $"{NombreUsuario};{Contraseña};{rol.IdRol}";
        }
    }
}
