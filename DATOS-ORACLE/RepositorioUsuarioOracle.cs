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
            string ssql = "INSERT INTO usuarios (id_usuario, nombre, apellidos, direccion, barrio, correo, telefono, nombre_usuario, contrasena, id_tipo) " +
                          "VALUES (:identificacion, :nombre, :apellido, :direccion, :barrio, :correo, :numTelefono, :nombreUsuario, :contraseña, :tipoUsuario)";

            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            orclCmd1.Parameters.Add(new OracleParameter(":identificacion", usuario.Id_Usuario));
            orclCmd1.Parameters.Add(new OracleParameter(":nombre", usuario.Nombre));
            orclCmd1.Parameters.Add(new OracleParameter(":apellido", usuario.Apellidos));
            orclCmd1.Parameters.Add(new OracleParameter(":direccion", usuario.Direccion));
            orclCmd1.Parameters.Add(new OracleParameter(":barrio", usuario.Barrio));
            orclCmd1.Parameters.Add(new OracleParameter(":correo", usuario.Correo));
            orclCmd1.Parameters.Add(new OracleParameter(":numTelefono", usuario.Telefono));
            orclCmd1.Parameters.Add(new OracleParameter(":nombreUsuario", usuario.Nombre_Usuario));
            orclCmd1.Parameters.Add(new OracleParameter(":contraseña", usuario.Contrasena));
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
                string ssql = "DELETE FROM tipo_usuarios WHERE id_tipo = :id";
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
    }
}
