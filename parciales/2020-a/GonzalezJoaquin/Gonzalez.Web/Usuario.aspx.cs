using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gonzalez.Web
{
    public partial class Usuario : System.Web.UI.Page
    {
        private Negocio.Usuario _Negocio;
        public Negocio.Usuario Negocio
        {
            get
            {
                if (_Negocio == null)
                {
                    _Negocio = new Negocio.Usuario();
                }
                return _Negocio;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Entitdades.Usuario usr = this.Negocio.RecuperarUno(this.txtNombreUsuario.Text);
                this.txtEmail.Text = usr.Email;
                this.txtTipoUsuario.Text = usr.TipoUsuario.ToString();
                this.txtUltimoIngreso.Text = usr.UltimoIngreso.ToString();
            }
            catch(Exception ex)
            {
                Page.Response.Write("Nombre de usuario invalido");
            }
        }
    }
}