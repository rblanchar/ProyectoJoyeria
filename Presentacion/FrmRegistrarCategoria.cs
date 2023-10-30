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
using System.IO;
using ENTIDAD;

namespace Presentacion
{
    public partial class FrmRegistrarCategoria : Form
    {
        ServiciodeLectura serviciodeLectura = new ServiciodeLectura();
        ServicioCategoriaProducto servicioCategoriaProducto = new ServicioCategoriaProducto();
        ModificarCateProducto modificar = new ModificarCateProducto();
        ServicioProducto servicioProducto = new ServicioProducto();
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

     

        private void FrmRegistrarCategoria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre.Focus();
            }
            else 
            {

                if (btn_Guardar.Text == "Registrar")
                {
                    string Codigo = txt_Codigo.Text;

                    if (servicioCategoriaProducto.BuscarCodigo(Codigo) == null)
                    {
                        Guardar(new CategoriaProducto(txt_Codigo.Text, txt_Nombre.Text));
                        Limpiar();
                        FrmRegistrarCategoria_Load(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Este Codigo ya existe!");
                        Limpiar();
                        txt_Codigo.Enabled = false;
                    }
                }

                else if (btn_Guardar.Text == "Modificar")
                {
                    CategoriaProducto categoriaproducto = new CategoriaProducto();
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        string codigo = txt_Codigo.Text;
                        categoriaproducto = servicioCategoriaProducto.BuscarCodigo(codigo);
                        if (categoriaproducto != null)
                        {
                            categoriaproducto.NomCategoria = txt_Nombre.Text;
                            Habilitado();
                            var msg = modificar.ModificarCategoriaProducto(categoriaproducto);
                            MessageBox.Show(msg);
                            Limpiar();
                            Cargar();
                        }
                        else
                        {
                            MessageBox.Show("Categoría de producto no encontrada.");
                        }
                    }
                }
                else if (btn_Guardar.Text == "Eliminar")
                {
                    if (!string.IsNullOrEmpty(txt_Codigo.Text))
                    {
                        DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.OK)
                        {
                            int sw = 0;
                            foreach (var item in servicioProducto.Consultar())
                            {
                                if (item.CategoriaProducto.Codigo == txt_Codigo.Text)
                                {
                                    MessageBox.Show("No se puede Eliminar una Categoria Asignada!");
                                    sw = 1;
                                    break;
                                }
                            }
                            if (sw == 0)
                            {
                                string codigo = txt_Codigo.Text;
                                var msg = modificar.EliminarCategoriaProducto(codigo);
                                MessageBox.Show(msg);
                                Limpiar();
                                Cargar();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un código válido antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        void Guardar(CategoriaProducto categoriaProducto)
        {
            var msg = servicioCategoriaProducto.Guardar(categoriaProducto);
            MessageBox.Show(msg);

        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar)
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cmb_Opcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Opcion.SelectedItem != null)
            {
                string Opcion = cmb_Opcion.SelectedItem.ToString();
                if (Opcion == "REGISTRAR")
                {
                    Habilitado();
                    Cargar();
                    txt_Nombre.Focus();
                    btn_Guardar.Text = "Registrar";

                }
                else if (Opcion == "CONSULTAR")
                {
                    Limpiar();

                    Deshabilitado();
                    txt_Codigo.Enabled = true;
                    txt_Codigo.Focus();
                }
                else if (Opcion == "ELIMINAR")
                {
                    Limpiar();
                    Habilitado();
                    btn_Guardar.Text = "Eliminar";
                    txt_Codigo.Enabled = true;
                    txt_Codigo.Focus();
                }
                if (Opcion == "MODIFICAR")
                {
                    Limpiar();
                    Habilitado();
                    label2.Visible = false;
                    btn_Guardar.Text = "Modificar";
                    txt_Codigo.Enabled = true;
                    txt_Codigo.Focus();
                }
            }
        }

        public string Cargar()
        {
            string filename = "Categoria.txt";
            if (File.Exists(filename))
            {
                var numero = serviciodeLectura.IncrementarCodigo(filename);
                txt_Codigo.Text = numero;
            }
            else
            {
                txt_Codigo.Text = "501";
            }
            return null;
           
        }
        void Habilitado()
        {
            label2.Visible = true;
            txt_Codigo.Enabled = true;
            txt_Nombre.Enabled = true;
            btn_Guardar.Enabled = true;
        }
        void Deshabilitado()
        {
            label2.Visible = false;
            txt_Codigo.Enabled = false;
            txt_Nombre.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Guardar.Text = string.Empty;

        }

        void Limpiar()
        {
            Deshabilitado();
            txt_Codigo.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            cmb_Opcion.Text = string.Empty;
            btn_Guardar.Text = "";
        }

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txt_Codigo.Text;
                bool resultado = consultar(codigo);


            }
        }

        public bool consultar(string codigo)
        {
            CategoriaProducto categoriaproducto = servicioCategoriaProducto.BuscarCodigo(codigo);

            if (categoriaproducto != null)
            {
                txt_Codigo.Text = categoriaproducto.Codigo;
                txt_Nombre.Text = categoriaproducto.NomCategoria;
                return true; 
            }
            else
            {
                MessageBox.Show("La categoría de producto no existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }


    }
}
