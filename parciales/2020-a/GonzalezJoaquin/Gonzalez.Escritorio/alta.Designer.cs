namespace Gonzalez.Escritorio
{
    partial class Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlAlta = new System.Windows.Forms.TableLayoutPanel();
            this.lblnombreUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlAlta
            // 
            this.tlAlta.ColumnCount = 2;
            this.tlAlta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlAlta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlAlta.Controls.Add(this.lblnombreUsuario, 0, 0);
            this.tlAlta.Controls.Add(this.lblEmail, 0, 1);
            this.tlAlta.Controls.Add(this.lblTipoUsuario, 0, 2);
            this.tlAlta.Controls.Add(this.lblClave, 0, 3);
            this.tlAlta.Controls.Add(this.txtEmail, 1, 1);
            this.tlAlta.Controls.Add(this.txtTipo, 1, 2);
            this.tlAlta.Controls.Add(this.txtClave, 1, 3);
            this.tlAlta.Controls.Add(this.txtNombreUsuario, 1, 0);
            this.tlAlta.Controls.Add(this.btnAceptar, 0, 4);
            this.tlAlta.Controls.Add(this.btnCancelar, 1, 4);
            this.tlAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlta.Location = new System.Drawing.Point(0, 0);
            this.tlAlta.Name = "tlAlta";
            this.tlAlta.RowCount = 5;
            this.tlAlta.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlta.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlta.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlta.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlta.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlta.Size = new System.Drawing.Size(174, 136);
            this.tlAlta.TabIndex = 0;
            // 
            // lblnombreUsuario
            // 
            this.lblnombreUsuario.AutoSize = true;
            this.lblnombreUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblnombreUsuario.Name = "lblnombreUsuario";
            this.lblnombreUsuario.Size = new System.Drawing.Size(80, 13);
            this.lblnombreUsuario.TabIndex = 0;
            this.lblnombreUsuario.Text = "Nomre Usuario: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email: ";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(3, 52);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(73, 13);
            this.lblTipoUsuario.TabIndex = 2;
            this.lblTipoUsuario.Text = "Tipo Usuario: ";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(3, 78);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(40, 13);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave: ";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(90, 3);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(81, 20);
            this.txtNombreUsuario.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(81, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(90, 55);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(81, 20);
            this.txtTipo.TabIndex = 12;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(90, 81);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(81, 20);
            this.txtClave.TabIndex = 13;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 136);
            this.Controls.Add(this.tlAlta);
            this.Name = "Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Alta";
            this.tlAlta.ResumeLayout(false);
            this.tlAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlAlta;
        private System.Windows.Forms.Label lblnombreUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}