using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gonzalez.Web
{
    public partial class Listado : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = NegocioAlumno.RecuperarTodos();
            this.GridView1.DataBind();
        }
    }
}