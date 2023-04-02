using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gonzalez.Web
{
    public partial class Alta : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void lBtnAceptar_Click(object sender, EventArgs e)
        {
            Entitdades.Usuario usr = new Entitdades.Usuario(
                this.txtNombreUsuario.Text,
                this.txtEmail.Text,
                this.txtClave.Text,
                int.Parse(this.DropDownList.SelectedValue),
                DateTime.Now
            );

            if (Utiles.Validaciones.EsMailValido(usr.Email))
            {
                Negocio.Usuario.Agregar(usr);
                Page.Response.Write("Usuario Agregado!");
            }
            else
            {
                Page.Response.Write("Mail Invalido");
            }
        }

        protected void lBtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}