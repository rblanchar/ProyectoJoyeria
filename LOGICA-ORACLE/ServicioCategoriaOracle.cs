using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class ServicioCategoriaOracle
    {
        RepositorioCategoriaOracle repositorio = new RepositorioCategoriaOracle();

        public List<CategoriaProducto> categorias;
        public List<CategoriaProducto> Consultar()
        {
            return repositorio.ObtenerTodos();
        }

        public string InsertarCategoria(CategoriaProducto categoriaProducto)
        {
            var msg = repositorio.InsertarCategoria(categoriaProducto);
            return msg;
        }

        public List<CategoriaProducto> IncrementaridCategoria()
        {
            return repositorio.IncrementarIdCategoria();
        }

        public CategoriaProducto BuscarId(string id_categoria)
        {
            foreach (var categoria in Consultar())
            {
                if (categoria.Id_Categoria == id_categoria)
                {
                    return categoria;
                }
            }
            return null;
        }

        public string ModificarCategoria(CategoriaProducto categoriaProducto)
        {
            var msg = repositorio.ModificarCategoria(categoriaProducto);
            return msg;
        }
        public string EliminarCategoria(string idCategoria)
        {
            var msg = repositorio.EliminarCategoria(idCategoria);
            return msg;
        }
    }
}
