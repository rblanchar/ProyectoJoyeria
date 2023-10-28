namespace Presentacion
{
    partial class FrmGestionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionProducto));
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.txt_Margen = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PrecioCosto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Material = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb20 = new System.Windows.Forms.Label();
            this.lb21 = new System.Windows.Forms.Label();
            this.lb22 = new System.Windows.Forms.Label();
            this.lb23 = new System.Windows.Forms.Label();
            this.lb24 = new System.Windows.Forms.Label();
            this.lb25 = new System.Windows.Forms.Label();
            this.lb26 = new System.Windows.Forms.Label();
            this.lb27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Opcion
            // 
            this.cmb_Opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Opcion.FormattingEnabled = true;
            this.cmb_Opcion.Items.AddRange(new object[] {
            "REGISTRAR",
            "CONSULTAR",
            "ELIMINAR",
            "MODIFICAR"});
            this.cmb_Opcion.Location = new System.Drawing.Point(143, 78);
            this.cmb_Opcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(133, 26);
            this.cmb_Opcion.TabIndex = 0;
            this.cmb_Opcion.SelectedIndexChanged += new System.EventHandler(this.cmb_Opcion_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(29, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 18);
            this.label20.TabIndex = 106;
            this.label20.Text = "Opcion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Enabled = false;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(452, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 6);
            this.label17.TabIndex = 103;
            this.label17.Text = "________________________";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Enabled = false;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(388, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 6);
            this.label13.TabIndex = 99;
            this.label13.Text = "_____________";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Enabled = false;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(136, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 6);
            this.label12.TabIndex = 98;
            this.label12.Text = "_____________________________________________________________________________";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Location = new System.Drawing.Point(29, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(518, 16);
            this.label11.TabIndex = 97;
            this.label11.Text = "_________________________________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 313);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(246, 336);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(123, 43);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(375, 336);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(123, 43);
            this.btn_Cancelar.TabIndex = 88;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(503, 336);
            this.btn_Regresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(123, 43);
            this.btn_Regresar.TabIndex = 89;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // txt_Margen
            // 
            this.txt_Margen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Margen.Enabled = false;
            this.txt_Margen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Margen.Location = new System.Drawing.Point(393, 250);
            this.txt_Margen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Margen.Name = "txt_Margen";
            this.txt_Margen.Size = new System.Drawing.Size(42, 17);
            this.txt_Margen.TabIndex = 7;
            this.txt_Margen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Margen_KeyPress);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Descripcion.Enabled = false;
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(137, 185);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(302, 17);
            this.txt_Descripcion.TabIndex = 4;
            this.txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descripcion_KeyPress);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Codigo.Enabled = false;
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(453, 133);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(94, 17);
            this.txt_Codigo.TabIndex = 3;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Margen Gan.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 87;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 86;
            this.label3.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "GESTION DE PRODUCTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cantidad.Enabled = false;
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(556, 250);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(59, 17);
            this.txt_Cantidad.TabIndex = 8;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Enabled = false;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(551, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 6);
            this.label18.TabIndex = 104;
            this.label18.Text = "_______________";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Categoria";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.Enabled = false;
            this.cmb_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(453, 78);
            this.cmb_Categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(160, 26);
            this.cmb_Categoria.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Enabled = false;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(148, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 6);
            this.label7.TabIndex = 111;
            this.label7.Text = "________________________";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_PrecioCosto
            // 
            this.txt_PrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PrecioCosto.Enabled = false;
            this.txt_PrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioCosto.Location = new System.Drawing.Point(152, 249);
            this.txt_PrecioCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PrecioCosto.Name = "txt_PrecioCosto";
            this.txt_PrecioCosto.Size = new System.Drawing.Size(90, 17);
            this.txt_PrecioCosto.TabIndex = 6;
            this.txt_PrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioCosto_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 110;
            this.label8.Text = "Precio Costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Enabled = false;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(552, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 6);
            this.label9.TabIndex = 114;
            this.label9.Text = "______________";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_Peso
            // 
            this.txt_Peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Peso.Enabled = false;
            this.txt_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Peso.Location = new System.Drawing.Point(553, 184);
            this.txt_Peso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(53, 17);
            this.txt_Peso.TabIndex = 5;
            this.txt_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Peso_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 113;
            this.label10.Text = "Peso";
            // 
            // cmb_Material
            // 
            this.cmb_Material.Enabled = false;
            this.cmb_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Material.FormattingEnabled = true;
            this.cmb_Material.Items.AddRange(new object[] {
            "REGISTRAR",
            "CONSULTAR",
            "ELIMINAR",
            "MODIFICAR"});
            this.cmb_Material.Location = new System.Drawing.Point(144, 129);
            this.cmb_Material.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Material.Name = "cmb_Material";
            this.cmb_Material.Size = new System.Drawing.Size(133, 26);
            this.cmb_Material.TabIndex = 2;
            this.cmb_Material.SelectedIndexChanged += new System.EventHandler(this.cmb_Material_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 18);
            this.label14.TabIndex = 116;
            this.label14.Text = "Material";
            // 
            // lb20
            // 
            this.lb20.AutoSize = true;
            this.lb20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb20.ForeColor = System.Drawing.Color.Red;
            this.lb20.Location = new System.Drawing.Point(435, 76);
            this.lb20.Name = "lb20";
            this.lb20.Size = new System.Drawing.Size(15, 18);
            this.lb20.TabIndex = 117;
            this.lb20.Text = "*";
            this.lb20.Visible = false;
            // 
            // lb21
            // 
            this.lb21.AutoSize = true;
            this.lb21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb21.ForeColor = System.Drawing.Color.Red;
            this.lb21.Location = new System.Drawing.Point(103, 129);
            this.lb21.Name = "lb21";
            this.lb21.Size = new System.Drawing.Size(15, 18);
            this.lb21.TabIndex = 117;
            this.lb21.Text = "*";
            this.lb21.Visible = false;
            // 
            // lb22
            // 
            this.lb22.AutoSize = true;
            this.lb22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb22.ForeColor = System.Drawing.Color.Red;
            this.lb22.Location = new System.Drawing.Point(432, 133);
            this.lb22.Name = "lb22";
            this.lb22.Size = new System.Drawing.Size(15, 18);
            this.lb22.TabIndex = 117;
            this.lb22.Text = "*";
            this.lb22.Visible = false;
            // 
            // lb23
            // 
            this.lb23.AutoSize = true;
            this.lb23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb23.ForeColor = System.Drawing.Color.Red;
            this.lb23.Location = new System.Drawing.Point(122, 183);
            this.lb23.Name = "lb23";
            this.lb23.Size = new System.Drawing.Size(15, 18);
            this.lb23.TabIndex = 117;
            this.lb23.Text = "*";
            this.lb23.Visible = false;
            // 
            // lb24
            // 
            this.lb24.AutoSize = true;
            this.lb24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb24.ForeColor = System.Drawing.Color.Red;
            this.lb24.Location = new System.Drawing.Point(536, 183);
            this.lb24.Name = "lb24";
            this.lb24.Size = new System.Drawing.Size(15, 18);
            this.lb24.TabIndex = 117;
            this.lb24.Text = "*";
            this.lb24.Visible = false;
            // 
            // lb25
            // 
            this.lb25.AutoSize = true;
            this.lb25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb25.ForeColor = System.Drawing.Color.Red;
            this.lb25.Location = new System.Drawing.Point(134, 248);
            this.lb25.Name = "lb25";
            this.lb25.Size = new System.Drawing.Size(15, 18);
            this.lb25.TabIndex = 117;
            this.lb25.Text = "*";
            this.lb25.Visible = false;
            // 
            // lb26
            // 
            this.lb26.AutoSize = true;
            this.lb26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb26.ForeColor = System.Drawing.Color.Red;
            this.lb26.Location = new System.Drawing.Point(372, 248);
            this.lb26.Name = "lb26";
            this.lb26.Size = new System.Drawing.Size(15, 18);
            this.lb26.TabIndex = 117;
            this.lb26.Text = "*";
            this.lb26.Visible = false;
            // 
            // lb27
            // 
            this.lb27.AutoSize = true;
            this.lb27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb27.ForeColor = System.Drawing.Color.Red;
            this.lb27.Location = new System.Drawing.Point(536, 248);
            this.lb27.Name = "lb27";
            this.lb27.Size = new System.Drawing.Size(15, 18);
            this.lb27.TabIndex = 117;
            this.lb27.Text = "*";
            this.lb27.Visible = false;
            // 
            // FrmGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 387);
            this.Controls.Add(this.lb27);
            this.Controls.Add(this.lb26);
            this.Controls.Add(this.lb25);
            this.Controls.Add(this.lb24);
            this.Controls.Add(this.lb23);
            this.Controls.Add(this.lb22);
            this.Controls.Add(this.lb21);
            this.Controls.Add(this.lb20);
            this.Controls.Add(this.cmb_Material);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PrecioCosto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Opcion);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.txt_Margen);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionProducto";
            this.Load += new System.EventHandler(this.FrmGestionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Opcion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.TextBox txt_Margen;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PrecioCosto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Material;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb20;
        private System.Windows.Forms.Label lb21;
        private System.Windows.Forms.Label lb22;
        private System.Windows.Forms.Label lb23;
        private System.Windows.Forms.Label lb24;
        private System.Windows.Forms.Label lb25;
        private System.Windows.Forms.Label lb26;
        private System.Windows.Forms.Label lb27;
    }
}