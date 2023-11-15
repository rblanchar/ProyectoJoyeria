using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using ENTIDAD;

namespace DATOS_ORACLE
{
    public class RepositorioClienteOracle :BaseDatosORACLE
    {
        public RepositorioClienteOracle() : base()
        {

        }

        public string InsertarCliente(Cliente cliente)
        {
            string ssql = "INSERT INTO clientes (id_cliente, cedula, nombre, apellidos, direccion, barrio, correo, telefono) " +
                          " VALUES (seq_id_cliente.NEXTVAL, :cedula, :nombre, :apellido, :direccion, :barrio, :correo, :numTelefono)";

            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            orclCmd1.Parameters.Add(new OracleParameter(":cedula", cliente.Cedula));
            orclCmd1.Parameters.Add(new OracleParameter(":nombre", cliente.Nombre));
            orclCmd1.Parameters.Add(new OracleParameter(":apellido", cliente.Apellidos));
            orclCmd1.Parameters.Add(new OracleParameter(":direccion", cliente.Direccion));
            orclCmd1.Parameters.Add(new OracleParameter(":barrio", cliente.Barrio));
            orclCmd1.Parameters.Add(new OracleParameter(":correo", cliente.Correo));
            orclCmd1.Parameters.Add(new OracleParameter(":Telefono", cliente.Telefono));

            int i = orclCmd1.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se registro exitosamente el cliente";
            }
            else
            {
                return "No se pudo registrar el cliente";
            }
        }

        public List<Cliente> ObtenerTodosClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            string ssql = "SELECT * FROM clientes ORDER BY id_cliente DESC";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listaClientes.Add(MapearCliente(reader));
            }

            reader.Close();
            CerrarConexion();
            return listaClientes;
        }

        private Cliente MapearCliente(OracleDataReader reader)
        {
            Cliente cliente = new Cliente();

            cliente.Id_Cliente = Convert.ToString(reader["ID_CLIENTE"]);
            cliente.Cedula = Convert.ToString(reader["CEDULA"]);
            cliente.Nombre = Convert.ToString(reader["NOMBRE"]);
            cliente.Apellidos = Convert.ToString(reader["APELLIDOS"]);
            cliente.Direccion = Convert.ToString(reader["DIRECCION"]);
            cliente.Barrio = Convert.ToString(reader["BARRIO"]);
            cliente.Correo = Convert.ToString(reader["CORREO"]);
            cliente.Telefono = Convert.ToString(reader["TELEFONO"]);

            return cliente;
            
        }
        public string EliminarCliente(string id)
        {
            try
            {
                string ssql = "DELETE FROM clientes WHERE id_cliente = :id";
                AbrirConexion();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandText = ssql;

                cmd.Parameters.Add(new OracleParameter(":id", id));

                int i = cmd.ExecuteNonQuery();
                CerrarConexion();

                if (i > 0)
                {
                    return $"Se Eliminó el cliente --> {id}";
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

        public Cliente ObtenerClientePorId(string id_Cliente)
        {
            string ssql = "SELECT * FROM clientes WHERE id_cliente = :id_cliente";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":id_cliente", id_Cliente));

            OracleDataReader rdr = cmd.ExecuteReader();

            Cliente Cliente = null;

            if (rdr.Read())
            {
                Cliente = MapearCliente(rdr);
            }

            rdr.Close();
            CerrarConexion();

            return Cliente;
        }

        public string ModificarCliente(Cliente cliente)
        {

            if (ObtenerClientePorId(cliente.Id_Cliente) == null)
            {
                return "El Cliente no existe en la base de datos.";
            }

            string ssql = "UPDATE clientes SET cedula = :cedula, nombre = :nombre, apellidos = :apellidos, direccion = :direccion, barrio = :barrio, correo = :correo, telefono = :telefono " +
               "WHERE id_cliente = :id_cliente";


            AbrirConexion();
            OracleCommand orclCmd = conexion.CreateCommand();
            orclCmd.CommandText = ssql;
            orclCmd.Parameters.Add(new OracleParameter(":cedula", cliente.Cedula));
            orclCmd.Parameters.Add(new OracleParameter(":nombre", cliente.Nombre));
            orclCmd.Parameters.Add(new OracleParameter(":apellidos", cliente.Apellidos));
            orclCmd.Parameters.Add(new OracleParameter(":direccion", cliente.Direccion));
            orclCmd.Parameters.Add(new OracleParameter(":barrio", cliente.Barrio));
            orclCmd.Parameters.Add(new OracleParameter(":correo", cliente.Correo));
            orclCmd.Parameters.Add(new OracleParameter(":telefono", cliente.Telefono));
            orclCmd.Parameters.Add(new OracleParameter(":id_cliente", cliente.Id_Cliente));

            int i = orclCmd.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se modificó el Cliente exitosamente.";
            }
            else
            {
                return "No se pudo modificar el Cliente.";
            }
        }

        public string ProximoIdCliente()
        {
            string proximoId = null;

            string ssql = "SELECT last_number FROM USER_SEQUENCES WHERE sequence_name ='SEQ_ID_CLIENTE'";

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
        public Cliente BuscarPorCedula(string cedula)
        {
            string ssql = "SELECT * FROM clientes WHERE cedula = :cedula";

            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":cedula", cedula));

            OracleDataReader reader = cmd.ExecuteReader();

            Cliente cliente = null;

            if (reader.Read())
            {
                cliente = MapearCliente(reader);
            }

            reader.Close();
            CerrarConexion();

            return cliente;
        }

    }
}
