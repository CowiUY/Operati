namespace BackOffice
{
    partial class GestionDeDeportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeDeportes));
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNomDeporte = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarDepor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(76, 61);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(85, 13);
            this.lblEquipo.TabIndex = 13;
            this.lblEquipo.Text = "Nombre Deporte";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(76, 99);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNomDeporte
            // 
            this.txtNomDeporte.Location = new System.Drawing.Point(232, 58);
            this.txtNomDeporte.Name = "txtNomDeporte";
            this.txtNomDeporte.Size = new System.Drawing.Size(160, 20);
            this.txtNomDeporte.TabIndex = 10;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(232, 99);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(160, 20);
            this.txtCategoria.TabIndex = 9;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(70, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 33);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Deporte";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarDepor
            // 
            this.btnEliminarDepor.Location = new System.Drawing.Point(287, 167);
            this.btnEliminarDepor.Name = "btnEliminarDepor";
            this.btnEliminarDepor.Size = new System.Drawing.Size(105, 33);
            this.btnEliminarDepor.TabIndex = 14;
            this.btnEliminarDepor.Text = "Eliminar Deporte";
            this.btnEliminarDepor.UseVisualStyleBackColor = true;
            this.btnEliminarDepor.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionDeDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 252);
            this.Controls.Add(this.btnEliminarDepor);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNomDeporte);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Name = "GestionDeDeportes";
            this.Text = "GestionDeDeportes";
            this.Load += new System.EventHandler(this.GestionDeDeportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNomDeporte;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarDepor;
    }
}