using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
    public class RepositorioTipoUsuario: Archivo
    {
        public RepositorioTipoUsuario(string fileName) : base(fileName)
        {
        }

        public List<TipoUsuario> ConsultarTodos()
        {
            try
            {
                List<TipoUsuario> lista = new List<TipoUsuario>();

                StreamReader sr = new StreamReader(fileName);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public TipoUsuario BuscarId(string id)
        {
            var lista = ConsultarTodos();
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    if (item.IdTipo == id)
                    {
                        return item;
                    }

                }
            }
            
            return null;
        }

        private TipoUsuario Mapear(string datos)
        {
            var linea = datos.Split(';');
            TipoUsuario rol = new TipoUsuario
            {
                IdTipo = linea[0],
                Nombre = linea[1]
            };
            return rol;
        }
    }
}
