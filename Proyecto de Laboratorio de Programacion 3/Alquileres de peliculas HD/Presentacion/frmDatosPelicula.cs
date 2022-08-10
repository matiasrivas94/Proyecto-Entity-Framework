using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alquileres_de_peliculas_HD.DataBase;

namespace Alquileres_de_peliculas_HD
{
    public partial class frmDatosPelicula : Form
    {

        public frmDatosPelicula()
        {
            InitializeComponent();
        }

        private void frmModificarPelicula_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Fondo7;
            }
            catch
            {
                this.BackgroundImage = null;
            }
            
            refrescar();
            this.dgvPeliculas.Columns["Id"].Visible = false;
            this.dgvPeliculas.Columns["Precio"].Visible = false;
            this.dgvPeliculas.Columns["Imagen"].Visible = false;
            this.dgvPeliculas.Columns["Sinopsis"].Visible = false;
            this.dgvPeliculas.Columns["Detalle"].Visible = false;

            dgvPeliculas.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿SALIR?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                fmrCrudPelicula CP = new fmrCrudPelicula(id);
                CP.gbEstado.Visible = true;
                CP.ShowDialog();

                refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBHD db = new DBHD())
                {
                    Peliculas oPelis = db.Peliculas.Find(id);
                    db.Peliculas.Remove(oPelis);

                    db.SaveChanges();
                }
                refrescar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fmrCrudPelicula CP = new fmrCrudPelicula();
            CP.ShowDialog();

            refrescar();
        }

        private void refrescar()
        {
            using (DBHD db = new DBHD())
            {
                var lst = from D in db.Peliculas
                          select D;
                dgvPeliculas.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvPeliculas.Rows[dgvPeliculas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
    }
}
