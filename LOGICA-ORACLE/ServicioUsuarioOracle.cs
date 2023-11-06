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
        RepositorioUsuarioOracle repositorioUsuarioOracle = new RepositorioUsuarioOracle();

        public string InsertarUsuario(Usuario usuario)
        {
            var msg = repositorioUsuarioOracle.InsertarUsuario(usuario);
            return msg;
        }

        public List<Usuario> usuarios;  

        public List<Usuario> Consultar()
        {
            usuarios = repositorioUsuarioOracle.ObtenerTodosUsuarios();  
            return usuarios;
        }

        public Usuario BuscarId(string id)
        {
            foreach (var usuario in Consultar())
            {
                if (usuario.Identificacion == id)
                {
                    return usuario;
                }
            }
            return null;
        }

    }
}
