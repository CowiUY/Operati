namespace BackOffice
{
    partial class GestionDeUsuarios
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
            this.txtSeleccionePOP = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSeleccionePOP
            // 
            this.txtSeleccionePOP.AutoSize = true;
            this.txtSeleccionePOP.Location = new System.Drawing.Point(131, 259);
            this.txtSeleccionePOP.Name = "txtSeleccionePOP";
            this.txtSeleccionePOP.Size = new System.Drawing.Size(199, 13);
            this.txtSeleccionePOP.TabIndex = 15;
            this.txtSeleccionePOP.Text = "SELECCIONE LA OPCION QUE DESEE";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Location = new System.Drawing.Point(287, 183);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(61, 13);
            this.txtContraseña.TabIndex = 14;
            this.txtContraseña.Text = "Contraseña";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(287, 157);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(287, 130);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(375, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 11;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(375, 176);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(375, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(355, 254);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarUsuario.TabIndex = 8;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSeleccionePOP);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Name = "GestionDeUsuarios";
            this.Text = "GestionDeUsuarios";
            this.Load += new System.EventHandler(this.GestionDeUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSeleccionePOP;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
    }
}