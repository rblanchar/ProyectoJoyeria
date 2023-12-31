﻿using ENTIDAD;
using System;
using System.Collections;
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
    public partial class FrmListadoCategorias : Form
    {
        ServicioCategoriaOracle servicioCategoriaProducto = new ServicioCategoriaOracle();
        public FrmListadoCategorias()
        {
            InitializeComponent();
        }

        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarGrilla(servicioCategoriaProducto.Consultar());
        }

        void CargarGrilla(List<CategoriaProducto> lista)
        {
            Grilla_Categorias.Rows.Clear();

            foreach (var item in lista)
            {
                Grilla_Categorias.Rows.Add(item.Id_Categoria, item.Nombre.ToUpper());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmMenuProducto().Show();
        }
    }
}
