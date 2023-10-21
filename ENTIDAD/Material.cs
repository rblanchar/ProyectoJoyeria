using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Material
    {
        public string Codigo {  get; set; }
        public string NombreMaterial { get; set; }

        public Material()
        {
            
        }

        public Material(string codigo, string nombreMaterial)
        {
            Codigo = codigo;
            NombreMaterial = nombreMaterial;
        }

        public override string ToString()
        {
            return $"{Codigo};{NombreMaterial}";
        }
    }
}
