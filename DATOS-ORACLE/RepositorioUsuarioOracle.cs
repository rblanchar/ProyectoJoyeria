using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTIDAD;

namespace DATOS_ORACLE
{
    public class RepositorioUsuarioOracle:BaseDatosORACLE
    {
        public RepositorioUsuarioOracle() : base()
        {

        }
        public string InsertarUsuario(Usuario usuario)
        {
            string ssql = "INSERT INTO usuarios (id_usuario, cedula, nombre, apellidos, direccion, barrio, correo, telefono, nombre_usuario, contrasena, id_tipo) " +
                          " VALUES (seq_id_usuario.NEXTVAL, :cedula, :nombre, :apellido, :direccion, :barrio, :correo, :numTelefono, :nombreUsuario, :contraseña, :tipoUsuario)";

            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            orclCmd1.Parameters.Add(new OracleParameter(":cedula", usuario.Cedula));
            orclCmd1.Parameters.Add(new OracleParameter(":nombre", usuario.Nombre));
            orclCmd1.Parameters.Add(new OracleParameter(":apellido", usuario.Apellidos));
            orclCmd1.Parameters.Add(new OracleParameter(":direccion", usuario.Direccion));
            orclCmd1.Parameters.Add(new OracleParameter(":barrio", usuario.Barrio));
            orclCmd1.Parameters.Add(new OracleParameter(":correo", usuario.Correo));
            orclCmd1.Parameters.Add(new OracleParameter(":Telefono", usuario.Telefono));
            orclCmd1.Parameters.Add(new OracleParameter(":nombre_Usuario", usuario.Nombre_Usuario));
            orclCmd1.Parameters.Add(new OracleParameter(":contrasena", usuario.Contrasena));
            orclCmd1.Parameters.Add(new OracleParameter(":tipoUsuario", usuario.tipoUsuario.IdTipo));

            int i = orclCmd1.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se Registró el Usuario Exitosamente!";
            }
            else
            {
                return "No se pudo Registrar el Usuario.";
            }
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string ssql = "SELECT * FROM usuarios ORDER BY id_usuario DESC";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listaUsuarios.Add(MapearUsuario(reader));
            }

            reader.Close();
            CerrarConexion();

            return listaUsuarios;
        }

        private Usuario MapearUsuario(OracleDataReader reader)
        {
            Usuario usuario = new Usuario();

            usuario.Id_Usuario = Convert.ToString(reader["ID_USUARIO"]);
            usuario.Cedula = Convert.ToString(reader["CEDULA"]);
            usuario.Nombre = Convert.ToString(reader["NOMBRE"]);
            usuario.Apellidos = Convert.ToString(reader["APELLIDOS"]);
            usuario.Direccion = Convert.ToString(reader["DIRECCION"]);
            usuario.Barrio = Convert.ToString(reader["BARRIO"]);
            usuario.Correo = Convert.ToString(reader["CORREO"]);
            usuario.Telefono = Convert.ToString(reader["TELEFONO"]);
            usuario.Nombre_Usuario = Convert.ToString(reader["NOMBRE_USUARIO"]);
            usuario.Contrasena = Convert.ToString(reader["CONTRASENA"]);
            TipoUsuario tipoUsuario = new TipoUsuario();
            tipoUsuario.IdTipo = Convert.ToString(reader["ID_TIPO"]);
            usuario.tipoUsuario = tipoUsuario;


            return usuario;
        }
        public string EliminarUsuario(string id)
        {
            try
            {
                string ssql = "DELETE FROM usuarios WHERE id_usuario = :id";
                AbrirConexion();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandText = ssql;

                cmd.Parameters.Add(new OracleParameter(":id", id));

                int i = cmd.ExecuteNonQuery();
                CerrarConexion();

                if (i > 0)
                {
                    return $"Se Eliminó el Usuario --> {id}";
                }
                else
                {
                    return "No se encontró un registro con el ID especificado.";
                }
            }
            catch (Exception ex)
            {
                return "Error al Eliminar: " + ex.Message;
            }
        }

        public Usuario ObtenerUsuarioPorId(string id_Usuario)
        {
            string ssql = "SELECT * FROM usuarios WHERE id_usuario = :id_Usuario";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":id_usuario", id_Usuario));

            OracleDataReader rdr = cmd.ExecuteReader();

            Usuario Usuario = null;

            if (rdr.Read())
            {
                Usuario = MapearUsuario(rdr);
            }

            rdr.Close();
            CerrarConexion();

            return Usuario;
        }
        public string ModificarUsuario(Usuario usuario)
        {

            if (ObtenerUsuarioPorId(usuario.Id_Usuario) == null)
            {
                return "El Usuario no existe en la base de datos.";
            }

            string ssql = "UPDATE usuarios SET cedula =:cedula, nombre =:nombre, apellidos =:apellidos, direccion =:direccion, barrio =:barrio,correo =:correo, telefono =:telefono, " +
                " nombre_usuario =:nombre_usuario, contrasena =:contrasena, id_tipo =:id_tipo WHERE id_usuario = :id_usuario";
 
            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;
            orclCmd.Parameters.Add(new OracleParameter(":cedula", usuario.Cedula));
            orclCmd.Parameters.Add(new OracleParameter(":nombre", usuario.Nombre));
            orclCmd.Parameters.Add(new OracleParameter(":apellidos", usuario.Apellidos));
            orclCmd.Parameters.Add(new OracleParameter(":direccion", usuario.Direccion));
            orclCmd.Parameters.Add(new OracleParameter(":barrio", usuario.Barrio));
            orclCmd.Parameters.Add(new OracleParameter(":correo", usuario.Correo));
            orclCmd.Parameters.Add(new OracleParameter(":telefono", usuario.Telefono));
            orclCmd.Parameters.Add(new OracleParameter(":nombre_usuario", usuario.Nombre_Usuario));
            orclCmd.Parameters.Add(new OracleParameter(":contrasena", usuario.Contrasena));
            orclCmd.Parameters.Add(new OracleParameter(":id_tipo", usuario.tipoUsuario.IdTipo));
            orclCmd.Parameters.Add(new OracleParameter(":id_usuario", usuario.Id_Usuario));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se modificó el Usuario exitosamente.";
            }
            else
            {
                return "No se pudo modificar el Usuario.";
            }
        }
        public string ProximoIdUsuario()
        {
            string proximoId = null;

            string ssql = "SELECT last_number FROM USER_SEQUENCES WHERE sequence_name ='SEQ_ID_USUARIO'";

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
        public Usuario ObtenerUsuarioPorCredenciales(string nombre_usuario, string contrasena)
        {
            string ssql = "SELECT * FROM usuarios WHERE nombre_usuario = :nombre_usuario AND contrasena = :contrasena";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":nombre_usuario", nombre_usuario));
            cmd.Parameters.Add(new OracleParameter(":contrasena", contrasena));

            OracleDataReader reader = cmd.ExecuteReader();

            Usuario usuario = null;

            if (reader.Read())
            {
                usuario = MapearUsuario(reader);
            }

            reader.Close();
            CerrarConexion();

            return usuario;
        }


    }
}
