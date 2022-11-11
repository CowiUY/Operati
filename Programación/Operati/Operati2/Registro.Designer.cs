namespace Operati2
{
    partial class Registro
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
            this.btnRegis = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNomUser = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtMailusuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.lblpConfiContra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(162, 216);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(75, 23);
            this.btnRegis.TabIndex = 0;
            this.btnRegis.Text = "Registrarse";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMail.Location = new System.Drawing.Point(35, 26);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Mail";
            // 
            // lblNomUser
            // 
            this.lblNomUser.AutoSize = true;
            this.lblNomUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNomUser.Location = new System.Drawing.Point(35, 65);
            this.lblNomUser.Name = "lblNomUser";
            this.lblNomUser.Size = new System.Drawing.Size(83, 13);
            this.lblNomUser.TabIndex = 2;
            this.lblNomUser.Text = "Nombre Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblContra.Location = new System.Drawing.Point(35, 111);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contraseña";
            // 
            // txtMailusuario
            // 
            this.txtMailusuario.Location = new System.Drawing.Point(162, 26);
            this.txtMailusuario.Name = "txtMailusuario";
            this.txtMailusuario.Size = new System.Drawing.Size(160, 20);
            this.txtMailusuario.TabIndex = 4;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(162, 65);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // txtContraUsuario
            // 
            this.txtContraUsuario.Location = new System.Drawing.Point(162, 111);
            this.txtContraUsuario.Name = "txtContraUsuario";
            this.txtContraUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtContraUsuario.TabIndex = 6;
            this.txtContraUsuario.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(162, 149);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(160, 20);
            this.txtConfirmarContra.TabIndex = 8;
            this.txtConfirmarContra.UseSystemPasswordChar = true;
            // 
            // lblpConfiContra
            // 
            this.lblpConfiContra.AutoSize = true;
            this.lblpConfiContra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblpConfiContra.Location = new System.Drawing.Point(35, 149);
            this.lblpConfiContra.Name = "lblpConfiContra";
            this.lblpConfiContra.Size = new System.Drawing.Size(108, 13);
            this.lblpConfiContra.TabIndex = 7;
            this.lblpConfiContra.Text = "Confirmar Contraseña";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(416, 290);
            this.Controls.Add(this.txtConfirmarContra);
            this.Controls.Add(this.lblpConfiContra);
            this.Controls.Add(this.txtContraUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtMailusuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNomUser);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnRegis);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNomUser;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtMailusuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContraUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Label lblpConfiContra;
    }
}