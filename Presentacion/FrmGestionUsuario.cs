using ENTIDAD;
using LOGICA;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmGestionUsuario : Form
    {
        private ServicioTipoUsuario servicioRol = new ServicioTipoUsuario();
        private ServicioUsuario servicioUsuario = new ServicioUsuario();
        private ModificarUsuario modificarUsuario = new ModificarUsuario();
        private EliminarUsuario eliminarUsuario = new EliminarUsuario();
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
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellidos.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_Barrio.Text = string.Empty;
            txt_correo.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_usuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;
            btn_Guardar.Text = string.Empty;
            l21.Visible = false;
            l22.Visible = false;
            l23.Visible = false;
            l24.Visible = false;
            l25.Visible = false;
            l26.Visible = false;
            lb27.Visible = false;
            DesHabilitar();
            
        }

        private void FrmGestionUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
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
            txt_id.Enabled = true;
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
            cmb_tipo.Enabled = false;
            txt_id.Enabled = false;
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
            l21.Visible = true; l22.Visible = true;
            l23.Visible = true; l24.Visible = true;
            l25.Visible = true; l26.Visible = true;
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

                }
                else if (Opcion == "CONSULTAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id.Enabled = true;
                    txt_id.Focus();
                }
                else if (Opcion == "ELIMINAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id.Enabled = true;
                    txt_id.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    limpiar();
                    DesHabilitar();
                    txt_id.Enabled = true;
                    txt_id.Focus();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                if (string.IsNullOrWhiteSpace(txt_id.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text)|| 
                    string.IsNullOrWhiteSpace(txt_apellidos.Text)|| string.IsNullOrWhiteSpace(txt_direccion.Text)||
                    string.IsNullOrWhiteSpace(txt_telefono.Text)|| string.IsNullOrWhiteSpace(cmb_tipo.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
                    usuario.tipoUsuario = servicioRol.BuscarId(cmb_tipo.SelectedValue.ToString());

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
                var msg = servicioUsuario.Guardar(usuario);
                MessageBox.Show(msg);

            }

           if (btn_Guardar.Text == "Modificar")
           {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    Usuario usuario = new Usuario();
                    usuario.Identificacion = txt_id.Text;
                    usuario.Nombre = txt_nombre.Text;
                    usuario.Apellido = txt_apellidos.Text;
                    usuario.Direccion = txt_direccion.Text;
                    usuario.Correo = txt_correo.Text;
                    usuario.NumTelefono = txt_telefono.Text;
                    if (cmb_tipo.Text.ToString()=="CLIENTE")
                    {
                        usuario.NombreUsuario = "";
                        usuario.Contraseña = "";
                    }
                    else
                    {
                        usuario.NombreUsuario = txt_usuario.Text;
                        usuario.Contraseña = txt_contraseña.Text;
                    }
                    usuario.tipoUsuario = servicioRol.BuscarId(cmb_tipo.SelectedValue.ToString());

                    var msg = modificarUsuario.Modificar(usuario);
                    servicioUsuario.RefrescarLista();
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

                    var id = txt_id.Text;
                    Usuario usuario = servicioUsuario.BuscarId(id);

                    if (usuario != null)
                    {

                        txt_nombre.Text = usuario.Nombre;
                        txt_apellidos.Text = usuario.Apellido;
                        txt_direccion.Text = usuario.Direccion;
                        txt_correo.Text = usuario.Correo;
                        txt_telefono.Text = usuario.NumTelefono;
                        txt_usuario.Text = usuario.NombreUsuario;
                        txt_contraseña.Text = usuario.Contraseña;
                        cmb_tipo.SelectedValue = usuario.tipoUsuario.IdTipo.ToString();

                        var msg = eliminarUsuario.Eliminar(usuario);
                        MessageBox.Show(msg);
                        limpiar();
                        Activar_cmb_Opcion();

                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
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
                        txt_usuario.Enabled = false;
                        txt_contraseña.Enabled = false;
                    }
                    else
                    {
                        txt_usuario.Enabled = true;
                        txt_contraseña.Enabled = true;
                    }
            }
        }

        public void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string id = txt_id.Text;

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
                            txt_id.Enabled = false;
                            cmb_Opcion.Enabled = false;
                        }
                        else if (Opcion == "ELIMINAR")
                        {
                            DesHabilitar();
                            btn_Guardar.Text = "Eliminar";
                            btn_Guardar.Enabled = true;
                            txt_id.Focus();
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
                txt_nombre.Text = usuario.Nombre;
                txt_apellidos.Text = usuario.Apellido;
                txt_direccion.Text = usuario.Direccion;
                txt_correo.Text = usuario.Correo;
                txt_telefono.Text = usuario.NumTelefono;
                txt_usuario.Text = usuario.NombreUsuario;
                txt_contraseña.Text = usuario.Contraseña;

                foreach (var item in servicioUsuario.usuarios)
                {
                    if (item.tipoUsuario == usuario.tipoUsuario)
                    {

                        cmb_tipo.Text = item.tipoUsuario.Nombre.ToString();
                        return true;
                    }
                }
            }
            
            return false;

        }

        private void txt_id_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Tab); // Puedes usar la tecla que desees
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
    }
}
