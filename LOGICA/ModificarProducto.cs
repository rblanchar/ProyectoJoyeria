using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ModificarProducto
    {
        private string fileName = "producto.txt";
        ServicioProducto servicioProducto = new ServicioProducto();
        RepositorioProducto repositorioProducto;

        public ModificarProducto()
        {
            repositorioProducto = new RepositorioProducto(fileName);
            servicioProducto.RefrescarLista();
        }

        public string Modificar(Producto producto)
        {
            servicioProducto.RefrescarLista();
            var productoExistente = servicioProducto.BuscarProducto(producto.Id_Producto);

            if (productoExistente != null)
            {

                productoExistente.Id_Producto = producto.Id_Producto;
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.CategoriaProducto = producto.CategoriaProducto;
                productoExistente.Material = producto.Material;
                productoExistente.Costo = producto.Costo;
                productoExistente.Peso = producto.Peso;
                productoExistente.Margen_Ganancia = producto.Margen_Ganancia;
                productoExistente.Cantidad = producto.Cantidad;

               
                repositorioProducto.ActualizarProducto(productoExistente);
                

                return "Producto modificado exitosamente.";
            }

            return "Producto no encontrado.";
        }
    }
}
