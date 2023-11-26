using ENTIDAD;
using LOGICA_ORACLE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            if (UsuarioLogueado.Tipo == "1;")
            {
                new FrmMenuSuper().Show();
            }
            else if (UsuarioLogueado.Tipo == "2;")
            {
                new FrmMenuAdmin().Show();
            }
            else
            {
                new FrmMenuVendedor().Show();
            }

        }

        void cargarUsuarios()
        {



        }
        private void FrmFacturadeVenta_Load(object sender, EventArgs e)
        {
            string usuarioLogueado = UsuarioLogueado.Usuario;
            DesHabilitar();
            txt_Fecha.Text = DateTime.Now.ToString("yyyy/MM/dd");

            txt_NombreUsuario.Text = usuarioLogueado;

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
                    string.IsNullOrWhiteSpace(txt_Apellidos.Text) || string.IsNullOrWhiteSpace(txt_Direccion.Text) || string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                    string.IsNullOrWhiteSpace(txt_Barrio.Text) || string.IsNullOrWhiteSpace(txt_Telefono.Text) ||
                    GrillaDetalle.Rows.Count == 1)
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
                        //GenerarPDFFactura();
                        limpiar();
                        txt_idFactura.Text = serviceFactura.ProximoidFactura();
                        Activar_cmb_Opcion();
                    }
                }
            }
        }
        private void GuardarCliente(Cliente cliente)
        {
            var msg = serviceCliente.InsertarCliente(cliente);

        }

        private void GenerarPDFFactura()
        {
            Document doc = new Document();
            try
            {
                // Dirección donde se guardará el archivo PDF (cambiar según tu necesidad)
                string path = Path.Combine(Directory.GetCurrentDirectory(), "factura.pdf");

                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                // Añadir contenido al PDF
                Paragraph encabezado = new Paragraph("Factura de Venta");
                encabezado.Alignment = Element.ALIGN_CENTER;
                doc.Add(encabezado);

                // Aquí puedes añadir la información de la factura: ID, fecha, cliente, detalles, etc.
                // Por ejemplo:
                doc.Add(new Paragraph("ID Factura: " + txt_idFactura.Text));
                doc.Add(new Paragraph("Fecha: " + txt_Fecha.Text));
                


                // ... (añade más detalles de la factura según tus campos)

                // Cerrar el documento PDF
                doc.Close();

                MessageBox.Show("Factura generada correctamente en: " + path, "PDF Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close();
            }
        }


        private void GuardarFactura()
        {
            Factura factura = new Factura();
            factura.Id_Factura = txt_idFactura.Text;
            factura.Fecha = Convert.ToDateTime(txt_Fecha.Text);
            factura.cliente = serviceCliente.BuscarId(txt_IdCliente.Text.ToString());

            string usuarioLogueado = UsuarioLogueado.idUsuario;
            factura.usuario = serviceUsuario.BuscarId(usuarioLogueado);

            var msg = serviceFactura.InsertarFactura(factura);

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

                        factura = new Factura { Id_Factura = txt_idFactura.Text.ToString() },
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

        private void button1_Click(object sender, EventArgs e)
        {

            var frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.cargado = true;
            frmListadoClientes.btn_Regresar.Visible = false;
            frmListadoClientes.btn_Regresar2.Visible = true;
            frmListadoClientes.ShowDialog();

            Cliente ClienteSeleccionado = frmListadoClientes.ClienteSeleccionado;
            TraerClientes(ClienteSeleccionado);

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
            txt_IdCliente.ReadOnly = true;

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


        private void txt_Cedula_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string cedula = txt_Cedula.Text.Trim();

                if (!string.IsNullOrWhiteSpace(cedula))
                {
                    Cliente cliente = serviceCliente.BuscarPorCedula(cedula);

                    if (cliente != null)
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
            var cantidadP = GrillaDetalle.Rows[e.RowIndex].Cells["cantidad"].Value;
            string columnaActual = GrillaDetalle.Columns[e.ColumnIndex].Name;

            if (Convert.ToString(cantidadP) == "" || cantidadP == null)
            {
                cantidadP = 0;
            }

            if (e.RowIndex != -1 && valorIdProducto != null)
            {

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
                    else if (columnaActual == "cantidad" && valorIdProducto != null && Convert.ToInt16(cantidadP) > 0)
                    {
                        if (lista.Cantidad >= Convert.ToInt32(cantidadP))
                        {
                            GrillaDetalle.Rows[e.RowIndex].Cells["iva"].Value = (Piva * Convert.ToDouble(cantidadP)).ToString("###,###");
                            GrillaDetalle.Rows[e.RowIndex].Cells["vr_total"].Value = (Ptotal).ToString("###,###");
                            double subtotal = 0;
                            double totalIVA = 0;
                            double totalPagar = 0;

                            foreach (DataGridViewRow fila in GrillaDetalle.Rows)
                            {
                                if (!fila.IsNewRow && Convert.ToString(fila.Cells["cantidad"].Value) != "")
                                {
                                    double vrTotal = Convert.ToDouble(fila.Cells["vr_total"].Value);

                                    subtotal += vrTotal;
                                    totalIVA += Convert.ToDouble(fila.Cells["iva"].Value);
                                }
                            }
                            if (lista.Cantidad >= Convert.ToInt16(cantidadP))
                            {

                                totalPagar = subtotal + totalIVA;

                                txt_Subtotal.Text = subtotal.ToString("###,###");
                                txt_Iva.Text = totalIVA.ToString("###,###");
                                txt_TotalPagar.Text = totalPagar.ToString("###,###");

                                bool todasLasFilasTienenCantidad = VerificarCantidadEnFilas();


                                btn_Guardar.Text = todasLasFilasTienenCantidad ? "Registrar" : "";

                            }
                            else
                            {
                                MessageBox.Show("La cantidad ingresada supera el stock");
                                GrillaDetalle.Rows[e.RowIndex].Cells["cantidad"].Value = "";
                                btn_Guardar.Text = "";
                            }

                        }
                        else
                        {
                            MessageBox.Show("La cantidad ingresada supera el stock");
                            GrillaDetalle.Rows[e.RowIndex].Cells["cantidad"].Value = "";
                            btn_Guardar.Text = "";
                        }
                    }
                }

            }
            else
            {
                GrillaDetalle.Rows[e.RowIndex].Cells["cantidad"].Value = "";
                GrillaDetalle.Rows[e.RowIndex].Cells["iva"].Value = "";
                GrillaDetalle.Rows[e.RowIndex].Cells["vr_total"].Value = "";
                btn_Guardar.Text = "";
            }
        }

        private bool VerificarCantidadEnFilas()
        {
            int lastRowIndex = GrillaDetalle.Rows.Count - 1;

            for (int i = 0; i < lastRowIndex; i++)
            {
                object valorCantidad = GrillaDetalle.Rows[i].Cells["cantidad"].Value;

                if (valorCantidad == null || string.IsNullOrWhiteSpace(valorCantidad.ToString()))
                {
                    return false;
                }
            }

            return true;
        }
        private void GrillaDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                var frmProductos = new FrmListadoProductos();
                frmProductos.cargado = true;
                frmProductos.button1.Visible = false;
                frmProductos.btn_Regresar2.Visible = true;
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
            var precioVenta = (producto.Costo * producto.Margen_Ganancia) + producto.Costo;
            GrillaDetalle.Rows[indiceFila].Cells["vr_unitario"].Value = precioVenta.ToString("###,###");
            var Piva = precioVenta * 0.19;
            GrillaDetalle.Rows[indiceFila].Cells["iva"].Value = Piva.ToString("###,###");
            GrillaDetalle.CurrentCell = GrillaDetalle["cantidad", indiceFila];
            GrillaDetalle.BeginEdit(true);

        }

        public void TraerClientes(Cliente cliente)
        {

            if (cliente !=null)
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

           
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Barrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void GrillaDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewCell currentCell = GrillaDetalle.CurrentCell;

                if (currentCell != null)
                {
                    btn_Guardar.Text = "";
                    if (currentCell.ReadOnly == false)
                    {
                        currentCell.Value = null;
                    }
                }
            }
        }

        private void GrillaDetalle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < GrillaDetalle.Rows.Count - 1) 
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    GrillaDetalle.Rows.RemoveAt(rowIndex);
                    ActualizarDatosAPagar(); 
                }
            }
            else
            {
                MessageBox.Show("La fila seleccionada no contiene datos válidos para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarDatosAPagar()
        {
            double subtotal = 0;
            double totalIVA = 0;
            double totalPagar = 0;

            foreach (DataGridViewRow fila in GrillaDetalle.Rows)
            {
                if (!fila.IsNewRow && Convert.ToString(fila.Cells["cantidad"].Value) != "")
                {
                    double vrTotal = Convert.ToDouble(fila.Cells["vr_total"].Value);

                    subtotal += vrTotal;
                    totalIVA += Convert.ToDouble(fila.Cells["iva"].Value);
                }
            }
            bool todasLasFilasTienenCantidad = VerificarCantidadEnFilas();


            btn_Guardar.Text = todasLasFilasTienenCantidad ? "Registrar" : "";

            totalPagar = subtotal + totalIVA;

            txt_Subtotal.Text = subtotal.ToString("###,###");
            txt_Iva.Text = totalIVA.ToString("###,###");
            txt_TotalPagar.Text = totalPagar.ToString("###,###");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarPDFFactura();
        }
    }
}
