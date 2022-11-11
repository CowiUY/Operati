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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeBanners));
            this.PBimagen = new System.Windows.Forms.PictureBox();
            this.btnImportImage = new System.Windows.Forms.Button();
            this.btnAgregoBanner = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblTitNom = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PBimagen
            // 
            this.PBimagen.BackColor = System.Drawing.Color.Transparent;
            this.PBimagen.Location = new System.Drawing.Point(58, 80);
            this.PBimagen.Name = "PBimagen";
            this.PBimagen.Size = new System.Drawing.Size(446, 268);
            this.PBimagen.TabIndex = 3;
            this.PBimagen.TabStop = false;
            this.PBimagen.Click += new System.EventHandler(this.PBimagen_Click);
            // 
            // btnImportImage
            // 
            this.btnImportImage.Location = new System.Drawing.Point(125, 26);
            this.btnImportImage.Name = "btnImportImage";
            this.btnImportImage.Size = new System.Drawing.Size(336, 31);
            this.btnImportImage.TabIndex = 2;
            this.btnImportImage.Text = "Importar Imagen ";
            this.btnImportImage.UseVisualStyleBackColor = true;
            this.btnImportImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregoBanner
            // 
            this.btnAgregoBanner.Location = new System.Drawing.Point(242, 455);
            this.btnAgregoBanner.Name = "btnAgregoBanner";
            this.btnAgregoBanner.Size = new System.Drawing.Size(115, 55);
            this.btnAgregoBanner.TabIndex = 4;
            this.btnAgregoBanner.Text = "Agregar Banner";
            this.btnAgregoBanner.UseVisualStyleBackColor = true;
            this.btnAgregoBanner.Click += new System.EventHandler(this.btnAgregoBanner_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(154, 371);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "Link";
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // lblTitNom
            // 
            this.lblTitNom.AutoSize = true;
            this.lblTitNom.Location = new System.Drawing.Point(99, 414);
            this.lblTitNom.Name = "lblTitNom";
            this.lblTitNom.Size = new System.Drawing.Size(82, 13);
            this.lblTitNom.TabIndex = 7;
            this.lblTitNom.Text = "Titulo o Nombre";
            this.lblTitNom.Click += new System.EventHandler(this.lblTitNom_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(197, 368);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(244, 20);
            this.txtLink.TabIndex = 10;
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(197, 411);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(244, 20);
            this.txtTitulo.TabIndex = 11;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(78, 551);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionDeBanners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 640);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblTitNom);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnAgregoBanner);
            this.Controls.Add(this.PBimagen);
            this.Controls.Add(this.btnImportImage);
            this.Name = "GestionDeBanners";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GestionDeBanners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBimagen;
        private System.Windows.Forms.Button btnImportImage;
        private System.Windows.Forms.Button btnAgregoBanner;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblTitNom;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
    }
}