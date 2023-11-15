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
            DesHabilitar();
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
                    
                    Cliente cliente = new Cliente();
                  
                    cliente.Id_Cliente = txt_IdCliente.Text;
                    cliente.Cedula = txt_Cedula.Text;
                    cliente.Nombre = txt_Nombre.Text;
                    cliente.Apellidos = txt_Apellidos.Text;
                    cliente.Direccion = txt_Direccion.Text;
                    cliente.Barrio = txt_Barrio.Text;
                    cliente.Correo = txt_Correo.Text;
                    cliente.Telefono = txt_Telefono.Text;

                   
                    GuardarCliente(cliente);
                   
                    GuardarFactura();
                    limpiar();
                    Activar_cmb_Opcion();
                }
            }
        }
        private void GuardarCliente(Cliente cliente)
        {
            var msg = serviceCliente.InsertarCliente(cliente);
            MessageBox.Show(msg);
        }

        private void GuardarFactura()
        {
            Factura factura = new Factura();
            factura.Id_Factura = txt_idFactura.Text;
            factura.Fecha = Convert.ToDateTime(txt_Fecha.Text);
            factura.cliente = serviceCliente.BuscarId(txt_IdCliente.Text.ToString());
            factura.usuario = serviceUsuario.BuscarId(cmb_Usuario.SelectedValue.ToString());

            var msg = serviceFactura.InsertarFactura(factura);
            MessageBox.Show(msg);
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
                    txt_IdCliente.Enabled = false;
                    var proximoIdCliente = serviceCliente.ProximoIdCliente();
                    txt_IdCliente.Text = Convert.ToString(proximoIdCliente);
                    var proximoIdFactura = serviceFactura.ProximoidFactura();
                    txt_idFactura.Text = Convert.ToString(proximoIdFactura);
                    btn_Guardar.Enabled = true;

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
            
            txt_Nombre.Enabled = false;
            txt_Apellidos.Enabled = false;
            txt_Barrio.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
            txt_IdCliente.Enabled = false;
           
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


        private bool BuscarClientePorCedula(string cedula)
        {
            Cliente cliente = serviceCliente.BuscarPorCedula(cedula);

            if (cliente != null)
            {
                MostrarDatosCliente(cliente);
                txt_IdCliente.Enabled = false;
                return true;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El cliente no existe. ¿Desea agregar un nuevo cliente?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    
                    Habilitar();
                    txt_IdCliente.Enabled = false;
                    var proximoIdCliente = serviceCliente.ProximoIdCliente();
                    txt_IdCliente.Text = Convert.ToString(proximoIdCliente);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente");
                }

                return false;
            }
        }

        private void txt_Cedula_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string cedula = txt_Cedula.Text.Trim();

                if (!string.IsNullOrWhiteSpace(cedula))
                {
                    bool clienteEncontrado = BuscarClientePorCedula(cedula);

                    if (clienteEncontrado)
                    {
                        if (cmb_Opcion.SelectedItem != null)
                        {
                            string opcion = cmb_Opcion.SelectedItem.ToString();

                            if (opcion == "REGISTRAR")
                            {
                                txt_IdCliente.Enabled = false;
                                cmb_Opcion.Text = string.Empty;
                                cmb_Opcion.Enabled = true;
                                cmb_Opcion.Focus();
                            }
                            else if (opcion == "ELIMINAR")
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
        }



        private void MostrarDatosCliente(Cliente cliente)
        {

            txt_IdCliente.Text = cliente.Id_Cliente;
            txt_Cedula.Text = cliente.Cedula;
            txt_Nombre.Text = cliente.Nombre;
            txt_Apellidos.Text = cliente.Apellidos;
            txt_Direccion.Text = cliente.Direccion;
            txt_Barrio.Text = cliente.Barrio;
            txt_Correo.Text = cliente.Correo;
            txt_Telefono.Text = cliente.Telefono;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string cedula = txt_Cedula.Text.Trim();

            if (!string.IsNullOrWhiteSpace(cedula))
            {
                BuscarClientePorCedula(cedula);
            }
            else
            {
                MessageBox.Show("Ingrese un ID de cliente antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
