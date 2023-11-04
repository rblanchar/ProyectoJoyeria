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
    public partial class FrmRegistrarMaterial : Form
    {
        ServicioMaterial servicioMaterial = new ServicioMaterial();
        ServiciodeLectura serviciodeLectura = new ServiciodeLectura();
        ModificarMaterial modificacion = new ModificarMaterial();
        ServicioProducto servicioProducto = new ServicioProducto();
        public FrmRegistrarMaterial()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

      

        private void FrmRegistrarMaterial_Load(object sender, EventArgs e)
        {
            Cargar();


        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void txt_Material_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Material.Text))
            {
                MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Material.Focus();
            }
            else 
            {
                if (btn_Guardar.Text == "Registrar")
                {
                    string Codigo = txt_Codigo.Text;

                    if (servicioMaterial.BuscarCodigo(Codigo) == null)
                    {
                        Guardar(new Material(txt_Codigo.Text, txt_Material.Text));
                        Limpiar();
                        FrmRegistrarMaterial_Load(this, EventArgs.Empty);
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

                    Material material = new Material();

                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de Modificar este registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        string codigo = txt_Codigo.Text;
                        material = servicioMaterial.BuscarCodigo(codigo);
                        if (material != null)
                        {

                            material.Nombre = txt_Material.Text;
                            Habilitado();
                            var msg = modificacion.ModificarMateriales(material);
                            MessageBox.Show(msg);
                            Limpiar();

                        }
                        else
                        {
                            MessageBox.Show("Material no encontrado.");
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
                                if (item.Material.Id_Material == txt_Codigo.Text)
                                {
                                    MessageBox.Show("No se puede Eliminar un Material Asignado!");
                                    sw = 1;
                                    break;
                                }
                            }
                            if (sw == 0)
                            {
                                string codigo = txt_Codigo.Text;
                                var msg = modificacion.EliminarMateriales(codigo);
                                MessageBox.Show(msg);
                                Limpiar();
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
        void Guardar(Material material)
        {
            var msg = servicioMaterial.Guardar(material);
            MessageBox.Show(msg);

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

        void Habilitado()
        {
            label2.Visible = true;
            txt_Codigo.Enabled = true;
            txt_Material.Enabled = true;
            btn_Guardar.Enabled = true;
           
        }
        void Deshabilitado()
        {
            label2.Visible = false;
            txt_Codigo.Enabled = false;
            txt_Material.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Guardar.Text = string.Empty;

        }

        void Limpiar()
        {
            Deshabilitado();
            txt_Codigo.Text = string.Empty;
            txt_Material.Text = string.Empty;
            cmb_Opcion.Text = string.Empty;
            btn_Guardar.Text = "";
        }

        public bool consultar(string codigo)
        {
            Material mater = servicioMaterial.BuscarCodigo(codigo);

            if (mater != null)
            {
                txt_Codigo.Text = mater.Id_Material;
                txt_Material.Text = mater.Nombre;
                return true;
            }
            else
            {
                MessageBox.Show("El material no existe.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txt_Codigo.Text;
                bool resultado = consultar(codigo);


            }
        }

        void Cargar()
        {
            string filename = "Material.txt";
            if (File.Exists(filename))
            {
                var numero = serviciodeLectura.IncrementarCodigo(filename);
                txt_Codigo.Text = numero;
            }
            else
            {
                txt_Codigo.Text = "501";
            }
        }
    }
}
