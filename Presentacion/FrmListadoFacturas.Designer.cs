namespace Presentacion
{
    partial class FrmListadoFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaListadoFacturas = new System.Windows.Forms.DataGridView();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaListadoFacturas
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaListadoFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaListadoFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListadoFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.Fecha,
            this.Cedula,
            this.Nombre,
            this.Apellidos,
            this.Nombre_Usuario,
            this.Subtotal,
            this.TotalPagar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaListadoFacturas.DefaultCellStyle = dataGridViewCellStyle4;
            this.GrillaListadoFacturas.Location = new System.Drawing.Point(1, 107);
            this.GrillaListadoFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaListadoFacturas.Name = "GrillaListadoFacturas";
            this.GrillaListadoFacturas.RowHeadersWidth = 51;
            this.GrillaListadoFacturas.Size = new System.Drawing.Size(1380, 422);
            this.GrillaListadoFacturas.TabIndex = 0;
            this.GrillaListadoFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaListadoFacturas_CellDoubleClick);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(1246, 52);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(135, 47);
            this.btn_Regresar.TabIndex = 81;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 82;
            this.label1.Text = "LISTADO DE FACTURAS";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(305, 73);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(178, 26);
            this.txt_Nombre.TabIndex = 83;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 84;
            this.label2.Text = "ID Factura / Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = "Filtrar:";
            // 
            // IdFactura
            // 
            this.IdFactura.HeaderText = "ID FACTURA";
            this.IdFactura.MinimumWidth = 6;
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.ReadOnly = true;
            this.IdFactura.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 140;
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
            this.Nombre.Width = 175;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "APELLIDOS";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 240;
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.HeaderText = "NOM_USUARIO";
            this.Nombre_Usuario.MinimumWidth = 6;
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.ReadOnly = true;
            this.Nombre_Usuario.Width = 200;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "SUBTOTAL";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // TotalPagar
            // 
            this.TotalPagar.HeaderText = "TOTAL PAGAR";
            this.TotalPagar.MinimumWidth = 6;
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.ReadOnly = true;
            this.TotalPagar.Width = 170;
            // 
            // FrmListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 534);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.GrillaListadoFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListadoFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoFacturas";
            this.Load += new System.EventHandler(this.FrmListadoFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaListadoFacturas;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
    }
}