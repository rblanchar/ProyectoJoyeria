using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
    public class RepositoriodeLecturaIdRol
    {
        public string LeerLinea(string filename)
        {
            string ultimaLinea = null;
            using (StreamReader leer = new StreamReader(filename))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    ultimaLinea = linea;
                }
            }
            return ultimaLinea;
        }
    }
}
