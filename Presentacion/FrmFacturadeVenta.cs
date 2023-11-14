using ENTIDAD;
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

        void cargarUsuarios()
        {
            
            cmb_Usuario.DataSource = serviceUsuario.Consultar();
            cmb_Usuario.ValueMember = "Id_Usuario";
            cmb_Usuario.DisplayMember = "Nombre_Usuario";


        }
        private void FrmFacturadeVenta_Load(object sender, EventArgs e)
        {
            DesHabilitar();
            txt_Fecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
            cargarUsuarios();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            cmb_Opcion.Enabled = true;
            cmb_Opcion.Text = string.Empty;
            cmb_Opcion.Focus();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                if (string.IsNullOrWhiteSpace(txt_IdCliente.Text) || string.IsNullOrWhiteSpace(txt_Nombre.Text) || string.IsNullOrWhiteSpace(txt_Cedula.Text) ||
                    string.IsNullOrWhiteSpace(txt_Apellidos.Text) || string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                    string.IsNullOrWhiteSpace(txt_Barrio.Text) || string.IsNullOrWhiteSpace(txt_Telefono.Text) || string.IsNullOrWhiteSpace(cmb_Usuario.Text) || string.IsNullOrWhiteSpace(cmb_Opcion.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Factura factura = new Factura();
                    factura.Id_Factura = txt_idFactura.Text;
                    factura.Fecha = Convert.ToDateTime(txt_Fecha.Text);
                    factura.cliente = serviceCliente.BuscarId(txt_IdCliente.Text.ToString());
                    factura.usuario = serviceUsuario.BuscarId(cmb_Usuario.SelectedValue.ToString());
      
                    Guardar(factura);
                    limpiar();
                    Activar_cmb_Opcion();
                }
            }
        }
        void Activar_cmb_Opcion()
        {
            cmb_Opcion.Text = string.Empty;
            cmb_Opcion.Enabled = true;
            cmb_Opcion.Focus();
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
            else
            {
               // this.Show();
            }
            
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedItem != null)
            {
                string Opcion = cmb_Opcion.SelectedItem.ToString();
                if (Opcion == "REGISTRAR")
                {
                    Habilitar();
                    //limpiar();
                    CamposObligatorios();
                    btn_Guardar.Text = "Registrar";

                    var proximoIdFactura = serviceFactura.ProximoidFactura();
                    txt_idFactura.Text = Convert.ToString(proximoIdFactura);
                    btn_Guardar.Enabled = true;

                }
                else if (Opcion == "CONSULTAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_IdCliente.Enabled = true;
                    txt_IdCliente.Focus();
                    btn_Guardar.Text = "Consultar";

                }
                else if (Opcion == "ELIMINAR")
                {
                    btn_Guardar.Text = "Eliminar";
                }
               
            }
        }
        void Habilitar()
        {
            txt_Cedula.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Apellidos.Enabled = true;
            txt_Barrio.Enabled = true;
            txt_Direccion.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Correo.Enabled = true;
            txt_IdCliente.Enabled = true;
        }

        void DesHabilitar()
        {
            txt_Cedula.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellidos.Enabled = false;
            txt_Barrio.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
           
        }

        void limpiar()
        {
            txt_Cedula.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Apellidos.Text = string.Empty;
            txt_Barrio.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
            txt_Telefono.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            txt_IdCliente.Text = string.Empty;
            txt_idFactura.Text = string.Empty;
            

            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
        }

        void CamposObligatorios()
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
        }

        public bool consultar(string id)
        {
            Cliente cliente = serviceCliente.BuscarId(id);

            if (cliente != null)
            {
                txt_Cedula.Text = cliente.Cedula;
                txt_Nombre.Text = cliente.Nombre;
                txt_Apellidos.Text = cliente.Apellidos;
                txt_Direccion.Text = cliente.Direccion;
                txt_Barrio.Text = cliente.Barrio;
                txt_Correo.Text = cliente.Correo;
                txt_Telefono.Text = cliente.Telefono;



                return true;

            }
            else
            {
                DialogResult resultado = MessageBox.Show("El cliente no existe. ¿Desea agregar un nuevo cliente?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    AbrirFormCliente();
                }
            }

            return false;
        }
        private void AbrirFormCliente()
        {
           
            FrmGestionCliente frmGestionCliente = new FrmGestionCliente();


            frmGestionCliente.ShowDialog();
        }

        private void txt_IdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string id = txt_IdCliente.Text;

                if (consultar(id) != false)
                {
                    if (cmb_Opcion.SelectedItem != null)
                    {
                        string Opcion = cmb_Opcion.SelectedItem.ToString();

                        if (Opcion == "REGISTRAR")
                        {
                          
                            cmb_Opcion.Text = string.Empty;
                            cmb_Opcion.Enabled = true;
                            cmb_Opcion.Focus();
                        }
                        else if (Opcion == "ELIMINAR")
                        {
                            DesHabilitar();
                            btn_Guardar.Text = "Eliminar";
                            btn_Guardar.Enabled = true;
                            txt_IdCliente.Focus();
                            cmb_Opcion.Enabled = false;
                        }
                    }

                }
            }
        }

        private void txt_IdCliente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Tab);
                this.txt_IdCliente_KeyDown(this, keyEventArgs);
            }
        }
    }
}
