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
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioProducto.Consultar());
            Grilla_Productos.Sort(Grilla_Productos.Columns["CATEGORIA"], ListSortDirection.Ascending);
        }

        void CargarGrilla(List<Producto> lista)
        {
            Grilla_Productos.Rows.Clear();

            foreach (var item in lista)
            {
                Grilla_Productos.Rows.Add(item.Codigo, item.CategoriaProducto.NomCategoria.ToUpper(), item.Material.NombreMaterial.ToUpper(),
                    item.Descripcion.ToUpper(), item.Peso.ToString(), item.PrecioCosto.ToString("###,###,###"), item.MargenGanancia.ToString(), item.Cantidad);
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
