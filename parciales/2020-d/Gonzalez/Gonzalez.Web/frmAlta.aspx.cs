using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gonzalez.Web
{
    public partial class frmAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkBtnCancelar_Click(object sender, EventArgs e)
        {
            this.txtID.Text = string.Empty;
            this.txtCuil.Text = string.Empty;
            this.txtApeNom.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.calFechaIngreso.SelectedDate = DateTime.Now;
            this.txtSalario.Text = string.Empty;
        }

        protected void linkBtnAceptar_Click(object sender, EventArgs e)
        {
            Negocio.Docente negocio = new Negocio.Docente();
            Entidades.Docente docente = new Entidades.Docente(
                this.txtApeNom.Text,
                this.txtCuil.Text,
                this.txtEmail.Text,
                this.calFechaIngreso.SelectedDate,
                int.Parse(this.txtID.Text),
                decimal.Parse(this.txtSalario.Text));
            if (Negocio.Validaciones.EsCuilValido(docente.Cuil))
            {
                negocio.Agregar(docente);
                Page.Response.Write("Docente registrado con exito");
            }
            else
            {
                Page.Response.Write("Cuil invalido");
            }

        }
    }
}