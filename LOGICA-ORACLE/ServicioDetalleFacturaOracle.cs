using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{  
    public class ServicioDetalleFacturaOracle
    {
        RepositorioDetalle_Factura repositorio = new RepositorioDetalle_Factura();

        public ServicioDetalleFacturaOracle()
        {
            
        }
        public string InsertarDetalleFactura(List<Detalle_Factura> detallesFactura)
        {
            var msg = repositorio.InsertarDetalleFactura(detallesFactura);
            return msg;
        }

        public DataTable GrupoFacturas(int idFactura)
        {
            DataTable resultados = repositorio.ObtenerDetalleFactura(idFactura);
            return resultados;
        }

        public string DevolucionFactura(string idFactura)
        {
            var msg = repositorio.EliminarDetalleFactura(idFactura);
            return msg; 
        }
    }
}
