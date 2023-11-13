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
        public Cliente cliente { get; set; }
        public Usuario usuario { get; set; }
        public int Subtotal { get; set; }
        public int Iva {  get; set; }
        public double Total_Pagar { get; set; }
       
        public Factura()
        {
        }

        public Factura(string id_Factura, DateTime fecha, Cliente cliente, Usuario usuario, int subtotal, 
            int iva, double total_Pagar)
        {
            Id_Factura = id_Factura;
            Fecha = fecha;
            this.cliente = cliente;
            this.usuario = usuario;
            Subtotal = subtotal;
            Iva = iva;
            Total_Pagar = total_Pagar;
        }

        public override string ToString()
        {
            return $"{Id_Factura}; {Fecha};{cliente.Id_Cliente};{usuario.Id_Usuario};{Subtotal};{Iva};{Total_Pagar};";
        }
    }
}
