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

        public DataTable ObtenerResultados()
        {
            DataTable tablaResultados = new DataTable();

            try
            {
                string ssql = "select f.id_factura,f.fecha,c.cedula,c.nombre,c.apellidos,u.nombre_usuario,f.subtotal,f.total_pagar " +
                              " from facturas f" +
                              " join clientes c" +
                              " on f.id_cliente = c.id_cliente" +
                              " join usuarios u " +
                              " on f.id_usuario = u.id_usuario";

                AbrirConexion();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandText = ssql;

                OracleDataAdapter adaptador = new OracleDataAdapter(cmd);
                adaptador.Fill(tablaResultados);

                CerrarConexion();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones si ocurre algún error en la consulta a la base de datos
                Console.WriteLine("Error: " + ex.Message);
            }

            return tablaResultados;
        }
    }
}
