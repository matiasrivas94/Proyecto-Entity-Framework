using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquileres_de_peliculas_HD
{
    public partial class fmrMenuAdmin : Form
    {
        string user;
        public fmrMenuAdmin(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void fmrMenuAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Fondo;
            }
            catch
            {
                this.BackgroundImage = null;
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Tag.ToString() == "1")
                {
                    fmrCrudEmpleado CE = new fmrCrudEmpleado();
                    CE.ShowDialog();
                }
                else
                {
                    if ((sender as Button).Tag.ToString() == "2")
                    {
                        fmrDatosEmpleado DE = new fmrDatosEmpleado();
                        DE.ShowDialog();
                    }
                    else
                    {
                        if ((sender as Button).Tag.ToString() == "3")
                        {
                            fmrCrudPelicula CP = new fmrCrudPelicula();
                            CP.ShowDialog();
                        }
                        else
                        {
                            if ((sender as Button).Tag.ToString() == "4")
                            {
                                frmDatosPelicula DP = new frmDatosPelicula();
                                DP.ShowDialog();
                            }
                            else
                            {
                                if ((sender as Button).Tag.ToString() == "5")
                                {
                                    frmCrudCliente CC = new frmCrudCliente();
                                    CC.ShowDialog();
                                }
                                else
                                {
                                    if ((sender as Button).Tag.ToString() == "6")
                                    {
                                        frmDatosCliente DC = new frmDatosCliente();
                                        DC.ShowDialog();
                                    }
                                    else
                                    {
                                       if ((sender as Button).Tag.ToString() == "7")
                                        {
                                            fmrAlquilarPeliculas AP = new fmrAlquilarPeliculas();
                                            AP.ShowDialog();
                                        }
                                        else
                                        {
                                            if ((sender as Button).Tag.ToString() == "8")
                                            {
                                                fmrRegistroDeAlquiler RA = new fmrRegistroDeAlquiler();
                                                RA.ShowDialog();
                                            }
                                            else
                                            {
                                                if ((sender as Button).Tag.ToString() == "9")
                                                {
                                                    fmrStock ST = new fmrStock();
                                                    ST.ShowDialog();
                                                }
                                                else
                                                {
                                                    if ((sender as Button).Tag.ToString() == "10")
                                                    {
                                                        var result = MessageBox.Show("¿Volver al menu anterior?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                                        if (result == DialogResult.Yes)
                                                        {
                                                            this.Close();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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
