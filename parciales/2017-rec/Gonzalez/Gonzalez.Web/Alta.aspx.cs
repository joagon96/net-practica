using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gonzalez.Web
{
    public partial class Alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnAceptar_Click(object sender, EventArgs e)
        {
            Entidades.Alumno alumno = new Entidades.Alumno(
                this.txtNombreApellido.Text,
                this.txtDni.Text,
                this.txtEmail.Text,
                decimal.Parse(this.txtNota.Text),
                this.Calendar.SelectedDate);

            if (Utiles.Validaciones.EsFechaDeNacimientoValida(alumno.FechaNacimiento))
            {
                Negocio.Alumno.Agregar(alumno);
                Page.Response.Write("Alumno Registrado");
            }
            else
            {
                Page.Response.Write("Fecha de Nacimiento Invalida");
            }
        }

        protected void lbtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}