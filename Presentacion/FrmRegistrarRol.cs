using ENTIDAD;
using LOGICA;
using System;
using System.Windows.Forms;
using System.IO;
namespace Presentacion
{
    public partial class FrmRegistrarRol : Form
    {
        private ServicioRol servicioRol = new ServicioRol();
        private ServiciodeLectura serviciodeLectura = new ServiciodeLectura();
        private ModificarRol modificar = new ModificarRol();

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
            cancelar();
        }

        void cancelar()
        {
            txt_NombreRol.Text = string.Empty;
            txt_NombreRol.Focus();
            cmb_Opcion.Enabled = true;
            cmb_Opcion.Text = string.Empty;
            cmb_Opcion.Focus();
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
            if (btn_Guardar.Text == "Registrar")
            {

                if (string.IsNullOrWhiteSpace(txt_NombreRol.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NombreRol.Focus();

                }
                else
                {

                    string IdRol = txt_IdRol.Text;

                    if (servicioRol.BuscarId(IdRol) == null)
                    {
                        Guardar(new Rol(txt_IdRol.Text, txt_NombreRol.Text));
                        cancelar();
                        FrmRegistrarRol_Load(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Este IdRol ya existe!");
                        cancelar();
                        txt_IdRol.Enabled = false;
                    }
                }
            }
            else if (btn_Guardar.Text == "Modificar")
            {

                Rol rol = new Rol();

                DialogResult respuesta = MessageBox.Show("¿Estás seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
                {
                    string id = txt_IdRol.Text;
                    rol = servicioRol.BuscarId(id);
                    if (rol != null)
                    {

                        rol.TipoRol = txt_NombreRol.Text;
                        Habilitado();
                        var msg = modificar.ActualizarRol(rol);
                        MessageBox.Show(msg);
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show("Rol no encontrado.");
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
                        string id = txt_IdRol.Text;
                        var msg = modificar.EliminarRol(id);
                        MessageBox.Show(msg);
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un código válido antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        void Guardar(Rol rol)
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
                    txt_NombreRol.Focus;
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
                    Habilitado();
                    btn_Guardar.Text = "Eliminar";
                    txt_IdRol.Enabled = true;
                    txt_IdRol.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    Limpiar();
                    Habilitado();
                    btn_Guardar.Text = "Modificar";
                    txt_IdRol.Enabled = true;
                    txt_IdRol.Focus();
                }
            }
        }

        void Habilitado()
        {
            txt_IdRol.Enabled = true;
            txt_NombreRol.Enabled = true;
            btn_Guardar.Enabled = true;
        }
        void Deshabilitado()
        {
            txt_IdRol.Enabled = false;
            txt_NombreRol.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Guardar.Text = string.Empty;

        }

        void Limpiar()
        {
            txt_IdRol.Text = string.Empty;
            txt_NombreRol.Text = string.Empty;
        }

        public bool consultar(string id)
        {
            Rol rol = servicioRol.BuscarId(id);

            if (rol != null)
            {
                txt_IdRol.Text = rol.IdRol;
                txt_NombreRol.Text = rol.TipoRol;
                return true;
            }
            else
            {
                MessageBox.Show("El rol no existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        void Cargar()
        {
            string filename = "Rol.txt";
            if (File.Exists(filename))
            {
                var numero = serviciodeLectura.IncrementarCodigo(filename);

                txt_IdRol.Text = numero;
            }
            else
            {
                txt_IdRol.Text = "1001";
            }
        }
    }
}
