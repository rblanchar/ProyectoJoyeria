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
    public partial class FrmListadoMateriales : Form
    {
        ServicioMaterial servicioMaterial = new ServicioMaterial();
        public FrmListadoMateriales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void FrmListadoMateriales_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioMaterial.Consultar());
        }

        void CargarGrilla(List<Material> lista)
        {
            Grilla_Materiales.Rows.Clear();

            foreach (var item in lista)
            {
                Grilla_Materiales.Rows.Add(item.Codigo, item.NombreMaterial.ToUpper());
            }
        }
    }
}
