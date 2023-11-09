using ENTIDAD;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ORACLE
{
    public class RepositorioMaterialOracle: BaseDatosORACLE
    {
        public RepositorioMaterialOracle(): base()
        {

        }

        public string InsertarMaterial(Material material)
        {

            string ssql = "INSERT INTO materiales(id_material, nombre) VALUES(seq_id_material.NEXTVAL, :nombre)";
            
            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;


            orclCmd1.Parameters.Add(new OracleParameter(":nombre", material.Nombre));
            int i = orclCmd1.ExecuteNonQuery();


            CerrarConexion();

            if (i > 0)
            {
                return "Se Registró el Material Exitosamente! ";
            }
            else
            {
                return "No se pudo Registrar el Material.";
            }
        }

        public List<Material> ObtenerTodos()
        {
            List<Material> list = new List<Material>();
            string ssql = "SELECT * FROM materiales ";

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
        private Material Mapear(OracleDataReader reader)
        {
            Material material = new Material();


            material.Id_Material= Convert.ToString(reader["ID_MATERIAL"]);
            material.Nombre = Convert.ToString(reader["NOMBRE"]);


            return material;
        }

        public string ModificarMaterial(Material material)
        {

            if (ObtenerMaterialPorId(material.Id_Material) == null)
            {
                return "El Material no existe en la base de datos.";
            }

            string ssql = "UPDATE materiales SET nombre = :nombre WHERE id_material = :id_material";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":nombre", material.Nombre));
            orclCmd.Parameters.Add(new OracleParameter(":id_material", material.Id_Material));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se modificó el Material exitosamente.";
            }
            else
            {
                return "No se pudo modificar el Material.";
            }
        }

        public Material ObtenerMaterialPorId(string id_material)
        {
            string ssql = "SELECT * FROM materiales WHERE id_material = :id_material";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":id_material", id_material));

            OracleDataReader rdr = cmd.ExecuteReader();

            Material material = null;

            if (rdr.Read())
            {
                material = Mapear(rdr);
            }

            rdr.Close();
            CerrarConexion();

            return material;
        }
        public string EliminarMaterial(string id_Material)
        {

            if (ObtenerMaterialPorId(id_Material) == null)
            {
                return "El Material no existe en la base de datos.";
            }

            string ssql = "DELETE FROM materiales WHERE id_material = :id_material";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":id_material", id_Material));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se eliminó el Material Exitosamente.";
            }
            else
            {
                return "No se pudo eliminar el Material.";
            }
        }


        public string ProximoIdMaterial()
        {
            string proximoId = null;

            string ssql = "SELECT last_number FROM USER_SEQUENCES WHERE sequence_name ='SEQ_ID_MATERIAL'";

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
