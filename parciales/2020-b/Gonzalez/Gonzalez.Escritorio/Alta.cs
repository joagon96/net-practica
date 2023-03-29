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
    public partial class Alta : Form
    {
        public Alta()
        {
            this.AlumnoNegocio = new Negocio.Alumno();
            this.Validaciones = new Negocio.Validaciones();
            InitializeComponent();
        }

        private Negocio.Alumno _AlumnoNegocio;
        public Negocio.Alumno AlumnoNegocio
        {
            get { return _AlumnoNegocio; }
            set { _AlumnoNegocio = value; }
        }

        private Negocio.Validaciones _Validaciones;
        public Negocio.Validaciones Validaciones
        {
            get { return _Validaciones; }
            set { _Validaciones = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entitdades.Alumno Alumno = new Entitdades.Alumno(
                this.txtApeNom.Text, 
                this.txtDni.Text,
                this.txtEmail.Text,
                this.fechaNacimientoTimePicker.Value,
                this.NotaNumeric.Value);

            if (!this.Validaciones.Validar(Alumno))
            {
                MessageBox.Show("Uno o mas campos son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.AlumnoNegocio.Agregar(Alumno);              
                MessageBox.Show("Alumno registrado con exito", "Alumno Regsitrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CleanForm();
            }
        }

        private void CleanForm()
        {
            this.txtApeNom.Text = string.Empty;
            this.txtDni.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.fechaNacimientoTimePicker.Value = DateTime.Now;
            this.NotaNumeric.Value = 0;
        }
    }
}
