using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
    public class Archivo
    {
        protected string fileName;
        public Archivo(string fileName)
        {
            this.fileName = fileName;
        }

        public String Guardar(string datos)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, true);
                sw.WriteLine(datos);
                sw.Close();
                return "Informacion Registrada Satisfactoriamente!";
            }
            catch (Exception)
            {

                return "Error de Transaccion!";
            }
        }
    }
}
