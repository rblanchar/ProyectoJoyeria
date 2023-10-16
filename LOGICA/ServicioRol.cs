using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;

namespace LOGICA
{
    public class ServicioRol
    {
        private string fileName = "Rol.txt";
        RepositorioRol repositorio;

        private List<Rol> Roles;
        public ServicioRol()
        {
            repositorio = new RepositorioRol(fileName);
            RefrescarLista();
        }
        void RefrescarLista()
        {
            Roles = repositorio.ConsultarTodos();
        }
        public string Guardar(Rol rol)
        {
            var msg = repositorio.Guardar(rol.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Rol> Consultar()
        {
            return Roles;
        }

        public Rol BuscarId(string id)
        {
            foreach (var item in Roles)
            {
                if (item.IdRol == id)
                {
                    return item;
                }
            }
            return null;
        }

        
    }
}
