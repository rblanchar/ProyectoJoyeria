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
