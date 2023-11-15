using System;
using System.Drawing;
using System.Windows.Forms;
using LOGICA_ORACLE;

namespace Presentacion
{
    public partial class FrmInicioSesion : Form
    {

        ServicioUsuarioOracle servicioUsuarioOracle = new ServicioUsuarioOracle();

        public FrmInicioSesion()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "Ingrese su nombre de usuario")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.Black;
            }
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "********";
                txt_pass.ForeColor = Color.Gray;
            }

        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "********")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Black;
            }
            if (txt_user.Text == "")
            {
                txt_user.Text = "Ingrese su nombre de usuario";
                txt_user.ForeColor = Color.Gray;
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MainMenuStrip = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarCredencialesYRedirigir();

        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                ValidarCredencialesYRedirigir();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ValidarCredencialesYRedirigir();
            }
        }


        private void ValidarCredencialesYRedirigir()
        {
            string contraseña = txt_pass.Text;
            string usuario = txt_user.Text;

            int idTipoUsuario = servicioUsuarioOracle.Loguin(usuario, contraseña);

            switch (idTipoUsuario)
            {
                case 1:
                    this.Close();
                    FrmMenuSuper super = new FrmMenuSuper();
                    super.Show();
                    break;
                case 2:
                    this.Close();
                    FrmMenuAdmin admin = new FrmMenuAdmin();
                    admin.Show();
                    break;
                case 3:
                    this.Close();
                    FrmMenuVendedor vendedor = new FrmMenuVendedor();
                    vendedor.Show();
                    break;
                default:

                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    break;
            }
        }

    }
}
