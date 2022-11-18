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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOForm));
            this.btnUser = new System.Windows.Forms.Button();
            this.btnBanners = new System.Windows.Forms.Button();
            this.btnDeportes = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.PanelGestion = new System.Windows.Forms.PictureBox();
            this.btnFormequipo = new System.Windows.Forms.Button();
            this.btnFormEncuentro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PanelGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUser.Location = new System.Drawing.Point(302, 74);
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
            this.btnBanners.BackColor = System.Drawing.Color.Transparent;
            this.btnBanners.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBanners.Location = new System.Drawing.Point(506, 74);
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
            this.btnDeportes.BackColor = System.Drawing.Color.Transparent;
            this.btnDeportes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeportes.Location = new System.Drawing.Point(302, 175);
            this.btnDeportes.Name = "btnDeportes";
            this.btnDeportes.Size = new System.Drawing.Size(172, 83);
            this.btnDeportes.TabIndex = 2;
            this.btnDeportes.Text = "Gestion de deportes";
            this.btnDeportes.UseVisualStyleBackColor = false;
            this.btnDeportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.AutoSize = true;
            this.btnEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEventos.Location = new System.Drawing.Point(506, 175);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(172, 83);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Gestion de Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // PanelGestion
            // 
            this.PanelGestion.Location = new System.Drawing.Point(33, 317);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(728, 90);
            this.PanelGestion.TabIndex = 25;
            this.PanelGestion.TabStop = false;
            // 
            // btnFormequipo
            // 
            this.btnFormequipo.AutoSize = true;
            this.btnFormequipo.BackColor = System.Drawing.Color.Transparent;
            this.btnFormequipo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFormequipo.Location = new System.Drawing.Point(112, 175);
            this.btnFormequipo.Name = "btnFormequipo";
            this.btnFormequipo.Size = new System.Drawing.Size(170, 83);
            this.btnFormequipo.TabIndex = 26;
            this.btnFormequipo.Text = "Gestion de Equipos";
            this.btnFormequipo.UseVisualStyleBackColor = false;
            // 
            // btnFormEncuentro
            // 
            this.btnFormEncuentro.AutoSize = true;
            this.btnFormEncuentro.BackColor = System.Drawing.Color.Transparent;
            this.btnFormEncuentro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFormEncuentro.Location = new System.Drawing.Point(112, 74);
            this.btnFormEncuentro.Name = "btnFormEncuentro";
            this.btnFormEncuentro.Size = new System.Drawing.Size(170, 83);
            this.btnFormEncuentro.TabIndex = 27;
            this.btnFormEncuentro.Text = "Gestion de Encuentros";
            this.btnFormEncuentro.UseVisualStyleBackColor = false;
            // 
            // BOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(8)))), ((int)(((byte)(21)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormEncuentro);
            this.Controls.Add(this.btnFormequipo);
            this.Controls.Add(this.PanelGestion);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnDeportes);
            this.Controls.Add(this.btnBanners);
            this.Controls.Add(this.btnUser);
            this.Name = "BOForm";
            this.Text = "BackOffice";
            this.Load += new System.EventHandler(this.BOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnBanners;
        private System.Windows.Forms.Button btnDeportes;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.PictureBox PanelGestion;
        private System.Windows.Forms.Button btnFormequipo;
        private System.Windows.Forms.Button btnFormEncuentro;
    }
}

