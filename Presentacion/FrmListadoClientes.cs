using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using LOGICA;
using LOGICA_ORACLE;

namespace Presentacion
{
    public partial class FrmListadoClientes : Form
    {
        ServicioClienteOracle servicioCliente = new ServicioClienteOracle();
        public FrmListadoClientes()
        {
            InitializeComponent();
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioCliente.Consultar());
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuClientes().Show();
        }

        void CargarGrilla(List<Cliente> lista)
        {
            Grilla_Clientes.Rows.Clear();

            foreach (var item in lista)
            {
              
                Grilla_Clientes.Rows.Add(item.Id_Cliente, item.Cedula, item.Nombre.ToUpper(), item.Apellidos.ToUpper(), item.Direccion.ToUpper(), item.Barrio.ToUpper(),
                    item.Correo.ToUpper(), item.Telefono);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            var filtro = txt_Filtro.Text;
            var lista = servicioCliente.BuscarFiltro(filtro);
            CargarGrilla(lista);
        }
    }
}
