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
            var usuarioExistente = servicioUsuario.BuscarId(usuario.Id_Usuario);

            if (usuarioExistente != null)
            {
               
                usuarioExistente.Nombre = usuario.Nombre;
                usuarioExistente.Apellidos = usuario.Apellidos;
                usuarioExistente.Direccion = usuario.Direccion;
                usuarioExistente.Barrio = usuario.Barrio;
                usuarioExistente.Correo = usuario.Correo;
                usuarioExistente.Telefono = usuario.Telefono;
                usuarioExistente.Nombre_Usuario = usuario.Nombre_Usuario;
                usuarioExistente.Contrasena = usuario.Contrasena;
                usuarioExistente.tipoUsuario = usuario.tipoUsuario;

                
                repositorioUsuario.ActualizarUsuario(usuarioExistente);

                
                return "Usuario modificado exitosamente.";
            }

            return "Usuario no encontrado.";
        }
    }
}
