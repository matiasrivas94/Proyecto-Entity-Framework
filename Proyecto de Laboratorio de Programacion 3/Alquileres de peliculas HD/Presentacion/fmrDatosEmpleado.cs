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
    public partial class fmrDatosEmpleado : Form
    {
        public fmrDatosEmpleado()
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

        private void fmrModificarUsuario_Load(object sender, EventArgs e)
        {
            refrescar();
            this.dgvUsuarios.Columns["Alquileres"].Visible = false;
            this.dgvUsuarios.Columns["Id"].Visible = false;

            dgvUsuarios.ClearSelection();
        }

        private void refrescar()
        {
            using (DBHD db = new DBHD())
            {
                var lst = from D in db.Usuarios
                          select D;
                dgvUsuarios.DataSource = lst.ToList();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null) {
                fmrCrudEmpleado AE = new fmrCrudEmpleado(id);
                AE.gbEstado.Visible = true;
                AE.ShowDialog();

                refrescar();
            }
        }

        private int? GetId() {
            try
            {
                return int.Parse(dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch {
                return null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            fmrCrudEmpleado AE = new fmrCrudEmpleado();
            AE.ShowDialog();

            refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (DBHD db = new DBHD())
                {
                    Usuarios oUser = db.Usuarios.Find(id);
                    db.Usuarios.Remove(oUser);

                    db.SaveChanges();
                }
                refrescar();
            }
        }
    }
}
