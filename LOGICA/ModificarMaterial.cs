using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ModificarMaterial
    {
        private string fileName = "Material.txt";
        ServicioMaterial servicioMaterial = new ServicioMaterial();
        RepositorioMaterial repositorio;
        RepositorioModificarMaterial material;

        public ModificarMaterial()
        {
            repositorio = new RepositorioMaterial(fileName);
            material = new RepositorioModificarMaterial(fileName); 
        }

        public string ModificarMateriales(Material materiales)
        {
            servicioMaterial.RefrescarLista();
            var materialExistente = servicioMaterial.BuscarCodigo(materiales.Id_Material);

            if (materialExistente != null)
            {
                materialExistente.Nombre = materiales.Nombre;

                material.ActualizarMaterial(materiales);
                
                return "Material modificado exitosamente.";
            }

            return "Material no encontrado.";
        }

        public string EliminarMateriales(string codigo)
        {
            servicioMaterial.RefrescarLista();
            var materialExistente = servicioMaterial.BuscarCodigo(codigo);

            if (materialExistente != null)
            {
                material.EliminarMaterial(codigo);

                return "Material eliminado exitosamente.";
            }

            return "Material no encontrado.";
        }

    }
}
