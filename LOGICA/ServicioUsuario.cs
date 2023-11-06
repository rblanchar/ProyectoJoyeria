using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;

namespace LOGICA
{
    public class ServicioUsuario
    {
        private string fileName = "usuario.txt";
        RepositorioUsuario repositorio;

        public List<Usuario> usuarios;
        public ServicioUsuario()
        {
            repositorio = new RepositorioUsuario(fileName);
            RefrescarLista();
        }
        public void RefrescarLista()
        {
            usuarios = repositorio.ConsultarTodos();
        }
        public string Guardar(Usuario usuario)
        {
            var msg = repositorio.Guardar(usuario.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Usuario> Consultar()
        {
            return usuarios;
        }

        public Usuario BuscarId(string id)
        {
            foreach (var item in usuarios)
            {
                if (item.Id_Usuario == id)
                {
                    return item;
                }
            }
            return null;
        }

        public int Loguin(string user, string pass)
        {
            foreach (var item in usuarios) 
            { 
                if (item.Nombre_Usuario== user && item.Contrasena==pass && Convert.ToString( item.tipoUsuario.IdTipo)=="1001")
                {
                    return 1;
                }
                else if (item.Nombre_Usuario == user && item.Contrasena == pass && Convert.ToString(item.tipoUsuario.IdTipo) == "1002")
                {
                    return 2;
                }
                else if (item.Nombre_Usuario == user && item.Contrasena == pass && Convert.ToString(item.tipoUsuario.IdTipo) == "1003")
                {
                    return 3;
                }
            }

            return 0;
        }

        public List<Usuario> BuscarX(string valor)
        {
            List<Usuario> listaFiltrada = new List<Usuario>();

            foreach (var item in usuarios)
            {
                if (item.Nombre.Contains(valor) || item.Apellidos.Contains(valor) || item.tipoUsuario.Nombre.Contains(valor) )
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }

    }
}
