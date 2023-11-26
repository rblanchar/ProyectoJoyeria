using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_ORACLE;
using ENTIDAD;

namespace Presentacion
{
    public partial class FormListadoDetalleFactura : Form
    {
        ServicioDetalleFacturaOracle servicioDetalleFacturaOracle = new ServicioDetalleFacturaOracle();
        private int idFactura;
        public FormListadoDetalleFactura()
        {
            InitializeComponent();

        }
       
        public FormListadoDetalleFactura(int idFactura) : this()
        {
            this.idFactura = idFactura;
        }
        public void CargarGrilla(int idFactura)
        { 
            try
            {
                DataTable datos = servicioDetalleFacturaOracle.GrupoFacturas(idFactura);

                if (datos != null && datos.Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Rows)
                    {
                        int indiceFila = GrillaDetalleFactura.Rows.Add();
                        DataGridViewRow nuevaFila = GrillaDetalleFactura.Rows[indiceFila];

                        nuevaFila.Cells["Column1"].Value = fila["id_factura"];
                        nuevaFila.Cells["DESCRIPCION"].Value = fila["descripcion"];
                        nuevaFila.Cells["CANTIDAD"].Value = fila["cantidad"];

                        double valorUnitario = Convert.ToDouble(fila["valor_unitario"]);
                        nuevaFila.Cells["VALOR_UNITARIO"].Value = valorUnitario.ToString("###,###,###");

                        double iva = Convert.ToDouble(fila["iva"]);
                        nuevaFila.Cells["IVA"].Value = iva.ToString("###,###,###"); 

                        double valorTotal = Convert.ToDouble(fila["valor_total"]);
                        nuevaFila.Cells["VALOR_TOTAL"].Value = valorTotal.ToString("###,###,###"); 
                     
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmListadoFacturas().Show();
        }

        private void FormListadoDetalleFactura_Load(object sender, EventArgs e)
        {
            CargarGrilla(idFactura);
        }
    }
}
