namespace Alquileres_de_peliculas_HD
{
    partial class fmrRegistroDeAlquiler
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
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.lblInteres = new System.Windows.Forms.Label();
            this.tbInteres = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReferencias
            // 
            this.lblReferencias.AutoSize = true;
            this.lblReferencias.Cursor = System.Windows.Forms.Cursors.No;
            this.lblReferencias.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencias.Location = new System.Drawing.Point(100, 316);
            this.lblReferencias.Name = "lblReferencias";
            this.lblReferencias.Size = new System.Drawing.Size(94, 17);
            this.lblReferencias.TabIndex = 21;
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
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(7, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 157);
            this.panel1.TabIndex = 20;
            // 
            // btnMenosDe
            // 
            this.btnMenosDe.BackColor = System.Drawing.Color.Yellow;
            this.btnMenosDe.Enabled = false;
            this.btnMenosDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosDe.Location = new System.Drawing.Point(203, 104);
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
            this.btnSinStock.Location = new System.Drawing.Point(203, 52);
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
            this.btnHayStock.Location = new System.Drawing.Point(203, 8);
            this.btnHayStock.Name = "btnHayStock";
            this.btnHayStock.Size = new System.Drawing.Size(75, 23);
            this.btnHayStock.TabIndex = 11;
            this.btnHayStock.UseVisualStyleBackColor = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(7, 5);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(167, 26);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "La fecha del alquiler se encuentra\r\ndentro del limite establecido.\r\n";
            // 
            // lblMenosDe
            // 
            this.lblMenosDe.AutoSize = true;
            this.lblMenosDe.Location = new System.Drawing.Point(7, 94);
            this.lblMenosDe.Name = "lblMenosDe";
            this.lblMenosDe.Size = new System.Drawing.Size(190, 52);
            this.lblMenosDe.TabIndex = 9;
            this.lblMenosDe.Text = "La fehca del alquiler a llegado a su \r\nultimo dia.\r\nSi no se regresa en las proxi" +
    "mas horas,\r\nse debera cobrar un pago por retraso.";
            // 
            // lblSinStock
            // 
            this.lblSinStock.AutoSize = true;
            this.lblSinStock.Location = new System.Drawing.Point(7, 49);
            this.lblSinStock.Name = "lblSinStock";
            this.lblSinStock.Size = new System.Drawing.Size(169, 26);
            this.lblSinStock.TabIndex = 10;
            this.lblSinStock.Text = "La fecha del alquiler se a vencido.\r\nSe cobrara un pago por retraso.\r\n";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.AllowUserToResizeColumns = false;
            this.dgvRegistro.AllowUserToResizeRows = false;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRegistro.Location = new System.Drawing.Point(4, 6);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(647, 152);
            this.dgvRegistro.TabIndex = 17;
            this.dgvRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellClick);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToResizeColumns = false;
            this.dgvPeliculas.AllowUserToResizeRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPeliculas.Location = new System.Drawing.Point(4, 164);
            this.dgvPeliculas.MultiSelect = false;
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(647, 147);
            this.dgvPeliculas.TabIndex = 24;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.Location = new System.Drawing.Point(371, 373);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(74, 16);
            this.lblInteres.TabIndex = 28;
            this.lblInteres.Text = "INTERES";
            // 
            // tbInteres
            // 
            this.tbInteres.Cursor = System.Windows.Forms.Cursors.No;
            this.tbInteres.Enabled = false;
            this.tbInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInteres.Location = new System.Drawing.Point(451, 370);
            this.tbInteres.Name = "tbInteres";
            this.tbInteres.Size = new System.Drawing.Size(100, 21);
            this.tbInteres.TabIndex = 27;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(371, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 16);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "TOTAL";
            // 
            // tbTotal
            // 
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(451, 343);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 21);
            this.tbTotal.TabIndex = 25;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Blue;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(374, 414);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(125, 39);
            this.btnReportes.TabIndex = 29;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // fmrRegistroDeAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(663, 490);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.tbInteres);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.lblReferencias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRegistro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrRegistroDeAlquiler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Alquiler";
            this.Load += new System.EventHandler(this.fmrRegistroDeAlquiler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.TextBox tbInteres;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnReportes;
    }
}