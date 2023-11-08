using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class ServicioProductoOracle
    {
        RepositorioProductoOracle repositorio = new RepositorioProductoOracle();

        public List<Producto> productos;
        public List<Producto> Consultar()
        {
            return repositorio.ObtenerTodos();
        }

        public string InsertarProducto(Producto producto)
        {
            var msg = repositorio.InsertarProducto(producto);
            return msg;
        }

        public List<Producto> IncrementarIdProducto()
        {
            return repositorio.IncrementarIdProducto();
        }

        public Producto BuscarId(string id)
        {
            foreach (var producto in Consultar())
            {
                if (producto.Id_Producto== id)
                {
                    return producto;
                }
            }
            return null;
        }

        public string ModificarProducto(Producto idproducto)
        {
            var msg = repositorio.ModificarProducto(idproducto);
            return msg;
        }
        public string EliminarProducto(string idProducto)
        {
            var msg = repositorio.EliminarProducto(idProducto);
            return msg;
        }

    }
}
