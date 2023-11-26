namespace Presentacion
{
    partial class FrmListadoDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoDevoluciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.GrillaDevoluciones = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = "LISTADO DETALLADO DE DEVOLUCION";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(980, 45);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(139, 47);
            this.btn_Regresar.TabIndex = 100;
            this.btn_Regresar.Text = "Cerrar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
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
            this.id_factura,
            this.Descripcion,
            this.Cantidad,
            this.Valor_Unitario,
            this.Iva,
            this.Valor_Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaDevoluciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaDevoluciones.Location = new System.Drawing.Point(3, 95);
            this.GrillaDevoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaDevoluciones.Name = "GrillaDevoluciones";
            this.GrillaDevoluciones.RowHeadersWidth = 51;
            this.GrillaDevoluciones.Size = new System.Drawing.Size(1115, 402);
            this.GrillaDevoluciones.TabIndex = 99;
            // 
            // id_factura
            // 
            this.id_factura.HeaderText = "ID FACTURA";
            this.id_factura.MinimumWidth = 6;
            this.id_factura.Name = "id_factura";
            this.id_factura.ReadOnly = true;
            this.id_factura.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.HeaderText = "VR UNITARIO";
            this.Valor_Unitario.MinimumWidth = 6;
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.ReadOnly = true;
            this.Valor_Unitario.Width = 200;
            // 
            // Iva
            // 
            this.Iva.HeaderText = "IVA";
            this.Iva.MinimumWidth = 6;
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 125;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "VR TOTAL";
            this.Valor_Total.MinimumWidth = 6;
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Width = 175;
            // 
            // FrmListadoDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.GrillaDevoluciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoDevoluciones";
            this.Load += new System.EventHandler(this.FrmListadoDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.DataGridView GrillaDevoluciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
    }
}