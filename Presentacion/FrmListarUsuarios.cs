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
using LOGICA_ORACLE;

namespace Presentacion
{
    
    public partial class FrmListarUsuarios : Form
    {
        ServicioUsuario servicioUsuario = new ServicioUsuario();
        ServicioTipoUsuario servicioRol = new ServicioTipoUsuario();
        ServicioTipoUsuarioOracle servicioTipoUsuarioOracle = new ServicioTipoUsuarioOracle();
        ServicioUsuarioOracle servicioUsuarioOracle = new ServicioUsuarioOracle();
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
            CargarGrilla(servicioUsuarioOracle.Consultar());
        }

        void CargarGrilla(List<Usuario> lista)
        {
            Grilla_Usuarios.Rows.Clear();
            
            foreach (var item in lista)
            {
                Grilla_Usuarios.Rows.Add(item.Identificacion, item.Nombre.ToUpper(), item.Apellido.ToUpper(), item.Direccion.ToUpper(),item.Barrio.ToUpper(),
                    item.Correo.ToUpper(), item.NumTelefono, item.NombreUsuario, item.Contraseña, item.tipoUsuario.Nombre.ToUpper());
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
            var lista = servicioUsuario.BuscarX(filtro);
            CargarGrilla(lista);
        }
    }
}
