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
    public class ServicioTipoUsuario
    {
        private string fileName = "TipoUsuario.txt";
        RepositorioTipoUsuario repositorio;

        private List<TipoUsuario> Roles;
        public ServicioTipoUsuario()
        {
            repositorio = new RepositorioTipoUsuario(fileName);
            RefrescarLista();
        }
        public void RefrescarLista()
        {
            Roles = repositorio.ConsultarTodos();
        }
        public string Guardar(TipoUsuario rol)
        {
            var msg = repositorio.Guardar(rol.ToString());
            RefrescarLista();
            return msg;
        }
        public List<TipoUsuario> Consultar()
        {
            return Roles;
        }

        public TipoUsuario BuscarId(string id)
        {
            if (File.Exists(fileName))
            {
                foreach (var item in Roles)
                {
                    if (item.IdTipo == id)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
