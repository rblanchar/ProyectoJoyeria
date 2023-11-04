using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ServicioProducto
    {
        private string fileName = "producto.txt";
        RepositorioProducto repositorio;

        public List<Producto> productos;
        public ServicioProducto()
        {
            repositorio = new RepositorioProducto(fileName);
            RefrescarLista();
        }
        public void RefrescarLista()
        {
            productos = repositorio.ConsultarTodos();
        }
        public string Guardar(Producto producto)
        {
            var msg = repositorio.Guardar(producto.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Producto> Consultar()
        {
            return productos;
        }

        public Producto BuscarProducto(string codigo)
        {
            foreach (var item in productos)
            {
                if (item.Id_Producto == codigo)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Producto> BuscarX(string valor)
        {
            List<Producto> listaFiltrada = new List<Producto>();

            foreach (var item in productos)
            {
                if (item.CategoriaProducto.Nombre.Contains(valor) || item.Material.Nombre.Contains(valor) || item.Descripcion.Contains(valor))
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
    }
}
