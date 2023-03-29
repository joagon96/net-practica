using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gonzalez.Web
{
    public partial class Alumno : System.Web.UI.Page
    {
        private Negocio.Alumno _NegocioAlumno;
        public Negocio.Alumno NegocioAlumno
        {
            get
            {
                if (_NegocioAlumno == null)
                {
                    _NegocioAlumno = new Negocio.Alumno();
                }
                return _NegocioAlumno;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Entitdades.Alumno Alumno = this.NegocioAlumno.RecuperarUno(this.txtDni.Text);
                this.txtApeNom.Text = Alumno.ApellidoNombre;
                this.txtNotaPromedio.Text = Alumno.NotaPromedio.ToString();
                this.txtEmail.Text = Alumno.Email;
                this.txtEdad.Text = Alumno.Edad.ToString();
            }
            catch (Exception ex)
            {
                Page.Response.Write(ex.Message);
            }
        }
    }
}