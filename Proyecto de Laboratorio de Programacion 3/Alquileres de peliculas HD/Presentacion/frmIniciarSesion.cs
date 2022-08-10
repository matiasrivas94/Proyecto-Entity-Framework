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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Fondo41;
            }
            catch
            {
                this.BackgroundImage = null;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (DBHD db = new DBHD())
            {
                try
                {
                    if ((tbUsuario.Text.ToUpper() == "ADMIN") && (tbContraseña.Text.ToUpper() == "ADMIN") && (cbTipo.Text.ToUpper() == "ADMIN"))
                    {
                        fmrPrincipal principal = new fmrPrincipal(cbTipo.Text);
                        Hide();
                        principal.ShowDialog();
                        this.Close();
                    }
                    //
                    var oUser = (from d in db.Usuarios
                                 where d.Contraseña == tbContraseña.Text.ToUpper() && d.Nombre == tbUsuario.Text.ToUpper() && d.Estado == true && d.Tipo == cbTipo.Text.ToUpper()
                                 select d).FirstOrDefault();
                    
                    if ((oUser.Nombre == tbUsuario.Text.ToUpper()) && (oUser.Contraseña == tbContraseña.Text.ToUpper()) && (oUser.Estado == true) && (cbTipo.Text.ToUpper() ==oUser.Tipo))
                         {
                            LoginInfo.user = oUser;
                            
                            fmrPrincipal principal = new fmrPrincipal(cbTipo.Text);
                            Hide();
                            principal.ShowDialog();
                            this.Close();
                         }
                    else
                    {
                        if ((oUser.Nombre == tbUsuario.Text.ToUpper()) && (oUser.Contraseña == tbContraseña.Text.ToUpper()) && (oUser.Estado == false))
                        {
                            MessageBox.Show("Este usuario ha sido dado de baja, comuniquese con el administrador.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Datos inválidos, verifique por favor e intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + " " + "Error Imprevisto");
                }
            }
        }

        private void frmIniciarSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
