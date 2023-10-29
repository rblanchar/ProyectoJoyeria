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
        public Material Material { get; set; }
        public double PrecioCosto { get; set; }
        public  decimal Peso {  get; set; }
        public double MargenGanancia { get; set; }
        public int Cantidad { get; set; }

        public Producto()
        {
            
        }

        public Producto(string codigo, string descripcion, CategoriaProducto categoriaProducto, Material material, 
            double precioCosto, decimal peso, double margenGanancia, int cantidad)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            CategoriaProducto = categoriaProducto;
            Material = material;
            PrecioCosto = precioCosto;
            Peso = peso;
            MargenGanancia = margenGanancia;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Codigo};{Descripcion};{CategoriaProducto.Codigo};{Material.Codigo};{PrecioCosto};{Peso};{MargenGanancia};{Cantidad}";
        }
    }
}
