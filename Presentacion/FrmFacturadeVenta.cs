using ENTIDAD;
using LOGICA;
using LOGICA_ORACLE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmFacturadeVenta : Form
    {
        ServicioUsuarioOracle serviceUsuario = new ServicioUsuarioOracle();
        ServicioClienteOracle serviceCliente = new ServicioClienteOracle();
        ServicioFacturaOracle serviceFactura = new ServicioFacturaOracle();
        public FrmFacturadeVenta()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        void cargarUsuariosClientes()
        {
            cmb_Usuario.DataSource = serviceUsuario.Consultar();
            cmb_Usuario.ValueMember = "Id_Usuario";
            cmb_Usuario.DisplayMember = "Nombre_Usuario";

            cmb_Cliente.DataSource = serviceCliente.Consultar();
            cmb_Cliente.ValueMember = "Id_Cliente";
            cmb_Cliente.DisplayMember = "Cedula";
        }
        private void FrmFacturadeVenta_Load(object sender, EventArgs e)
        {
            txt_Fecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
            cargarUsuariosClientes();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                //if (string.IsNullOrWhiteSpace(txt_id_Usuario.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_Cedula.Text) ||
                //    string.IsNullOrWhiteSpace(txt_apellidos.Text) || string.IsNullOrWhiteSpace(txt_direccion.Text) ||
                //    string.IsNullOrWhiteSpace(txt_Barrio.Text) || string.IsNullOrWhiteSpace(txt_telefono.Text) || string.IsNullOrWhiteSpace(cmb_tipo.Text))
                //{
                //    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                    Factura factura = new Factura();
                    factura.Id_Factura = txt_idFactura.Text;
                    factura.Fecha = Convert.ToDateTime(txt_Fecha.Text);
                    factura.cliente = serviceCliente.BuscarId(cmb_Cliente.SelectedValue.ToString());
                    factura.usuario = serviceUsuario.BuscarId(cmb_Usuario.SelectedValue.ToString());
      
                    //usuario.tipoUsuario = servicioTipoUsuario.BuscarId(cmb_tipo.SelectedValue.ToString());

                    Guardar(factura);
                    //limpiar();
                    //Activar_cmb_Opcion();
                //}
            }
        }

        void Guardar(Factura factura)
        {
            var msg = serviceFactura.InsertarFactura(factura);
            MessageBox.Show(msg);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // new FrmListadoClientes().Show();
            FrmListadoClientes frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.FormClosed += FormCliente_FormClosed;
            frmListadoClientes.Show();
            this.Hide();
        }
        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenuClientes frmCliente = Application.OpenForms.OfType<FrmMenuClientes>().FirstOrDefault();

            if (frmCliente != null)
            {
                frmCliente.Close();
                this.Show();
            }
            
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedItem != null)
            {
                string Opcion = cmb_Opcion.SelectedItem.ToString();
                if (Opcion == "REGISTRAR")
                {
                    //Habilitar();
                    //CamposObligatorios();
                    btn_Guardar.Text = "Registrar";

                    var proximoIdFactura = serviceFactura.ProximoidFactura();
                    txt_idFactura.Text = Convert.ToString(proximoIdFactura);
                    btn_Guardar.Enabled = true;

                }
                else if (Opcion == "CONSULTAR")
                {

                }
                else if (Opcion == "ELIMINAR")
                {

                }
                else if (Opcion == "MODIFICAR")
                {

                }
            }
        }
    }
}
