using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;
using System.IO;

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
        public void RefrescarLista()
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
            if (File.Exists(fileName))
            {
                foreach (var item in Roles)
                {
                    if (item.IdRol == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
