using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
