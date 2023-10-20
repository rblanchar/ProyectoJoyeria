using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class CategoriaProducto
    {
        public string Codigo {  get; set; }
        public string NomCategoria { get; set;}

        public CategoriaProducto()
        {
            
        }

        public CategoriaProducto(string codigo, string nomCategoria)
        {
            Codigo = codigo;
            NomCategoria = nomCategoria;

        }

        public override string ToString()
        {
            return $"{Codigo};{NomCategoria}";
        }
    }
}
