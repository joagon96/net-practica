using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        private UsuarioLogic _Logic;
        public UsuarioLogic Logic
        {
            get
            {
                if(_Logic == null)
                {
                    _Logic = new UsuarioLogic();
                }
                return _Logic;
            }
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private Usuario Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = Entity.Nombre;
            this.apellidoTextBox.Text = Entity.Apellido;
            this.emailTextBox.Text = Entity.Email;
            this.nombreUsuarioTextBox.Text = Entity.NombreUsuario;
            this.habilitadoCheckBox.Checked = Entity.Habilitado;
        }

        private void LoadEntity(Usuario user)
        {
            user.Nombre = this.nombreTextBox.Text;
            user.Apellido = this.apellidoTextBox.Text;
            user.Email = this.emailTextBox.Text;
            user.NombreUsuario = this.nombreUsuarioTextBox.Text;
            user.Habilitado = this.habilitadoCheckBox.Checked;
            user.Clave = this.claveTextBox.Text;
        }

        private void SaveEntity(Usuario user)
        {
            Logic.Save(user);
        }

        private void DeleteEntity(int id)
        {
            Logic.Delete(id);
        }

        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.habilitadoCheckBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                LoadForm(SelectedID);
            }
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                switch (this.FormMode)
                {
                    case FormModes.Modificacion:
                        this.Entity = new Usuario();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(Entity);
                        this.SaveEntity(Entity);
                        break;
                    case FormModes.Baja:
                        this.DeleteEntity(this.SelectedID);
                        break;
                    case FormModes.Alta:
                        this.Entity = new Usuario();
                        this.LoadEntity(Entity);
                        this.SaveEntity(Entity);
                        break;
                    default:
                        break;

                }
                this.LoadGrid();
                this.formPanel.Visible = false;
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                LoadForm(SelectedID);
            }
        }

        protected void nuevorLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.nombreUsuarioTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            this.ClearForm();
            this.formPanel.Visible = false;
        }
    }
}