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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void Lista_Load(object sender, EventArgs e)
        {
            LoadListaComboBox();
        }

        private void LoadListaComboBox()
        {
            this.cbLista.DataSource = Negocio.Alumno.RecuperarTodos();
            this.cbLista.DisplayMember = "ApellidoNombre";
            this.cbLista.ValueMember = "ID";
        }
    }
}
