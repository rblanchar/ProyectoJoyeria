﻿namespace Presentacion
{
    partial class FrmListadoClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoClientes));
            this.Grilla_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Regresar2 = new System.Windows.Forms.Button();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Clientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grilla_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grilla_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Cedula,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Barrio,
            this.Correo,
            this.Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grilla_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grilla_Clientes.Location = new System.Drawing.Point(4, 90);
            this.Grilla_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.Grilla_Clientes.Name = "Grilla_Clientes";
            this.Grilla_Clientes.RowHeadersWidth = 51;
            this.Grilla_Clientes.Size = new System.Drawing.Size(1676, 442);
            this.Grilla_Clientes.TabIndex = 0;
            this.Grilla_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_Clientes_CellDoubleClick);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(1548, 42);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(132, 42);
            this.btn_Regresar.TabIndex = 1;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Filtro.Location = new System.Drawing.Point(312, 59);
            this.txt_Filtro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(236, 26);
            this.txt_Filtro.TabIndex = 3;
            this.txt_Filtro.TextChanged += new System.EventHandler(this.txt_Filtro_TextChanged);
            this.txt_Filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre/Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "LISTADO GENERAL DE CLIENTES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filtrar:";
            // 
            // btn_Regresar2
            // 
            this.btn_Regresar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar2.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar2.Location = new System.Drawing.Point(1548, 42);
            this.btn_Regresar2.Name = "btn_Regresar2";
            this.btn_Regresar2.Size = new System.Drawing.Size(132, 41);
            this.btn_Regresar2.TabIndex = 8;
            this.btn_Regresar2.Text = "Regresar";
            this.btn_Regresar2.UseVisualStyleBackColor = false;
            this.btn_Regresar2.Visible = false;
            this.btn_Regresar2.Click += new System.EventHandler(this.btn_Regresar2_Click);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "ID";
            this.Id_Cliente.MinimumWidth = 6;
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Width = 80;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "CEDULA";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 220;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "APELLIDOS";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 242;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "DIRECCION";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 250;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "BARRIO";
            this.Barrio.MinimumWidth = 6;
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 260;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "CORREO";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 320;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "TELEFONO";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 535);
            this.Controls.Add(this.btn_Regresar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.Grilla_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoClientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Clientes;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_Regresar;
        public System.Windows.Forms.Button btn_Regresar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}