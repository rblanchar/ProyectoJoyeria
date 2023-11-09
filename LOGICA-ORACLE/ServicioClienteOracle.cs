using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS_ORACLE;


namespace LOGICA_ORACLE
{
    public class ServicioClienteOracle
    {
        RepositorioClienteOracle repositorio = new RepositorioClienteOracle();

       public string InsertarCliente(Cliente cliente)
        {
            var msg = repositorio.InsertarCliente(cliente);
            return msg;
        }

        public List<Cliente> clientes;

        public List<Cliente> Consultar()
        {
            clientes = repositorio.ObtenerTodosClientes();
            return clientes;
        }

        public Cliente BuscarId(string id)
        {
            foreach (var cliente in Consultar())
            {
                if (cliente.Id_Cliente == id)
                {
                    return cliente;
                }
            }
            return null;
        }

        public string ModificarCliente(Cliente cliente)
        {
            var msg = repositorio.ModificarCliente(cliente);
            return msg;
        }

        public string EliminarCliente(string id)
        {
            var msg = repositorio.EliminarCliente(id);
            return msg;
        }
        public string ProximoIdCliente()
        {
            return repositorio.ProximoIdCliente();
        }

        public List<Cliente> BuscarFiltro(string valor)
        {
            List<Cliente> listaFiltrada = new List<Cliente>();

            foreach (var item in clientes)
            {
                
                if (item.Nombre.Contains(valor) || item.Apellidos.Contains(valor))
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
    }
}
