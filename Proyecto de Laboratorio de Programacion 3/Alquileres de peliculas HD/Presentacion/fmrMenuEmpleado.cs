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
    public partial class fmrMenuEmpleado : Form
    {
        string user;
        public fmrMenuEmpleado(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void fmrMenuEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Fondo5;
            }
            catch
            {
                this.BackgroundImage = null;
            }
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Tag.ToString() == "1")
                {
                    fmrCrudPelicula CP = new fmrCrudPelicula();
                    CP.ShowDialog();
                }
                else
                {
                    if ((sender as Button).Tag.ToString() == "2")
                    {
                        frmDatosPelicula DP = new frmDatosPelicula();
                        DP.ShowDialog();
                    }
                    else
                    {
                        if ((sender as Button).Tag.ToString() == "3")
                        {
                            frmCrudCliente CC = new frmCrudCliente();
                            CC.ShowDialog();
                        }
                        else
                        {
                            if ((sender as Button).Tag.ToString() == "4")
                            {
                                frmDatosCliente DC = new frmDatosCliente();
                                DC.ShowDialog();
                            }
                            else
                            {
                                if ((sender as Button).Tag.ToString() == "5")
                                {
                                    fmrAlquilarPeliculas ALP = new fmrAlquilarPeliculas();
                                    ALP.ShowDialog();
                                }
                                else
                                {
                                    if ((sender as Button).Tag.ToString() == "6")
                                    {
                                        fmrRegistroDeAlquiler RQ = new fmrRegistroDeAlquiler();
                                        RQ.ShowDialog();
                                    }
                                    else
                                    {
                                        if ((sender as Button).Tag.ToString() == "7")
                                        {
                                            fmrStock ST = new fmrStock();
                                            ST.ShowDialog();
                                        }
                                        else
                                        {
                                            if ((sender as Button).Tag.ToString() == "8")
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " " + "Error Imprevisto");
            }
        }
    }
}
