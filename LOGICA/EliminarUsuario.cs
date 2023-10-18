using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace LOGICA
{
    public class EliminarUsuario
    {
        private string fileName = "usuario.txt";
        ServicioUsuario servicioUsuario = new ServicioUsuario();
        RepositorioUsuario repositorio;

        public EliminarUsuario()
        {
            repositorio = new RepositorioUsuario(fileName);
            servicioUsuario.RefrescarLista();
        }

        public string Eliminar(Usuario usuario)
        {
            var usuarioExistente = servicioUsuario.BuscarId(usuario.Identificacion);

            if (usuarioExistente != null)
            {
                // Realiza la eliminación del usuario en el repositorio
                repositorio.EliminarUsuario(usuarioExistente);

                servicioUsuario.RefrescarLista();
                return "Usuario eliminado exitosamente.";
            }

            return "Usuario no encontrado.";
        }
    }
}
