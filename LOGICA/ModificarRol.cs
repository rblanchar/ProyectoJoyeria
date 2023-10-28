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
            var RolExistente = servicioRol.BuscarId(rol.IdRol);

            if (RolExistente != null)
            {
                RolExistente.TipoRol = rol.TipoRol;

                roles.ActualizarRol(rol);
                servicioRol.RefrescarLista();
                return "Rol modificado exitosamente.";
            }

            return "Rol no encontrado.";
        }

        public string EliminarRol(string id)
        {
            var rolExistente = servicioRol.BuscarId(id);

            if (rolExistente != null)
            {
                roles.EliminarRol(id);

                return "Rol eliminado exitosamente.";
            }

            return "Rol no encontrado.";
        }
    }
}
