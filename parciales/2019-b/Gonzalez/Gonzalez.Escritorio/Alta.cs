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
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Entidades.Persona persona = new Entidades.Persona(
                this.txtApellido.Text,
                this.txtNombre.Text,
                this.txtEmail.Text,
                this.dateTimePicker.Value,
                int.Parse(this.comboBoxTipos.GetItemText(this.comboBoxTipos.SelectedValue)));

            if (Negocio.Validaciones.Requeridos(persona) && Negocio.Validaciones.EsFechaNacimientoValida(persona.FechaNacimiento)) 
            {
                Negocio.Persona personaNegocio = new Negocio.Persona();
                personaNegocio.Agregar(persona);
            }
            else
            {
                MessageBox.Show("uno o mas campos no son invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            Negocio.TipoPersona tipoNegocio = new Negocio.TipoPersona();
            this.comboBoxTipos.DataSource = tipoNegocio.RecuperarTodos();
            this.comboBoxTipos.DisplayMember = "Descripcion";
            this.comboBoxTipos.ValueMember = "ID";
        }
    }
}
