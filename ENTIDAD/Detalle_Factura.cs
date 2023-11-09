using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Detalle_Factura
    {
        public Factura factura { get; set; }
        public Producto producto { get; set; }
        public double Cantidad { get; set; }
        public double Valor_Unitario { get; set; }
        public double Valor_Total { get; set; }
        public decimal Iva { get; set; }
        public double SubTotal { get; set; }

        public Detalle_Factura()
        {
        }

        public Detalle_Factura(Factura factura, Producto producto, double cantidad, double valor_Unitario, double valor_Total, 
            decimal iva, double subTotal)
        {
            this.factura = factura;
            this.producto = producto;
            Cantidad = cantidad;
            Valor_Unitario = valor_Unitario;
            Valor_Total = valor_Total;
            Iva = iva;
            SubTotal = subTotal;
 
        }

        public override string ToString()
        {
            return $"{factura.Id_Factura}; {producto.Id_Producto}; {Cantidad};{Valor_Unitario}; {Valor_Total}; {Iva}; " +
                $"{SubTotal}";
        }
    }
}
