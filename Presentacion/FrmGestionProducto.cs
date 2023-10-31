using ENTIDAD;
using LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        ServicioProducto servicioProducto= new ServicioProducto();
        EliminarProducto eliminarProducto = new EliminarProducto();
        ModificarProducto modificarProducto = new ModificarProducto();

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
            limpiar();

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
                limpiar();
                DesHabilitarCampos();
                txt_Codigo.Enabled = true;
                txt_Codigo.Focus();
            }
            else if (Opcion == "MODIFICAR")
            {
                HabilitarCampos();
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

                    producto.CategoriaProducto = categoriaProducto.BuscarCodigo(cmb_Categoria.SelectedValue.ToString());
                    producto.Material = servicioMaterial.BuscarCodigo(cmb_Material.SelectedValue.ToString());
                    producto.Codigo = txt_Codigo.Text;
                    producto.Descripcion = txt_Descripcion.Text;
                    CultureInfo culture = new CultureInfo("en-US");
                    producto.PrecioCosto = double.Parse(txt_PrecioCosto.Text, culture);
                    producto.Peso = decimal.Parse(txt_Peso.Text, culture);
                    producto.MargenGanancia = double.Parse(txt_Margen.Text, culture);
                    producto.Cantidad = int.Parse(txt_Cantidad.Text);

                    Guardar(producto);
                    limpiar();
                }
                
            }
            if (btn_Guardar.Text == "Modificar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    Producto producto = new Producto();
                    producto.Codigo = txt_Codigo.Text;
                    producto.Descripcion = txt_Descripcion.Text;
                    producto.CategoriaProducto = categoriaProducto.BuscarCodigo(cmb_Categoria.SelectedValue.ToString());
                    producto.Material = servicioMaterial.BuscarCodigo(cmb_Material.SelectedValue.ToString());
                    producto.PrecioCosto = double.Parse(txt_PrecioCosto.Text);
                    producto.Peso = decimal.Parse(txt_Peso.Text);
                    producto.MargenGanancia = double.Parse(txt_Margen.Text);
                    producto.Cantidad = int.Parse(txt_Cantidad.Text);

                    var msg = modificarProducto.Modificar(producto);
                    servicioProducto.RefrescarLista();
                    MessageBox.Show(msg);
                    limpiar();
                }
            }
            else if (btn_Guardar.Text == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de Eliminar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {

                    var codigo = txt_Codigo.Text;
                    Producto producto = servicioProducto.BuscarProducto(codigo);

                    if (producto != null)
                    {

                        txt_Codigo.Text = producto.Codigo;
                        txt_Descripcion.Text = producto.Descripcion;
                        cmb_Categoria.SelectedValue = producto.CategoriaProducto.Codigo.ToString();
                        cmb_Material.SelectedValue = producto.Material.Codigo.ToString();
                        txt_PrecioCosto.Text = Convert.ToDouble(producto.PrecioCosto).ToString();
                        txt_Peso.Text = Convert.ToDecimal(producto.Peso).ToString();
                        txt_Margen.Text = Convert.ToDouble(producto.MargenGanancia).ToString();
                        txt_Cantidad.Text = Convert.ToInt32(producto.Cantidad).ToString();
                        
                        
                        var msg = eliminarProducto.Eliminar(producto);
                        MessageBox.Show(msg);
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
            }

        }
        public bool consultar(string codigo)
        {
           
            Producto producto = servicioProducto.BuscarProducto(codigo);

            if (producto != null)
            {
                txt_Codigo.Text = producto.Codigo;
                txt_Descripcion.Text = producto.Descripcion;
                txt_PrecioCosto.Text = producto.PrecioCosto.ToString("###,###,###");
                txt_Peso.Text = producto.Peso.ToString();
                txt_Margen.Text = producto.MargenGanancia.ToString();
                txt_Cantidad.Text = producto.Cantidad.ToString();

                cmb_Categoria.Text = producto.CategoriaProducto.NomCategoria.ToString();
                cmb_Material.Text = producto.Material.NombreMaterial.ToString();
                return true;
            }
            else
            {
                if (cmb_Opcion.Text != "REGISTRAR")
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            return false;
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
            cmb_Opcion.Enabled = true;
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
            if (cmb_Opcion.Text == "REGISTRAR")
            { 
                if (cmb_Material.Text == "NO APLICA")
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

        public void Guardar(Producto producto)
        {
            var msg = servicioProducto.Guardar(producto);
            MessageBox.Show(msg);
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_PrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Margen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Codigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                KeyEventArgs keyEventArgs = new KeyEventArgs(Keys.Tab);
                this.txt_Codigo_KeyDown(this, keyEventArgs);
            }
        }

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string id = txt_Codigo.Text;

                if (consultar(id) != false)
                {
                    if (cmb_Opcion.SelectedItem != null)
                    {
                        string Opcion = cmb_Opcion.SelectedItem.ToString();

                        if (Opcion == "REGISTRAR")
                        {
                            MessageBox.Show("Este producto se encuentra registrado en la Base de Datos!");
                            limpiar();
                            DesHabilitarCampos();
                            cmb_Opcion.Text = string.Empty;
                            cmb_Opcion.Enabled = true;
                            cmb_Opcion.Focus();
                        }

                        else if (Opcion == "MODIFICAR")
                        {
                            HabilitarCampos();
                            btn_Guardar.Text = "Modificar";
                            btn_Guardar.Enabled = true;
                            txt_Codigo.Enabled = false;
                            cmb_Opcion.Enabled = false;
                        }
                        else if (Opcion == "ELIMINAR")
                        {
                            DesHabilitarCampos();
                            btn_Guardar.Text = "Eliminar";
                            btn_Guardar.Enabled = true;
                            txt_Codigo.Focus();
                            cmb_Opcion.Enabled = false;
                        }
                    }

                }
            }
        }

        private void txt_Peso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
