using ENTIDAD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RepositorioProducto: Archivo
    {
        public RepositorioProducto(string fileName) : base(fileName)
        {
        }
        public List<Producto> ConsultarTodos()
        {
            try
            {
                List<Producto> lista = new List<Producto>();

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

        public void ActualizarProducto(Producto producto)
        {

            var lineas = File.ReadAllLines(fileName);
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(';');
                if (partes.Length == 7 && partes[0] == producto.Codigo)
                {
                    lineas[i] = $"{producto.Codigo};{producto.Descripcion};{producto.CategoriaProducto.Codigo};{producto.PrecioCosto};" +
                        $"{producto.Peso};{producto.MargenGanancia};{producto.Existencia};";
                }
            }
            File.WriteAllLines(fileName, lineas);
        }

        public void EliminarProducto(Producto producto)
        {

            var lineas = File.ReadAllLines(fileName);
            var nuevasLineas = new List<string>();
            foreach (var linea in lineas)
            {
                string[] partes = linea.Split(';');
                if (partes.Length == 7 && partes[0] != producto.Codigo)
                {
                    nuevasLineas.Add(linea);
                }
            }

            File.WriteAllLines(fileName, nuevasLineas);
        }

        private Producto Mapear(string datos)
        {
            if (datos == "" || datos == null)
            {
                return null;
            }
            var linea = datos.Split(';');
            Producto producto = new Producto
            {
                Codigo = linea[0],
                Descripcion = linea[1],
                CategoriaProducto = new RepositorioCategoriaProducto("Producto.txt").BuscarCodigo(linea[2]),
                PrecioCosto = Convert.ToDouble(linea[3]),
                Peso = Convert.ToDouble(linea[4]),
                MargenGanancia = Convert.ToDouble(linea[5]),
                Existencia = Convert.ToInt16(linea[6])
            };
            return producto;
        }

    }
}
