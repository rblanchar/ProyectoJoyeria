
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
    public partial class FrmListadoGeneralDevolucion : Form
    {
        ServicioDevolucionFacturaOracle servicioDevolucionFacturaOracle = new ServicioDevolucionFacturaOracle();
        public FrmListadoGeneralDevolucion()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmReporte().Show();
        }

        private void FrmListadoGeneralDevolucion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            DataTable datos = servicioDevolucionFacturaOracle.GrupoDevoluciones();

            if (datos != null && datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    int indiceFila = GrillaDevoluciones.Rows.Add();
                    DataGridViewRow nuevaFila = GrillaDevoluciones.Rows[indiceFila];

                    nuevaFila.Cells["IDFACTURA"].Value = fila["id_factura"];
                    DateTime fecha = Convert.ToDateTime(fila["MAX(d.fecha)"]);
                    nuevaFila.Cells["FECHA"].Value = fecha.ToString("dd/MM/yyyy");

                    nuevaFila.Cells["CEDULA"].Value = fila["cedula"];
                    nuevaFila.Cells["NOMBRE"].Value = fila["nombre"];
                    nuevaFila.Cells["APELLIDOS"].Value = fila["apellidos"];

                    double total = Convert.ToDouble(fila["SUM(d.valor_total)"]);
                    nuevaFila.Cells["TOTALPAGAR"].Value = total.ToString("###,###,###");

                    nuevaFila.Cells["NOMBRE_USUARIO"].Value = fila["nombre_usuario"].ToString().ToUpper();
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

        private void FiltrarGrilla()
        {
            string filtro = txt_Nombre.Text;

            foreach (DataGridViewRow fila in GrillaDevoluciones.Rows)
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

        private void GrillaDevoluciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object idFactura = GrillaDevoluciones.Rows[e.RowIndex].Cells["IDFACTURA"].Value;

            if (idFactura != null)
            {

                this.Close();

                FrmListadoDevoluciones formDetalle = new FrmListadoDevoluciones(Convert.ToInt32(idFactura));
                formDetalle.Show();
            }
        }
    }
}
