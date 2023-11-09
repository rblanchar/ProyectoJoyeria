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
    public partial class FrmFacturadeVenta : Form
    {
        //ServicioRol 
        public FrmFacturadeVenta()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        private void FrmFacturadeVenta_Load(object sender, EventArgs e)
        {
            txt_Fecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
