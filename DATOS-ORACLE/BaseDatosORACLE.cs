using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class BaseDatosORACLE
    {
        protected OracleConnection conexion = null;    // = new OracleConnection();
        protected string cadena = "user id=administrador;password=12345;data source=" +
                                "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                "(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=" +
                                "(SERVICE_NAME=XEPDB1)))";

        public BaseDatosORACLE()
        {
            conexion = new OracleConnection(cadena);
        }
        public string AbrirConexion()
        {
            conexion.Open();
            return conexion.State.ToString();
        }

        public string CerrarConexion()
        {
            conexion.Close();
            return conexion.State.ToString();
        }
    }
}
