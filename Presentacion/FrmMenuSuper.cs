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
            new FrmRegistrarRol().Show();
        }
    }
}
