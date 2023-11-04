using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class RepositorioTipoUsuarioOracle: BaseDatosORACLE
    {
        public RepositorioTipoUsuarioOracle() : base()
        {
            
        }
        public string InsertarUsuario(TipoUsuario tipoUsuario)
        {
            // Utiliza una sentencia INSERT sin mencionar el campo ID, ya que es una secuencia.
            //string ssql = "INSERT INTO tipo_Usuarios (NOMBRE) VALUES (:nombre)";
            string ssql = "INSERT INTO tipo_usuarios VALUES(:seq_tipo_usuario.NEXTVAL)";
            // Abre la conexión a la base de datos
            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            // Crea el parámetro para el nombre
            orclCmd1.Parameters.Add(new OracleParameter(":nombre", "PROBANDO"));

            int i = orclCmd1.ExecuteNonQuery();

            // Cierra la conexión
            CerrarConexion();

            // Verifica el valor de 'i' para determinar si la inserción se realizó con éxito
            if (i > 0)
            {
                return "Se Registró el Tipo de Usuario Exitosamente! ";
            }
            else
            {
                return "No se pudo Registrar el Tipo de Usuario.";
            }
        }
    }
}
