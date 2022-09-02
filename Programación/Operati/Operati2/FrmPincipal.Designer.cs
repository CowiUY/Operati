namespace Operati2
{
    partial class Frmuno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmuno));
            this.panPanel = new System.Windows.Forms.Panel();
            this.btnMotor = new System.Windows.Forms.ComboBox();
            this.btnBasket = new System.Windows.Forms.ComboBox();
            this.btnPoli = new System.Windows.Forms.ComboBox();
            this.btnFubtol = new System.Windows.Forms.ComboBox();
            this.btnIdioma = new System.Windows.Forms.ComboBox();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panPanel
            // 
            this.panPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panPanel.Controls.Add(this.btnMotor);
            this.panPanel.Controls.Add(this.btnBasket);
            this.panPanel.Controls.Add(this.btnPoli);
            this.panPanel.Controls.Add(this.btnFubtol);
            this.panPanel.Controls.Add(this.btnIdioma);
            this.panPanel.Controls.Add(this.Imagen);
            this.panPanel.Controls.Add(this.btnConfig);
            this.panPanel.Controls.Add(this.btnLogin);
            this.panPanel.Controls.Add(this.btnBuscar);
            this.panPanel.Controls.Add(this.btnMas);
            this.panPanel.Location = new System.Drawing.Point(-3, -10);
            this.panPanel.Name = "panPanel";
            this.panPanel.Size = new System.Drawing.Size(1011, 113);
            this.panPanel.TabIndex = 22;
            // 
            // btnMotor
            // 
            this.btnMotor.FormattingEnabled = true;
            this.btnMotor.Location = new System.Drawing.Point(550, 30);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Size = new System.Drawing.Size(109, 21);
            this.btnMotor.TabIndex = 4;
            this.btnMotor.Text = "MOTOR";
            this.btnMotor.UseWaitCursor = true;
            // 
            // btnBasket
            // 
            this.btnBasket.FormattingEnabled = true;
            this.btnBasket.Location = new System.Drawing.Point(435, 30);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(109, 21);
            this.btnBasket.TabIndex = 5;
            this.btnBasket.Text = "BALONCESTO";
            this.btnBasket.UseWaitCursor = true;
            // 
            // btnPoli
            // 
            this.btnPoli.FormattingEnabled = true;
            this.btnPoli.Location = new System.Drawing.Point(320, 30);
            this.btnPoli.Name = "btnPoli";
            this.btnPoli.Size = new System.Drawing.Size(109, 21);
            this.btnPoli.TabIndex = 3;
            this.btnPoli.Text = "POLIDEPORTIVO";
            this.btnPoli.UseWaitCursor = true;
            // 
            // btnFubtol
            // 
            this.btnFubtol.FormattingEnabled = true;
            this.btnFubtol.Location = new System.Drawing.Point(205, 30);
            this.btnFubtol.Name = "btnFubtol";
            this.btnFubtol.Size = new System.Drawing.Size(109, 21);
            this.btnFubtol.TabIndex = 2;
            this.btnFubtol.Text = "FUTBOL";
            this.btnFubtol.UseWaitCursor = true;
            // 
            // btnIdioma
            // 
            this.btnIdioma.FormattingEnabled = true;
            this.btnIdioma.Items.AddRange(new object[] {
            "ESP",
            "EN "});
            this.btnIdioma.Location = new System.Drawing.Point(117, 30);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(69, 21);
            this.btnIdioma.TabIndex = 0;
            this.btnIdioma.Text = "IDIOMA";
            this.btnIdioma.UseWaitCursor = true;
            // 
            // Imagen
            // 
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(-178, -54);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(472, 231);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen.TabIndex = 17;
            this.Imagen.TabStop = false;
            this.Imagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(933, 61);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(52, 33);
            this.btnConfig.TabIndex = 16;
            this.btnConfig.Text = "⚙️";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(871, 32);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login / Sign in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(690, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 21);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar 🔍︎ ";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMas
            // 
            this.btnMas.FormattingEnabled = true;
            this.btnMas.Location = new System.Drawing.Point(760, 32);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(74, 21);
            this.btnMas.TabIndex = 6;
            this.btnMas.Text = "MAS +";
            this.btnMas.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(819, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 400);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 400);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Frmuno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1005, 560);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panPanel);
            this.Name = "Frmuno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPanel;
        private System.Windows.Forms.ComboBox btnMotor;
        private System.Windows.Forms.ComboBox btnBasket;
        private System.Windows.Forms.ComboBox btnPoli;
        private System.Windows.Forms.ComboBox btnFubtol;
        private System.Windows.Forms.ComboBox btnIdioma;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox btnMas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

