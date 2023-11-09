using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenuSuper : Form
    {
        public FrmMenuSuper()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmInicioSesion().Show();

        }

        private void btn_Gestion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmGestionUsuario().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuUsuario().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmListarUsuarios().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListarUsuarios().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmRegistrarMaterial().Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new FrmFacturadeVenta().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuClientes().Show();
        }
    }
}
