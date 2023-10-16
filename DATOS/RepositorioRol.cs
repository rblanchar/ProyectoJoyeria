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
    public class RepositorioRol: Archivo
    {
        public RepositorioRol(string fileName) : base(fileName)
        {
        }

        public List<Rol> ConsultarTodos()
        {
            try
            {
                List<Rol> lista = new List<Rol>();

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

        public Rol BuscarId(string id)
        {
            var lista = ConsultarTodos();
            foreach (var item in lista)
            {
                if (item.IdRol == id)
                {
                    return item;
                }

            }
            return null;
        }

        private Rol Mapear(string datos)
        {
            var linea = datos.Split(';');
            Rol rol = new Rol
            {
                IdRol = linea[0],
                TipoRol = linea[1]
            };
            return rol;
        }
    }
}
