namespace Operati2
{
    partial class Login
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
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegisto = new System.Windows.Forms.Button();
            this.lblNOCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblContraseña.Location = new System.Drawing.Point(39, 104);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblUser.Location = new System.Drawing.Point(57, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Usuario";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(161, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 25);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(116, 101);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(227, 20);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(116, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblmail.Location = new System.Drawing.Point(74, 72);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(26, 13);
            this.lblmail.TabIndex = 11;
            this.lblmail.Text = "Mail";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(116, 69);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(227, 20);
            this.TxtMail.TabIndex = 10;
            this.TxtMail.TextChanged += new System.EventHandler(this.TxtMail_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(341, 231);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegisto
            // 
            this.btnRegisto.Location = new System.Drawing.Point(25, 231);
            this.btnRegisto.Name = "btnRegisto";
            this.btnRegisto.Size = new System.Drawing.Size(131, 23);
            this.btnRegisto.TabIndex = 13;
            this.btnRegisto.Text = "Registrate Aqui";
            this.btnRegisto.UseVisualStyleBackColor = true;
            this.btnRegisto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNOCuenta
            // 
            this.lblNOCuenta.AutoSize = true;
            this.lblNOCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNOCuenta.Location = new System.Drawing.Point(39, 203);
            this.lblNOCuenta.Name = "lblNOCuenta";
            this.lblNOCuenta.Size = new System.Drawing.Size(100, 13);
            this.lblNOCuenta.TabIndex = 14;
            this.lblNOCuenta.Text = "¿No tienes cuenta?";
            this.lblNOCuenta.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(432, 274);
            this.Controls.Add(this.lblNOCuenta);
            this.Controls.Add(this.btnRegisto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegisto;
        private System.Windows.Forms.Label lblNOCuenta;
    }
}