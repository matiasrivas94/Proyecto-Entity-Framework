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
    public partial class fmrPrincipal : Form
    {
        string tipo;

        public fmrPrincipal(string usuario)
        {
            InitializeComponent();

            this.tipo = usuario; ;
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Principal;
            }
            catch
            {
                this.BackgroundImage = null;
            }

            if (tipo == "ADMIN")
            {
                btnAdministrador.Enabled = true;
                btnEmpleado.Enabled = false;
            }
            else if (tipo == "EMPLEADO")
            {
                btnAdministrador.Enabled = false;
                btnEmpleado.Enabled = true;
            }

            MessageBox.Show("BIENVENIDO" + " "+ LoginInfo.user.Nombre);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Tag.ToString() == "2")
                {
                    fmrMenuAdmin admi = new fmrMenuAdmin(tipo);
                    admi.ShowDialog();
                }
                else
                {
                    if ((sender as Button).Tag.ToString() == "1")
                    {
                        fmrMenuEmpleado stock = new fmrMenuEmpleado(tipo);
                        stock.ShowDialog();
                    }
                    else
                    {
                        if ((sender as Button).Tag.ToString() == "3")
                        {
                            fmrCambiarSesion sesion = new fmrCambiarSesion();
                            sesion.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " " + "Error Imprevisto");
            }
        }
    }
}
