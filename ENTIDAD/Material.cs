using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Material
    {
        public string Id_Material {  get; set; }
        public string Nombre { get; set; }

        public Material()
        {
            
        }

        public Material(string codigo, string nombreMaterial)
        {
            Id_Material = codigo;
            Nombre = nombreMaterial;
        }

        public override string ToString()
        {
            return $"{Id_Material};{Nombre}";
        }
    }
}
