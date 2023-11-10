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
        private RepositorioProductoOracle repositorio = new RepositorioProductoOracle();
        private ServicioCategoriaOracle servicioCategoria = new ServicioCategoriaOracle();
        private ServicioMaterialOracle servicioMaterial = new ServicioMaterialOracle();

        public List<Producto> Consultar()
        {
            return repositorio.ObtenerTodos();
        }

        public string InsertarProducto(Producto producto)
        {
            var msg = repositorio.InsertarProducto(producto);
            return msg;
        }

        public string IncrementarIdProducto()
        {
            return repositorio.IncrementarIdProducto();
        }

        public Producto BuscarId(string id)
        {
            foreach (var producto in Consultar())
            {
                if (producto.Id_Producto == id)
                {
                    return producto;
                }
            }
            return null;
        }

        public List<Producto> BuscarFiltro(string valor)
        {
            List<Producto> listaFiltrada = new List<Producto>();

            foreach (var item in Consultar())
            {
                CategoriaProducto nombreCategoria = servicioCategoria.BuscarId(item.CategoriaProducto.Id_Categoria.ToString());
                Material nombreMaterial = servicioMaterial.BuscarId(item.Material.Id_Material.ToString());

                if (item.Descripcion.Contains(valor) || nombreCategoria.Nombre.Contains(valor) || nombreMaterial.Nombre.Contains(valor))
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
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
