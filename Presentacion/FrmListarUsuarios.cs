using ENTIDAD;
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

namespace Presentacion
{
    
    public partial class FrmListarUsuarios : Form
    {
        ServicioTipoUsuarioOracle serviceTipoUsuario = new ServicioTipoUsuarioOracle();
        ServicioUsuarioOracle serviceUsuario = new ServicioUsuarioOracle();
        public FrmListarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuUsuario().Show();
        }

        private void FrmListarUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla(serviceUsuario.Consultar());
        }

        void CargarGrilla(List<Usuario> lista)
        {
            Grilla_Usuarios.Rows.Clear();
            
            foreach (var item in lista)
            {
                TipoUsuario tipoUsuario = serviceTipoUsuario.BuscarId(item.tipoUsuario.IdTipo.ToString());

                Grilla_Usuarios.Rows.Add(item.Id_Usuario,item.Cedula, item.Nombre.ToUpper(), item.Apellidos.ToUpper(), item.Direccion.ToUpper(),item.Barrio.ToUpper(),
                    item.Correo.ToUpper(), item.Telefono, item.Nombre_Usuario, item.Contrasena,tipoUsuario.Nombre.ToUpper() );
            }

        }
        private void Grilla_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            var filtro = txt_Nombre.Text;           
            var lista=serviceUsuario.BuscarFiltro(filtro);
            CargarGrilla(lista);
        }
    }
}
