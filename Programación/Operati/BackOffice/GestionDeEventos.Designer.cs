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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeEventos));
            this.dtgEventos = new System.Windows.Forms.DataGridView();
            this.txtFechaEvento = new System.Windows.Forms.TextBox();
            this.txtHoraEvento = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugarEvento = new System.Windows.Forms.TextBox();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.lblIDEvento = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEventos
            // 
            this.dtgEventos.AllowUserToOrderColumns = true;
            this.dtgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgEventos.Location = new System.Drawing.Point(37, 218);
            this.dtgEventos.Name = "dtgEventos";
            this.dtgEventos.Size = new System.Drawing.Size(634, 271);
            this.dtgEventos.TabIndex = 67;
            this.dtgEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEventos_CellClick);
            this.dtgEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEventos_CellContentClick);
            // 
            // txtFechaEvento
            // 
            this.txtFechaEvento.Enabled = false;
            this.txtFechaEvento.Location = new System.Drawing.Point(402, 21);
            this.txtFechaEvento.Name = "txtFechaEvento";
            this.txtFechaEvento.Size = new System.Drawing.Size(107, 20);
            this.txtFechaEvento.TabIndex = 90;
            // 
            // txtHoraEvento
            // 
            this.txtHoraEvento.Enabled = false;
            this.txtHoraEvento.Location = new System.Drawing.Point(402, 60);
            this.txtHoraEvento.Name = "txtHoraEvento";
            this.txtHoraEvento.Size = new System.Drawing.Size(107, 20);
            this.txtHoraEvento.TabIndex = 89;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(300, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 88;
            this.lblFecha.Text = "Fecha";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLugar.Location = new System.Drawing.Point(76, 105);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 80;
            this.lblLugar.Text = "Lugar";
            // 
            // txtLugarEvento
            // 
            this.txtLugarEvento.Location = new System.Drawing.Point(141, 98);
            this.txtLugarEvento.Name = "txtLugarEvento";
            this.txtLugarEvento.Size = new System.Drawing.Size(107, 20);
            this.txtLugarEvento.TabIndex = 79;
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(141, 59);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(107, 20);
            this.txtNombreEvento.TabIndex = 69;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(733, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 31);
            this.btnModificar.TabIndex = 78;
            this.btnModificar.Text = "Update";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(733, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 31);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(732, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 31);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombreEncuentro
            // 
            this.lblNombreEncuentro.AutoSize = true;
            this.lblNombreEncuentro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreEncuentro.Location = new System.Drawing.Point(14, 59);
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            this.lblNombreEncuentro.Size = new System.Drawing.Size(96, 13);
            this.lblNombreEncuentro.TabIndex = 71;
            this.lblNombreEncuentro.Text = "Nombre de Evento";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(300, 60);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 39);
            this.lblHora.TabIndex = 72;
            this.lblHora.Text = "Hora inicio \r\n\r\n Hr : Min";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(803, 75);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 93;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarNombre.Location = new System.Drawing.Point(586, 102);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(257, 20);
            this.txtBuscarNombre.TabIndex = 92;
            this.txtBuscarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNombre_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblIDEvento);
            this.panel1.Controls.Add(this.txtIdEvento);
            this.panel1.Controls.Add(this.txtHoraEvento);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.lblLugar);
            this.panel1.Controls.Add(this.txtNombreEvento);
            this.panel1.Controls.Add(this.txtLugarEvento);
            this.panel1.Controls.Add(this.txtBuscarNombre);
            this.panel1.Controls.Add(this.lblNombreEncuentro);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtFechaEvento);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 188);
            this.panel1.TabIndex = 94;
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Location = new System.Drawing.Point(141, 21);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(107, 20);
            this.txtIdEvento.TabIndex = 94;
            this.txtIdEvento.TextChanged += new System.EventHandler(this.txtIdEvento_TextChanged);
            // 
            // lblIDEvento
            // 
            this.lblIDEvento.AutoSize = true;
            this.lblIDEvento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIDEvento.Location = new System.Drawing.Point(71, 21);
            this.lblIDEvento.Name = "lblIDEvento";
            this.lblIDEvento.Size = new System.Drawing.Size(55, 13);
            this.lblIDEvento.TabIndex = 95;
            this.lblIDEvento.Text = "ID Evento";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Evento";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Evento";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lugar";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hora Inicio";
            this.Column5.Name = "Column5";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(733, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 31);
            this.btnReset.TabIndex = 95;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GestionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 521);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgEventos);
            this.Controls.Add(this.panel1);
            this.Name = "GestionDeEventos";
            this.Text = "GestionDeEventos";
            this.Load += new System.EventHandler(this.GestionDeEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgEventos;
        public System.Windows.Forms.TextBox txtFechaEvento;
        public System.Windows.Forms.TextBox txtHoraEvento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        public System.Windows.Forms.TextBox txtLugarEvento;
        public System.Windows.Forms.TextBox txtNombreEvento;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombreEncuentro;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblBuscar;
        public System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDEvento;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.Button btnReset;
    }
}