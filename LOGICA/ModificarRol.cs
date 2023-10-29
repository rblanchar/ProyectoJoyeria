using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ModificarRol
    {
        private string fileName = "Rol.txt";
        ServicioRol servicioRol = new ServicioRol();
        RepositorioRol repositorio;
        RepositorioModificarRol roles;

        public ModificarRol()
        {
            repositorio = new RepositorioRol(fileName);
            roles = new RepositorioModificarRol(fileName);
        }
        public string ActualizarRol(Rol rol)
        {
            servicioRol.RefrescarLista();
            var RolExistente = servicioRol.BuscarId(rol.IdRol);

            if (RolExistente != null)
            {
                RolExistente.TipoRol = rol.TipoRol;
                
                roles.ActualizarRol(rol);
                
                return "Usuario Modificado Exitosamente.";
            }

            return "Rol no encontrado.";
        }

        public string EliminarRol(string id)
        {
            servicioRol.RefrescarLista();
            var rolExistente = servicioRol.BuscarId(id);

            if (rolExistente != null)
            {
                roles.EliminarRol(id);

                return "Usuario Eliminado Exitosamente.";
            }

            return "Rol no encontrado.";
        }
    }
}
