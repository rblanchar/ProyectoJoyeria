using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Producto
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public double PrecioCosto { get; set; }
        public double MargenGanancia { get; set; }
        public int Existencia { get; set; }

        public Producto()
        {
            
        }

        public Producto(string codigo, string nombre, double precioCosto, float margenGanancia, int existencia)
        {
            Codigo = codigo;
            Nombre = nombre;
            PrecioCosto = precioCosto;
            MargenGanancia = margenGanancia;
            Existencia = existencia;
        }

        public override string ToString()
        {
            return $"{Codigo};{Nombre};{PrecioCosto};{MargenGanancia};{Existencia}";
        }
    }
}
