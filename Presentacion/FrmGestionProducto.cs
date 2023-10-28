using LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmGestionProducto : Form
    {
        ServicioCategoriaProducto categoriaProducto= new ServicioCategoriaProducto();
        ServicioMaterial servicioMaterial= new ServicioMaterial();
        public FrmGestionProducto()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void FrmGestionProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }
        void CargarCategorias()
        {
            cmb_Categoria.DataSource = categoriaProducto.Consultar();
            cmb_Categoria.ValueMember = "Codigo";
            cmb_Categoria.DisplayMember = "NomCategoria";

            cmb_Material.DataSource = servicioMaterial.Consultar();
            cmb_Material.ValueMember = "Codigo";
            cmb_Material.DisplayMember = "NombreMaterial";

        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmb_Opcion.SelectedItem.ToString();
            //MessageBox.Show("Has seleccionado: " + selectedItem);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
