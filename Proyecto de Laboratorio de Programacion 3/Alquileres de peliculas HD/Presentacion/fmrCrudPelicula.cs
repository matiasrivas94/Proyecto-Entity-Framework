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

namespace Alquileres_de_peliculas_HD
{
    public partial class fmrCrudPelicula : Form
    {
        public int? id;
        Peliculas oPelis = null;

        public fmrCrudPelicula(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
        }

        private void fmrAgregarPelicula_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Fondo2;
                pbxFoto.BackgroundImage = Properties.Resources.Fondo3;
            }
            catch
            {
                this.BackgroundImage = null;
            }
         
        }

        private void CargaDatos()
        {
            using (DBHD db = new DBHD())
            {
                oPelis = db.Peliculas.Find(id);

                tbNombre.Text = oPelis.Nombre;
                cbGenero.Text = oPelis.Genero;
                tbPais.Text = oPelis.Pais;
                tbDuracion.Text = oPelis.Duracion.ToString();
                tbSinopsis.Text = oPelis.Sinopsis;

                //Imagen
                MemoryStream ms = new MemoryStream(oPelis.Imagen);
                Bitmap bmp = new Bitmap(ms);
                pbxFoto.Image = bmp;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Salir del Ingreso de la Pelicula?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    if ((tbNombre.Text != string.Empty) && (tbDuracion.Text != string.Empty) && (tbPais.Text != string.Empty) &&
                        (cbGenero.Text != string.Empty) &&(tbSinopsis.Text != string.Empty) && (pbxFoto.Image != null))
                    {
                        //Linq
                        if (id == null)
                        {
                            oPelis = new Peliculas();

                            oPelis.Nombre = tbNombre.Text.ToUpper();
                            oPelis.Genero = cbGenero.Text.ToUpper();
                            oPelis.Pais = tbPais.Text;
                            oPelis.Duracion = Convert.ToInt32(tbDuracion.Text);
                            oPelis.Sinopsis = tbSinopsis.Text;
                            oPelis.Precio = 50;
                            oPelis.Stock = 0;
                            oPelis.Estado = true;

                            //Imagen
                            byte[] file = null;
                            Stream myStream = openFileDialog1.OpenFile();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                myStream.CopyTo(ms);
                                file = ms.ToArray();
                            }
                            oPelis.Imagen = file;

                            db.Peliculas.Add(oPelis);
                            //
                            db.SaveChanges();
                            MessageBox.Show("Se a agregado una nueva pelicula", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else // ACTUALIZAR
                        {
                            oPelis.Nombre = tbNombre.Text.ToUpper();
                            oPelis.Genero = cbGenero.Text.ToUpper();
                            oPelis.Pais = tbPais.Text;
                            oPelis.Duracion = Convert.ToInt32(tbDuracion.Text);
                            oPelis.Sinopsis = tbSinopsis.Text;
                            oPelis.Precio = 50;
                            if (rbAlta.Checked == true)
                                oPelis.Estado = true;
                            else if (rbBaja.Checked == true)
                                oPelis.Estado = false;

                            //IMAGEN
                            byte[] file = null;
                            Stream myStream = openFileDialog1.OpenFile();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                myStream.CopyTo(ms);
                                file = ms.ToArray();
                            }
                            oPelis.Imagen = file;

                            db.Entry(oPelis).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Actualizacion Realizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "PELICULAS";
            openFileDialog1.Title = "Buscar imagen";
            openFileDialog1.Filter = "Archivos jpg(*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

           if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                pbxFoto.Load(openFileDialog1.FileName);
            }
            
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) && !(Char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
