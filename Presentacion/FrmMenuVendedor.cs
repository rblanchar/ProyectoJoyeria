using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenuVendedor : Form
    {
        public FrmMenuVendedor()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmInicioSesion().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Gestion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuClientes().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmFacturadeVenta().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmReporte().Show();
        }
    }
}
