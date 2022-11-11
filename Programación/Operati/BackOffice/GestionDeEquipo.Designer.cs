namespace BackOffice
{
    partial class GestionDeEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeEquipo));
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.llblNombreEquipo = new System.Windows.Forms.Label();
            this.lblPaisDeEquipo = new System.Windows.Forms.Label();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar  Equipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(302, 233);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(112, 31);
            this.btnBorrarEquipo.TabIndex = 1;
            this.btnBorrarEquipo.Text = "Borrar Equipo";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            // 
            // llblNombreEquipo
            // 
            this.llblNombreEquipo.AutoSize = true;
            this.llblNombreEquipo.Location = new System.Drawing.Point(129, 121);
            this.llblNombreEquipo.Name = "llblNombreEquipo";
            this.llblNombreEquipo.Size = new System.Drawing.Size(80, 13);
            this.llblNombreEquipo.TabIndex = 2;
            this.llblNombreEquipo.Text = "Nombre Equipo";
            // 
            // lblPaisDeEquipo
            // 
            this.lblPaisDeEquipo.AutoSize = true;
            this.lblPaisDeEquipo.Location = new System.Drawing.Point(132, 162);
            this.lblPaisDeEquipo.Name = "lblPaisDeEquipo";
            this.lblPaisDeEquipo.Size = new System.Drawing.Size(59, 13);
            this.lblPaisDeEquipo.TabIndex = 3;
            this.lblPaisDeEquipo.Text = "Pais origen";
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(242, 113);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(232, 20);
            this.txtNomEquipo.TabIndex = 4;
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Location = new System.Drawing.Point(242, 154);
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(232, 20);
            this.txtPaisOrigen.TabIndex = 5;
            // 
            // GestionDeEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(595, 345);
            this.Controls.Add(this.txtPaisOrigen);
            this.Controls.Add(this.txtNomEquipo);
            this.Controls.Add(this.lblPaisDeEquipo);
            this.Controls.Add(this.llblNombreEquipo);
            this.Controls.Add(this.btnBorrarEquipo);
            this.Controls.Add(this.button1);
            this.Name = "GestionDeEquipo";
            this.Text = "GestionDeEquipo";
            this.Load += new System.EventHandler(this.GestionDeEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.Label llblNombreEquipo;
        private System.Windows.Forms.Label lblPaisDeEquipo;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.TextBox txtPaisOrigen;
    }
}