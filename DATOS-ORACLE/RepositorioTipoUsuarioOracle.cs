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
        public string InsertarTipoUsuario(TipoUsuario tipoUsuario)
        {
            
            string ssql = "INSERT INTO tipo_usuarios(id_tipo, nombre) VALUES(seq_tipo_usuario.NEXTVAL, :nombre)";

            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;


            orclCmd1.Parameters.Add(new OracleParameter(":nombre", tipoUsuario.Nombre));
            int i = orclCmd1.ExecuteNonQuery();


            CerrarConexion();

            if (i > 0)
            {
                return "Se Registró el Tipo de Usuario Exitosamente! ";
            }
            else
            {
                return "No se pudo Registrar el Tipo de Usuario.";
            }
        }

        public List<TipoUsuario> ObtenerTodos()
        {
            List<TipoUsuario> list = new List<TipoUsuario>();
            string ssql = "SELECT * FROM tipo_usuarios ORDER BY ID_TIPO DESC";

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
        private TipoUsuario Mapear(OracleDataReader reader)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();


            tipoUsuario.IdTipo = Convert.ToString(reader["ID_TIPO"]);
            tipoUsuario.Nombre = Convert.ToString(reader["NOMBRE"]);


            return tipoUsuario;
        }

        public string ModificarTipoUsuario(TipoUsuario tipoUsuario)
        {
            
            if (ObtenerTipoUsuarioPorId(tipoUsuario.IdTipo) == null)
            {
                return "El tipo de usuario no existe en la base de datos.";
            }

            string ssql = "UPDATE tipo_usuarios SET nombre = :nombre WHERE id_tipo = :id_tipo";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":nombre", tipoUsuario.Nombre));
            orclCmd.Parameters.Add(new OracleParameter(":id_tipo", tipoUsuario.IdTipo));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se modificó el Tipo de Usuario exitosamente.";
            }
            else
            {
                return "No se pudo modificar el Tipo de Usuario.";
            }
        }

        public TipoUsuario ObtenerTipoUsuarioPorId(string idTipo)
        {
            string ssql = "SELECT * FROM tipo_usuarios WHERE id_tipo = :id_tipo";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":id_tipo", idTipo));

            OracleDataReader rdr = cmd.ExecuteReader();

            TipoUsuario tipoUsuario = null;

            if (rdr.Read())
            {
                tipoUsuario = Mapear(rdr);
            }

            rdr.Close();
            CerrarConexion();

            return tipoUsuario;
        }
        public string EliminarTipoUsuario(string idTipo)
        {
            
            if (ObtenerTipoUsuarioPorId(idTipo) == null)
            {
                return "El tipo de usuario no existe en la base de datos.";
            }

            string ssql = "DELETE FROM tipo_usuarios WHERE id_tipo = :id_tipo";

            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;

            orclCmd.Parameters.Add(new OracleParameter(":id_tipo", idTipo));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se eliminó el Tipo de Usuario exitosamente.";
            }
            else
            {
                return "No se pudo eliminar el Tipo de Usuario.";
            }
        }


        public List<TipoUsuario> IncrementarIdTipoUsuario()
        {
            List<TipoUsuario> list = new List<TipoUsuario>();
            string ssql = "SELECT * FROM tipo_usuarios ORDER BY ID_TIPO DESC FETCH FIRST 1 ROW ONLY";

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
