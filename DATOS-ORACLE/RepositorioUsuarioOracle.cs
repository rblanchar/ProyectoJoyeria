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

            orclCmd1.Parameters.Add(new OracleParameter(":identificacion", usuario.Identificacion));
            orclCmd1.Parameters.Add(new OracleParameter(":nombre", usuario.Nombre));
            orclCmd1.Parameters.Add(new OracleParameter(":apellido", usuario.Apellido));
            orclCmd1.Parameters.Add(new OracleParameter(":direccion", usuario.Direccion));
            orclCmd1.Parameters.Add(new OracleParameter(":barrio", usuario.Barrio));
            orclCmd1.Parameters.Add(new OracleParameter(":correo", usuario.Correo));
            orclCmd1.Parameters.Add(new OracleParameter(":numTelefono", usuario.NumTelefono));
            orclCmd1.Parameters.Add(new OracleParameter(":nombreUsuario", usuario.NombreUsuario));
            orclCmd1.Parameters.Add(new OracleParameter(":contraseña", usuario.Contraseña));
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

            usuario.Identificacion = Convert.ToString(reader["ID_USUARIO"]);
            usuario.Nombre = Convert.ToString(reader["NOMBRE"]);
            usuario.Apellido = Convert.ToString(reader["APELLIDOS"]);
            usuario.Direccion = Convert.ToString(reader["DIRECCION"]);
            usuario.Barrio = Convert.ToString(reader["BARRIO"]);
            usuario.Correo = Convert.ToString(reader["CORREO"]);
            usuario.NumTelefono = Convert.ToString(reader["TELEFONO"]);
            usuario.NombreUsuario = Convert.ToString(reader["NOMBRE_USUARIO"]);
            usuario.Contraseña = Convert.ToString(reader["CONTRASENA"]);
            TipoUsuario tipoUsuario = new TipoUsuario();
            tipoUsuario.IdTipo = Convert.ToString(reader["ID_TIPO"]);
            usuario.tipoUsuario = tipoUsuario;


            return usuario;
        }
    }
}
