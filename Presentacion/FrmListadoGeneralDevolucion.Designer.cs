namespace Presentacion
{
    partial class FrmListadoGeneralDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoGeneralDevolucion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrillaDevoluciones = new System.Windows.Forms.DataGridView();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 29);
            this.label1.TabIndex = 105;
            this.label1.Text = "LISTADO GENERAL DE DEVOLUCIONES";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(1116, 78);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(139, 47);
            this.btn_Regresar.TabIndex = 104;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(306, 99);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(178, 26);
            this.txt_Nombre.TabIndex = 108;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 109;
            this.label2.Text = "ID Factura / Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 110;
            this.label3.Text = "Filtrar:";
            // 
            // GrillaDevoluciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.Fecha,
            this.Cedula,
            this.Nombre,
            this.Apellidos,
            this.TotalPagar,
            this.Nombre_Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaDevoluciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaDevoluciones.Location = new System.Drawing.Point(2, 133);
            this.GrillaDevoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaDevoluciones.Name = "GrillaDevoluciones";
            this.GrillaDevoluciones.RowHeadersWidth = 51;
            this.GrillaDevoluciones.Size = new System.Drawing.Size(1255, 422);
            this.GrillaDevoluciones.TabIndex = 107;
            this.GrillaDevoluciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDevoluciones_CellDoubleClick);
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
            // TotalPagar
            // 
            this.TotalPagar.HeaderText = "TOTAL PAGAR";
            this.TotalPagar.MinimumWidth = 6;
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.ReadOnly = true;
            this.TotalPagar.Width = 170;
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.HeaderText = "NOM_USUARIO";
            this.Nombre_Usuario.MinimumWidth = 6;
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.ReadOnly = true;
            this.Nombre_Usuario.Width = 200;
            // 
            // FrmListadoGeneralDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1261, 559);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrillaDevoluciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Regresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoGeneralDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoGeneralDevolucion";
            this.Load += new System.EventHandler(this.FrmListadoGeneralDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GrillaDevoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
    }
}