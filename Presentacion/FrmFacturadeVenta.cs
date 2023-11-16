using ENTIDAD;
using LOGICA_ORACLE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmFacturadeVenta : Form
    {
        ServicioUsuarioOracle serviceUsuario = new ServicioUsuarioOracle();
        ServicioClienteOracle serviceCliente = new ServicioClienteOracle();
        ServicioFacturaOracle serviceFactura = new ServicioFacturaOracle();
        ServicioProductoOracle ServiceProducto = new ServicioProductoOracle();
        ServicioCategoriaOracle serviceCategoria = new ServicioCategoriaOracle();
        ServicioMaterialOracle serviceMaterial = new ServicioMaterialOracle();
        ServicioDetalleFacturaOracle serviceDetalleFactura = new ServicioDetalleFacturaOracle();

        public FrmFacturadeVenta()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        void cargarUsuarios()
        {

            cmb_Usuario.DataSource = serviceUsuario.Consultar();
            cmb_Usuario.ValueMember = "Id_Usuario";
            cmb_Usuario.DisplayMember = "Nombre_Usuario";


        }
        private void FrmFacturadeVenta_Load(object sender, EventArgs e)
        {
            DesHabilitar();
            txt_Fecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
            cargarUsuarios();

            var proximoIdFactura = serviceFactura.ProximoidFactura();
            txt_idFactura.Text = Convert.ToString(proximoIdFactura);

            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            DesHabilitar();
            txt_IdCliente.ReadOnly = true;
            txt_IdCliente.Focus();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (btn_Guardar.Text == "Registrar")
            {
                if (string.IsNullOrWhiteSpace(txt_IdCliente.Text) || string.IsNullOrWhiteSpace(txt_Nombre.Text) || string.IsNullOrWhiteSpace(txt_Cedula.Text) ||
                    string.IsNullOrWhiteSpace(txt_Apellidos.Text) || string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                    string.IsNullOrWhiteSpace(txt_Barrio.Text) || string.IsNullOrWhiteSpace(txt_Telefono.Text) || string.IsNullOrWhiteSpace(cmb_Usuario.Text) )
                {
                    MessageBox.Show("Por favor, completa todos los Campos Obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cedula = txt_Cedula.Text.Trim();

                    if (!string.IsNullOrWhiteSpace(cedula))
                    {
                        Cliente buscarCliente = serviceCliente.BuscarPorCedula(cedula);

                        if (buscarCliente == null)
                        {

                            Cliente cliente = new Cliente();

                            cliente.Id_Cliente = txt_IdCliente.Text;
                            cliente.Cedula = txt_Cedula.Text;
                            cliente.Nombre = txt_Nombre.Text;
                            cliente.Apellidos = txt_Apellidos.Text;
                            cliente.Direccion = txt_Direccion.Text;
                            cliente.Barrio = txt_Barrio.Text;
                            cliente.Correo = txt_Correo.Text;
                            cliente.Telefono = txt_Telefono.Text;

                            GuardarCliente(cliente);
                        }
                        GuardarFactura();
                        GuardarDetalle_Factura(GrillaDetalle);
                        limpiar();
                        Activar_cmb_Opcion();
                    }
                }
            }
        }
        private void GuardarCliente(Cliente cliente)
        {
            var msg = serviceCliente.InsertarCliente(cliente);
            //MessageBox.Show(msg);
        }

        private void GuardarFactura()
        {
            Factura factura = new Factura();
            factura.Id_Factura = txt_idFactura.Text;
            factura.Fecha = Convert.ToDateTime(txt_Fecha.Text);
            factura.cliente = serviceCliente.BuscarId(txt_IdCliente.Text.ToString());
            factura.usuario = serviceUsuario.BuscarId(cmb_Usuario.SelectedValue.ToString());

            var msg = serviceFactura.InsertarFactura(factura);
            MessageBox.Show(msg);
        }

        public void GuardarDetalle_Factura(DataGridView grillaDetalle)
        {
            List<Detalle_Factura> detalleFactura = new List<Detalle_Factura>();

            foreach (DataGridViewRow fila in grillaDetalle.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Detalle_Factura detalle = new Detalle_Factura
                    {

                        factura = new Factura { Id_Factura = txt_idFactura.Text.ToString() } ,
                        producto = new Producto { Id_Producto = fila.Cells["id_producto"].Value.ToString() },
                        Cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value),
                        Valor_Unitario = Convert.ToDouble(fila.Cells["vr_unitario"].Value),
                        iva = Convert.ToDouble(fila.Cells["iva"].Value),
                        Valor_Total = Convert.ToDouble(fila.Cells["vr_total"].Value)
                    };

                    detalleFactura.Add(detalle);
                }
            }

            var msg = serviceDetalleFactura.InsertarDetalleFactura(detalleFactura);
            MessageBox.Show(msg);
        }
        void Activar_cmb_Opcion()
        {

        }
        void Guardar(Factura factura)
        {
            var msg = serviceFactura.InsertarFactura(factura);
           // MessageBox.Show(msg);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // new FrmListadoClientes().Show();

            FrmListadoClientes frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.FormClosed += FormCliente_FormClosed;
            frmListadoClientes.Show();
            this.Hide();

        }
        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenuClientes frmCliente = Application.OpenForms.OfType<FrmMenuClientes>().FirstOrDefault();

            if (frmCliente != null)
            {

                frmCliente.Close();
                this.Show();
            }
            else
            {
                // this.Show();
            }

        }

       
        void Habilitar()
        {
            txt_Cedula.ReadOnly = false;
            txt_Nombre.ReadOnly = false;
            txt_Apellidos.ReadOnly = false;
            txt_Barrio.ReadOnly = false;
            txt_Direccion.ReadOnly = false;
            txt_Telefono.ReadOnly = false;
            txt_Correo.ReadOnly = false;
        }

        void DesHabilitar()
        {

            txt_Nombre.ReadOnly = true;
            txt_Apellidos.ReadOnly = true;
            txt_Barrio.ReadOnly = true;
            txt_Direccion.ReadOnly = true;
            txt_Telefono.ReadOnly = true;
            txt_Correo.ReadOnly = true;

        }

        void limpiar()
        {
            txt_Cedula.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Apellidos.Text = string.Empty;
            txt_Barrio.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
            txt_Telefono.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            txt_IdCliente.Text = string.Empty;
            txt_idFactura.Text = string.Empty;
            txt_Subtotal.Text = string.Empty;
            txt_Iva.Text = string.Empty;
            txt_TotalPagar.Text = string.Empty;
            GrillaDetalle.Rows.Clear();

            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
        }

        void CamposObligatorios()
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
        }


        private void txt_Cedula_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string cedula = txt_Cedula.Text.Trim();

                if (!string.IsNullOrWhiteSpace(cedula))
                {
                    Cliente cliente = serviceCliente.BuscarPorCedula(cedula);

                    if (cliente!=null)
                    {
                        MostrarDatosCliente(cliente);
                        txt_IdCliente.ReadOnly = true;
 
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("El cliente no existe. ¿Desea agregar un nuevo cliente?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {

                            Habilitar();
                            txt_IdCliente.Enabled = false;
                            var proximoIdCliente = serviceCliente.ProximoIdCliente();
                            txt_IdCliente.Text = Convert.ToString(proximoIdCliente);
                            txt_Nombre.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el cliente");
                        }
                    }
                }
            }
        }



        private void MostrarDatosCliente(Cliente cliente)
        {

            txt_IdCliente.Text = cliente.Id_Cliente;
            txt_Cedula.Text = cliente.Cedula;
            txt_Nombre.Text = cliente.Nombre;
            txt_Apellidos.Text = cliente.Apellidos;
            txt_Direccion.Text = cliente.Direccion;
            txt_Barrio.Text = cliente.Barrio;
            txt_Correo.Text = cliente.Correo;
            txt_Telefono.Text = cliente.Telefono;
        }


        private void GrillaDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var valorIdProducto = GrillaDetalle.Rows[e.RowIndex].Cells["ID_PRODUCTO"].Value;

            if (e.RowIndex != -1 && valorIdProducto != null)
            {

                string columnaActual = GrillaDetalle.Columns[e.ColumnIndex].Name;
                var cantidadP = GrillaDetalle.Rows[e.RowIndex].Cells["cantidad"].Value;

                var lista = ServiceProducto.BuscarId(valorIdProducto.ToString());
                if (lista != null)
                {

                    var precioVenta = (lista.Costo * lista.Margen_Ganancia) + lista.Costo;
                    var Piva = precioVenta * 0.19;
                    var Ptotal = precioVenta * Convert.ToDouble(cantidadP);

                    if (columnaActual == "id_producto")
                    {

                        CategoriaProducto categoria = serviceCategoria.BuscarId(lista.CategoriaProducto.Id_Categoria);
                        Material material = serviceMaterial.BuscarId(lista.Material.Id_Material);

                        GrillaDetalle.Rows[e.RowIndex].Cells["descripcion"].Value = lista.Descripcion.ToString().ToUpper();
                        GrillaDetalle.Rows[e.RowIndex].Cells["categoria"].Value = categoria.Nombre.ToString().ToUpper();
                        GrillaDetalle.Rows[e.RowIndex].Cells["material"].Value = material.Nombre.ToString().ToUpper();

                        GrillaDetalle.Rows[e.RowIndex].Cells["vr_unitario"].Value = precioVenta.ToString("###,###");
                        GrillaDetalle.Rows[e.RowIndex].Cells["iva"].Value = Piva.ToString("###,###");
                        GrillaDetalle.Rows[e.RowIndex].Cells["vr_total"].Value = (Ptotal).ToString("###,###");

                    }
                    else if (columnaActual == "cantidad" && valorIdProducto != null)
                    {
                        GrillaDetalle.Rows[e.RowIndex].Cells["iva"].Value = (Piva * Convert.ToDouble(cantidadP)).ToString("###,###");
                        GrillaDetalle.Rows[e.RowIndex].Cells["vr_total"].Value = (Ptotal).ToString("###,###");
                        double subtotal = 0;
                        double totalIVA = 0;
                        double totalPagar = 0;

                        foreach (DataGridViewRow fila in GrillaDetalle.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                double vrTotal = Convert.ToDouble(fila.Cells["vr_total"].Value);

                                subtotal += vrTotal;
                                totalIVA += Convert.ToDouble(fila.Cells["iva"].Value);
                            }
                        }

                        totalPagar = subtotal + totalIVA;

                        txt_Subtotal.Text = subtotal.ToString("###,###");
                        txt_Iva.Text = totalIVA.ToString("###,###");
                        txt_TotalPagar.Text = totalPagar.ToString("###,###");
                    }
                }

            }
        }

        private void GrillaDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                var frmProductos = new FrmListadoProductos();
                frmProductos.ShowDialog();

                Producto productoSeleccionado = frmProductos.ProductoSeleccionado;

                if (productoSeleccionado != null)
                {
                    TraerProducto(productoSeleccionado);
                }
            }
        }

        public void TraerProducto(Producto producto)
        {
            int indiceFila = GrillaDetalle.Rows.Add();        

            GrillaDetalle.Rows[indiceFila].Cells["id_producto"].Value = producto.Id_Producto;
            CategoriaProducto categoria = serviceCategoria.BuscarId(producto.CategoriaProducto.Id_Categoria);
            GrillaDetalle.Rows[indiceFila].Cells["categoria"].Value = categoria.Nombre;
            Material material = serviceMaterial.BuscarId(producto.Material.Id_Material);
            GrillaDetalle.Rows[indiceFila].Cells["material"].Value = producto.Material.Nombre;
            GrillaDetalle.Rows[indiceFila].Cells["descripcion"].Value = producto.Descripcion;
            var precioVenta = (producto.Costo * producto.Margen_Ganancia)+ producto.Costo;
            GrillaDetalle.Rows[indiceFila].Cells["vr_unitario"].Value = precioVenta.ToString("###,###");
            var Piva = precioVenta * 0.19;
            GrillaDetalle.Rows[indiceFila].Cells["iva"].Value = Piva.ToString("###,###");
            //GrillaDetalle.Rows[e.RowIndex].Cells["vr_total"].Value = (Ptotal).ToString("###,###");
        }
    }
}
