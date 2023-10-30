using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DATOS
{
    public class RepositorioModificarRol:Archivo
    {
        public RepositorioModificarRol(string fileName) : base(fileName)
        {
        }
        public void ActualizarRol(Rol rol)
        {
            try
            {
                var lineas = File.ReadAllLines(fileName);
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] partes = lineas[i].Split(';');
                    if (partes.Length >= 2 && partes[0] == rol.IdRol)
                    {

                        lineas[i] = $"{rol.IdRol};{rol.TipoRol}";
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
        public void EliminarRol(string id)
        {
            try
            {
                var lineas = File.ReadAllLines(fileName);
                var nuevasLineas = new List<string>();

                foreach (var linea in lineas)
                {
                    string[] partes = linea.Split(';');
                    if (partes.Length >= 2 && partes[0] == id)
                    {

                    }
                    else
                    {
                        nuevasLineas.Add(linea);
                    }
                }

                File.WriteAllLines(fileName, nuevasLineas);

                Console.WriteLine("Usuario eliminado del archivo correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el Usuario del archivo: " + ex.Message);
            }
        }
    }
}
