namespace BackOffice
{
    partial class GestionDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeUsuarios));
            this.txtContraseña = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNivelPermiso = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.txtContraseña.Location = new System.Drawing.Point(23, 111);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(61, 13);
            this.txtContraseña.TabIndex = 14;
            this.txtContraseña.Text = "Contraseña";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.SystemColors.Control;
            this.lblMail.Location = new System.Drawing.Point(35, 80);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(3, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Nombre de Usuario";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(116, 77);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(175, 20);
            this.txtMail.TabIndex = 11;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(116, 108);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(175, 20);
            this.txtContra.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(116, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(611, 289);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(139, 43);
            this.btnAgregarUsuario.TabIndex = 8;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Location = new System.Drawing.Point(611, 387);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(139, 43);
            this.btnEliminarUser.TabIndex = 15;
            this.btnEliminarUser.Text = "Eliminar usuario";
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NivelPermiso";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(41, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 298);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID usuario";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Usuario";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mail";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contraseña";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NivelPermiso";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtIdUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.txtNivelPermiso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 186);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(116, 12);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtIdUsuario.TabIndex = 20;
            this.txtIdUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(399, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(402, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(265, 20);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // txtNivelPermiso
            // 
            this.txtNivelPermiso.Location = new System.Drawing.Point(116, 137);
            this.txtNivelPermiso.Name = "txtNivelPermiso";
            this.txtNivelPermiso.Size = new System.Drawing.Size(175, 20);
            this.txtNivelPermiso.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(611, 338);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 43);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(611, 436);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 40);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 549);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "GestionDeUsuarios";
            this.Text = "GestionDeUsuarios";
            this.Load += new System.EventHandler(this.GestionDeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNivelPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
    }
}