using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ServicioCategoriaProducto
    {
        private string fileName = "Rol.txt";
        RepositorioCategoriaProducto repositorio;

        private List<CategoriaProducto> CategoriaProductos;
        public ServicioCategoriaProducto()
        {
            repositorio = new RepositorioCategoriaProducto(fileName);
            RefrescarLista();
        }
        void RefrescarLista()
        {
            CategoriaProductos = repositorio.ConsultarTodos();
        }
        public string Guardar(CategoriaProducto categoriaProducto)
        {
            var msg = repositorio.Guardar(categoriaProducto.ToString());
            RefrescarLista();
            return msg;
        }
        public List<CategoriaProducto> Consultar()
        {
            return CategoriaProductos;
        }

        public CategoriaProducto BuscarId(string codigo)
        {
            foreach (var item in CategoriaProductos)
            {
                if (item.Codigo == codigo)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
