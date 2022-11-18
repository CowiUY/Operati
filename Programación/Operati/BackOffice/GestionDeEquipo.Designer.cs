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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEquipo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar  Equipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(512, 445);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(112, 31);
            this.btnBorrarEquipo.TabIndex = 1;
            this.btnBorrarEquipo.Text = "Borrar Equipo";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
            // 
            // llblNombreEquipo
            // 
            this.llblNombreEquipo.AutoSize = true;
            this.llblNombreEquipo.Location = new System.Drawing.Point(52, 50);
            this.llblNombreEquipo.Name = "llblNombreEquipo";
            this.llblNombreEquipo.Size = new System.Drawing.Size(80, 13);
            this.llblNombreEquipo.TabIndex = 2;
            this.llblNombreEquipo.Text = "Nombre Equipo";
            // 
            // lblPaisDeEquipo
            // 
            this.lblPaisDeEquipo.AutoSize = true;
            this.lblPaisDeEquipo.Location = new System.Drawing.Point(74, 82);
            this.lblPaisDeEquipo.Name = "lblPaisDeEquipo";
            this.lblPaisDeEquipo.Size = new System.Drawing.Size(59, 13);
            this.lblPaisDeEquipo.TabIndex = 3;
            this.lblPaisDeEquipo.Text = "Pais origen";
            // 
            // txtNomEquipo
            // 
            this.txtNomEquipo.Location = new System.Drawing.Point(163, 50);
            this.txtNomEquipo.Name = "txtNomEquipo";
            this.txtNomEquipo.Size = new System.Drawing.Size(232, 20);
            this.txtNomEquipo.TabIndex = 4;
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Location = new System.Drawing.Point(163, 82);
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(232, 20);
            this.txtPaisOrigen.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIDEquipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblPaisDeEquipo);
            this.panel1.Controls.Add(this.llblNombreEquipo);
            this.panel1.Controls.Add(this.txtPaisOrigen);
            this.panel1.Controls.Add(this.txtNomEquipo);
            this.panel1.Location = new System.Drawing.Point(52, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 172);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(90, 138);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(259, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(83, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 287);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Equipo";
            // 
            // txtIDEquipo
            // 
            this.txtIDEquipo.Location = new System.Drawing.Point(163, 22);
            this.txtIDEquipo.Name = "txtIDEquipo";
            this.txtIDEquipo.Size = new System.Drawing.Size(232, 20);
            this.txtIDEquipo.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(512, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(512, 510);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 31);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Equipo";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Equipo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pais Origen";
            this.Column2.Name = "Column2";
            // 
            // GestionDeEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 609);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBorrarEquipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "GestionDeEquipo";
            this.Text = "GestionDeEquipo";
            this.Load += new System.EventHandler(this.GestionDeEquipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.Label llblNombreEquipo;
        private System.Windows.Forms.Label lblPaisDeEquipo;
        private System.Windows.Forms.TextBox txtNomEquipo;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEquipo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}