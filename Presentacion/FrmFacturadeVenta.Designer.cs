namespace Presentacion
{
    partial class FrmFacturadeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturadeVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idFactura = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Barrio = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.GrillaDetalle = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_Iva = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_TotalPagar = new System.Windows.Forms.TextBox();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(1034, 748);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(145, 49);
            this.btn_Guardar.TabIndex = 56;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(1185, 748);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 48);
            this.btn_Cancelar.TabIndex = 57;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(1336, 748);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(145, 48);
            this.btn_Regresar.TabIndex = 58;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "FACTURACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "Fecha:";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BackColor = System.Drawing.Color.White;
            this.txt_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Fecha.Location = new System.Drawing.Point(109, 50);
            this.txt_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(131, 25);
            this.txt_Fecha.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1119, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "Factura de Venta N°";
            // 
            // txt_idFactura
            // 
            this.txt_idFactura.BackColor = System.Drawing.Color.White;
            this.txt_idFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idFactura.Location = new System.Drawing.Point(1362, 22);
            this.txt_idFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idFactura.Name = "txt_idFactura";
            this.txt_idFactura.ReadOnly = true;
            this.txt_idFactura.Size = new System.Drawing.Size(100, 38);
            this.txt_idFactura.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 712);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1222, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 66;
            this.label5.Text = "Usuario:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(214, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 68;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.BackColor = System.Drawing.Color.White;
            this.txt_IdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdCliente.Location = new System.Drawing.Point(113, 106);
            this.txt_IdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(85, 21);
            this.txt_IdCliente.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Enabled = false;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1478, 6);
            this.label12.TabIndex = 99;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 100;
            this.label7.Text = "Cedula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 100;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1085, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 100;
            this.label9.Text = "Apellidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 29);
            this.label10.TabIndex = 100;
            this.label10.Text = "Direccion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 29);
            this.label11.TabIndex = 101;
            this.label11.Text = "Barrio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(793, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 29);
            this.label13.TabIndex = 102;
            this.label13.Text = "Correo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1179, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 29);
            this.label14.TabIndex = 103;
            this.label14.Text = "Telefono:";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(155, 165);
            this.txt_Cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(172, 28);
            this.txt_Cedula.TabIndex = 0;
            this.txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress);
            this.txt_Cedula.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_Cedula_PreviewKeyDown);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.White;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(663, 169);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(285, 28);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.BackColor = System.Drawing.Color.White;
            this.txt_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(1222, 165);
            this.txt_Apellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.ReadOnly = true;
            this.txt_Apellidos.Size = new System.Drawing.Size(253, 28);
            this.txt_Apellidos.TabIndex = 3;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.BackColor = System.Drawing.Color.White;
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(151, 230);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.ReadOnly = true;
            this.txt_Direccion.Size = new System.Drawing.Size(240, 28);
            this.txt_Direccion.TabIndex = 4;
            this.txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Direccion_KeyPress);
            // 
            // txt_Barrio
            // 
            this.txt_Barrio.BackColor = System.Drawing.Color.White;
            this.txt_Barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Barrio.Location = new System.Drawing.Point(522, 229);
            this.txt_Barrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Barrio.Name = "txt_Barrio";
            this.txt_Barrio.ReadOnly = true;
            this.txt_Barrio.Size = new System.Drawing.Size(235, 28);
            this.txt_Barrio.TabIndex = 5;
            this.txt_Barrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Barrio_KeyPress);
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.White;
            this.txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.Location = new System.Drawing.Point(893, 231);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.ReadOnly = true;
            this.txt_Correo.Size = new System.Drawing.Size(250, 28);
            this.txt_Correo.TabIndex = 6;
            this.txt_Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Correo_KeyPress);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.White;
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(1323, 230);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.ReadOnly = true;
            this.txt_Telefono.Size = new System.Drawing.Size(152, 28);
            this.txt_Telefono.TabIndex = 7;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Enabled = false;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1478, 6);
            this.label15.TabIndex = 111;
            this.label15.Text = resources.GetString("label15.Text");
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Enabled = false;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(1360, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 6);
            this.label16.TabIndex = 112;
            this.label16.Text = "_________________________";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // GrillaDetalle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.categoria,
            this.material,
            this.descripcion,
            this.cantidad,
            this.vr_unitario,
            this.iva,
            this.vr_total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaDetalle.Location = new System.Drawing.Point(4, 279);
            this.GrillaDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaDetalle.Name = "GrillaDetalle";
            this.GrillaDetalle.RowHeadersWidth = 51;
            this.GrillaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GrillaDetalle.Size = new System.Drawing.Size(1477, 406);
            this.GrillaDetalle.TabIndex = 113;
            this.GrillaDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDetalle_CellDoubleClick);
            this.GrillaDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDetalle_CellEndEdit);
            this.GrillaDetalle.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrillaDetalle_RowHeaderMouseClick);
            this.GrillaDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrillaDetalle_KeyDown);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID_PROD";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.Width = 120;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 210;
            // 
            // material
            // 
            this.material.HeaderText = "MATERIAL";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.ReadOnly = true;
            this.material.Width = 155;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 418;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANT";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 80;
            // 
            // vr_unitario
            // 
            this.vr_unitario.HeaderText = "VR UNITARIO";
            this.vr_unitario.MinimumWidth = 6;
            this.vr_unitario.Name = "vr_unitario";
            this.vr_unitario.ReadOnly = true;
            this.vr_unitario.Width = 165;
            // 
            // iva
            // 
            this.iva.HeaderText = "IVA";
            this.iva.MinimumWidth = 6;
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Width = 120;
            // 
            // vr_total
            // 
            this.vr_total.HeaderText = "VR TOTAL";
            this.vr_total.MinimumWidth = 6;
            this.vr_total.Name = "vr_total";
            this.vr_total.ReadOnly = true;
            this.vr_total.Width = 155;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(641, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 18);
            this.label17.TabIndex = 119;
            this.label17.Text = "*";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(1201, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 18);
            this.label18.TabIndex = 120;
            this.label18.Text = "*";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(130, 229);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 18);
            this.label19.TabIndex = 121;
            this.label19.Text = "*";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(509, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 18);
            this.label20.TabIndex = 123;
            this.label20.Text = "*";
            this.label20.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(880, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 18);
            this.label21.TabIndex = 124;
            this.label21.Text = "*";
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(1293, 228);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 18);
            this.label22.TabIndex = 125;
            this.label22.Text = "*";
            this.label22.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(108, 171);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 18);
            this.label23.TabIndex = 126;
            this.label23.Text = "*";
            this.label23.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Enabled = false;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(111, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 6);
            this.label24.TabIndex = 128;
            this.label24.Text = "______________________";
            this.label24.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Enabled = false;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(106, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(143, 6);
            this.label25.TabIndex = 129;
            this.label25.Text = "___________________________________";
            this.label25.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 704);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 130;
            this.label6.Text = "Subtotal:";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.BackColor = System.Drawing.Color.White;
            this.txt_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subtotal.Location = new System.Drawing.Point(849, 704);
            this.txt_Subtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.ReadOnly = true;
            this.txt_Subtotal.Size = new System.Drawing.Size(122, 30);
            this.txt_Subtotal.TabIndex = 131;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(994, 704);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 29);
            this.label26.TabIndex = 132;
            this.label26.Text = "IVA:";
            // 
            // txt_Iva
            // 
            this.txt_Iva.BackColor = System.Drawing.Color.White;
            this.txt_Iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Iva.Location = new System.Drawing.Point(1052, 704);
            this.txt_Iva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Iva.Name = "txt_Iva";
            this.txt_Iva.ReadOnly = true;
            this.txt_Iva.Size = new System.Drawing.Size(114, 30);
            this.txt_Iva.TabIndex = 133;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1186, 704);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(163, 29);
            this.label27.TabIndex = 134;
            this.label27.Text = "Total a Pagar:";
            // 
            // txt_TotalPagar
            // 
            this.txt_TotalPagar.BackColor = System.Drawing.Color.White;
            this.txt_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPagar.Location = new System.Drawing.Point(1356, 700);
            this.txt_TotalPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TotalPagar.Name = "txt_TotalPagar";
            this.txt_TotalPagar.ReadOnly = true;
            this.txt_TotalPagar.Size = new System.Drawing.Size(123, 30);
            this.txt_TotalPagar.TabIndex = 135;
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Enabled = false;
            this.txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUsuario.Location = new System.Drawing.Point(1330, 105);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(138, 28);
            this.txt_NombreUsuario.TabIndex = 136;
            // 
            // FrmFacturadeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1487, 801);
            this.Controls.Add(this.txt_NombreUsuario);
            this.Controls.Add(this.txt_TotalPagar);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txt_Iva);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.GrillaDetalle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Barrio);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_IdCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_idFactura);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Regresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFacturadeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturadeVenta";
            this.Load += new System.EventHandler(this.FrmFacturadeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txt_Cedula;
        public System.Windows.Forms.TextBox txt_Nombre;
        public System.Windows.Forms.TextBox txt_Apellidos;
        public System.Windows.Forms.TextBox txt_Direccion;
        public System.Windows.Forms.TextBox txt_Barrio;
        public System.Windows.Forms.TextBox txt_Correo;
        public System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.DataGridView GrillaDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_Iva;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_TotalPagar;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_total;
    }
}