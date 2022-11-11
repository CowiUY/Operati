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
            this.txtNombreEncuentro = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEventos
            // 
            this.dtgEventos.AllowUserToOrderColumns = true;
            this.dtgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEventos.Location = new System.Drawing.Point(55, 132);
            this.dtgEventos.Name = "dtgEventos";
            this.dtgEventos.Size = new System.Drawing.Size(571, 271);
            this.dtgEventos.TabIndex = 67;
            this.dtgEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEventos_CellContentClick);
            // 
            // txtFechaEvento
            // 
            this.txtFechaEvento.Enabled = false;
            this.txtFechaEvento.Location = new System.Drawing.Point(780, 174);
            this.txtFechaEvento.Name = "txtFechaEvento";
            this.txtFechaEvento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEvento.TabIndex = 90;
            // 
            // txtHoraEvento
            // 
            this.txtHoraEvento.Enabled = false;
            this.txtHoraEvento.Location = new System.Drawing.Point(773, 220);
            this.txtHoraEvento.Name = "txtHoraEvento";
            this.txtHoraEvento.Size = new System.Drawing.Size(107, 20);
            this.txtHoraEvento.TabIndex = 89;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(735, 181);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 88;
            this.lblFecha.Text = "Fecha";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(699, 303);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 80;
            this.lblLugar.Text = "Lugar";
            // 
            // txtLugarEvento
            // 
            this.txtLugarEvento.Location = new System.Drawing.Point(760, 303);
            this.txtLugarEvento.Name = "txtLugarEvento";
            this.txtLugarEvento.Size = new System.Drawing.Size(107, 20);
            this.txtLugarEvento.TabIndex = 79;
            // 
            // txtNombreEncuentro
            // 
            this.txtNombreEncuentro.Location = new System.Drawing.Point(780, 132);
            this.txtNombreEncuentro.Name = "txtNombreEncuentro";
            this.txtNombreEncuentro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEncuentro.TabIndex = 69;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(732, 409);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 31);
            this.btnModificar.TabIndex = 78;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(733, 446);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 31);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(732, 372);
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
            this.lblNombreEncuentro.Location = new System.Drawing.Point(663, 139);
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            this.lblNombreEncuentro.Size = new System.Drawing.Size(111, 13);
            this.lblNombreEncuentro.TabIndex = 71;
            this.lblNombreEncuentro.Text = "Nombre de Encuentro";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(702, 220);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 39);
            this.lblHora.TabIndex = 72;
            this.lblHora.Text = "Hora inicio \r\n\r\n Hr : Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarNombre.Location = new System.Drawing.Point(295, 85);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(169, 20);
            this.txtBuscarNombre.TabIndex = 92;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(192, 82);
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
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFechaEvento);
            this.Controls.Add(this.txtHoraEvento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.txtLugarEvento);
            this.Controls.Add(this.txtNombreEncuentro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombreEncuentro);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtgEventos);
            this.Name = "GestionDeEventos";
            this.Text = "GestionDeEventos";
            this.Load += new System.EventHandler(this.GestionDeEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgEventos;
        public System.Windows.Forms.TextBox txtFechaEvento;
        public System.Windows.Forms.TextBox txtHoraEvento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        public System.Windows.Forms.TextBox txtLugarEvento;
        public System.Windows.Forms.TextBox txtNombreEncuentro;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombreEncuentro;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtBuscarNombre;
        public System.Windows.Forms.Button btnBuscar;
    }
}