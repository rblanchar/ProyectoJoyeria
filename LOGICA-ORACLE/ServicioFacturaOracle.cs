using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class ServicioFacturaOracle
    {
        RepositorioFacturaOracle repositorio = new RepositorioFacturaOracle();
        public ServicioFacturaOracle()
        {
            
        }
        public string InsertarFactura(Factura factura)
        {
            var msg = repositorio.InsertarFactura(factura);
            return msg;
        }

        public string ProximoidFactura()
        {
            return repositorio.ProximoIdFactura();
        }

        public DataTable GrupoFacturas()
        {
            DataTable resultados = repositorio.ObtenerResultados();
            return resultados;
        }
    }

    
}
