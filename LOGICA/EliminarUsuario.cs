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
            servicioUsuario.RefrescarLista();
            var usuarioExistente = servicioUsuario.BuscarId(usuario.Identificacion);

            if (usuarioExistente != null)
            {
                
                repositorio.EliminarUsuario(usuarioExistente);

               
                return "Usuario eliminado exitosamente.";
            }

            return "Usuario no encontrado.";
        }
    }
}