using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;

namespace LOGICA
{
    public class ServicioLecturaIdRol
    {
        RepositoriodeLecturaIdRol repositoriodeLectura = new RepositoriodeLecturaIdRol();

        public ServicioLecturaIdRol()
        {
            
        }

        public string  IncrementarId(string filename)
        {
            string datos = repositoriodeLectura.LeerLinea(filename);
            string[] partes = datos.Split(';');
            if (partes.Length == 2)
            {
                if (int.TryParse(partes[0], out int numeroId))
                {
                    numeroId++;
                    partes[0] = numeroId.ToString();
                }
            }
            return partes[0];
        }
    }
}
