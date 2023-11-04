using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LOGICA
{
    public class ServicioCategoriaProducto
    {
        private string fileName = "Categoria.txt";
        RepositorioCategoriaProducto repositorio;

        private List<CategoriaProducto> CategoriaProductos;
        public ServicioCategoriaProducto()
        {
            repositorio = new RepositorioCategoriaProducto(fileName);
            RefrescarLista();
        }
        public void RefrescarLista()
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

        public CategoriaProducto BuscarCodigo(string codigo)
        {
            if (File.Exists(fileName))
            {
                foreach (var item in CategoriaProductos)
                {
                    if (item.Id_Categoria == codigo)
                    {
                        return item;
                    }
                }
            }
            
            return null;
        }

    }
}
