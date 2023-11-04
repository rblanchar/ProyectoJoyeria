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
    }
}
