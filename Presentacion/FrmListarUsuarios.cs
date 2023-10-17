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
    
    public partial class FrmListarUsuarios : Form
    {
        ServicioUsuario servicioUsuario = new ServicioUsuario();
        ServicioRol servicioRol = new ServicioRol();
        public FrmListarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuSuper().Show();
        }

        private void FrmListarUsuarios_Load(object sender, EventArgs e)
        {
            Grilla_Usuarios.Rows.Clear();
            Grilla_Usuarios.ColumnHeadersDefaultCellStyle.Font = new Font(Grilla_Usuarios.Font, FontStyle.Bold);

            foreach ( var item in servicioUsuario.Consultar())
            {
                Grilla_Usuarios.Rows.Add(item.Identificacion, item.Nombre.ToUpper(), item.Apellido.ToUpper(), item.Direccion.ToUpper(),
                    item.Correo.ToUpper(), item.NumTelefono, item.NombreUsuario, item.Contraseña,item.rol.TipoRol.ToUpper());
            }
        }

        private void Grilla_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
