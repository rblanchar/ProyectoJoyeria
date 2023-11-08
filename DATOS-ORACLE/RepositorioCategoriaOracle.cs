using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class RepositorioCategoriaOracle: BaseDatosORACLE
    {
        public RepositorioCategoriaOracle() : base()
        {

        }

        public string InsertarCategoria(CategoriaProducto categoriaProducto)
        {

            string ssql = "INSERT INTO categoria_productos(id_categoria, nombre) VALUES(seq_id_categoria_producto.NEXTVAL, :nombre)";
            ;
            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;


            orclCmd1.Parameters.Add(new OracleParameter(":nombre", categoriaProducto.Nombre));
            int i = orclCmd1.ExecuteNonQuery();


            CerrarConexion();

            if (i > 0)
            {
                return "Se Registró la CategoriaProducto Exitosamente! ";
            }
            else
            {
                return "No se pudo Registrar la CategoriaProducto.";
            }
        }

        public List<CategoriaProducto> ObtenerTodos()
        {
            List<CategoriaProducto> list = new List<CategoriaProducto>();
            string ssql = "SELECT * FROM categoria_productos ";

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
        private CategoriaProducto Mapear(OracleDataReader reader)
        {
            CategoriaProducto categoriaProducto = new CategoriaProducto();


            categoriaProducto.Id_Categoria = Convert.ToString(reader["ID_CATEGORIA"]);
            categoriaProducto.Nombre = Convert.ToString(reader["NOMBRE"]);


            return categoriaProducto;
        }

        public string ModificarCategoria(CategoriaProducto categoriaProducto)
        {

            if (ObtenerCategoriaPorId(categoriaProducto.Id_Categoria) == null)
            {
                return "La Categoria no existe en la base de datos.";
            }

            string ssql = "UPDATE categoria_productos SET nombre = :nombre WHERE id_categoria = :id_categoria";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":nombre", categoriaProducto.Nombre));
            orclCmd.Parameters.Add(new OracleParameter(":id_categoria", categoriaProducto.Id_Categoria));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se modificó La CategoriaProducto exitosamente.";
            }
            else
            {
                return "No se pudo modificar la CategoriaProducto.";
            }
        }

        public CategoriaProducto ObtenerCategoriaPorId(string id_categoria)
        {
            string ssql = "SELECT * FROM categoria_productos WHERE id_categoria = :id_categoria";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":id_categoria", id_categoria));

            OracleDataReader rdr = cmd.ExecuteReader();

            CategoriaProducto categoriaProducto = null;

            if (rdr.Read())
            {
                categoriaProducto = Mapear(rdr);
            }

            rdr.Close();
            CerrarConexion();

            return categoriaProducto;
        }
        public string EliminarCategoria(string id_Categoria)
        {

            if (ObtenerCategoriaPorId(id_Categoria) == null)
            {
                return "La CategoriaProducto no existe en la base de datos.";
            }

            string ssql = "DELETE FROM categoria_productos WHERE id_categoria = :id_categoria";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":id_categoria", id_Categoria));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se eliminó la CategoriaProducto Exitosamente.";
            }
            else
            {
                return "No se pudo eliminar la CategoriaProducto.";
            }
        }


        public List<CategoriaProducto> IncrementarIdCategoria()
        {
            List<CategoriaProducto> list = new List<CategoriaProducto>();
            string ssql = "SELECT * FROM categoria_productos ORDER BY ID_categoria DESC FETCH FIRST 1 ROW ONLY";

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
    }
}
