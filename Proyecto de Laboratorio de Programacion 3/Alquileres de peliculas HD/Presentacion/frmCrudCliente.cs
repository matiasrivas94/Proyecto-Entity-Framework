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
    public partial class frmCrudCliente : Form
    {
        public int? id;
        Clientes oClient = null;

        public frmCrudCliente(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
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

        private void CargaDatos()
        {
            using (DBHD db = new DBHD())
            {
                oClient = db.Clientes.Find(id);

                tbNombre.Text = oClient.Nombre;
                tbApellido.Text = oClient.Apellido;
                tbDNI.Text = oClient.Dni.ToString();
                tbDireccion.Text = oClient.Direccion;
                tbEmail.Text = oClient.Email;
                tbTelefono.Text = oClient.Celular_Telefono.ToString();
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
                string query = (from c in db.Clientes
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (DBHD db = new DBHD())
            {
                try
                {
                    if ((tbDNI.Text != string.Empty) && (tbNombre.Text != string.Empty) && (tbApellido.Text != string.Empty) && (tbDireccion.Text != string.Empty)
                        && (tbEmail.Text != string.Empty)&& (tbTelefono.Text != string.Empty))
                    {
                        if (tbDNI.TextLength == 8)
                        {
                            bool xdni = controlaDni(Convert.ToInt32(tbDNI.Text));
                            if (xdni == true)
                            {
                                //Linq
                                if (id == null)
                                    oClient = new Clientes();

                                oClient.Nombre = tbNombre.Text.ToUpper();
                                oClient.Apellido = tbApellido.Text.ToUpper();
                                oClient.Dni = Convert.ToInt32(tbDNI.Text);
                                oClient.Direccion = tbDireccion.Text.ToUpper();
                                oClient.Email = tbEmail.Text.ToUpper();
                                oClient.Celular_Telefono = Convert.ToInt32(tbTelefono.Text);
                                oClient.Estado = true;
                                
                                db.Clientes.Add(oClient);
                                db.SaveChanges();

                                MessageBox.Show("Se a agregado un nuevo cliente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (xdni == false)
                                {
                                    oClient.Nombre = tbNombre.Text.ToUpper();
                                    oClient.Apellido = tbApellido.Text.ToUpper();
                                    oClient.Dni = Convert.ToInt32(tbDNI.Text);
                                    oClient.Direccion = tbDireccion.Text.ToUpper();
                                    oClient.Email = tbEmail.Text.ToUpper();
                                    oClient.Celular_Telefono = Convert.ToInt32(tbTelefono.Text);
                                    if (rbAlta.Checked == true)
                                        oClient.Estado = true;
                                    else
                                        oClient.Estado = false;


                                    db.Entry(oClient).State = System.Data.Entity.EntityState.Modified;
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
    }
}
