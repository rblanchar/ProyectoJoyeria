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
        public FrmRegistrarMaterial()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        void cancelar()
        {
            txt_Material.Text = string.Empty;
            txt_Material.Focus();
        }

        private void FrmRegistrarMaterial_Load(object sender, EventArgs e)
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
                string Codigo = txt_Codigo.Text;

                if (servicioMaterial.BuscarCodigo(Codigo) == null)
                {
                    Guardar(new Material(txt_Codigo.Text, txt_Material.Text));
                    cancelar();
                    FrmRegistrarMaterial_Load(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Este Codigo ya existe!");
                    cancelar();
                    txt_Codigo.Enabled = false;
                }
            }
        }
        void Guardar(Material material)
        {
            var msg = servicioMaterial.Guardar(material);
            MessageBox.Show(msg);

        }
    }
}
