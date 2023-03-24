using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : AplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic user = new UsuarioLogic();
            this.UsuarioActual = user.GetOne(ID);
            MapearDeDatos();

        }
        public virtual void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.cbHabilitado.Checked = this.UsuarioActual.Habilitado;

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion) {
                this.btnAceptar.Text = "Guardar";
            }

            if (this.Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }

            if (this.Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

        }
        public virtual void MapearADatos() 
        {
            if (this.Modo == ModoForm.Alta)
            {
                Usuario user = new Usuario();
                this.UsuarioActual = user;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.Habilitado = this.cbHabilitado.Checked;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.State = BusinessEntity.States.New;
            }

            if (this.Modo == ModoForm.Modificacion)
            {
                Usuario user = new Usuario();
                this.UsuarioActual = user;
                this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.Habilitado = this.cbHabilitado.Checked;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.State = BusinessEntity.States.Modified;
            }

            if (this.Modo == ModoForm.Baja)
            {
                this.UsuarioActual.State = BusinessEntity.States.Deleted;
            }

            UsuarioLogic ul = new UsuarioLogic();
            ul.Save(UsuarioActual);
        }
        public virtual void GuardarCambios() 
        {
            MapearADatos();
        }
        public virtual bool Validar() 
        {
            if (this.txtNombre.Text.Length == 0 ||
                this.txtApellido.Text.Length == 0 ||
                this.txtEmail.Text.Length == 0 ||
                this.txtUsuario.Text.Length == 0)
            {
                return false;
            }

            if (this.txtClave.Text != this.txtConfirmarClave.Text)
            {
                return false;
            }

            if (this.txtClave.Text.Length <8)
            {
                return false;
            }
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            return Regex.IsMatch(this.txtEmail.Text, regex, RegexOptions.IgnoreCase);
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void tlUsuarioDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private Usuario _UsuarioActual;
        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Notificar("OK", "El Usuario se proceso con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Notificar("Error","uno o mas parametros son invalidos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
