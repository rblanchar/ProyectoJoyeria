using LOGICA_ORACLE;
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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (UsuarioLogueado.Tipo == "1;")
            {
                new FrmMenuSuper().Show();
            }
            else if (UsuarioLogueado.Tipo == "2;")
            {
                new FrmMenuAdmin().Show();
            }
            else
            {
                new FrmMenuVendedor().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListadoFacturas().Show();
        }
    }
}
