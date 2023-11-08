using DATOS_ORACLE;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA_ORACLE
{
    public class ServicioMaterialOracle
    {
        RepositorioMaterialOracle repositorio = new RepositorioMaterialOracle();

        public List<Material> materiales;
        public List<Material> Consultar()
        {
            return repositorio.ObtenerTodos();
        }

        public string InsertarMaterial(Material material)
        {
            var msg = repositorio.InsertarMaterial(material);
            return msg;
        }

        public List<Material> IncrementaridMaterial()
        {
            return repositorio.IncrementarIdMaterial();
        }

        public Material BuscarId(string id_material)
        {
            foreach (var material in Consultar())
            {
                if (material.Id_Material == id_material)
                {
                    return material;
                }
            }
            return null;
        }

        public string ModificarMaterial(Material material)
        {
            var msg = repositorio.ModificarMaterial(material);
            return msg;
        }
        public string EliminarMaterial(string idMaterial)
        {
            var msg = repositorio.EliminarMaterial(idMaterial);
            return msg;
        }
    }
}
