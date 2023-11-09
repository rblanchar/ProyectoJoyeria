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
    public partial class FrmListadoTipoUsuarios : Form
    {
        ServicioTipoUsuarioOracle servicioTipoUsuarioOracle = new ServicioTipoUsuarioOracle();
        public FrmListadoTipoUsuarios()
        {
            InitializeComponent();
        }

        private void FrmListadoTipoUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        void CargarGrilla()
        {
            Grilla_TipoUsuarios.Rows.Clear();

            var lista = servicioTipoUsuarioOracle.Consultar();
            foreach (var item in lista)
            {
                Grilla_TipoUsuarios.Rows.Add(item.IdTipo, item.Nombre.ToUpper());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuUsuario().Show();
        }
    }
}
