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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblIdDeporte = new System.Windows.Forms.Label();
            this.txtIdDeporte = new System.Windows.Forms.TextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(59, 41);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(85, 13);
            this.lblEquipo.TabIndex = 13;
            this.lblEquipo.Text = "Nombre Deporte";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(62, 73);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNomDeporte
            // 
            this.txtNomDeporte.Location = new System.Drawing.Point(216, 53);
            this.txtNomDeporte.Name = "txtNomDeporte";
            this.txtNomDeporte.Size = new System.Drawing.Size(160, 20);
            this.txtNomDeporte.TabIndex = 10;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(216, 87);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(160, 20);
            this.txtCategoria.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(437, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 33);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Deporte";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarDepor
            // 
            this.btnEliminarDepor.Location = new System.Drawing.Point(437, 406);
            this.btnEliminarDepor.Name = "btnEliminarDepor";
            this.btnEliminarDepor.Size = new System.Drawing.Size(105, 33);
            this.btnEliminarDepor.TabIndex = 14;
            this.btnEliminarDepor.Text = "Eliminar Deporte";
            this.btnEliminarDepor.UseVisualStyleBackColor = true;
            this.btnEliminarDepor.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(23, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 277);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(437, 466);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 33);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdDeporte);
            this.panel1.Controls.Add(this.lblIdDeporte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.lblEquipo);
            this.panel1.Controls.Add(this.txtNomDeporte);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Location = new System.Drawing.Point(65, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 166);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(62, 130);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(254, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(437, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 33);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblIdDeporte
            // 
            this.lblIdDeporte.AutoSize = true;
            this.lblIdDeporte.Location = new System.Drawing.Point(62, 15);
            this.lblIdDeporte.Name = "lblIdDeporte";
            this.lblIdDeporte.Size = new System.Drawing.Size(59, 13);
            this.lblIdDeporte.TabIndex = 20;
            this.lblIdDeporte.Text = "ID Deporte";
            // 
            // txtIdDeporte
            // 
            this.txtIdDeporte.Location = new System.Drawing.Point(216, 15);
            this.txtIdDeporte.Name = "txtIdDeporte";
            this.txtIdDeporte.Size = new System.Drawing.Size(160, 20);
            this.txtIdDeporte.TabIndex = 21;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID_Deporte";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NombreDeporte";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            // 
            // GestionDeDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 600);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarDepor);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Name = "GestionDeDeportes";
            this.Text = "GestionDeDeportes";
            this.Load += new System.EventHandler(this.GestionDeDeportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNomDeporte;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarDepor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtIdDeporte;
        private System.Windows.Forms.Label lblIdDeporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}