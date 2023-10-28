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
            cancelar();
        }

        void cancelar()
        {
            txt_Nombre.Text = string.Empty;
            txt_Nombre.Focus();
        }

        private void FrmRegistrarCategoria_Load(object sender, EventArgs e)
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
                string Codigo = txt_Codigo.Text;

                if (servicioCategoriaProducto.BuscarCodigo(Codigo) == null)
                {
                    Guardar(new CategoriaProducto(txt_Codigo.Text, txt_Nombre.Text));
                    cancelar();
                    FrmRegistrarCategoria_Load(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Este Codigo ya existe!");
                    cancelar();
                    txt_Codigo.Enabled = false;
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
    }
}
