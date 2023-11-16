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
        public double iva {  get; set; }
        public double Valor_Total { get; set; }


        public Detalle_Factura()
        {
        }

        public Detalle_Factura(Factura factura, Producto producto, double cantidad, double valor_Unitario, double iva, double valor_Total)
        {
            this.factura = factura;
            this.producto = producto;
            Cantidad = cantidad;
            Valor_Unitario = valor_Unitario;
            this.iva = iva;
            Valor_Total = valor_Total;
        }

        public override string ToString()
        {
            return $"{factura.Id_Factura}; {producto.Id_Producto}; {Cantidad};{Valor_Unitario};{iva};{Valor_Total}";
        }
    }
}
