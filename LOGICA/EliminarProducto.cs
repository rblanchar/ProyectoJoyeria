using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class EliminarProducto
    {
        private string fileName = "producto.txt";
        ServicioProducto servicioProducto = new ServicioProducto();
        RepositorioProducto repositorioProducto;

        public EliminarProducto()
        {
            repositorioProducto = new RepositorioProducto(fileName);
            servicioProducto.RefrescarLista();
        }

        public string Eliminar(Producto producto)
        {
            servicioProducto.RefrescarLista();
            var productoExistente = servicioProducto.BuscarProducto(producto.Codigo);

            if (productoExistente != null)
            {

                repositorioProducto.EliminarProducto(productoExistente);


                return "Producto eliminado exitosamente.";
            }

            return "Producto no encontrado.";
        }
    }
}
