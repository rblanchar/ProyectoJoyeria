using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ServiciodeLectura
    {
        RepositoriodeLectura repositoriodeLectura = new RepositoriodeLectura();

        public ServiciodeLectura()
        {

        }

        public string IncrementarCodigo(string filename)
        {

            string datos = repositoriodeLectura.LeerLinea(filename);
            string[] partes = datos.Split(';');
            if (partes.Length == 2)
            {
                if (int.TryParse(partes[0], out int numeroCodigo))
                {
                    numeroCodigo++;
                    partes[0] = numeroCodigo.ToString();
                }
            }
            return partes[0];
        }
    }
}
