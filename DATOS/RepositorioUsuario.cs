using ENTIDAD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RepositorioUsuario: Archivo
    {
        public RepositorioUsuario(string fileName) : base(fileName)
        {
        }
        public List<Usuario> ConsultarTodos()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

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

        public void ActualizarUsuario(Usuario usuario)
        {
          
            var lineas = File.ReadAllLines(fileName);
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(';');
                if (partes.Length == 10 && partes[0] == usuario.Id_Usuario)
                {
                    
                    lineas[i] = $"{usuario.Id_Usuario};{usuario.Nombre};{usuario.Apellidos};{usuario.Direccion};{usuario.Barrio}" +
                        $"{usuario.Correo};{usuario.Telefono};{usuario.Nombre_Usuario};{usuario.Contrasena};{usuario.tipoUsuario.IdTipo}";
                }
            }

            
            File.WriteAllLines(fileName, lineas);
        }

        public void EliminarUsuario(Usuario usuario)
        {
           
            var lineas = File.ReadAllLines(fileName);
            var nuevasLineas = new List<string>();
            foreach (var linea in lineas)
            {
                string[] partes = linea.Split(';');
                if (partes.Length == 10 && partes[0] != usuario.Id_Usuario)
                {
                    nuevasLineas.Add(linea);
                }
            }

            // Vuelve a escribir las líneas restantes en el archivo
            File.WriteAllLines(fileName, nuevasLineas);
        }

        private Usuario Mapear(string datos)
        {
            if (datos == "" || datos == null)
            {
                return null;
            }
            var linea = datos.Split(';');
            Usuario usuario = new Usuario
            {
                Id_Usuario = linea[0],
                Nombre = linea[1],
                Apellidos = linea[2],
                Direccion = linea[3],
                Barrio = linea[4],
                Correo = linea[5],
                Telefono = linea[6],
                Nombre_Usuario = linea[7],
                Contrasena = linea[8],
                tipoUsuario = new RepositorioTipoUsuario("TipoUsuario.txt").BuscarId(linea[9])

            };
            return usuario;
        }
    }
}
