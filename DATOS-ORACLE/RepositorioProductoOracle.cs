using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class RepositorioProductoOracle:BaseDatosORACLE
    {
        public RepositorioProductoOracle() : base()
        {

        }

        public string InsertarProducto(Producto producto)
        {

            string ssql = "INSERT INTO productos (id_producto, descripcion, costo, peso, margen_ganancia, cantidad, id_categoria, id_material) " +
                 "VALUES (seq_id_producto.NEXTVAL, :descripcion, :costo, :peso, :margen_ganancia, :cantidad, :id_categoria, :id_material)";


            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;


            orclCmd1.Parameters.Add(new OracleParameter(":descripcion", producto.Descripcion));
            orclCmd1.Parameters.Add(new OracleParameter(":costo", producto.Costo));
            orclCmd1.Parameters.Add(new OracleParameter(":peso", producto.Peso));
            orclCmd1.Parameters.Add(new OracleParameter(":margen_ganancia", producto.Margen_Ganancia));
            orclCmd1.Parameters.Add(new OracleParameter(":cantidad", producto.Cantidad));
            orclCmd1.Parameters.Add(new OracleParameter(":id_categoria", producto.CategoriaProducto.Id_Categoria));
            orclCmd1.Parameters.Add(new OracleParameter(":id_material", producto.Material.Id_Material));
            int i = orclCmd1.ExecuteNonQuery();


            CerrarConexion();

            if (i > 0)
            {
                return "Se Registró el Producto Exitosamente! ";
            }
            else
            {
                return "No se pudo Registrar el Producto.";
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> list = new List<Producto>();
            string ssql = "SELECT * FROM productos ";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            OracleDataReader Rdr = cmd.ExecuteReader();

            while (Rdr.Read())
            {
                list.Add(Mapear(Rdr));
            }
            Rdr.Close();
            CerrarConexion();

            return list;

        }
        private Producto Mapear(OracleDataReader reader)
        {
            Producto producto = new Producto();


            producto.Id_Producto = Convert.ToString(reader["ID_PRODUCTO"]);
            producto.Descripcion= Convert.ToString(reader["DESCRIPCION"]);
            producto.Costo = Convert.ToDouble(reader["COSTO"]);

            producto.Peso = Convert.ToDecimal(reader["PESO"]);
            producto.Margen_Ganancia = Convert.ToDouble(reader["MARGEN_GANANCIA"]);
            producto.Cantidad = Convert.ToInt16(reader["CANTIDAD"]);

            CategoriaProducto categoriaProducto = new CategoriaProducto();
            categoriaProducto.Id_Categoria = Convert.ToString(reader["ID_CATEGORIA"]);
            producto.CategoriaProducto = categoriaProducto;

            Material material = new Material();
            material.Id_Material = Convert.ToString(reader["ID_MATERIAL"]);
            producto.Material = material;


            return producto;
        }

        public string ModificarProducto(Producto producto)
        {

            if (ObtenerProductoPorId(producto.Id_Producto) == null)
            {
                return "El Producto no existe en la base de datos.";
            }

            string ssql = "UPDATE productos SET descripcion =:descripcion, costo =:costo, peso =:peso,margen_ganancia =:margen_ganancia, " +
                " cantidad =:cantidad, id_categoria =:id_categoria, id_material =:id_material " +
                " WHERE id_producto = :id_producto";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":descripcion", producto.Descripcion));
            orclCmd.Parameters.Add(new OracleParameter(":costo", producto.Costo));
            orclCmd.Parameters.Add(new OracleParameter(":peso", producto.Peso));
            orclCmd.Parameters.Add(new OracleParameter(":margen_ganancia", producto.Margen_Ganancia));
            orclCmd.Parameters.Add(new OracleParameter(":cantidad", producto.Cantidad));
            orclCmd.Parameters.Add(new OracleParameter(":id_categoria", producto.CategoriaProducto.Id_Categoria));
            orclCmd.Parameters.Add(new OracleParameter(":id_material", producto.Material.Id_Material));
            orclCmd.Parameters.Add(new OracleParameter(":id_producto", producto.Id_Producto));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se modificó el Producto exitosamente.";
            }
            else
            {
                return "No se pudo modificar el Producto.";
            }
        }

        public Producto ObtenerProductoPorId(string id_producto)
        {
            string ssql = "SELECT * FROM productos WHERE id_producto = :id_producto";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":id_producto", id_producto));

            OracleDataReader rdr = cmd.ExecuteReader();

            Producto producto = null;

            if (rdr.Read())
            {
                producto = Mapear(rdr);
            }

            rdr.Close();
            CerrarConexion();

            return producto;
        }
        public string EliminarProducto(string id_producto)
        {

            if (ObtenerProductoPorId(id_producto) == null)
            {
                return "El Producto no existe en la base de datos.";
            }

            string ssql = "DELETE FROM productos WHERE id_producto = :id_producto";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":id_producto", id_producto));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se eliminó el Producto Exitosamente.";
            }
            else
            {
                return "No se pudo eliminar el Producto.";
            }
        }

        public string IncrementarIdProducto()
        {
            string proximoId = null;
            string ssql = "SELECT last_number FROM USER_SEQUENCES WHERE sequence_name ='SEQ_ID_PRODUCTO'";
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
