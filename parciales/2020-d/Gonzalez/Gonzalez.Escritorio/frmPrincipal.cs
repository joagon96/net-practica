using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gonzalez.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado Listado = new frmListado();
            Listado.ShowDialog();
        }

        private void recuperarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecuperar Recuperar = new frmRecuperar();
            Recuperar.ShowDialog();
        }
    }
}
