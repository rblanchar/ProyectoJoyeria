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
        public double Costo { get; set; }
        public  decimal Peso {  get; set; }
        public double Margen_Ganancia { get; set; }
        public int Cantidad { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public Material Material { get; set; }
        public Producto()
        {
            
        }

        public Producto(string id_Producto, string descripcion, double costo, decimal peso, double margen_Ganancia, 
            int cantidad, CategoriaProducto categoriaProducto, Material material)
        {
            Id_Producto = id_Producto;
            Descripcion = descripcion;
            Costo = costo;
            Peso = peso;
            Margen_Ganancia = margen_Ganancia;
            Cantidad = cantidad;
            CategoriaProducto = categoriaProducto;
            Material = material;
        }

        public override string ToString()
        {
            return $"{Id_Producto};{Descripcion};{Costo};{Peso};{Margen_Ganancia};{Cantidad};{CategoriaProducto.Id_Categoria};{Material.Id_Material}";
        }
    }
}
