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
                if (partes.Length == 9 && partes[0] == usuario.Identificacion)
                {
                    
                    lineas[i] = $"{usuario.Identificacion};{usuario.Nombre};{usuario.Apellido};{usuario.Direccion};" +
                        $"{usuario.Correo};{usuario.NumTelefono};{usuario.NombreUsuario};{usuario.Contraseña};{usuario.rol.IdRol}";
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
                if (partes.Length == 9 && partes[0] != usuario.Identificacion)
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
                Identificacion = linea[0],
                Nombre = linea[1],
                Apellido = linea[2],
                Direccion = linea[3],
                Correo = linea[4],
                NumTelefono = linea[5],
                NombreUsuario = linea[6],
                Contraseña = linea[7],
                rol = new RepositorioRol("Rol.txt").BuscarId(linea[8])

            };
            return usuario;
        }
    }
}
