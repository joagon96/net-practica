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
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            this.dataGridView1.DataSource = Negocio.Usuario.RecuperarTodos();
        }

        private void toolStripButtondelete_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = ((Entitdades.Usuario)this.dataGridView1.SelectedRows[0].DataBoundItem).NombreUsuario;
                Negocio.Usuario.Eliminar(nombreUsuario);
                this.LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
