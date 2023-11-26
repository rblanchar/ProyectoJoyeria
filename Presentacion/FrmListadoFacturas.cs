using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using LOGICA_ORACLE;

namespace Presentacion
{
    public partial class FrmListadoFacturas : Form
    {
        ServicioFacturaOracle servicioFacturaOracle = new ServicioFacturaOracle();
        public FrmListadoFacturas()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmReporte().Show();
        }

        public void CargarGrilla()
        {
            DataTable datos = servicioFacturaOracle.GrupoFacturas();

            if (datos != null && datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    if (Convert.ToInt32(fila["total_Pagar"])>0)
                    {
                        int indiceFila = GrillaListadoFacturas.Rows.Add();
                        DataGridViewRow nuevaFila = GrillaListadoFacturas.Rows[indiceFila];

                        nuevaFila.Cells["IDFACTURA"].Value = fila["id_factura"];

                        DateTime fecha = Convert.ToDateTime(fila["fecha"]);
                        nuevaFila.Cells["FECHA"].Value = fecha.ToString("dd/MM/yyyy");

                        nuevaFila.Cells["CEDULA"].Value = fila["cedula"];
                        nuevaFila.Cells["NOMBRE"].Value = fila["nombre"];
                        nuevaFila.Cells["APELLIDOS"].Value = fila["apellidos"];
                        nuevaFila.Cells["NOMBRE_USUARIO"].Value = fila["nombre_usuario"];

                        double subtotal = Convert.ToDouble(fila["subtotal"]);
                        nuevaFila.Cells["SUBTOTAL"].Value = subtotal.ToString("###,###,###");

                        double totalPagar = Convert.ToDouble(fila["total_pagar"]);
                        nuevaFila.Cells["TOTALPAGAR"].Value = totalPagar.ToString("###,###,###");
                    }                    
                }
            }
            else
            {

                MessageBox.Show("No hay datos para mostrar.");
            }
        }

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void FiltrarGrilla()
        {
            string filtro = txt_Nombre.Text;

            foreach (DataGridViewRow fila in GrillaListadoFacturas.Rows)
            {

                bool mostrarFila = true;
                if (!fila.IsNewRow)
                {
                    if (!string.IsNullOrEmpty(filtro) &&
                    !fila.Cells["IDFACTURA"].Value.ToString().Contains(filtro) &&
                    !fila.Cells["CEDULA"].Value.ToString().Contains(filtro))
                    {
                        mostrarFila = false;
                    }
                }

                fila.Visible = mostrarFila;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrilla();
        }

        private void GrillaListadoFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object idFactura = GrillaListadoFacturas.Rows[e.RowIndex].Cells["IDFACTURA"].Value;

            if (idFactura != null)
            {
               
                this.Close();

                FormListadoDetalleFactura formDetalle = new FormListadoDetalleFactura(Convert.ToInt32(idFactura));
                formDetalle.Show();
            }
        }
    }
}
