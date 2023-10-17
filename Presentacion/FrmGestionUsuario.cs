using ENTIDAD;
using LOGICA;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmGestionUsuario : Form
    {
        private ServicioRol servicioRol = new ServicioRol();
        private ServicioUsuario servicioUsuario = new ServicioUsuario();
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

        void CargarRoles()
        {
            cmb_tipo.DataSource = servicioRol.Consultar();
            cmb_tipo.ValueMember = "IdRol";
            cmb_tipo.DisplayMember = "TipoRol";

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        void limpiar()
        {
            cmb_tipo.Text = string.Empty;
            cmb_tipo.Enabled = false;
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellidos.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_correo.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_usuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;
            btn_Guardar.Text = string.Empty;
            DesHabilitar();
            cmb_Opcion.SelectedItem = null;
            cmb_Opcion.Focus();
        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
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

        private void cmb_Opcion_Click(object sender, EventArgs e)
        {
            //if (cmb_Opcion.SelectedItem != null)
            //{
            //    string Opcion = cmb_Opcion.SelectedItem.ToString();
            //    if (Opcion== "REGISTRAR")
            //    {
            //        HabilitarRegistrar();
            //    }
            //}
        }
        void Habilitar()
        {
            cmb_tipo.Enabled = true;
            txt_id.Enabled = true;
            txt_nombre.Enabled = true;
            txt_apellidos.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
            txt_usuario.Enabled = true;
            txt_contraseña.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        void DesHabilitar()
        {
            cmb_tipo.Enabled = false;
            txt_id.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellidos.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
            txt_usuario.Enabled = false;
            txt_contraseña.Enabled = false;
            btn_Guardar.Enabled = false;
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedItem != null)
            {
                string Opcion = cmb_Opcion.SelectedItem.ToString();
                if (Opcion == "REGISTRAR")
                {
                    Habilitar();
                    btn_Guardar.Text = "Registrar";

                }
                else if (Opcion == "CONSULTAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id.Enabled = true;
                    btn_Guardar.Text = "Consultar";
                    btn_Guardar.Enabled = true;
                    txt_id.Focus();
                }
                else if (Opcion == "ELIMINAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id.Enabled = true;
                    btn_Guardar.Text = "Eliminar";
                    btn_Guardar.Enabled = true;
                    txt_id.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id.Enabled = true;
                    btn_Guardar.Text = "Modificar";
                    btn_Guardar.Enabled = true;
                    txt_id.Focus();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                Usuario usuario = new Usuario();
                usuario.Identificacion = txt_id.Text;
                usuario.Nombre = txt_nombre.Text;
                usuario.Apellido = txt_apellidos.Text;
                usuario.Direccion = txt_direccion.Text;
                usuario.Correo = txt_correo.Text;
                usuario.NumTelefono = txt_telefono.Text;
                usuario.NombreUsuario = txt_usuario.Text;
                usuario.Contraseña = txt_contraseña.Text;
                usuario.rol = servicioRol.BuscarId(
                    cmb_tipo.SelectedValue.ToString());

                Guardar(usuario);
                limpiar();
            }

            void Guardar(Usuario usuario)
            {
                var msg = servicioUsuario.Guardar(usuario);
                MessageBox.Show(msg);

            }
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.SelectedItem != null)
            {
                string datos = cmb_tipo.SelectedItem.ToString();
                string[] partes = datos.Split(';');
                if (partes.Length == 2)

                    if (partes[1] == "CLIENTE")
                    {
                        Habilitar();
                        btn_Guardar.Text = "Registrar";
                        txt_usuario.Enabled = false;
                        txt_contraseña.Enabled = false;
                    }
            }
        }
    }
}
