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
    public partial class FrmMenuUsuario : Form
    {
        public FrmMenuUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmRegistrarRol().Show();
        }

        private void btn_Gestion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmGestionUsuario().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListarUsuarios().Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }
    }
}
