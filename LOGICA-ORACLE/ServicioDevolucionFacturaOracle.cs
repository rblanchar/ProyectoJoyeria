using DATOS_ORACLE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class ServicioDevolucionFacturaOracle
    {
        RepositorioDevolucionesOracle repositorio = new RepositorioDevolucionesOracle();

        public DataTable GrupoDevoluciones()
        {
            DataTable resultados = repositorio.ObtenerDevoluciones();
            return resultados;
        }

        public DataTable GrupoDevolucionesId(int idFactura)
        {
            DataTable resultados = repositorio.ObtenerDevolucionFacturaId(idFactura);
            return resultados;
        }
    }
}
