using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace LOGICA
{
    public class ModificarUsuario
    {
        private string fileName = "usuario.txt";
        ServicioUsuario servicioUsuario = new ServicioUsuario();
        RepositorioUsuario repositorioUsuario;

        public ModificarUsuario()
        {
            repositorioUsuario = new RepositorioUsuario(fileName);
            servicioUsuario.RefrescarLista();
        }

        public string Modificar(Usuario usuario)
        {
            servicioUsuario.RefrescarLista();
            var usuarioExistente = servicioUsuario.BuscarId(usuario.Identificacion);

            if (usuarioExistente != null)
            {
               
                usuarioExistente.Nombre = usuario.Nombre;
                usuarioExistente.Apellido = usuario.Apellido;
                usuarioExistente.Direccion = usuario.Direccion;
                usuarioExistente.Correo = usuario.Correo;
                usuarioExistente.NumTelefono = usuario.NumTelefono;
                usuarioExistente.NombreUsuario = usuario.NombreUsuario;
                usuarioExistente.Contraseña = usuario.Contraseña;
                usuarioExistente.rol = usuario.rol;

                
                repositorioUsuario.ActualizarUsuario(usuarioExistente);

                
                return "Usuario modificado exitosamente.";
            }

            return "Usuario no encontrado.";
        }
    }
}
