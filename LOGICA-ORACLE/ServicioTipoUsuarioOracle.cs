using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class ServicioTipoUsuarioOracle
    {
         RepositorioTipoUsuarioOracle repositorio = new RepositorioTipoUsuarioOracle();

        public List<TipoUsuario> tipoUsuarios;
        public List<TipoUsuario> Consultar()
        {
            return repositorio.ObtenerTodos();
        }

        public string InsertarTipoUsuario(TipoUsuario tipoUsuario)
        {
            var msg = repositorio.InsertarTipoUsuario(tipoUsuario);
            return msg;
        }

        public List<TipoUsuario> IncrementarTipoUsuario()
        {
            return repositorio.IncrementarIdTipoUsuario();
        }

        public TipoUsuario BuscarId(string id)
        {
            foreach (var tipoUsuario in Consultar())
            {
                if (tipoUsuario.IdTipo == id)
                {
                    return tipoUsuario;
                }
            }
            return null;
        }

        public string ModificarTipoUsuario(TipoUsuario tipoUsuario)
        {
            var msg = repositorio.ModificarTipoUsuario(tipoUsuario);
            return msg;
        }
        public string EliminarTipoUsuario(string idTipo)
        {
            var msg = repositorio.EliminarTipoUsuario(idTipo);
            return msg;
        }

    }
}
