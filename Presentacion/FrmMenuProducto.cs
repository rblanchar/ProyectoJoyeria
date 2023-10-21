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
    public partial class FrmMenuProducto : Form
    {
        public FrmMenuProducto()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmRegistrarCategoria().Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmGestionProducto().Show();    
        }
    }
}
