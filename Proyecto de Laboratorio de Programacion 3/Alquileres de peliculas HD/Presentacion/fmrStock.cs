using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Alquileres_de_peliculas_HD.DataBase;
using System.Data.SqlClient;

namespace Alquileres_de_peliculas_HD
{
    public partial class fmrStock : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=AlquilerHD;Integrated Security=True");

        Peliculas oPelis = null;

        public fmrStock()
        {
            InitializeComponent();
        }

        private void fmrStock_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.symbol;
            }
            catch
            {
                this.BackgroundImage = null;
            }
            refrescar();
            
            this.dgvPeliculas.Columns["Id"].Visible = false;
            this.dgvPeliculas.Columns["Precio"].Visible = false;
            this.dgvPeliculas.Columns["Estado"].Visible = false;
            this.dgvPeliculas.Columns["Imagen"].Visible = false;
            this.dgvPeliculas.Columns["Sinopsis"].Visible = false;
            this.dgvPeliculas.Columns["Detalle"].Visible = false;

            dgvPeliculas.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea Salir del Stock?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void notifica()//muestra colores en la grilla de cada uno de las peliculas que haya
        {
            for (int i = 0; i < dgvPeliculas.Rows.Count; i++)
            {
                if ((int.Parse(dgvPeliculas.Rows[i].Cells["Stock"].Value.ToString())) == 0)
                {
                    dgvPeliculas.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    if ((int.Parse(dgvPeliculas.Rows[i].Cells["Stock"].Value.ToString())) < 3)
                    {
                        dgvPeliculas.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvPeliculas.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void refrescar()
        {
            using (DBHD db = new DBHD())
            {
                var lst = from D in db.Peliculas
                          select D;
                dgvPeliculas.DataSource = lst.ToList();
            }
            notifica();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (GetId() != null)
            {
                CargaDatos();

                using (DBHD db = new DBHD())
                {
                    oPelis.Stock = Convert.ToInt32(nudCantidad.Value);
                    db.Entry(oPelis).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("STOCK Actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refrescar();
                }
            }
        }

        private void CargaDatos()
        {
            using (DBHD db = new DBHD())
            {
                oPelis = db.Peliculas.Find(GetId());
            }
            refrescar();
        }

        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nudCantidad.Value = decimal.Parse(dgvPeliculas.CurrentRow.Cells["Stock"].Value.ToString());
        }


        private void tbNombre_KeyUp(object sender, KeyEventArgs e)
        {     
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM Peliculas WHERE Nombre like('" + tbNombre.Text + "%') AND Genero like ('"+tbGenero.Text+"%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgvPeliculas.DataSource = dt;

            conexion.Close();
            notifica();
        }
    }
}
