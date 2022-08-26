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
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDepor = new System.Windows.Forms.Label();
            this.txtNomEquipo = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtTipoDeporte = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarDeporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(247, 92);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 13;
            this.lblEquipo.Text = "Equipo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(247, 130);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDepor
            // 
            this.lblDepor.AutoSize = true;
            this.lblDepor.Location = new System.Drawing.Point(247, 52);
            this.lblDepor.Name = "lblDepor";
            this.lblDepor.Size = new System.Drawing.Size(84, 13);
            this.lblDepor.TabIndex = 11;
            this.lblDepor.Text = "Tipo de Deporte";
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(354, 85);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNomEquipo.TabIndex = 10;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(354, 127);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 9;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtTipoDeporte
            // 
            this.txtTipoDeporte.Location = new System.Drawing.Point(354, 49);
            this.txtTipoDeporte.Name = "txtTipoDeporte";
            this.txtTipoDeporte.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDeporte.TabIndex = 8;
            this.txtTipoDeporte.TextChanged += new System.EventHandler(this.txtTipoDeporte_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(184, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 33);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Deporte";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarDeporte
            // 
            this.btnEliminarDeporte.Location = new System.Drawing.Point(418, 237);
            this.btnEliminarDeporte.Name = "btnEliminarDeporte";
            this.btnEliminarDeporte.Size = new System.Drawing.Size(125, 33);
            this.btnEliminarDeporte.TabIndex = 14;
            this.btnEliminarDeporte.Text = "Eliminar Deporte";
            this.btnEliminarDeporte.UseVisualStyleBackColor = true;
            // 
            // GestionDeDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarDeporte);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDepor);
            this.Controls.Add(this.txtNomEquipo);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtTipoDeporte);
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
        private System.Windows.Forms.Label lblDepor;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtTipoDeporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarDeporte;
    }
}