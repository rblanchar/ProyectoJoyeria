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
            
            new FrmMenuClientes().Show();
            this.Close();
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

        private void Grilla_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string id_Cliente = Grilla_Clientes.Rows[e.RowIndex].Cells["Id_Cliente"].Value.ToString();
                string cedula = Grilla_Clientes.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                string nombre = Grilla_Clientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string apellidos = Grilla_Clientes.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
                string direccion = Grilla_Clientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                string barrio = Grilla_Clientes.Rows[e.RowIndex].Cells["Barrio"].Value.ToString();
                string correo = Grilla_Clientes.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                string telefono = Grilla_Clientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

                FrmFacturadeVenta facturadeVenta = new FrmFacturadeVenta();
                facturadeVenta.txt_IdCliente.Text = $"{id_Cliente}";
                facturadeVenta.txt_Cedula.Text = $"{cedula}";
                facturadeVenta.txt_Nombre.Text = $"{nombre}";
                facturadeVenta.txt_Apellidos.Text = $"{apellidos}";
                facturadeVenta.txt_Direccion.Text = $"{direccion}";
                facturadeVenta.txt_Barrio.Text = $"{barrio}";
                facturadeVenta.txt_Correo.Text = $"{correo}";
                facturadeVenta.txt_Telefono.Text = $"{telefono}";

                facturadeVenta.Show();
                this.Close();
            }
        }
    }
}
