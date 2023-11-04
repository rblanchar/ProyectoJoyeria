using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Producto
    {
        public string Id_Producto {  get; set; }
        public string Descripcion { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public Material Material { get; set; }
        public double Costo { get; set; }
        public  decimal Peso {  get; set; }
        public double Margen_Ganancia { get; set; }
        public int Cantidad { get; set; }

        public Producto()
        {
            
        }

        public Producto(string id_Producto, string descripcion, CategoriaProducto categoriaProducto, Material material,
            double costo, decimal peso, double margen_Ganancia, int cantidad)
        {
            Id_Producto = id_Producto;
            Descripcion = descripcion;
            CategoriaProducto = categoriaProducto;
            Material = material;
            Costo = costo;
            Peso = peso;
            Margen_Ganancia = margen_Ganancia;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Id_Producto};{Descripcion};{CategoriaProducto.Id_Categoria};{Material.Id_Material};{Costo};{Peso};{Margen_Ganancia};{Cantidad}";
        }
    }
}
