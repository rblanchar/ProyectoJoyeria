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

namespace Presentacion
{
    public partial class FrmListadoTipoUsuarios : Form
    {
        ServicioRol servicioRol = new ServicioRol();
        public FrmListadoTipoUsuarios()
        {
            InitializeComponent();
        }

        private void FrmListadoTipoUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioRol.Consultar());
        }
        void CargarGrilla(List<Rol> lista)
        {
            Grilla_TipoUsuarios.Rows.Clear();

            foreach (var item in lista)
            {
                Grilla_TipoUsuarios.Rows.Add(item.IdRol, item.TipoRol.ToUpper());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuUsuario().Show();
        }
    }
}
