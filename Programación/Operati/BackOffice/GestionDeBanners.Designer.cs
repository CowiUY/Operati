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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImportImage = new System.Windows.Forms.Button();
            this.btnAgregoBanner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdBanner = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(370, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 298);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id Banner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo o Nombre";
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregoBanner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImportImage);
            this.Name = "GestionDeBanners";
            this.Text = "GestionDeBanners";
            this.Load += new System.EventHandler(this.GestionDeBanners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImportImage;
        private System.Windows.Forms.Button btnAgregoBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdBanner;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}