namespace Vista
{
    partial class frmInicio
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNombAnuncio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttSelecAnuncio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblColorAnu = new System.Windows.Forms.Label();
            this.txtAnuncio = new System.Windows.Forms.TextBox();
            this.lblPubli = new System.Windows.Forms.Label();
            this.lblFechaAnu = new System.Windows.Forms.Label();
            this.lblPorAnu = new System.Windows.Forms.Label();
            this.lblAutorAnu = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.bttSelecAnuncio);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lblCurso);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anuncios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actividades";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(35, 23);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombAnuncio,
            this.ColFecha});
            this.dataGridView1.Location = new System.Drawing.Point(38, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 138);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColNombAnuncio
            // 
            this.ColNombAnuncio.HeaderText = "Titulo";
            this.ColNombAnuncio.Name = "ColNombAnuncio";
            this.ColNombAnuncio.ReadOnly = true;
            this.ColNombAnuncio.Width = 250;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha Publicación";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 150;
            // 
            // bttSelecAnuncio
            // 
            this.bttSelecAnuncio.Location = new System.Drawing.Point(473, 200);
            this.bttSelecAnuncio.Name = "bttSelecAnuncio";
            this.bttSelecAnuncio.Size = new System.Drawing.Size(90, 23);
            this.bttSelecAnuncio.TabIndex = 3;
            this.bttSelecAnuncio.Text = "Seleccionar";
            this.bttSelecAnuncio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAutorAnu);
            this.groupBox2.Controls.Add(this.lblPorAnu);
            this.groupBox2.Controls.Add(this.lblFechaAnu);
            this.groupBox2.Controls.Add(this.lblPubli);
            this.groupBox2.Controls.Add(this.txtAnuncio);
            this.groupBox2.Controls.Add(this.lblColorAnu);
            this.groupBox2.Location = new System.Drawing.Point(38, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anuncio:";
            // 
            // lblColorAnu
            // 
            this.lblColorAnu.BackColor = System.Drawing.Color.Teal;
            this.lblColorAnu.Location = new System.Drawing.Point(19, 16);
            this.lblColorAnu.Name = "lblColorAnu";
            this.lblColorAnu.Size = new System.Drawing.Size(491, 120);
            this.lblColorAnu.TabIndex = 0;
            this.lblColorAnu.Click += new System.EventHandler(this.lblColorAnu_Click);
            // 
            // txtAnuncio
            // 
            this.txtAnuncio.Location = new System.Drawing.Point(25, 22);
            this.txtAnuncio.Multiline = true;
            this.txtAnuncio.Name = "txtAnuncio";
            this.txtAnuncio.Size = new System.Drawing.Size(478, 110);
            this.txtAnuncio.TabIndex = 1;
            this.txtAnuncio.Text = "[Titulo del anuncio] \r\n[Contenido del anuncio]";
            // 
            // lblPubli
            // 
            this.lblPubli.AutoSize = true;
            this.lblPubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubli.Location = new System.Drawing.Point(11, 143);
            this.lblPubli.Name = "lblPubli";
            this.lblPubli.Size = new System.Drawing.Size(71, 13);
            this.lblPubli.TabIndex = 2;
            this.lblPubli.Text = "Publicado: ";
            // 
            // lblFechaAnu
            // 
            this.lblFechaAnu.AutoSize = true;
            this.lblFechaAnu.Location = new System.Drawing.Point(79, 143);
            this.lblFechaAnu.Name = "lblFechaAnu";
            this.lblFechaAnu.Size = new System.Drawing.Size(37, 13);
            this.lblFechaAnu.TabIndex = 3;
            this.lblFechaAnu.Text = "Fecha";
            // 
            // lblPorAnu
            // 
            this.lblPorAnu.AutoSize = true;
            this.lblPorAnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorAnu.Location = new System.Drawing.Point(222, 143);
            this.lblPorAnu.Name = "lblPorAnu";
            this.lblPorAnu.Size = new System.Drawing.Size(30, 13);
            this.lblPorAnu.TabIndex = 4;
            this.lblPorAnu.Text = "Por:";
            // 
            // lblAutorAnu
            // 
            this.lblAutorAnu.AutoSize = true;
            this.lblAutorAnu.Location = new System.Drawing.Point(258, 143);
            this.lblAutorAnu.Name = "lblAutorAnu";
            this.lblAutorAnu.Size = new System.Drawing.Size(71, 13);
            this.lblAutorAnu.TabIndex = 5;
            this.lblAutorAnu.Text = "Nombre autor";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 431);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblColorAnu;
        private System.Windows.Forms.Button bttSelecAnuncio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombAnuncio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAutorAnu;
        private System.Windows.Forms.Label lblPorAnu;
        private System.Windows.Forms.Label lblFechaAnu;
        private System.Windows.Forms.Label lblPubli;
        private System.Windows.Forms.TextBox txtAnuncio;
    }
}