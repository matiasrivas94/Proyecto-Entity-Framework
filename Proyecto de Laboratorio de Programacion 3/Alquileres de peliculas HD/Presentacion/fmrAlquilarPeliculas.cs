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
using System.Collections;
using System.IO;

namespace Alquileres_de_peliculas_HD
{
    public partial class fmrAlquilarPeliculas : Form
    {               
        public fmrAlquilarPeliculas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea Salir del Alquiler?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fmrAlquilarPeliculas_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Fondo41;
            }
            catch
            {
                this.BackgroundImage = null;
            }

            refrescarclientes();
            this.dgvClientes.Columns["Alquileres"].Visible = false;
            this.dgvClientes.Columns["Id"].Visible = false;    
            this.dgvClientes.Columns["Estado"].Visible = false;

            refrescarpeliculas();

            dgvClientes.ClearSelection();
            dgvAgregarPeli.ClearSelection();
            dgvQuitarPeli.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = dgvAgregarPeli.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvAgregarPeli.Rows[i];
                if (Convert.ToBoolean(row.Cells["Column1"].Value))
                {
                    peliculasBindingSource1.Add((Peliculas)row.DataBoundItem);
                    peliculasBindingSource.RemoveAt(row.Index);
                }
                controlMas();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            for (int i = dgvQuitarPeli.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvQuitarPeli.Rows[i];
                if (Convert.ToBoolean(row.Cells["Column2"].Value))
                {
                    peliculasBindingSource.Add((Peliculas)row.DataBoundItem);
                    peliculasBindingSource1.RemoveAt(row.Index);
                }
            }
            controlMenos();
        }

        private void controlMas()
        {
            int a = 50;
            int cantidad = Convert.ToInt32(dgvQuitarPeli.Rows.Count);
            tbTotal.Text = Convert.ToString(a * cantidad);
            dtpEntrega.Value = dtpEntrega.Value;
            dtpRegreso.Value = dtpEntrega.Value.AddDays(cantidad);
        }

        private void controlMenos()
        {
            int a = Convert.ToInt32(tbTotal.Text);
            int b = a - 50;
            tbTotal.Text = Convert.ToString(b);
            dtpRegreso.Value = dtpRegreso.Value.AddDays(-1);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (tbClienteDNI.Text != string.Empty && tbClienteApellido.Text != string.Empty && tbClientenombre.Text != string.Empty && cboFormaPago.Text != string.Empty)
            {
                int cantidad = Convert.ToInt32(dgvQuitarPeli.Rows.Count);
                if (cantidad <= 6 && cantidad != 0)
                {
                    using (DBHD db = new DBHD())
                    {
                        try
                        {
                            Detalle oDetalle = null; ;
                            Alquileres oAlq = new Alquileres();

                            oAlq.FechaEntrega = dtpEntrega.Value;
                            oAlq.FechaDevolucion = dtpRegreso.Value;
                            oAlq.Total = Convert.ToInt32(tbTotal.Text);
                            oAlq.Estado = true;

                            oAlq.FK_id_cliente = ((Clientes)dgvClientes.Rows[dgvClientes.CurrentRow.Index].DataBoundItem).id;
                            oAlq.FK_id_usuario = LoginInfo.user.id;

                            db.Alquileres.Add(oAlq);
                            db.SaveChanges();                    

                            foreach (DataGridViewRow r in dgvQuitarPeli.Rows)
                            {
                               oDetalle = new Detalle();

                               oDetalle.FK_id_peliculas = ((Peliculas)r.DataBoundItem).id;
                               oDetalle.FK_id_alquileres = oAlq.id;

                                Peliculas oPelis = (Peliculas)r.DataBoundItem;
                                oPelis.Stock--;
                                db.Entry(oPelis).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                db.Detalle.Add(oDetalle);
                                db.SaveChanges();
                            }

                            Pagos oPagos = new Pagos();

                            oPagos.tipo = cboFormaPago.Text;
                            oPagos.monto = Convert.ToInt32(tbTotal.Text);
                            oPagos.FK_id_Alquiler = oAlq.id;

                            db.Pagos.Add(oPagos);
                            db.SaveChanges();

                            MessageBox.Show("Se a ingresado un Alquiler", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refrescarpeliculas();

                            dgvQuitarPeli.Rows.Clear();

                            tbClienteApellido.Clear();
                            tbClienteDNI.Clear();
                            tbClientenombre.Clear();
                            tbTotal.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.InnerException.ToString() + " " + "Error Imprevisto");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("5 Peliculas como maximo");
                }
            }
            else
            {
                MessageBox.Show("Complete los datos del cliente Cliente");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmCrudCliente CC = new frmCrudCliente();
            CC.ShowDialog();

            refrescarclientes();
        }

        private void refrescarclientes()
        {
            using (DBHD db = new DBHD())
            {
                var lst = from D in db.Clientes
                          where D.Estado == true
                          select D;
                dgvClientes.DataSource = lst.ToList();
            }
        }

        private void refrescarpeliculas() {
            using (DBHD db = new DBHD())
            {

                var lst = from D in db.Peliculas
                          where D.Stock > 0 && D.Estado == true
                          select D;
                peliculasBindingSource.DataSource = lst.ToList();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbClienteDNI.Text = dgvClientes.CurrentRow.Cells["Dni"].Value.ToString();
            tbClienteApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
            tbClientenombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
        }
    }
}
