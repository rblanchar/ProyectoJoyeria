using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Factura
    {
        public string Id_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public double Total_Pagar { get; set; }
        public Cliente cliente { get; set; }
        public Usuario usuario { get; set; }


        public Factura()
        {
        }

        public Factura(string id_Factura, DateTime fecha, double total_Pagar, Cliente cliente, Usuario usuario)
        {
            Id_Factura = id_Factura;
            Fecha = fecha;
            Total_Pagar = total_Pagar;
            this.cliente = cliente;
            this.usuario = usuario;
        }

        public override string ToString()
        {
            return $"{Id_Factura}; {Fecha}; {Total_Pagar}; {cliente.Id_Cliente}; {usuario.Id_Usuario}";
        }
    }
}
