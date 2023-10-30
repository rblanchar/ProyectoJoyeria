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
            var productoExistente = servicioProducto.BuscarProducto(producto.Codigo);

            if (productoExistente != null)
            {

                productoExistente.Codigo = producto.Codigo;
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.CategoriaProducto = producto.CategoriaProducto;
                productoExistente.Material = producto.Material;
                productoExistente.PrecioCosto = producto.PrecioCosto;
                productoExistente.Peso = producto.Peso;
                productoExistente.MargenGanancia = producto.MargenGanancia;
                productoExistente.Cantidad = producto.Cantidad;


                repositorioProducto.ActualizarProducto(productoExistente);

               
                return "Producto modificado exitosamente.";
            }

            return "Producto no encontrado.";
        }
    }
}
