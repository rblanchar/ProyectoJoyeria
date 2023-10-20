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
            txt_correo.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_usuario.Text = string.Empty;
            txt_contraseña.Text = string.Empty;
            btn_Guardar.Text = string.Empty;
            DesHabilitar();
            
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
                    usuario.NombreUsuario = txt_usuario.Text;
                    usuario.Contraseña = txt_contraseña.Text;
                    usuario.rol = servicioRol.BuscarId(cmb_tipo.SelectedValue.ToString());

                    var msg = modificarUsuario.Modificar(usuario);
                    servicioUsuario.RefrescarLista();
                    MessageBox.Show(msg);
                    limpiar();
                    cmb_Opcion.Text = string.Empty;
                    cmb_Opcion.Enabled = true;
                    cmb_Opcion.Focus();
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
                        cmb_tipo.SelectedValue = usuario.rol.IdRol.ToString();

                        var msg = eliminarUsuario.Eliminar(usuario);
                        MessageBox.Show(msg);
                        limpiar();
                        cmb_Opcion.Text = string.Empty;
                        cmb_Opcion.Enabled = true;
                        cmb_Opcion.Focus();

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
                        btn_Guardar.Text = "Registrar";
                        txt_usuario.Enabled = false;
                        txt_contraseña.Enabled = false;
                    }
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                            txt_id.Focus();
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
                    if (item.rol == usuario.rol)
                    {

                        cmb_tipo.Text = item.rol.TipoRol.ToString();
                        return true;
                    }
                }
            }
            
            return false;

        }
    }
}
