namespace BackOffice
{
    partial class GestionDeEventos
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
            this.dtgEventos = new System.Windows.Forms.DataGridView();
            this.btnVerEventos = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dtpFechaCrear = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nUDminutos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDhora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.chkConfirmacionDeFinal = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkConfirmacionDeInicio = new System.Windows.Forms.CheckBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDminutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDhora)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEventos
            // 
            this.dtgEventos.AllowUserToOrderColumns = true;
            this.dtgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEventos.Location = new System.Drawing.Point(55, 132);
            this.dtgEventos.Name = "dtgEventos";
            this.dtgEventos.Size = new System.Drawing.Size(571, 271);
            this.dtgEventos.TabIndex = 67;
            // 
            // btnVerEventos
            // 
            this.btnVerEventos.Location = new System.Drawing.Point(211, 426);
            this.btnVerEventos.Name = "btnVerEventos";
            this.btnVerEventos.Size = new System.Drawing.Size(266, 41);
            this.btnVerEventos.TabIndex = 66;
            this.btnVerEventos.Text = "MOSTRAR LISTA COMPLETA";
            this.btnVerEventos.UseVisualStyleBackColor = true;
            this.btnVerEventos.Click += new System.EventHandler(this.btnVerEventos_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(779, 187);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 90;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(780, 248);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(86, 20);
            this.txtHora.TabIndex = 89;
            // 
            // dtpFechaCrear
            // 
            this.dtpFechaCrear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCrear.Location = new System.Drawing.Point(778, 159);
            this.dtpFechaCrear.Name = "dtpFechaCrear";
            this.dtpFechaCrear.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCrear.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "m";
            // 
            // nUDminutos
            // 
            this.nUDminutos.Location = new System.Drawing.Point(834, 222);
            this.nUDminutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDminutos.Name = "nUDminutos";
            this.nUDminutos.Size = new System.Drawing.Size(32, 20);
            this.nUDminutos.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "h";
            // 
            // nUDhora
            // 
            this.nUDhora.Location = new System.Drawing.Point(780, 222);
            this.nUDhora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nUDhora.Name = "nUDhora";
            this.nUDhora.Size = new System.Drawing.Size(32, 20);
            this.nUDhora.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(780, 59);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(32, 20);
            this.txtID.TabIndex = 81;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(716, 293);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 80;
            this.lblresultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(780, 286);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(107, 20);
            this.txtResultado.TabIndex = 79;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(780, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 69;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(747, 373);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 31);
            this.btnModificar.TabIndex = 78;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(747, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 31);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(747, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 31);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(780, 132);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 70;
            // 
            // chkConfirmacionDeFinal
            // 
            this.chkConfirmacionDeFinal.AutoSize = true;
            this.chkConfirmacionDeFinal.Location = new System.Drawing.Point(780, 312);
            this.chkConfirmacionDeFinal.Name = "chkConfirmacionDeFinal";
            this.chkConfirmacionDeFinal.Size = new System.Drawing.Size(48, 17);
            this.chkConfirmacionDeFinal.TabIndex = 75;
            this.chkConfirmacionDeFinal.Text = "Final";
            this.chkConfirmacionDeFinal.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(727, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Nombre";
            // 
            // chkConfirmacionDeInicio
            // 
            this.chkConfirmacionDeInicio.AutoSize = true;
            this.chkConfirmacionDeInicio.Location = new System.Drawing.Point(834, 312);
            this.chkConfirmacionDeInicio.Name = "chkConfirmacionDeInicio";
            this.chkConfirmacionDeInicio.Size = new System.Drawing.Size(51, 17);
            this.chkConfirmacionDeInicio.TabIndex = 74;
            this.chkConfirmacionDeInicio.Text = "Inicio";
            this.chkConfirmacionDeInicio.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(699, 255);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 13);
            this.lblHora.TabIndex = 72;
            this.lblHora.Text = "Hora de inicio";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(744, 139);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 73;
            this.lblPais.Text = "Pais";
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha1.Location = new System.Drawing.Point(407, 88);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(90, 20);
            this.dtFecha1.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarNombre.Location = new System.Drawing.Point(200, 87);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(169, 20);
            this.txtBuscarNombre.TabIndex = 92;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(97, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 23);
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GestionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 521);
            this.Controls.Add(this.dtFecha1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.dtpFechaCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUDminutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUDhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.chkConfirmacionDeFinal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.chkConfirmacionDeInicio);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.dtgEventos);
            this.Controls.Add(this.btnVerEventos);
            this.Name = "GestionDeEventos";
            this.Text = "GestionDeEventos";
            this.Load += new System.EventHandler(this.GestionDeEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDminutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDhora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgEventos;
        public System.Windows.Forms.Button btnVerEventos;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.DateTimePicker dtpFechaCrear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nUDminutos;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown nUDhora;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblresultado;
        public System.Windows.Forms.TextBox txtResultado;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.CheckBox chkConfirmacionDeFinal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkConfirmacionDeInicio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPais;
        public System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBuscarNombre;
        public System.Windows.Forms.Button btnBuscar;
    }
}