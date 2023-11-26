using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_ORACLE;
using ENTIDAD;

namespace Presentacion
{
    public partial class FrmGestionCliente : Form
    {
        ServicioClienteOracle servicioCliente = new ServicioClienteOracle();   
        public FrmGestionCliente()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuClientes().Show();
        }

        void limpiar()
        {
         
            txt_id_Cliente.Text = string.Empty;
            txt_Cedula.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellidos.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_Barrio.Text = string.Empty;
            txt_correo.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            btn_Guardar.Text = string.Empty;

            l22.Visible = false;
            l23.Visible = false;
            l24.Visible = false;
            l25.Visible = false;
            lb27.Visible = false;
            lb28.Visible = false;

            DesHabilitar();

        }

        void Habilitar()
        {
          
            txt_id_Cliente.Enabled = true;
            txt_Cedula.Enabled = true;
            txt_nombre.Enabled = true;
            txt_apellidos.Enabled = true;
            txt_direccion.Enabled = true;
            txt_Barrio.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        void DesHabilitar()
        {
            txt_id_Cliente.Enabled = false;
          
            txt_Cedula.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellidos.Enabled = false;
            txt_direccion.Enabled = false;
            txt_Barrio.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
            btn_Guardar.Enabled = false;
        }

        void CamposObligatorios()
        {
            l22.Visible = true; l24.Visible = true;
            l23.Visible = true; lb28.Visible = true;
            l25.Visible = true; 
            lb27.Visible = true; 
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedItem != null)
            {
                string Opcion = cmb_Opcion.SelectedItem.ToString();
                if (Opcion == "REGISTRAR")
                {
                    Habilitar();
                    CamposObligatorios();
                    btn_Guardar.Text = "Registrar";

                    var proximoIdCliente = servicioCliente.ProximoIdCliente();
                    txt_id_Cliente.Text = Convert.ToString(proximoIdCliente);

                    txt_id_Cliente.Enabled = false;

                }
                else if (Opcion == "CONSULTAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id_Cliente.Enabled = true;
                    txt_id_Cliente.Focus();
                }
                else if (Opcion == "ELIMINAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id_Cliente.Enabled = true;
                    txt_id_Cliente.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id_Cliente.Enabled = true;
                    txt_id_Cliente.Focus();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                if (string.IsNullOrWhiteSpace(txt_id_Cliente.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_Cedula.Text) ||
                    string.IsNullOrWhiteSpace(txt_apellidos.Text) || string.IsNullOrWhiteSpace(txt_direccion.Text) ||
                    string.IsNullOrWhiteSpace(txt_Barrio.Text) || string.IsNullOrWhiteSpace(txt_telefono.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.Id_Cliente = txt_id_Cliente.Text;
                    cliente.Cedula = txt_Cedula.Text;
                    cliente.Nombre = txt_nombre.Text;
                    cliente.Apellidos = txt_apellidos.Text;
                    cliente.Direccion = txt_direccion.Text;
                    cliente.Barrio = txt_Barrio.Text;
                    cliente.Correo = txt_correo.Text;
                    cliente.Telefono = txt_telefono.Text;
                  
                    Guardar(cliente);
                    limpiar();
                    Activar_cmb_Opcion();

                }
            }


            void Activar_cmb_Opcion()
            {
                cmb_Opcion.Text = string.Empty;
                cmb_Opcion.Enabled = true;
                cmb_Opcion.Focus();
            }
            void Guardar(Cliente cliente)
            {
                var msg = servicioCliente.InsertarCliente(cliente);
                MessageBox.Show(msg);

            }

            if (btn_Guardar.Text == "Modificar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id_Cliente = txt_id_Cliente.Text;
                    cliente.Cedula = txt_Cedula.Text;
                    cliente.Nombre = txt_nombre.Text;
                    cliente.Apellidos = txt_apellidos.Text;
                    cliente.Direccion = txt_direccion.Text;
                    cliente.Barrio = txt_Barrio.Text;
                    cliente.Correo = txt_correo.Text;
                    cliente.Telefono = txt_telefono.Text;
                    

                    var msg = servicioCliente.ModificarCliente(cliente);
                    MessageBox.Show(msg);
                    limpiar();
                    Activar_cmb_Opcion();
                }
            }


            else if (btn_Guardar.Text == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de Eliminar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {

                    var id = txt_id_Cliente.Text;
                  

                    var msg = servicioCliente.EliminarCliente(id);
                    MessageBox.Show(msg);
                    limpiar();
                    Activar_cmb_Opcion();
                }

            }
        }

        private void txt_id_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string id = txt_id_Cliente.Text;

                if (consultar(id) != false)
                {
                    if (cmb_Opcion.SelectedItem != null)
                    {
                        string Opcion = cmb_Opcion.SelectedItem.ToString();

                        if (Opcion == "REGISTRAR")
                        {
                            MessageBox.Show("Este usuario se encuentra registrado en la Base de Datos!");
                            limpiar();
                            cmb_Opcion.Text = string.Empty;
                            cmb_Opcion.Enabled = true;
                            cmb_Opcion.Focus();
                        }

                        else if (Opcion == "MODIFICAR")
                        {
                            Habilitar();
                            btn_Guardar.Text = "Modificar";
                            btn_Guardar.Enabled = true;
                            txt_id_Cliente.Enabled = false;
                            cmb_Opcion.Enabled = false;
                        }
                        else if (Opcion == "ELIMINAR")
                        {
                            DesHabilitar();
                            btn_Guardar.Text = "Eliminar";
                            btn_Guardar.Enabled = true;
                            txt_id_Cliente.Focus();
                            cmb_Opcion.Enabled = false;
                        }
                    }

                }
            }
        }


        public bool consultar(string id)
        {
            Cliente cliente = servicioCliente.BuscarId(id);

            if (cliente != null)
            {
                txt_Cedula.Text = cliente.Cedula;
                txt_nombre.Text = cliente.Nombre;
                txt_apellidos.Text = cliente.Apellidos;
                txt_direccion.Text = cliente.Direccion;
                txt_Barrio.Text = cliente.Barrio;
                txt_correo.Text = cliente.Correo;
                txt_telefono.Text = cliente.Telefono;
              

               
                return true;

            }

            return false;
        }

        private void txt_id_Cliente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Tab);
                this.txt_id_Cliente_KeyDown(this, keyEventArgs);
            }
        }

        private void txt_Barrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar))
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_id_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            cmb_Opcion.Enabled = true;
            cmb_Opcion.Text = string.Empty;
            cmb_Opcion.Focus();
        }

        private void FrmGestionCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
