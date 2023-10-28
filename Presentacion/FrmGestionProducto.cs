using ENTIDAD;
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
            string Opcion = cmb_Opcion.SelectedItem.ToString();
            if (Opcion=="REGISTRAR")
            {
                
                HabilitarCampos();
                CamposObligatorios();
                btn_Guardar.Text = "Registrar";
            }
            else if(Opcion == "CONSULTAR")
            {
                DesHabilitarCampos();
                limpiar();
                txt_Codigo.Enabled = true;
                txt_Codigo.Focus();
            }
            else if (Opcion == "MODIFICAR")
            {
                
                DesHabilitarCampos();
                limpiar();
                btn_Guardar.Text = "Modificar";
                txt_Codigo.Enabled = true;
                txt_Codigo.Focus();
            }
            else if (Opcion =="ELIMINAR")
            {
                
                DesHabilitarCampos();
                limpiar();
                btn_Guardar.Text = "Eliminar";
                txt_Codigo.Enabled = true;
                txt_Codigo.Focus();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {

                if (string.IsNullOrWhiteSpace(cmb_Opcion.Text) || string.IsNullOrWhiteSpace(cmb_Categoria.Text) ||
                    string.IsNullOrWhiteSpace(cmb_Material.Text) || string.IsNullOrWhiteSpace(txt_Codigo.Text) ||
                    string.IsNullOrWhiteSpace(txt_Descripcion.Text) || string.IsNullOrWhiteSpace(txt_PrecioCosto.Text)||
                    string.IsNullOrWhiteSpace(txt_Margen.Text)|| string.IsNullOrWhiteSpace(txt_Cantidad.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios * ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Producto producto = new Producto();
                    
                    MessageBox.Show("Guardado!");
                }

               
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar()
        {
            cmb_Opcion.Text = string.Empty;
            cmb_Categoria.Text = string.Empty;
            cmb_Material.Text = string.Empty;
            txt_Codigo.Text = string.Empty;
            txt_Descripcion.Text = string.Empty;
            txt_Peso.Text = string.Empty;
            txt_PrecioCosto.Text = string.Empty;
            txt_Margen.Text = string.Empty;
            txt_Cantidad.Text = string.Empty;
            btn_Guardar.Text= string.Empty;
            lb20.Visible = false;
            lb21.Visible = false;
            lb22.Visible = false;
            lb23.Visible = false;
            lb24.Visible = false;
            lb25.Visible = false;
            lb26.Visible = false;
            lb27.Visible = false;
            DesHabilitarCampos();
            cmb_Opcion.Focus();
        }

        void DesHabilitarCampos()
        {
            cmb_Categoria.Enabled = false;
            cmb_Material.Enabled = false;
            txt_Descripcion.Enabled = false;
            txt_Peso.Enabled = false;
            txt_PrecioCosto.Enabled = false;
            txt_Margen.Enabled = false;
            txt_Cantidad.Enabled = false;
            txt_Codigo.Enabled = false;
        }

        void HabilitarCampos()
        {
            limpiar();
            txt_Codigo.Enabled = true;
            cmb_Categoria.Enabled = true;
            cmb_Material.Enabled = true;
            txt_Descripcion.Enabled = true;
            txt_Peso.Enabled = true;
            txt_PrecioCosto.Enabled = true;
            txt_Margen.Enabled = true;
            txt_Cantidad.Enabled = true;
        }

        void CamposObligatorios()
        {
            lb20.Visible = true;
            lb21.Visible = true;
            lb22.Visible = true;
            lb23.Visible = true;
            lb24.Visible = true;
            lb25.Visible = true;
            lb26.Visible = true;
            lb27.Visible = true;

        }
        private void cmb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Material.Text=="NO APLICA")
            {
                txt_Peso.Enabled = false;
                lb24.Visible = false;
                txt_Peso.Text = "0";
                txt_Codigo.Focus();
            }
            else
            {   
                txt_Peso.Enabled = true;
                lb24.Visible = true;
                txt_Peso.Text = string.Empty;
                txt_Codigo.Focus();
            }
        }
    }
}
