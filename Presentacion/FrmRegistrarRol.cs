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
        private ServicioLecturaIdRol servicioLecturaIdRol = new ServicioLecturaIdRol();

        public FrmRegistrarRol()
        {
            InitializeComponent();

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        void cancelar()
        {
            txt_NombreRol.Text = string.Empty;
            txt_NombreRol.Focus();
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

        void Guardar(Rol rol)
        {
            var msg = servicioRol.Guardar(rol);
            MessageBox.Show(msg);

        }

        private void FrmRegistrarRol_Load(object sender, EventArgs e)
        {
            string filename = "Rol.txt";
            if (File.Exists(filename))
            {
                var numero = servicioLecturaIdRol.IncrementarId(filename);

                txt_IdRol.Text = numero;
            }
            else
            {
                txt_IdRol.Text = "1001";
            }
        }
    }
}
