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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmRegistrarMaterial().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListadoMateriales().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListadoCategorias().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListadoProductos().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListadoResumidoProductos().Show();
        }
    }
}
