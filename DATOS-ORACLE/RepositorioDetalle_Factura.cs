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
    public class RepositorioDetalle_Factura: BaseDatosORACLE
    {
        public RepositorioDetalle_Factura():base()
        {
            
        }

     

        public string InsertarDetalleFactura(List<Detalle_Factura> detallesFactura)
        {

            AbrirConexion();

            foreach (var detalle in detallesFactura)
            {
                string ssql = "INSERT INTO detalle_facturas (id_factura, id_producto, cantidad, valor_unitario, iva, valor_total) " +
                                "VALUES (:v_id_factura, :v_id_producto, :v_cantidad, :v_valUnitario, :v_iva, :v_valTotal)";

                OracleCommand orclCmd1 = conexion.CreateCommand();
                orclCmd1.CommandText = ssql;

                orclCmd1.Parameters.Add(new OracleParameter(":v_id_factura", detalle.factura.Id_Factura));
                orclCmd1.Parameters.Add(new OracleParameter(":v_id_producto", detalle.producto.Id_Producto));
                orclCmd1.Parameters.Add(new OracleParameter(":v_cantidad", detalle.Cantidad));
                orclCmd1.Parameters.Add(new OracleParameter(":v_valUnitario", detalle.Valor_Unitario));
                orclCmd1.Parameters.Add(new OracleParameter(":v_iva", detalle.iva));
                orclCmd1.Parameters.Add(new OracleParameter(":v_valTotal", detalle.Valor_Total));

                int i = orclCmd1.ExecuteNonQuery();


                if (i <= 0)
                {
                    CerrarConexion();
                    return "No se pudo registrar el detalle de la factura";
                }
            }

            CerrarConexion();
            return "Registro de Factura Exitoso!";
        }

        public DataTable ObtenerDetalleFactura(int idFactura)
        {
            DataTable tablaDetalleFactura = new DataTable();

            try
            {
               
                   
                string ssql = "SELECT df.id_factura, p.descripcion, df.cantidad, df.valor_unitario, df.iva, df.valor_total " +
                                    " FROM detalle_facturas df " +
                                    " JOIN productos p ON df.id_producto = p.id_producto " +
                                    " WHERE df.id_factura = :Id_Factura";

                AbrirConexion();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandText = ssql;

                cmd.Parameters.Add(new OracleParameter(":Id_Factura", OracleDbType.Int32)).Value = idFactura;

                   
                OracleDataAdapter adaptador = new OracleDataAdapter(cmd);
                adaptador.Fill(tablaDetalleFactura);


                CerrarConexion();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return tablaDetalleFactura;
        }

    }
}
