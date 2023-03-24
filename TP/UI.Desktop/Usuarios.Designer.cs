namespace UI.Desktop
{
    partial class Usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tbsEditar = new System.Windows.Forms.ToolStripButton();
            this.tbsBorrar = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.usuarioLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioLogicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.tlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.tsUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLogicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLogicBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tlUsuarios);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(702, 232);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(702, 257);
            this.tcUsuarios.TabIndex = 0;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.tsUsuarios);
            // 
            // tlUsuarios
            // 
            this.tlUsuarios.ColumnCount = 2;
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarios.Controls.Add(this.dvgUsuarios, 0, 0);
            this.tlUsuarios.Controls.Add(this.btnActualizar, 0, 1);
            this.tlUsuarios.Controls.Add(this.btnSalir, 1, 1);
            this.tlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlUsuarios.Name = "tlUsuarios";
            this.tlUsuarios.RowCount = 2;
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarios.Size = new System.Drawing.Size(702, 232);
            this.tlUsuarios.TabIndex = 0;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AllowUserToAddRows = false;
            this.dvgUsuarios.AllowUserToDeleteRows = false;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.usuario,
            this.email,
            this.habilitado});
            this.tlUsuarios.SetColumnSpan(this.dvgUsuarios, 2);
            this.dvgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dvgUsuarios.MultiSelect = false;
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUsuarios.Size = new System.Drawing.Size(696, 197);
            this.dvgUsuarios.TabIndex = 0;
            this.dvgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuarios_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "NombreUsuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "Habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(543, 206);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(624, 206);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tbsEditar,
            this.tbsBorrar});
            this.tsUsuarios.Location = new System.Drawing.Point(3, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(112, 25);
            this.tsUsuarios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tbsEditar
            // 
            this.tbsEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsEditar.Image = ((System.Drawing.Image)(resources.GetObject("tbsEditar.Image")));
            this.tbsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsEditar.Name = "tbsEditar";
            this.tbsEditar.Size = new System.Drawing.Size(23, 22);
            this.tbsEditar.Text = "toolStripButton1";
            this.tbsEditar.ToolTipText = "Editar";
            this.tbsEditar.Click += new System.EventHandler(this.tbsEditar_Click);
            // 
            // tbsBorrar
            // 
            this.tbsBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tbsBorrar.Image")));
            this.tbsBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsBorrar.Name = "tbsBorrar";
            this.tbsBorrar.Size = new System.Drawing.Size(23, 22);
            this.tbsBorrar.Text = "toolStripButton1";
            this.tbsBorrar.ToolTipText = "Borrar";
            this.tbsBorrar.Click += new System.EventHandler(this.tbsBorrar_Click);
            // 
            // usuarioLogicBindingSource
            // 
            this.usuarioLogicBindingSource.DataSource = typeof(Business.Logic.UsuarioLogic);
            // 
            // usuarioLogicBindingSource1
            // 
            this.usuarioLogicBindingSource1.DataSource = typeof(Business.Logic.UsuarioLogic);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Business.Entities.Usuario);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 257);
            this.Controls.Add(this.tcUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.tlUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLogicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLogicBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlUsuarios;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.BindingSource usuarioLogicBindingSource1;
        private System.Windows.Forms.BindingSource usuarioLogicBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tbsEditar;
        private System.Windows.Forms.ToolStripButton tbsBorrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
    }
}

