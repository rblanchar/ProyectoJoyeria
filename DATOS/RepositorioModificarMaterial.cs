using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DATOS
{
    public class RepositorioModificarMaterial:Archivo
    {
        public RepositorioModificarMaterial(string fileName) : base(fileName)
        {
        }
        public void ActualizarMaterial(Material material)
        {
            try
            {
                var lineas = File.ReadAllLines(fileName);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] partes = lineas[i].Split(';');
                    if (partes.Length >= 2 && partes[0] == material.Codigo)
                    {

                        lineas[i] = $"{material.Codigo};{material.NombreMaterial}";
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
        public void EliminarMaterial(string codigo)
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

                Console.WriteLine("Material eliminado del archivo correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el material del archivo: " + ex.Message);
            }
        }
    }
}
