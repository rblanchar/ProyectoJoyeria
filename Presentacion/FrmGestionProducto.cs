using ENTIDAD;
using LOGICA;
using LOGICA_ORACLE;
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

        ServicioCategoriaOracle servicioCategoriaOracle = new ServicioCategoriaOracle();
        ServicioMaterialOracle servicioMaterialOracle = new ServicioMaterialOracle();
        ServicioProductoOracle servicioProductoOracle = new ServicioProductoOracle();

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
            cmb_Categoria.DataSource = servicioCategoriaOracle.Consultar();
            cmb_Categoria.ValueMember = "Id_Categoria";
            cmb_Categoria.DisplayMember = "Nombre";

            cmb_Material.DataSource = servicioMaterialOracle.Consultar();
            cmb_Material.ValueMember = "Id_Material";
            cmb_Material.DisplayMember = "Nombre";

        }
        
        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
            string Opcion = cmb_Opcion.SelectedItem.ToString();

            if (Opcion=="REGISTRAR")
            {
                
                HabilitarCampos();
                CamposObligatorios();
                btn_Guardar.Text = "Registrar";

                var proximoIdProducto = servicioProductoOracle.IncrementarIdProducto();
                txt_Codigo.Text = Convert.ToString(proximoIdProducto);

                txt_Codigo.Enabled = false;
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
                    string.IsNullOrWhiteSpace(txt_Descripcion.Text) || string.IsNullOrWhiteSpace(txt_PrecioCosto.Text) ||
                    string.IsNullOrWhiteSpace(txt_Margen.Text) || string.IsNullOrWhiteSpace(txt_Cantidad.Text))
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios * ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Producto producto = new Producto
                    {
                        CategoriaProducto = servicioCategoriaOracle.BuscarId(cmb_Categoria.SelectedValue.ToString()),
                        Material = servicioMaterialOracle.BuscarId(cmb_Material.SelectedValue.ToString()),
                        Id_Producto = txt_Codigo.Text,
                        Descripcion = txt_Descripcion.Text,
                        Costo = Convert.ToDouble(txt_PrecioCosto.Text),
                        Peso = Convert.ToDecimal(txt_Peso.Text),
                        Margen_Ganancia = Convert.ToDouble(txt_Margen.Text),
                        Cantidad = Convert.ToInt32(txt_Cantidad.Text)
                    };

                    Guardar(producto);
                    limpiar();
                }
             }
            else if (btn_Guardar.Text == "Modificar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    Producto producto = new Producto
                    {
                        Id_Producto = txt_Codigo.Text,
                        Descripcion = txt_Descripcion.Text,
                        CategoriaProducto = servicioCategoriaOracle.BuscarId(cmb_Categoria.SelectedValue.ToString()),
                        Material = servicioMaterialOracle.BuscarId(cmb_Material.SelectedValue.ToString()),
                        Costo = Convert.ToDouble(txt_PrecioCosto.Text),
                        Peso = Convert.ToDecimal(txt_Peso.Text),
                        Margen_Ganancia = Convert.ToDouble(txt_Margen.Text),
                        Cantidad = Convert.ToInt32(txt_Cantidad.Text)
                    };

                    var msg = servicioProductoOracle.ModificarProducto(producto);
                    MessageBox.Show(msg);
                    limpiar();
                }
            }
            else if (btn_Guardar.Text == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de Eliminar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    var id = txt_Codigo.Text;
                    Producto producto = servicioProductoOracle.BuscarId(id);

                    if (producto != null)
                    {
                        txt_Codigo.Text = producto.Id_Producto;
                        txt_Descripcion.Text = producto.Descripcion;
                        cmb_Categoria.SelectedValue = producto.CategoriaProducto.Id_Categoria.ToString();
                        cmb_Material.SelectedValue = producto.Material.Id_Material.ToString();
                        txt_PrecioCosto.Text = Convert.ToDouble(producto.Costo).ToString();
                        txt_Peso.Text = Convert.ToDecimal(producto.Peso).ToString();
                        txt_Margen.Text = Convert.ToDouble(producto.Margen_Ganancia).ToString();
                        txt_Cantidad.Text = Convert.ToInt32(producto.Cantidad).ToString();

                        var msg = servicioProductoOracle.EliminarProducto(id);
                        MessageBox.Show(msg);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
            }
        }
        public bool consultar(string id)
        {

            Producto producto = servicioProductoOracle.BuscarId(id);

            if (producto != null)
            {
                txt_Codigo.Text = producto.Id_Producto;
                txt_Descripcion.Text = producto.Descripcion;
                txt_PrecioCosto.Text = producto.Costo.ToString("###,###,###");
                txt_Peso.Text = producto.Peso.ToString();
                txt_Margen.Text = producto.Margen_Ganancia.ToString();
                txt_Cantidad.Text = producto.Cantidad.ToString();

                CategoriaProducto categoriaProducto2 = servicioCategoriaOracle.BuscarId(producto.CategoriaProducto.Id_Categoria.ToString());

                if (categoriaProducto2 != null)
                {
                    cmb_Categoria.Text = categoriaProducto2.Nombre.ToString();
                }

                Material material2 = servicioMaterialOracle.BuscarId(producto.Material.Id_Material.ToString());
                if (material2 != null)
                {
                    cmb_Material.Text = material2.Nombre.ToString();
                }
                //cmb_Categoria.Text = producto.CategoriaProducto.Nombre.ToString();
                //cmb_Material.Text = producto.Material.Nombre.ToString();
                return true;
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
            var msg = servicioProductoOracle.InsertarProducto(producto);
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
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
