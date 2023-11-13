using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class RepositorioFacturaOracle: BaseDatosORACLE
    {
        public RepositorioFacturaOracle():base()
        {
            
        }

        public string InsertarFactura(Factura factura)
        {
            string ssql = "INSERT INTO facturas (id_factura, fecha, id_cliente, id_usuario ) " +
                          " VALUES (seq_id_factura.NEXTVAL, :fecha, :id_cliente, :id_usuario)";

            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            orclCmd1.Parameters.Add(new OracleParameter(":fecha", factura.Fecha));
            orclCmd1.Parameters.Add(new OracleParameter(":id_cliente", factura.cliente.Id_Cliente));
            orclCmd1.Parameters.Add(new OracleParameter(":id_usuario", factura.usuario.Id_Usuario));


            int i = orclCmd1.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Registro de Factura Exitoso!";
            }
            else
            {
                return "No se pudo registrar la Factura";
            }
        }



        public string ProximoIdFactura()
        {
            string proximoId = null;

            string ssql = "SELECT last_number FROM USER_SEQUENCES WHERE sequence_name ='SEQ_ID_FACTURA'";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            OracleDataReader Rdr = cmd.ExecuteReader();

            if (Rdr.Read())
            {
                proximoId = Rdr[0].ToString();
            }

            Rdr.Close();
            CerrarConexion();

            return proximoId;
        }
    }
}
