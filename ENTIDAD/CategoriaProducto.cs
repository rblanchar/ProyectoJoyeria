using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class CategoriaProducto
    {
        public string Id_Categoria {  get; set; }
        public string Nombre { get; set;}

        public CategoriaProducto()
        {
            
        }

        public CategoriaProducto(string id_Categoria, string nombre)
        {
            Id_Categoria = id_Categoria;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Id_Categoria};{Nombre}";
        }
    }
}
