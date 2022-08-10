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
    public partial class fmrCambiarSesion : Form
    {
        public fmrCambiarSesion()
        {
            InitializeComponent();
        }

        private void btnCerrarSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
