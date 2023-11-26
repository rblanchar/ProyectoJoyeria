using LOGICA;
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
    public partial class FrmVentasVendedor : Form
    {
        ServicioFacturaOracle servicioFactura = new ServicioFacturaOracle();
        public FrmVentasVendedor()
        {
            InitializeComponent();
        }

        private void FrmVentasVendedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            DataTable datos = servicioFactura.GrupoVentasVendedor();

            if (datos != null && datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    int indiceFila = GrillaReporteVendedor.Rows.Add();
                    DataGridViewRow nuevaFila = GrillaReporteVendedor.Rows[indiceFila];

                    nuevaFila.Cells["ID_USUARIO"].Value = fila["id_usuario"];
                    nuevaFila.Cells["NOMBRE_USUARIO"].Value = fila["nombre_usuario"];

                    double totalVentas = Convert.ToDouble(fila["total_ventas"]);
                    nuevaFila.Cells["TOTAL_VENTAS"].Value = totalVentas.ToString("###,###,###");

                }
            }
            else
            {

                MessageBox.Show("No hay datos para mostrar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmReporte().Show();
        }
    }
}
