using DATOS_ORACLE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;


namespace LOGICA_ORACLE
{
    public class ServicioUsuarioOracle
    {
        RepositorioUsuarioOracle repositorio = new RepositorioUsuarioOracle();
        public string InsertarUsuario(Usuario usuario)
        {
            var msg = repositorio.InsertarUsuario(usuario);
            return msg;
        }

        public List<Usuario> usuarios;

        public List<Usuario> Consultar()
        {
            usuarios = repositorio.ObtenerTodosUsuarios();
            return usuarios;
        }

        public Usuario BuscarId(string id)
        {
            foreach (var usuario in Consultar())
            {
                if (usuario.Id_Usuario == id)
                {
                    return usuario;
                }
            }
            return null;
        }
        public string ModificarUsuario(Usuario Usuario)
        {
            var msg = repositorio.ModificarUsuario(Usuario);
            return msg;
        }
        public string EliminarUsuario(string id)
        {
            var msg = repositorio.EliminarUsuario(id);
            return msg;
        }

    }
}
