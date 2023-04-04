namespace Gonzalez.Escritorio
{
    partial class Lista
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
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(13, 13);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(121, 21);
            this.cbLista.TabIndex = 0;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 388);
            this.Controls.Add(this.cbLista);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLista;
    }
}