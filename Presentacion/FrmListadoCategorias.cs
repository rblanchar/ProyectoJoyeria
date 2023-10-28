using ENTIDAD;
using LOGICA;
using System;
using System.Collections;
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
    public partial class FrmListadoCategorias : Form
    {
        ServicioCategoriaProducto servicioCategoriaProducto = new ServicioCategoriaProducto();
        public FrmListadoCategorias()
        {
            InitializeComponent();
        }

        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioCategoriaProducto.Consultar());
        }

        void CargarGrilla(List<CategoriaProducto> lista)
        {
            Grilla_Categorias.Rows.Clear();

            foreach (var item in lista)
            {
                Grilla_Categorias.Rows.Add(item.Codigo, item.NomCategoria.ToUpper());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }
    }
}
