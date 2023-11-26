using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class RepositorioDevolucionesOracle: BaseDatosORACLE
    {
        public RepositorioDevolucionesOracle():base()
        {
            
        }
        public DataTable ObtenerDevoluciones()
        {           
            DataTable tablaFacturas = new DataTable();

            try
            {
                string ssql = "SELECT d.id_factura,MAX(d.fecha),c.cedula,c.nombre, c.apellidos, SUM(d.valor_total), u.nombre_usuario " +
                              " FROM devoluciones d" +
                              " JOIN productos p" +
                              " ON d.id_producto = p.id_producto" +
                              " JOIN facturas f " +
                              " ON f.id_factura = d.id_factura" +
                              " JOIN clientes c" +
                              " ON f.id_cliente = c.id_cliente" +
                              " JOIN usuarios u " +
                              " ON f.id_usuario = u.id_usuario" +
                              " GROUP BY d.id_factura,c.cedula,c.nombre, c.apellidos,u.nombre_usuario";

                AbrirConexion();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandText = ssql;

                OracleDataAdapter adaptador = new OracleDataAdapter(cmd);
                adaptador.Fill(tablaFacturas);

                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return tablaFacturas;
        }

        public DataTable ObtenerDevolucionFacturaId(int idFactura)
        {
            DataTable tablaDetalleFactura = new DataTable();

            try
            {


                string ssql = "SELECT d.id_factura, p.descripcion, d.cantidad, d.valor_unitario, d.iva, d.valor_total " +
                                    " FROM devoluciones d  " +
                                    " JOIN productos p " +
                                    " ON d.id_producto = p.id_producto " +
                                    " WHERE d.id_factura = :Id_Factura";

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
