namespace BackOffice
{
    partial class GestionDeEncuentros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeEncuentros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEncuentro = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregaEncuentro = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBorrarEncuentro = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Encuentro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            // 
            // txtIdEncuentro
            // 
            this.txtIdEncuentro.Location = new System.Drawing.Point(141, 17);
            this.txtIdEncuentro.Name = "txtIdEncuentro";
            this.txtIdEncuentro.Size = new System.Drawing.Size(185, 20);
            this.txtIdEncuentro.TabIndex = 2;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(141, 53);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(185, 20);
            this.txtHora.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(141, 91);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(185, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtIdEncuentro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHora);
            this.panel1.Location = new System.Drawing.Point(34, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 137);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(50, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 272);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(393, 91);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(317, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(452, 60);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_Encuentro";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            // 
            // btnAgregaEncuentro
            // 
            this.btnAgregaEncuentro.Location = new System.Drawing.Point(562, 214);
            this.btnAgregaEncuentro.Name = "btnAgregaEncuentro";
            this.btnAgregaEncuentro.Size = new System.Drawing.Size(109, 33);
            this.btnAgregaEncuentro.TabIndex = 8;
            this.btnAgregaEncuentro.Text = "Agregar Encuentro";
            this.btnAgregaEncuentro.UseVisualStyleBackColor = true;
            this.btnAgregaEncuentro.Click += new System.EventHandler(this.btnAgregaEncuentro_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(562, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBorrarEncuentro
            // 
            this.btnBorrarEncuentro.Location = new System.Drawing.Point(562, 315);
            this.btnBorrarEncuentro.Name = "btnBorrarEncuentro";
            this.btnBorrarEncuentro.Size = new System.Drawing.Size(109, 33);
            this.btnBorrarEncuentro.TabIndex = 10;
            this.btnBorrarEncuentro.Text = "Borrar Encuentro";
            this.btnBorrarEncuentro.UseVisualStyleBackColor = true;
            this.btnBorrarEncuentro.Click += new System.EventHandler(this.btnBorrarEncuentro_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(562, 363);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(109, 33);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // GestionDeEncuentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.btnBorrarEncuentro);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAgregaEncuentro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "GestionDeEncuentros";
            this.Text = "GestionDeEncuentros";
            this.Load += new System.EventHandler(this.GestionDeEncuentros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdEncuentro;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAgregaEncuentro;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBorrarEncuentro;
        private System.Windows.Forms.Button Reset;
    }
}