using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DATOS
{
    public class RepositorioModificarCategoriaProducto:Archivo
    {
        public RepositorioModificarCategoriaProducto(string fileName) : base(fileName)
        {
        }

        public void ActualizarCategoriaProducto(CategoriaProducto categoriaProducto)
        {
            try
            {
                var lineas = File.ReadAllLines(fileName);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] partes = lineas[i].Split(';');
                    if (partes.Length >= 2 && partes[0] == categoriaProducto.Id_Categoria)
                    {

                        lineas[i] = $"{categoriaProducto.Id_Categoria};{categoriaProducto.Nombre}";
                    }
                }


                File.WriteAllLines(fileName, lineas);


                Console.WriteLine("Datos actualizados en el archivo correctamente.");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al actualizar los datos en el archivo: " + ex.Message);
            }
        }
        public void EliminarCategoriaProducto(string codigo)
        {
            try
            {
                var lineas = File.ReadAllLines(fileName);
                var nuevasLineas = new List<string>();

                foreach (var linea in lineas)
                {
                    string[] partes = linea.Split(';');
                    if (partes.Length >= 2 && partes[0] == codigo)
                    {

                    }
                    else
                    {
                        nuevasLineas.Add(linea);
                    }
                }

                File.WriteAllLines(fileName, nuevasLineas);

                Console.WriteLine("Categoría de producto eliminada del archivo correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la categoría de producto del archivo: " + ex.Message);
            }
        }
    }
}
