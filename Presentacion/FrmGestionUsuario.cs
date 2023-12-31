﻿using ENTIDAD;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using LOGICA_ORACLE;

namespace Presentacion
{
    public partial class FrmGestionUsuario : Form
    {
        private ServicioUsuarioOracle servicioUsuario = new ServicioUsuarioOracle();
        private ServicioTipoUsuarioOracle servicioTipoUsuario = new ServicioTipoUsuarioOracle();
        public FrmGestionUsuario()
        {
            InitializeComponent();
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

        void CargarTipoUsuarios()
        {
            cmb_tipo.DataSource = servicioTipoUsuario.Consultar();
            cmb_tipo.ValueMember = "IdTipo";
            cmb_tipo.DisplayMember = "Nombre";

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuUsuario().Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            cmb_Opcion.Enabled = true;
            cmb_Opcion.Text = string.Empty;
            cmb_Opcion.Focus();
        }
        void limpiar()
        {
            cmb_tipo.Text = string.Empty;
            cmb_tipo.Enabled = false;
            txt_id_Usuario.Text = string.Empty;
            txt_Cedula.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellidos.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_Barrio.Text = string.Empty;
            txt_correo.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_usuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;
            btn_Guardar.Text = string.Empty;

            l22.Visible = false;
            l23.Visible = false;
            l24.Visible = false;
            l25.Visible = false;
            l26.Visible = false;
            lb27.Visible = false;
            lb28.Visible = false;
            
            DesHabilitar();

        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            CargarTipoUsuarios();
            limpiar();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && char.IsUpper(e.KeyChar))
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        void Habilitar()
        {
            cmb_tipo.Enabled = true;
            txt_id_Usuario.Enabled = true;
            txt_Cedula.Enabled = true;
            txt_nombre.Enabled = true;
            txt_apellidos.Enabled = true;
            txt_direccion.Enabled = true;
            txt_Barrio.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
            txt_usuario.Enabled = true;
            txt_contraseña.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        void DesHabilitar()
        {
            txt_id_Usuario.Enabled = false;
            cmb_tipo.Enabled = false;
            txt_Cedula.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellidos.Enabled = false;
            txt_direccion.Enabled = false;
            txt_Barrio.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
            txt_usuario.Enabled = false;
            txt_contraseña.Enabled = false;
            btn_Guardar.Enabled = false;
        }

        void CamposObligatorios()
        {
            l22.Visible = true;
            l23.Visible = true; l24.Visible = true;
            l25.Visible = true; l26.Visible = true;
            lb27.Visible = true; lb28.Visible = true;
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

                    var proximoIdUsuario = servicioUsuario.ProximoidUsuario();
                    txt_id_Usuario.Text = Convert.ToString(proximoIdUsuario);

                    txt_id_Usuario.Enabled = false;

                }
                else if (Opcion == "CONSULTAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id_Usuario.Enabled = true;
                    txt_id_Usuario.Focus();
                }
                else if (Opcion == "ELIMINAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id_Usuario.Enabled = true;
                    txt_id_Usuario.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id_Usuario.Enabled = true;
                    txt_id_Usuario.Focus();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                if (string.IsNullOrWhiteSpace(txt_id_Usuario.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_Cedula.Text) ||
                    string.IsNullOrWhiteSpace(txt_apellidos.Text) || string.IsNullOrWhiteSpace(txt_direccion.Text) ||
                    string.IsNullOrWhiteSpace(txt_Barrio.Text) || string.IsNullOrWhiteSpace(txt_telefono.Text) || string.IsNullOrWhiteSpace(cmb_tipo.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = txt_id_Usuario.Text;
                    usuario.Cedula = txt_Cedula.Text;
                    usuario.Nombre = txt_nombre.Text;
                    usuario.Apellidos = txt_apellidos.Text;
                    usuario.Direccion = txt_direccion.Text;
                    usuario.Barrio = txt_Barrio.Text;
                    usuario.Correo = txt_correo.Text;
                    usuario.Telefono = txt_telefono.Text;
                    usuario.Nombre_Usuario = txt_usuario.Text;
                    usuario.Contrasena = txt_contraseña.Text;
                    usuario.tipoUsuario = servicioTipoUsuario.BuscarId(cmb_tipo.SelectedValue.ToString());

                    Guardar(usuario);
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
            void Guardar(Usuario usuario)
            {
                var msg = servicioUsuario.InsertarUsuario(usuario);
                MessageBox.Show(msg);

            }

            if (btn_Guardar.Text == "Modificar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = txt_id_Usuario.Text;
                    usuario.Cedula = txt_Cedula.Text;
                    usuario.Nombre = txt_nombre.Text;
                    usuario.Apellidos = txt_apellidos.Text;
                    usuario.Direccion = txt_direccion.Text;
                    usuario.Barrio = txt_Barrio.Text;
                    usuario.Correo = txt_correo.Text;
                    usuario.Telefono = txt_telefono.Text;
                    usuario.Nombre_Usuario = txt_usuario.Text;
                    usuario.Contrasena = txt_contraseña.Text;
                    usuario.tipoUsuario = servicioTipoUsuario.BuscarId(cmb_tipo.SelectedValue.ToString());

                    var msg = servicioUsuario.ModificarUsuario(usuario);
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

                    var id = txt_id_Usuario.Text;
                    // Usuario usuario = servicioUsuario.BuscarId(id);

                    var msg = servicioUsuario.EliminarUsuario(id);
                    MessageBox.Show(msg);
                    limpiar();
                    Activar_cmb_Opcion();
                }
                
            }
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string id = txt_id_Usuario.Text;

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
                            if (cmb_tipo.Text=="CLIENTE")
                            {
                                txt_usuario.Enabled = false;
                                txt_contraseña.Enabled= false;
                            }
                            btn_Guardar.Text = "Modificar";
                            btn_Guardar.Enabled = true;
                            txt_id_Usuario.Enabled = false;
                            cmb_Opcion.Enabled = false;
                        }
                        else if (Opcion == "ELIMINAR")
                        {
                            DesHabilitar();
                            btn_Guardar.Text = "Eliminar";
                            btn_Guardar.Enabled = true;
                            txt_id_Usuario.Focus();
                            cmb_Opcion.Enabled = false;
                        }
                    }

                }
            }
        }
        public bool consultar(string id)
        {
            Usuario usuario = servicioUsuario.BuscarId(id);

            if (usuario != null)
            {
                txt_Cedula.Text = usuario.Cedula;
                txt_nombre.Text = usuario.Nombre;
                txt_apellidos.Text = usuario.Apellidos;
                txt_direccion.Text = usuario.Direccion;
                txt_Barrio.Text = usuario.Barrio;
                txt_correo.Text = usuario.Correo;
                txt_telefono.Text = usuario.Telefono;
                txt_usuario.Text = usuario.Nombre_Usuario;
                txt_contraseña.Text = usuario.Contrasena;

                TipoUsuario tipoUsuario2 = servicioTipoUsuario.BuscarId(usuario.tipoUsuario.IdTipo.ToString());

                if (tipoUsuario2 != null)
                {
                    cmb_tipo.Text = tipoUsuario2.Nombre.ToString();
                }

                return true;

            }

            return false;
        }

        private void txt_id_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Tab); 
                this.txt_id_KeyDown(this, keyEventArgs);
            }
        }

        private void txt_Barrio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
