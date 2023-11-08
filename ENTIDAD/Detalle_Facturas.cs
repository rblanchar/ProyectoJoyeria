using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Detalle_Facturas
    {
        public Facturas facturas { get; set; }
        public Producto producto { get; set; }
        public double Cantidad { get; set; }
        public double Valor_Unitario { get; set; }
        public double Valor_Total { get; set; }
        public decimal Iva { get; set; }
        public double SubTotal { get; set; }
        public double Total_Dia { get; set; }

        public Detalle_Facturas()
        {
        }

        public Detalle_Facturas(Facturas facturas, Producto producto, double cantidad, double valor_Unitario, double valor_Total, decimal iva, double subTotal, double total_Dia)
        {
            this.facturas = facturas;
            this.producto = producto;
            Cantidad = cantidad;
            Valor_Unitario = valor_Unitario;
            Valor_Total = valor_Total;
            Iva = iva;
            SubTotal = subTotal;
            Total_Dia = total_Dia;
        }

        public override string ToString()
        {
            return $"{facturas.Id_Factura}; {producto.Id_Producto}; {Cantidad};{Valor_Unitario}; {Valor_Total}; {Iva}; " +
                $"{SubTotal}; {Total_Dia}";
        }
    }
}
