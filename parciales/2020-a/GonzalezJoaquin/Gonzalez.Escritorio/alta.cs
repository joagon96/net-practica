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

        private Negocio.Usuario _UsuarioNegocio;
        public Negocio.Usuario UsuarioNegocio
        {
            get { return _UsuarioNegocio; }
            set { _UsuarioNegocio = value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Entitdades.Usuario usr = new Entitdades.Usuario();
            usr.NombreUsuario = this.txtNombreUsuario.Text;
            usr.Email = this.txtNombreUsuario.Text;
            usr.TipoUsuario = int.Parse(this.txtTipo.Text);
            usr.Clave = this.txtClave.Text;

            Agregar(usr);
        }

        private void Agregar(Entitdades.Usuario usr)
        {
            this.UsuarioNegocio = new Negocio.Usuario();
            if (this.UsuarioNegocio.validaciones(usr))
            {
                this.UsuarioNegocio.Agregar(usr);
                MessageBox.Show("Usuario Agregado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El mail no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
