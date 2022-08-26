namespace BackOffice
{
    partial class APIPublicidad
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
            this.IMGdelBanner = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IMGdelBanner
            // 
            this.IMGdelBanner.Location = new System.Drawing.Point(256, 290);
            this.IMGdelBanner.Name = "IMGdelBanner";
            this.IMGdelBanner.Size = new System.Drawing.Size(75, 23);
            this.IMGdelBanner.TabIndex = 0;
            this.IMGdelBanner.Text = "IMG Banner";
            this.IMGdelBanner.UseVisualStyleBackColor = true;
            this.IMGdelBanner.Click += new System.EventHandler(this.IMGdelBanner_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 266);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // APIPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IMGdelBanner);
            this.Name = "APIPublicidad";
            this.Text = "APIPublicidad";
            this.Load += new System.EventHandler(this.APIPublicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IMGdelBanner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}