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
        public string Descripcion { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public double PrecioCosto { get; set; }
        public double Peso {  get; set; }
        public double MargenGanancia { get; set; }
        public int Existencia { get; set; }

        public Producto()
        {
            
        }

        public Producto(string codigo, string descripcion, CategoriaProducto categoriaProducto, double precioCosto, 
            double peso, double margenGanancia, int existencia)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            CategoriaProducto = categoriaProducto;
            PrecioCosto = precioCosto;
            Peso = peso;
            MargenGanancia = margenGanancia;
            Existencia = existencia;
        }

        public override string ToString()
        {
            return $"{Codigo};{Descripcion};{CategoriaProducto.Codigo};{PrecioCosto};{Peso};{MargenGanancia};{Existencia}";
        }
    }
}
