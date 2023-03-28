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
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Negocio.RecuperarTodos();
            this.GridView1.DataBind();
        }
    }
}