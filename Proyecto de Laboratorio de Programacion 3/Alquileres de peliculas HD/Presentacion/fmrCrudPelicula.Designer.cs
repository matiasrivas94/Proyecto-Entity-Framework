namespace Alquileres_de_peliculas_HD
{
    partial class fmrCrudPelicula
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
            this.lblMinutos = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.tbSinopsis = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinutos.Location = new System.Drawing.Point(209, 121);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 44;
            this.lblMinutos.Text = "Minutos";
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFoto.Location = new System.Drawing.Point(500, 36);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(29, 23);
            this.btnFoto.TabIndex = 6;
            this.btnFoto.Tag = "6";
            this.btnFoto.Text = ".....";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // tbPais
            // 
            this.tbPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPais.Location = new System.Drawing.Point(82, 93);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(121, 20);
            this.tbPais.TabIndex = 3;
            this.tbPais.Tag = "3";
            this.tbPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPais_KeyPress);
            // 
            // tbDuracion
            // 
            this.tbDuracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDuracion.Location = new System.Drawing.Point(82, 121);
            this.tbDuracion.MaxLength = 3;
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(121, 20);
            this.tbDuracion.TabIndex = 4;
            this.tbDuracion.Tag = "4";
            this.tbDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuracion_KeyPress);
            // 
            // tbSinopsis
            // 
            this.tbSinopsis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSinopsis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSinopsis.Location = new System.Drawing.Point(82, 149);
            this.tbSinopsis.Multiline = true;
            this.tbSinopsis.Name = "tbSinopsis";
            this.tbSinopsis.Size = new System.Drawing.Size(247, 89);
            this.tbSinopsis.TabIndex = 5;
            this.tbSinopsis.Tag = "5";
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbNombre.Location = new System.Drawing.Point(82, 36);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Tag = "1";
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFoto.Location = new System.Drawing.Point(397, 12);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(28, 13);
            this.lblFoto.TabIndex = 40;
            this.lblFoto.Text = "Foto";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSinopsis.Location = new System.Drawing.Point(27, 149);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(46, 13);
            this.lblSinopsis.TabIndex = 37;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDuracion.Location = new System.Drawing.Point(27, 121);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 34;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPais.Location = new System.Drawing.Point(27, 93);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 32;
            this.lblPais.Text = "Pais";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenero.Location = new System.Drawing.Point(27, 63);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 30;
            this.lblGenero.Text = "Genero";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombre.Location = new System.Drawing.Point(27, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // cbGenero
            // 
            this.cbGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ciencia Ficcion",
            "Accion",
            "Drama",
            "Romance",
            "Suspenso",
            "Terror",
            "Thriller",
            "Comedia",
            "Fantasia",
            "Documental"});
            this.cbGenero.Location = new System.Drawing.Point(82, 63);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 2;
            this.cbGenero.Tag = "2";
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFoto.Location = new System.Drawing.Point(335, 36);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(159, 255);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 42;
            this.pbxFoto.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_Select_22735;
            this.btnAgregar.Location = new System.Drawing.Point(212, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 53);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Tag = "7";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_Stop_22739;
            this.btnSalir.Location = new System.Drawing.Point(545, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Tag = "8";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbBaja);
            this.gbEstado.Controls.Add(this.rbAlta);
            this.gbEstado.Location = new System.Drawing.Point(82, 248);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(131, 43);
            this.gbEstado.TabIndex = 45;
            this.gbEstado.TabStop = false;
            this.gbEstado.Tag = "5";
            this.gbEstado.Text = "Estado";
            this.gbEstado.Visible = false;
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.BackColor = System.Drawing.Color.Transparent;
            this.rbBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaja.Location = new System.Drawing.Point(71, 18);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(54, 19);
            this.rbBaja.TabIndex = 13;
            this.rbBaja.Text = "Baja";
            this.rbBaja.UseVisualStyleBackColor = false;
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.BackColor = System.Drawing.Color.Transparent;
            this.rbAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlta.Location = new System.Drawing.Point(11, 18);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(49, 19);
            this.rbAlta.TabIndex = 12;
            this.rbAlta.Text = "Alta";
            this.rbAlta.UseVisualStyleBackColor = false;
            // 
            // fmrCrudPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 359);
            this.ControlBox = false;
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbDuracion);
            this.Controls.Add(this.tbSinopsis);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbGenero);
            this.Name = "fmrCrudPelicula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud  Pelicula";
            this.Load += new System.EventHandler(this.fmrAgregarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.TextBox tbSinopsis;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.RadioButton rbAlta;
    }
}