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
    public class ServicioMaterial
    {
        private string fileName = "Material.txt";
        RepositorioMaterial repositorio;

        private List<Material> Materiales;
        public ServicioMaterial()
        {
            repositorio = new RepositorioMaterial(fileName);
            RefrescarLista();
        }
        public void RefrescarLista()
        {
            Materiales = repositorio.ConsultarTodos();
        }
        public string Guardar(Material material)
        {
            var msg = repositorio.Guardar(material.ToString());
            RefrescarLista();
            return msg;
        }
        public List<Material> Consultar()
        {
            return Materiales;
        }

        public Material BuscarCodigo(string codigo)
        {
            if (File.Exists(fileName))
            {
                foreach (var item in Materiales)
                {
                    if (item.Id_Material == codigo)
                    {
                        return item;
                    }
                }
                
            }
            return null;
        }

    }
}
