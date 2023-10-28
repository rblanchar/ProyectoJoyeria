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

namespace Presentacion
{
    public partial class FrmListadoProductos : Form
    {
        ServicioProducto servicioProducto= new ServicioProducto();
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioProducto.Consultar());
        }

        void CargarGrilla(List<Producto> lista)
        {
            Grilla_Productos.Rows.Clear();

            foreach (var item in lista)
            {
                Grilla_Productos.Rows.Add(item.Codigo,item.CategoriaProducto.NomCategoria.ToUpper(),item.Material.NombreMaterial.ToUpper(),
                    item.Descripcion.ToUpper(), item.Peso, item.PrecioCosto, item.MargenGanancia, item.Cantidad);
            }
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            var filtro = txt_Nombre.Text;
            var lista = servicioProducto.BuscarX(filtro);
            CargarGrilla(lista);
        }
    }
}
