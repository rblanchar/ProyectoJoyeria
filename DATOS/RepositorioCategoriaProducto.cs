using ENTIDAD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RepositorioCategoriaProducto: Archivo
    {
        public RepositorioCategoriaProducto(string fileName) : base(fileName)
        {
        }

        public List<CategoriaProducto> ConsultarTodos()
        {
            try
            {
                List<CategoriaProducto> lista = new List<CategoriaProducto>();

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

        public CategoriaProducto BuscarCodigo(string codigo)
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

        private CategoriaProducto Mapear(string datos)
        {
            var linea = datos.Split(';');
            CategoriaProducto categoria = new CategoriaProducto
            {
                Codigo = linea[0],
                NomCategoria = linea[1]
            };
            return categoria;
        }

    }
}
