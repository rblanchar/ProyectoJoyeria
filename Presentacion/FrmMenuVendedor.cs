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
    }
}
