using LOGICA;
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
    public partial class FrmInicioSesion : Form
    {
        ServicioUsuario servicioUsuario= new ServicioUsuario();
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
            if (txt_pass.Text=="")
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
            string contraseña = txt_pass.Text;
            string usuario = txt_user.Text;

            if (servicioUsuario.Loguin(usuario, contraseña) == 1)
            {
                this.Close();
                FrmMenuSuper super = new FrmMenuSuper();
                super.Show();             
            }
            else if (servicioUsuario.Loguin(usuario, contraseña) == 2)
            {
                this.Close();
                new FrmMenuAdmin().Show();
                
            }
            else if (servicioUsuario.Loguin(usuario, contraseña) == 3)
            {
                this.Close();
                new FrmMenuVendedor().Show();

            }


        }
    }
}
