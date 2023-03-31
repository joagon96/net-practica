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
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Docente negocio = new Negocio.Docente();
                Entidades.Docente docente = negocio.RecuperarUno(this.txtCuil.Text);
                this.txtID.Text = docente.id.ToString();
                this.txtApeNom.Text = docente.ApellidoNombre;
                this.txtEmail.Text = docente.Email;
                this.txtFechaIngreso.Text = docente.FechaIngreso.ToString();
                this.txtSalario.Text = docente.Salario.ToString();
                this.txtAntiguedad.Text = docente.Antiguedad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
