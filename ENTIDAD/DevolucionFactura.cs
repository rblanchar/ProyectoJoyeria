using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class DevolucionFactura
    {
        public string Id_Devolucion {  get; set; }
        public DateTime Fecha { get; set; }
        public Factura factura { get; set; }
        public Producto producto { get; set; }
        public double Cantidad { get; set; }
        public double Valor_Unitario { get; set; }
        public double iva { get; set; }
        public double Valor_Total { get; set; }
        public string Motivo { get; set; }
        public DevolucionFactura()
        {
            
        }

        public DevolucionFactura(string id_Devolucion, DateTime fecha, Factura factura, Producto producto, 
            double cantidad, double valor_Unitario, double iva, double valor_Total, string motivo)
        {
            Id_Devolucion = id_Devolucion;
            Fecha = fecha;
            this.factura = factura;
            this.producto = producto;
            Cantidad = cantidad;
            Valor_Unitario = valor_Unitario;
            this.iva = iva;
            Valor_Total = valor_Total;
            Motivo = motivo;
        }

        public override string ToString()
        {
            return $"{Id_Devolucion};{Fecha};{factura.Id_Factura};{producto.Id_Producto};{Cantidad};{Valor_Unitario};" +
                $"{iva};{Valor_Total};{Motivo}";
        }
    }
}
