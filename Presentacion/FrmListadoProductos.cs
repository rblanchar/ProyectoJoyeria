using ENTIDAD;
using LOGICA_ORACLE;
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
        ServicioProductoOracle servicioProducto= new ServicioProductoOracle();
        ServicioCategoriaOracle servicioCategoria= new ServicioCategoriaOracle();
        ServicioMaterialOracle servicioMaterial= new ServicioMaterialOracle();
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
            //Grilla_Productos.Sort(Grilla_Productos.Columns["CATEGORIA"], ListSortDirection.Ascending);
        }

        void CargarGrilla(List<Producto> lista)
        {
            Grilla_Productos.Rows.Clear();

            foreach (var item in lista)
            {

                CategoriaProducto categoria = servicioCategoria.BuscarId(item.CategoriaProducto.Id_Categoria.ToString());
                Material material = servicioMaterial.BuscarId(item.Material.Id_Material);

                Grilla_Productos.Rows.Add(item.Id_Producto, item.Descripcion.ToUpper(), item.Costo.ToString("###,###,###"), item.Peso.ToString(), 
                     item.Margen_Ganancia.ToString("0.##"), item.Cantidad, categoria.Nombre.ToUpper(), material.Nombre.ToUpper());
            }
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            var filtro = txt_Nombre.Text;
            var lista = servicioProducto.BuscarFiltro(filtro);
            CargarGrilla(lista);
        }
    }
}
