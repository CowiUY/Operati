namespace BackOffice
{
    partial class BOForm
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
            this.btnUser = new System.Windows.Forms.Button();
            this.btnBanners = new System.Windows.Forms.Button();
            this.btnDeportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUser.Location = new System.Drawing.Point(110, 161);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(172, 83);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Gestion de Usuarios";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBanners
            // 
            this.btnBanners.AutoSize = true;
            this.btnBanners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBanners.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBanners.Location = new System.Drawing.Point(303, 161);
            this.btnBanners.Name = "btnBanners";
            this.btnBanners.Size = new System.Drawing.Size(170, 83);
            this.btnBanners.TabIndex = 1;
            this.btnBanners.Text = "Gestion de Banners";
            this.btnBanners.UseVisualStyleBackColor = false;
            this.btnBanners.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeportes
            // 
            this.btnDeportes.AutoSize = true;
            this.btnDeportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeportes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeportes.Location = new System.Drawing.Point(503, 161);
            this.btnDeportes.Name = "btnDeportes";
            this.btnDeportes.Size = new System.Drawing.Size(172, 83);
            this.btnDeportes.TabIndex = 2;
            this.btnDeportes.Text = "Gestion de deportes";
            this.btnDeportes.UseVisualStyleBackColor = false;
            this.btnDeportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // BOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeportes);
            this.Controls.Add(this.btnBanners);
            this.Controls.Add(this.btnUser);
            this.Name = "BOForm";
            this.Text = "BackOffice";
            this.Load += new System.EventHandler(this.BOForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnBanners;
        private System.Windows.Forms.Button btnDeportes;
    }
}

