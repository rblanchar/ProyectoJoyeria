using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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

        //public string InsertarDetalleFactura(Detalle_Factura detalle_factura)
        //{
        //    string ssql = "INSERT INTO detalle_facturas (id_factura, id_producto, cantidad, valor_unitario, iva,valor_total) " +
        //                  " VALUES (:v_id_factura, :v_id_producto, :v_cantidad, :v_valUnitario, :v_iva,:v_valTotal)";

        //    AbrirConexion();
        //    OracleCommand orclCmd1 = conexion.CreateCommand();
        //    orclCmd1.CommandText = ssql;

        //    orclCmd1.Parameters.Add(new OracleParameter(":v_id_factura", detalle_factura.factura.Id_Factura));
        //    orclCmd1.Parameters.Add(new OracleParameter(":v_id_producto", detalle_factura.producto.Id_Producto));
        //    orclCmd1.Parameters.Add(new OracleParameter(":v_cantidad", detalle_factura.Cantidad));
        //    orclCmd1.Parameters.Add(new OracleParameter(":v_valUnitario", detalle_factura.Valor_Unitario));
        //    orclCmd1.Parameters.Add(new OracleParameter(":v_iva", detalle_factura.iva));
        //    orclCmd1.Parameters.Add(new OracleParameter(":v_valTotal", detalle_factura.Valor_Total));

        //    int i = orclCmd1.ExecuteNonQuery();

        //    CerrarConexion();

        //    if (i > 0)
        //    {
        //        return "Registro de Factura Exitoso!";
        //    }
        //    else
        //    {
        //        return "No se pudo registrar la Factura";
        //    }
        //}

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
            return "Registro de Detalle de Factura Exitoso!";
        }

    }
}
