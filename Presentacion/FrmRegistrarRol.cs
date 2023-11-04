using ENTIDAD;
using LOGICA;
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Presentacion
{
    public partial class FrmRegistrarRol : Form
    {
        private ServicioTipoUsuario servicioRol = new ServicioTipoUsuario();
        private ServiciodeLectura serviciodeLectura = new ServiciodeLectura();
        private ModificarTipoUsuario modificar = new ModificarTipoUsuario();
        ServicioUsuario servicioUsuario = new ServicioUsuario();
        public FrmRegistrarRol()
        {
            InitializeComponent();

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuUsuario().Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txt_NombreRol_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_IdRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreRol.Text))
            {
                MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NombreRol.Focus();

            }
            else
            {
                if (btn_Guardar.Text == "Registrar")
                {
                    string IdRol = txt_IdRol.Text;

                    if (servicioRol.BuscarId(IdRol) == null)
                    {
                        Guardar(new TipoUsuario(txt_IdRol.Text, txt_NombreRol.Text));
                        Limpiar();
                        FrmRegistrarRol_Load(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Este Id_Usuario ya existe!");

                        txt_IdRol.Enabled = false;
                    }
                    
                }
                else if (btn_Guardar.Text == "Modificar")
                {

                    TipoUsuario rol = new TipoUsuario();

                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        string id = txt_IdRol.Text;
                        rol = servicioRol.BuscarId(id);
                        if (rol != null)
                        {

                            rol.Nombre = txt_NombreRol.Text;
                            Habilitado();
                            
                            var msg = modificar.ActualizarRol(rol);
                            MessageBox.Show(msg);
                            Limpiar();

                        }
                        else
                        {
                            MessageBox.Show("Tipo de Usuario no encontrado.");
                        }
                    }
                }

                else if (btn_Guardar.Text == "Eliminar")
                {
                    if (!string.IsNullOrEmpty(txt_IdRol.Text))
                    {
                        DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.OK)
                        {
                            int sw = 0;
                            foreach (var item in servicioUsuario.Consultar())
                            {
                                if (item.tipoUsuario.IdTipo == txt_IdRol.Text)
                                {
                                    MessageBox.Show("No se puede Eliminar un TipodeUsuario Asignado!");
                                    sw = 1;
                                    break;
                                }
                            }
                            if(sw ==0)
                            {
                                string id = txt_IdRol.Text;
                                var msg = modificar.EliminarRol(id);
                                MessageBox.Show(msg);
                                Limpiar();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un código válido antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        void Guardar(TipoUsuario rol)
        {
            var msg = servicioRol.Guardar(rol);
            MessageBox.Show(msg);

        }

        private void FrmRegistrarRol_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedItem != null)
            {
                string Opcion = cmb_Opcion.SelectedItem.ToString();
                if (Opcion == "REGISTRAR")
                {
                    Habilitado();
                    Cargar();
                    txt_IdRol.Enabled = false;
                    txt_NombreRol.Focus();
                    btn_Guardar.Text = "Registrar";
                  
                }
                else if (Opcion == "CONSULTAR")
                {
                    Limpiar();

                    Deshabilitado();
                    txt_IdRol.Enabled = true;
                    txt_IdRol.Focus();
                }
                else if (Opcion == "ELIMINAR")
                {
                    Limpiar();
                    Deshabilitado();
                    btn_Guardar.Enabled = true;
                    btn_Guardar.Text = "Eliminar";
                    txt_IdRol.Enabled = true;
                    txt_IdRol.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    Limpiar();
                    Habilitado();
                    lb10.Visible = false;
                    btn_Guardar.Text = "Modificar";
                    txt_IdRol.Enabled = true;
                    txt_IdRol.Focus();
                }
            }
        }

        void Habilitado()
        {
            lb10.Visible = true;
            txt_IdRol.Enabled = true;
            txt_NombreRol.Enabled = true;
            btn_Guardar.Enabled = true;
        }
        void Deshabilitado()
        {
            lb10.Visible = false;
            txt_IdRol.Enabled = false;
            txt_NombreRol.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Guardar.Text = string.Empty;

        }

        public void Limpiar()
        {
            Deshabilitado ();
            txt_IdRol.Text = string.Empty;
            txt_NombreRol.Text = string.Empty;
            cmb_Opcion.Text = string.Empty;
            btn_Guardar.Text = "";
        }

        public bool consultar(string id)
        {
            TipoUsuario rol = servicioRol.BuscarId(id);

            if (rol != null)
            {
                txt_IdRol.Text = rol.IdTipo;
                txt_NombreRol.Text = rol.Nombre;
                return true;
            }
            else
            {
                MessageBox.Show("El Tipo de Usuario no existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txt_IdRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = txt_IdRol.Text;
                bool resultado = consultar(id);


            }
        }

        public string Cargar()
        {
            string filename = "TipoUsuario.txt";
            if (File.Exists(filename))
            {
                var numero = serviciodeLectura.IncrementarCodigo(filename);

                txt_IdRol.Text = numero;
            }
            else
            {
                txt_IdRol.Text = "301";
            }
            return null;
        }
    }
}
