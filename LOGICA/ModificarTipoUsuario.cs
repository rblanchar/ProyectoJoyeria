using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ModificarTipoUsuario
    {
        private string fileName = "TipoUsuario.txt";
        ServicioTipoUsuario servicioTipoUsuario = new ServicioTipoUsuario();
        RepositorioTipoUsuario repositorio;
        RepositorioModificarRol roles;

        public ModificarTipoUsuario()
        {
            repositorio = new RepositorioTipoUsuario(fileName);
            roles = new RepositorioModificarRol(fileName);
        }
        public string ActualizarRol(TipoUsuario rol)
        {
            servicioTipoUsuario.RefrescarLista();
            var RolExistente = servicioTipoUsuario.BuscarId(rol.IdTipo);

            if (RolExistente != null)
            {
                RolExistente.Nombre = rol.Nombre;
                
                roles.ActualizarRol(rol);
                
                return "Usuario Modificado Exitosamente.";
            }

            return "Rol no encontrado.";
        }

        public string EliminarRol(string id)
        {
            servicioTipoUsuario.RefrescarLista();
            var rolExistente = servicioTipoUsuario.BuscarId(id);

            if (rolExistente != null)
            {
                roles.EliminarRol(id);

                return "Usuario Eliminado Exitosamente.";
            }

            return "Rol no encontrado.";
        }
    }
}
