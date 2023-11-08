using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Facturas
    {
        public string Id_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public double Total_Pagar { get; set; }
        public Clientes clientes { get; set; }
        public Usuario usuario { get; set; }

        public Facturas()
        {
        }

        public Facturas(string id_Factura, DateTime fecha, double total_Pagar, Clientes clientes, Usuario usuario)
        {
            Id_Factura = id_Factura;
            Fecha = fecha;
            Total_Pagar = total_Pagar;
            this.clientes = clientes;
            this.usuario = usuario;
        }

        public override string ToString()
        {
            return $"{Id_Factura}; {Fecha}; {Total_Pagar}; {clientes.Id_Cliente}; {usuario.Id_Usuario}";
        }
    }
}
