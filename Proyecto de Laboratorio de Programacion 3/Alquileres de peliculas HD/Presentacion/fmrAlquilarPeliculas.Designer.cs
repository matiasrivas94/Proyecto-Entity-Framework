namespace Alquileres_de_peliculas_HD
{
    partial class fmrAlquilarPeliculas
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
            this.components = new System.ComponentModel.Container();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.gbxDocumento = new System.Windows.Forms.GroupBox();
            this.dtpRegreso = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblRegreso = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvAgregarPeli = new System.Windows.Forms.DataGridView();
            this.dgvQuitarPeli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbxDatosdelCliente = new System.Windows.Forms.GroupBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.tbClienteDNI = new System.Windows.Forms.TextBox();
            this.tbClienteApellido = new System.Windows.Forms.TextBox();
            this.tbClientenombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.estadoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peliculasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCOAODOPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuitarPeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbxDatosdelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Cursor = System.Windows.Forms.Cursors.No;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(706, 20);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(273, 16);
            this.lblInformacion.TabIndex = 32;
            this.lblInformacion.Text = "INFORMACION A TENER EN CUENTA";
            // 
            // gbxDocumento
            // 
            this.gbxDocumento.Controls.Add(this.dtpRegreso);
            this.gbxDocumento.Controls.Add(this.dtpEntrega);
            this.gbxDocumento.Controls.Add(this.lblRegreso);
            this.gbxDocumento.Controls.Add(this.lblEntrega);
            this.gbxDocumento.Location = new System.Drawing.Point(604, 425);
            this.gbxDocumento.Name = "gbxDocumento";
            this.gbxDocumento.Size = new System.Drawing.Size(210, 102);
            this.gbxDocumento.TabIndex = 29;
            this.gbxDocumento.TabStop = false;
            this.gbxDocumento.Text = "Documento del Alquiler";
            // 
            // dtpRegreso
            // 
            this.dtpRegreso.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpRegreso.Enabled = false;
            this.dtpRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegreso.Location = new System.Drawing.Point(127, 62);
            this.dtpRegreso.Name = "dtpRegreso";
            this.dtpRegreso.Size = new System.Drawing.Size(79, 20);
            this.dtpRegreso.TabIndex = 1113;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpEntrega.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpEntrega.Enabled = false;
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(127, 37);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(79, 20);
            this.dtpEntrega.TabIndex = 1113;
            // 
            // lblRegreso
            // 
            this.lblRegreso.AutoSize = true;
            this.lblRegreso.Location = new System.Drawing.Point(29, 62);
            this.lblRegreso.Name = "lblRegreso";
            this.lblRegreso.Size = new System.Drawing.Size(95, 13);
            this.lblRegreso.TabIndex = 8;
            this.lblRegreso.Text = "Fecha de Regreso";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(29, 37);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(92, 13);
            this.lblEntrega.TabIndex = 0;
            this.lblEntrega.Text = "Fecha de Entrega";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Cursor = System.Windows.Forms.Cursors.No;
            this.lblAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(87, 233);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(321, 16);
            this.lblAgregar.TabIndex = 41;
            this.lblAgregar.Text = "Seleccione la/s peliculas que desea alquilar.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(385, 499);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 13);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "TOTAL:";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTotal.Location = new System.Drawing.Point(442, 494);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(41, 21);
            this.tbTotal.TabIndex = 44;
            this.tbTotal.Text = "0";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.moneda;
            this.btnPagar.Location = new System.Drawing.Point(489, 484);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(41, 43);
            this.btnPagar.TabIndex = 2;
            this.btnPagar.Tag = "2";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_cancel_1712;
            this.btnCancelar.Location = new System.Drawing.Point(1008, -2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 38);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Precios, Plazos e Intereses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Location = new System.Drawing.Point(706, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 65);
            this.label4.TabIndex = 45;
            this.label4.Text = "1)Una pelicula cuesta $50.\r\n\r\n2)Un Alquiler tiene un plazo de un dia por pelicula" +
    ".\r\n\r\n3)No cumplido el plazo se aplica un interes de $20 por pelicula.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_diskette_43574;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(366, 422);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Tag = "1";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Maroon;
            this.btnQuitar.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_Redo_27872;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(489, 422);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(109, 43);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Tag = "2";
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvAgregarPeli
            // 
            this.dgvAgregarPeli.AllowUserToAddRows = false;
            this.dgvAgregarPeli.AllowUserToDeleteRows = false;
            this.dgvAgregarPeli.AutoGenerateColumns = false;
            this.dgvAgregarPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarPeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idCOAODOPD,
            this.nombreDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.sinopsisDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dgvAgregarPeli.DataSource = this.peliculasBindingSource;
            this.dgvAgregarPeli.Location = new System.Drawing.Point(12, 266);
            this.dgvAgregarPeli.Name = "dgvAgregarPeli";
            this.dgvAgregarPeli.Size = new System.Drawing.Size(463, 150);
            this.dgvAgregarPeli.TabIndex = 47;
            // 
            // dgvQuitarPeli
            // 
            this.dgvQuitarPeli.AllowUserToAddRows = false;
            this.dgvQuitarPeli.AllowUserToDeleteRows = false;
            this.dgvQuitarPeli.AutoGenerateColumns = false;
            this.dgvQuitarPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuitarPeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.id,
            this.nombreDataGridViewTextBoxColumn1,
            this.generoDataGridViewTextBoxColumn1,
            this.duracionDataGridViewTextBoxColumn1,
            this.paisDataGridViewTextBoxColumn1,
            this.sinopsisDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1,
            this.imagenDataGridViewImageColumn1,
            this.estadoDataGridViewCheckBoxColumn1,
            this.stockDataGridViewTextBoxColumn1});
            this.dgvQuitarPeli.DataSource = this.peliculasBindingSource1;
            this.dgvQuitarPeli.Location = new System.Drawing.Point(489, 266);
            this.dgvQuitarPeli.Name = "dgvQuitarPeli";
            this.dgvQuitarPeli.Size = new System.Drawing.Size(463, 150);
            this.dgvQuitarPeli.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Seleccione la/s peliculas que desea quitar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Agregar un nuevo cliente";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Cyan;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_add_user_309049;
            this.btnAgregarCliente.Location = new System.Drawing.Point(245, 176);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(49, 38);
            this.btnAgregarCliente.TabIndex = 52;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(245, 12);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(447, 158);
            this.dgvClientes.TabIndex = 51;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // gbxDatosdelCliente
            // 
            this.gbxDatosdelCliente.Controls.Add(this.cboFormaPago);
            this.gbxDatosdelCliente.Controls.Add(this.lblPago);
            this.gbxDatosdelCliente.Controls.Add(this.tbClienteDNI);
            this.gbxDatosdelCliente.Controls.Add(this.tbClienteApellido);
            this.gbxDatosdelCliente.Controls.Add(this.tbClientenombre);
            this.gbxDatosdelCliente.Controls.Add(this.lblNombre);
            this.gbxDatosdelCliente.Controls.Add(this.lblApellido);
            this.gbxDatosdelCliente.Controls.Add(this.lblDni);
            this.gbxDatosdelCliente.Location = new System.Drawing.Point(3, 9);
            this.gbxDatosdelCliente.Name = "gbxDatosdelCliente";
            this.gbxDatosdelCliente.Size = new System.Drawing.Size(227, 161);
            this.gbxDatosdelCliente.TabIndex = 50;
            this.gbxDatosdelCliente.TabStop = false;
            this.gbxDatosdelCliente.Text = "Cliente Selecionado";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.cboFormaPago.Location = new System.Drawing.Point(87, 134);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(100, 21);
            this.cboFormaPago.TabIndex = 49;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(6, 137);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(79, 13);
            this.lblPago.TabIndex = 48;
            this.lblPago.Text = "Forma de Pago";
            // 
            // tbClienteDNI
            // 
            this.tbClienteDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClienteDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbClienteDNI.Location = new System.Drawing.Point(87, 28);
            this.tbClienteDNI.MaxLength = 8;
            this.tbClienteDNI.Name = "tbClienteDNI";
            this.tbClienteDNI.Size = new System.Drawing.Size(100, 20);
            this.tbClienteDNI.TabIndex = 1;
            this.tbClienteDNI.Tag = "1";
            // 
            // tbClienteApellido
            // 
            this.tbClienteApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClienteApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbClienteApellido.Location = new System.Drawing.Point(87, 61);
            this.tbClienteApellido.MaxLength = 12;
            this.tbClienteApellido.Name = "tbClienteApellido";
            this.tbClienteApellido.Size = new System.Drawing.Size(100, 20);
            this.tbClienteApellido.TabIndex = 2;
            this.tbClienteApellido.Tag = "2";
            // 
            // tbClientenombre
            // 
            this.tbClientenombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClientenombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbClientenombre.Location = new System.Drawing.Point(87, 94);
            this.tbClientenombre.MaxLength = 20;
            this.tbClientenombre.Name = "tbClientenombre";
            this.tbClientenombre.Size = new System.Drawing.Size(100, 20);
            this.tbClientenombre.TabIndex = 3;
            this.tbClientenombre.Tag = "3";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(27, 28);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Select";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // generoDataGridViewTextBoxColumn1
            // 
            this.generoDataGridViewTextBoxColumn1.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn1.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn1.Name = "generoDataGridViewTextBoxColumn1";
            // 
            // duracionDataGridViewTextBoxColumn1
            // 
            this.duracionDataGridViewTextBoxColumn1.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn1.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn1.Name = "duracionDataGridViewTextBoxColumn1";
            this.duracionDataGridViewTextBoxColumn1.Width = 60;
            // 
            // paisDataGridViewTextBoxColumn1
            // 
            this.paisDataGridViewTextBoxColumn1.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn1.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn1.Name = "paisDataGridViewTextBoxColumn1";
            this.paisDataGridViewTextBoxColumn1.Width = 110;
            // 
            // sinopsisDataGridViewTextBoxColumn1
            // 
            this.sinopsisDataGridViewTextBoxColumn1.DataPropertyName = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn1.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn1.Name = "sinopsisDataGridViewTextBoxColumn1";
            this.sinopsisDataGridViewTextBoxColumn1.Visible = false;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.Visible = false;
            // 
            // imagenDataGridViewImageColumn1
            // 
            this.imagenDataGridViewImageColumn1.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn1.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn1.Name = "imagenDataGridViewImageColumn1";
            this.imagenDataGridViewImageColumn1.Visible = false;
            // 
            // estadoDataGridViewCheckBoxColumn1
            // 
            this.estadoDataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn1.Name = "estadoDataGridViewCheckBoxColumn1";
            this.estadoDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn1
            // 
            this.stockDataGridViewTextBoxColumn1.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn1.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn1.Name = "stockDataGridViewTextBoxColumn1";
            this.stockDataGridViewTextBoxColumn1.Visible = false;
            this.stockDataGridViewTextBoxColumn1.Width = 50;
            // 
            // peliculasBindingSource1
            // 
            this.peliculasBindingSource1.DataSource = typeof(Alquileres_de_peliculas_HD.DataBase.Peliculas);
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataSource = typeof(Alquileres_de_peliculas_HD.DataBase.Peliculas);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // idCOAODOPD
            // 
            this.idCOAODOPD.DataPropertyName = "id";
            this.idCOAODOPD.HeaderText = "id";
            this.idCOAODOPD.Name = "idCOAODOPD";
            this.idCOAODOPD.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.Width = 60;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.Width = 110;
            // 
            // sinopsisDataGridViewTextBoxColumn
            // 
            this.sinopsisDataGridViewTextBoxColumn.DataPropertyName = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.Name = "sinopsisDataGridViewTextBoxColumn";
            this.sinopsisDataGridViewTextBoxColumn.Visible = false;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Visible = false;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.Visible = false;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 50;
            // 
            // fmrAlquilarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 535);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbxDatosdelCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQuitarPeli);
            this.Controls.Add(this.dgvAgregarPeli);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.gbxDocumento);
            this.Name = "fmrAlquilarPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquilar Peliculas";
            this.Load += new System.EventHandler(this.fmrAlquilarPeliculas_Load);
            this.gbxDocumento.ResumeLayout(false);
            this.gbxDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarPeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuitarPeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbxDatosdelCliente.ResumeLayout(false);
            this.gbxDatosdelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.GroupBox gbxDocumento;
        private System.Windows.Forms.DateTimePicker dtpRegreso;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label lblRegreso;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvAgregarPeli;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private System.Windows.Forms.DataGridView dgvQuitarPeli;
        private System.Windows.Forms.BindingSource peliculasBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbxDatosdelCliente;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox tbClienteDNI;
        private System.Windows.Forms.TextBox tbClienteApellido;
        private System.Windows.Forms.TextBox tbClientenombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCOAODOPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}