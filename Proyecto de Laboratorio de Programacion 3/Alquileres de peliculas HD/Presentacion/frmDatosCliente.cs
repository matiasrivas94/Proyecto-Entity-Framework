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
    public partial class frmDatosCliente : Form
    {
        public frmDatosCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¡Se cancelara toda modificacion si no se a guardado!", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDatosCliente_Load(object sender, EventArgs e)
        {
            refrescar();
            this.dgvClientes.Columns["Alquileres"].Visible = false;
            this.dgvClientes.Columns["Id"].Visible = false;

            dgvClientes.ClearSelection();
        }

        private void refrescar()
        {
            using (DBHD db = new DBHD())
            {
                var lst = from D in db.Clientes
                          select D;
                dgvClientes.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrudCliente CC = new frmCrudCliente();
            CC.ShowDialog();

            refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                frmCrudCliente CC = new frmCrudCliente(id);
                CC.gbEstado.Visible = true;
                CC.ShowDialog();

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
                    Clientes oClient = db.Clientes.Find(id);
                    db.Clientes.Remove(oClient);

                    db.SaveChanges();
                }
                refrescar();
            }
        }
    }
}
