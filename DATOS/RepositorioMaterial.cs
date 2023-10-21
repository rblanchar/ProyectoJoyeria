using ENTIDAD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RepositorioMaterial: Archivo
    {
        public RepositorioMaterial(string fileName) : base(fileName)
        {
        }

        public List<Material> ConsultarTodos()
        {
            try
            {
                List<Material> lista = new List<Material>();

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

        public Material BuscarCodigo(string codigo)
        {
            var lista = ConsultarTodos();
            foreach (var item in lista)
            {
                if (item.Codigo == codigo)
                {
                    return item;
                }

            }
            return null;
        }

        private Material Mapear(string datos)
        {
            var linea = datos.Split(';');
            Material material = new Material
            {
                Codigo = linea[0],
                NombreMaterial = linea[1]
            };
            return material;
        }

    }
}
