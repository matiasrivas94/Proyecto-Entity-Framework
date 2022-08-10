namespace Alquileres_de_peliculas_HD
{
    partial class fmrStock
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
            this.lblReferencias = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenosDe = new System.Windows.Forms.Button();
            this.btnSinStock = new System.Windows.Forms.Button();
            this.btnHayStock = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMenosDe = new System.Windows.Forms.Label();
            this.lblSinStock = new System.Windows.Forms.Label();
            this.gbActualizarStock = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbActualizarStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReferencias
            // 
            this.lblReferencias.AutoSize = true;
            this.lblReferencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReferencias.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencias.Location = new System.Drawing.Point(604, 102);
            this.lblReferencias.Name = "lblReferencias";
            this.lblReferencias.Size = new System.Drawing.Size(94, 17);
            this.lblReferencias.TabIndex = 13;
            this.lblReferencias.Text = "REFERENCIAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnMenosDe);
            this.panel1.Controls.Add(this.btnSinStock);
            this.panel1.Controls.Add(this.btnHayStock);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.lblMenosDe);
            this.panel1.Controls.Add(this.lblSinStock);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(551, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 169);
            this.panel1.TabIndex = 12;
            // 
            // btnMenosDe
            // 
            this.btnMenosDe.BackColor = System.Drawing.Color.Yellow;
            this.btnMenosDe.Enabled = false;
            this.btnMenosDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosDe.Location = new System.Drawing.Point(101, 116);
            this.btnMenosDe.Name = "btnMenosDe";
            this.btnMenosDe.Size = new System.Drawing.Size(75, 23);
            this.btnMenosDe.TabIndex = 13;
            this.btnMenosDe.UseVisualStyleBackColor = false;
            // 
            // btnSinStock
            // 
            this.btnSinStock.BackColor = System.Drawing.Color.Red;
            this.btnSinStock.Enabled = false;
            this.btnSinStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinStock.Location = new System.Drawing.Point(101, 74);
            this.btnSinStock.Name = "btnSinStock";
            this.btnSinStock.Size = new System.Drawing.Size(75, 23);
            this.btnSinStock.TabIndex = 12;
            this.btnSinStock.UseVisualStyleBackColor = false;
            // 
            // btnHayStock
            // 
            this.btnHayStock.BackColor = System.Drawing.Color.Lime;
            this.btnHayStock.Enabled = false;
            this.btnHayStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayStock.Location = new System.Drawing.Point(101, 32);
            this.btnHayStock.Name = "btnHayStock";
            this.btnHayStock.Size = new System.Drawing.Size(75, 23);
            this.btnHayStock.TabIndex = 11;
            this.btnHayStock.UseVisualStyleBackColor = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(7, 32);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Hay Stock";
            // 
            // lblMenosDe
            // 
            this.lblMenosDe.AutoSize = true;
            this.lblMenosDe.Location = new System.Drawing.Point(7, 121);
            this.lblMenosDe.Name = "lblMenosDe";
            this.lblMenosDe.Size = new System.Drawing.Size(88, 13);
            this.lblMenosDe.TabIndex = 9;
            this.lblMenosDe.Text = "Menos de 3 Pelis";
            // 
            // lblSinStock
            // 
            this.lblSinStock.AutoSize = true;
            this.lblSinStock.Location = new System.Drawing.Point(7, 79);
            this.lblSinStock.Name = "lblSinStock";
            this.lblSinStock.Size = new System.Drawing.Size(53, 13);
            this.lblSinStock.TabIndex = 10;
            this.lblSinStock.Text = "Sin Stock";
            // 
            // gbActualizarStock
            // 
            this.gbActualizarStock.Controls.Add(this.btnActualizar);
            this.gbActualizarStock.Controls.Add(this.nudCantidad);
            this.gbActualizarStock.Controls.Add(this.lblCantidad);
            this.gbActualizarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbActualizarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizarStock.Location = new System.Drawing.Point(67, 351);
            this.gbActualizarStock.Name = "gbActualizarStock";
            this.gbActualizarStock.Size = new System.Drawing.Size(298, 75);
            this.gbActualizarStock.TabIndex = 10;
            this.gbActualizarStock.TabStop = false;
            this.gbActualizarStock.Text = "Actualizar Stock";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::Alquileres_de_peliculas_HD.Properties.Resources.if_Select_22735;
            this.btnActualizar.Location = new System.Drawing.Point(232, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 55);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Tag = "5";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudCantidad.Location = new System.Drawing.Point(79, 33);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 4;
            this.nudCantidad.Tag = "4";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(17, 33);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToResizeColumns = false;
            this.dgvPeliculas.AllowUserToResizeRows = false;
            this.dgvPeliculas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPeliculas.Location = new System.Drawing.Point(3, 122);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(546, 223);
            this.dgvPeliculas.TabIndex = 9;
            this.dgvPeliculas.Tag = "9";
            this.dgvPeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellClick);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.tbGenero);
            this.gbFiltro.Controls.Add(this.tbNombre);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.lblGenero);
            this.gbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(49, 33);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(395, 71);
            this.gbFiltro.TabIndex = 8;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro de Busqueda";
            // 
            // tbGenero
            // 
            this.tbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbGenero.Location = new System.Drawing.Point(69, 36);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(117, 22);
            this.tbGenero.TabIndex = 1;
            this.tbGenero.Tag = "1";
            this.tbGenero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyUp);
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbNombre.Location = new System.Drawing.Point(250, 36);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(117, 22);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.Tag = "2";
            this.tbNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pelicula";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(15, 36);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 15);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero";
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
            this.btnSalir.Location = new System.Drawing.Point(691, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 49);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fmrStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 432);
            this.ControlBox = false;
            this.Controls.Add(this.lblReferencias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbActualizarStock);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.gbFiltro);
            this.Name = "fmrStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.fmrStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbActualizarStock.ResumeLayout(false);
            this.gbActualizarStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenosDe;
        private System.Windows.Forms.Button btnSinStock;
        private System.Windows.Forms.Button btnHayStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMenosDe;
        private System.Windows.Forms.Label lblSinStock;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbActualizarStock;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblGenero;
        public System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGenero;
    }
}