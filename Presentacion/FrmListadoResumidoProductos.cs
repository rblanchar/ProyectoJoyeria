using ENTIDAD;
using LOGICA_ORACLE;
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
    public partial class FrmListadoResumidoProductos : Form
    {
        ServicioProductoOracle servicioProducto = new ServicioProductoOracle();
        public FrmListadoResumidoProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void FrmListadoResumidoProductos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }


        public void CargarGrilla()
        {
            DataTable datos = servicioProducto.GrupoCategoriaMaterial();

            if (datos != null && datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    int indiceFila = Grilla_Productos.Rows.Add();
                    DataGridViewRow nuevaFila = Grilla_Productos.Rows[indiceFila];
                    
                    nuevaFila.Cells["CATEGORIA"].Value = fila["nombre"];
                    nuevaFila.Cells["MATERIAL"].Value = fila["nombre1"];
                    nuevaFila.Cells["CANTIDAD"].Value = fila["SUM(p.cantidad)"];
                }
            }
            else
            {

                MessageBox.Show("No hay datos para mostrar.");
            }
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

            FiltrarGrilla();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FiltrarGrilla()
        {
            string filtro = txt_Nombre.Text;

            foreach (DataGridViewRow fila in Grilla_Productos.Rows )
            {

                bool mostrarFila = true;
                if (!fila.IsNewRow) 
                {
                    if (!string.IsNullOrEmpty(filtro) &&
                    !fila.Cells["CATEGORIA"].Value.ToString().Contains(filtro) &&
                    !fila.Cells["MATERIAL"].Value.ToString().Contains(filtro))
                    {
                        mostrarFila = false;
                    }
                }

                fila.Visible = mostrarFila;
            }
        }
    }
}
