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
    public partial class fmrCrudEmpleado : Form
    {
        public int? id;
        Usuarios oUsers = null;

        public fmrCrudEmpleado(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null) {
                CargaDatos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Cancelar el ingreso de un nuevo empleado?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (DBHD db = new DBHD())
            {
                try
                {
                    //AGREGAR
                    if ((tbDNI.Text != string.Empty) && (tbUsuario.Text != string.Empty) && (tbContraseña.Text != string.Empty) && (cbTipo.Text != string.Empty))
                    {
                        if (tbDNI.TextLength == 8)
                        {
                            bool xdni = controlaDni(Convert.ToInt32(tbDNI.Text));
                            if (xdni == true)
                            {
                                //Linq
                                if (id == null)
                                    oUsers = new Usuarios();

                                oUsers.Nombre = tbUsuario.Text.ToUpper();
                                oUsers.Contraseña = tbContraseña.Text.ToUpper();
                                oUsers.Dni = Convert.ToInt32(tbDNI.Text);
                                oUsers.Tipo = cbTipo.SelectedItem.ToString();
                                oUsers.Estado = true;
                               
                                db.Usuarios.Add(oUsers);
                                db.SaveChanges();

                                MessageBox.Show("Se a agregado un nuevo empleado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                             }
                        else
                        {
                            //ACTUALIZAR
                            if (xdni == false)
                            {
                               oUsers.Nombre = tbUsuario.Text.ToUpper();
                               oUsers.Contraseña = tbContraseña.Text.ToUpper();
                               oUsers.Dni = Convert.ToInt32(tbDNI.Text);
                               oUsers.Tipo = cbTipo.SelectedItem.ToString();
                               if (rbAlta.Checked == true)
                                    oUsers.Estado = true;
                               else
                                    oUsers.Estado = false;
                            
                               db.Entry(oUsers).State = System.Data.Entity.EntityState.Modified;
                               db.SaveChanges();

                               MessageBox.Show("Actulizacion Realizada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                               this.Close();
                           }
                        }
                     }
                     else
                    {
                        MessageBox.Show("El DNI ingresado no es válido, debe tener 8 caracteres", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                  }
                  else
                  {
                     MessageBox.Show("Hay campos sin completar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + " " + "Error Imprevisto");
                    MessageBox.Show("Puede que el DNI ya este ingresado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargaDatos()
        {
            using (DBHD db = new DBHD())
            {
                oUsers = db.Usuarios.Find(id);

                tbUsuario.Text = oUsers.Nombre;
                tbContraseña.Text = oUsers.Contraseña;
                tbDNI.Text = oUsers.Dni.ToString();
                cbTipo.Text = oUsers.Tipo;
            }
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((tbDNI.MaxLength == 8))
            {
                char ch = e.KeyChar;
                if (!Char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }
        }

        public bool controlaDni(int dni)
        {
            using (DBHD db = new DBHD())
            {
                string query = (from c in db.Usuarios
                                where c.Dni == dni
                                select c.Nombre).FirstOrDefault();
                if (query != null)
                {
                    return false;
                }
                else
                    return true;
            }
        }
    }
}
