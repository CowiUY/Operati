namespace BackOffice
{
    partial class GestionDeBanners
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
            this.PBimagen = new System.Windows.Forms.PictureBox();
            this.btnImportImage = new System.Windows.Forms.Button();
            this.btnAgregoBanner = new System.Windows.Forms.Button();
            this.lblIdBanner = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblTitNom = new System.Windows.Forms.Label();
            this.txtIdBanner = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PBimagen
            // 
            this.PBimagen.BackColor = System.Drawing.Color.Transparent;
            this.PBimagen.Location = new System.Drawing.Point(370, 24);
            this.PBimagen.Name = "PBimagen";
            this.PBimagen.Size = new System.Drawing.Size(418, 298);
            this.PBimagen.TabIndex = 3;
            this.PBimagen.TabStop = false;
            // 
            // btnImportImage
            // 
            this.btnImportImage.Location = new System.Drawing.Point(554, 339);
            this.btnImportImage.Name = "btnImportImage";
            this.btnImportImage.Size = new System.Drawing.Size(75, 23);
            this.btnImportImage.TabIndex = 2;
            this.btnImportImage.Text = "Importar Imagen ";
            this.btnImportImage.UseVisualStyleBackColor = true;
            this.btnImportImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregoBanner
            // 
            this.btnAgregoBanner.Location = new System.Drawing.Point(107, 166);
            this.btnAgregoBanner.Name = "btnAgregoBanner";
            this.btnAgregoBanner.Size = new System.Drawing.Size(128, 23);
            this.btnAgregoBanner.TabIndex = 4;
            this.btnAgregoBanner.Text = "Agregar Banner";
            this.btnAgregoBanner.UseVisualStyleBackColor = true;
            this.btnAgregoBanner.Click += new System.EventHandler(this.btnAgregoBanner_Click);
            // 
            // lblIdBanner
            // 
            this.lblIdBanner.AutoSize = true;
            this.lblIdBanner.Location = new System.Drawing.Point(39, 35);
            this.lblIdBanner.Name = "lblIdBanner";
            this.lblIdBanner.Size = new System.Drawing.Size(52, 13);
            this.lblIdBanner.TabIndex = 5;
            this.lblIdBanner.Text = "id Banner";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(64, 75);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "Link";
            // 
            // lblTitNom
            // 
            this.lblTitNom.AutoSize = true;
            this.lblTitNom.Location = new System.Drawing.Point(9, 118);
            this.lblTitNom.Name = "lblTitNom";
            this.lblTitNom.Size = new System.Drawing.Size(82, 13);
            this.lblTitNom.TabIndex = 7;
            this.lblTitNom.Text = "Titulo o Nombre";
            // 
            // txtIdBanner
            // 
            this.txtIdBanner.Location = new System.Drawing.Point(107, 35);
            this.txtIdBanner.Name = "txtIdBanner";
            this.txtIdBanner.Size = new System.Drawing.Size(235, 20);
            this.txtIdBanner.TabIndex = 9;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(107, 72);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(235, 20);
            this.txtLink.TabIndex = 10;
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(107, 115);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(155, 20);
            this.txtTitulo.TabIndex = 11;
            // 
            // GestionDeBanners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtIdBanner);
            this.Controls.Add(this.lblTitNom);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblIdBanner);
            this.Controls.Add(this.btnAgregoBanner);
            this.Controls.Add(this.PBimagen);
            this.Controls.Add(this.btnImportImage);
            this.Name = "GestionDeBanners";
            this.Text = "GestionDeBanners";
            this.Load += new System.EventHandler(this.GestionDeBanners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBimagen;
        private System.Windows.Forms.Button btnImportImage;
        private System.Windows.Forms.Button btnAgregoBanner;
        private System.Windows.Forms.Label lblIdBanner;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblTitNom;
        private System.Windows.Forms.TextBox txtIdBanner;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}