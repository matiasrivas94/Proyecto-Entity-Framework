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
using System.Data.SqlClient;
using Alquileres_de_peliculas_HD.Presentacion;

namespace Alquileres_de_peliculas_HD
{
    public partial class fmrRegistroDeAlquiler : Form
    {
        public fmrRegistroDeAlquiler()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=AlquilerHD;Integrated Security=True");

        private void fmrRegistroDeAlquiler_Load(object sender, EventArgs e)
        {
            refrescar();
            this.dgvRegistro.Columns["Usuarios"].Visible = false;
            this.dgvRegistro.Columns["Clientes"].Visible = false;
            this.dgvRegistro.Columns["Detalle"].Visible = false;
            this.dgvRegistro.Columns["Pagos"].Visible = false;
            this.dgvRegistro.Columns["Id"].Visible = false;
            TOTAL();
            controldefechas();
        }

        private void refrescar()
        {
            using (DBHD db = new DBHD())
            {
                var lst = from D in db.Alquileres
                          where D.Estado == true
                          select D;
                dgvRegistro.DataSource = lst.ToList();
            }
        }

        public void TOTAL()
        {
            int x = 0;
            for (int i = 0; i < dgvRegistro.Rows.Count; i++)
            {
                x = x + Convert.ToInt32(dgvRegistro.Rows[i].Cells["Total"].Value);
            }
            tbTotal.Text = x.ToString() + "$";
        }

        public void controldefechas()
        {
            int inter = 20;
            int a = dgvRegistro.Rows.Count;
            int b = dgvPeliculas.Rows.Count;

            for (int i = 0; i < dgvRegistro.Rows.Count; i++)
            {
                DateTime fechaAhora = DateTime.Now.Date;
                DateTime peli = Convert.ToDateTime(dgvRegistro.Rows[i].Cells["FechaDevolucion"].Value).Date;
                int resul = fechaAhora.CompareTo(peli);

                if (resul == 0)
                {
                    dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (resul < 0)
                {
                    dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (resul > 0)
                {
                    dgvRegistro.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    if (dgvRegistro.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                    {
                        tbInteres.Text = Convert.ToString(b * inter);
                    }
                }
            }
        }

        private void dgvRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            using (DBHD db = new DBHD())
            {
                try
                {
                    int a = int.Parse(dgvRegistro.Rows[dgvRegistro.CurrentRow.Index].Cells[0].Value.ToString());
                    var lst = from D in db.Detalle
                              from P in db.Peliculas
                              where D.FK_id_alquileres == a && P.id == D.FK_id_peliculas
                              select P;
                    dgvPeliculas.DataSource = lst.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + " " + "Error Imprevisto");
                }

            }
            this.dgvPeliculas.Columns["Id"].Visible = false;
            this.dgvPeliculas.Columns["Precio"].Visible = false;
            this.dgvPeliculas.Columns["Imagen"].Visible = false;
            this.dgvPeliculas.Columns["Stock"].Visible = false;
            this.dgvPeliculas.Columns["Detalle"].Visible = false;
            controldefechas();
          }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            CrystalReport CR = new CrystalReport();
            CR.ShowDialog();
        }
    }
}