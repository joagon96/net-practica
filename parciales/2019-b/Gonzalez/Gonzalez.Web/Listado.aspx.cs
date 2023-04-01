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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Negocio.Persona persona = new Negocio.Persona();
                this.GridView1.DataSource = persona.RecuperarTodos();
                this.GridView1.DataBind();

                Negocio.TipoPersona tipo = new Negocio.TipoPersona();
                this.DropDownList1.DataSource = tipo.RecuperarTodos();
                this.DropDownList1.DataTextField = "Descripcion";
                this.DropDownList1.DataValueField = "ID";
                this.DropDownList1.DataBind();
            }
        }


        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            Negocio.Persona persona = new Negocio.Persona();
            this.GridView1.DataSource = persona.RecuperarPorTipoPersona(int.Parse(this.DropDownList1.SelectedValue));
            this.GridView1.DataBind();
        }
    }
}