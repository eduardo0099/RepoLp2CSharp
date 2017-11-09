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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColAutorActivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccionActivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCursoActivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDocActivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFiltroFecha = new System.Windows.Forms.ComboBox();
            this.cmbFiltroAccion = new System.Windows.Forms.ComboBox();
            this.cmbFiltroCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAutorAnu = new System.Windows.Forms.Label();
            this.lblPorAnu = new System.Windows.Forms.Label();
            this.lblFechaAnu = new System.Windows.Forms.Label();
            this.lblPubli = new System.Windows.Forms.Label();
            this.txtAnuncio = new System.Windows.Forms.TextBox();
            this.lblColorAnu = new System.Windows.Forms.Label();
            this.bttSelecAnuncio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNombAnuncio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurso = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cmbFiltroFecha);
            this.tabPage2.Controls.Add(this.cmbFiltroAccion);
            this.tabPage2.Controls.Add(this.cmbFiltroCurso);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(857, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actividades";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bienvenido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Vista.Properties.Resources.loguin;
            this.pictureBox1.Image = global::Vista.Properties.Resources.loguin;
            this.pictureBox1.InitialImage = global::Vista.Properties.Resources.loguin;
            this.pictureBox1.Location = new System.Drawing.Point(452, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Actividades: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAutorActivi,
            this.colAccionActivi,
            this.ColCursoActivi,
            this.ColDocActivi});
            this.dataGridView2.Location = new System.Drawing.Point(24, 225);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(807, 254);
            this.dataGridView2.TabIndex = 1;
            // 
            // ColAutorActivi
            // 
            this.ColAutorActivi.HeaderText = "Autor";
            this.ColAutorActivi.Name = "ColAutorActivi";
            this.ColAutorActivi.ReadOnly = true;
            this.ColAutorActivi.Width = 200;
            // 
            // colAccionActivi
            // 
            this.colAccionActivi.HeaderText = "Accion";
            this.colAccionActivi.Name = "colAccionActivi";
            this.colAccionActivi.ReadOnly = true;
            // 
            // ColCursoActivi
            // 
            this.ColCursoActivi.HeaderText = "Curso";
            this.ColCursoActivi.Name = "ColCursoActivi";
            this.ColCursoActivi.ReadOnly = true;
            // 
            // ColDocActivi
            // 
            this.ColDocActivi.HeaderText = "Titulo Documento";
            this.ColDocActivi.Name = "ColDocActivi";
            this.ColDocActivi.ReadOnly = true;
            this.ColDocActivi.Width = 150;
            // 
            // cmbFiltroFecha
            // 
            this.cmbFiltroFecha.FormattingEnabled = true;
            this.cmbFiltroFecha.Location = new System.Drawing.Point(659, 188);
            this.cmbFiltroFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltroFecha.Name = "cmbFiltroFecha";
            this.cmbFiltroFecha.Size = new System.Drawing.Size(148, 24);
            this.cmbFiltroFecha.TabIndex = 4;
            this.cmbFiltroFecha.Text = "Hoy";
            // 
            // cmbFiltroAccion
            // 
            this.cmbFiltroAccion.FormattingEnabled = true;
            this.cmbFiltroAccion.Location = new System.Drawing.Point(419, 188);
            this.cmbFiltroAccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltroAccion.Name = "cmbFiltroAccion";
            this.cmbFiltroAccion.Size = new System.Drawing.Size(189, 24);
            this.cmbFiltroAccion.TabIndex = 3;
            this.cmbFiltroAccion.Text = "Todos las acciones";
            // 
            // cmbFiltroCurso
            // 
            this.cmbFiltroCurso.FormattingEnabled = true;
            this.cmbFiltroCurso.Location = new System.Drawing.Point(133, 188);
            this.cmbFiltroCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltroCurso.Name = "cmbFiltroCurso";
            this.cmbFiltroCurso.Size = new System.Drawing.Size(237, 24);
            this.cmbFiltroCurso.TabIndex = 2;
            this.cmbFiltroCurso.Text = "Todos los Cursos";
            this.cmbFiltroCurso.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtros:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(813, 310);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 351);
            this.label1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.bttSelecAnuncio);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lblCurso);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(857, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anuncios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAutorAnu);
            this.groupBox2.Controls.Add(this.lblPorAnu);
            this.groupBox2.Controls.Add(this.lblFechaAnu);
            this.groupBox2.Controls.Add(this.lblPubli);
            this.groupBox2.Controls.Add(this.txtAnuncio);
            this.groupBox2.Controls.Add(this.lblColorAnu);
            this.groupBox2.Location = new System.Drawing.Point(51, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(700, 206);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anuncio:";
            // 
            // lblAutorAnu
            // 
            this.lblAutorAnu.AutoSize = true;
            this.lblAutorAnu.Location = new System.Drawing.Point(344, 176);
            this.lblAutorAnu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutorAnu.Name = "lblAutorAnu";
            this.lblAutorAnu.Size = new System.Drawing.Size(95, 17);
            this.lblAutorAnu.TabIndex = 5;
            this.lblAutorAnu.Text = "Nombre autor";
            // 
            // lblPorAnu
            // 
            this.lblPorAnu.AutoSize = true;
            this.lblPorAnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorAnu.Location = new System.Drawing.Point(296, 176);
            this.lblPorAnu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorAnu.Name = "lblPorAnu";
            this.lblPorAnu.Size = new System.Drawing.Size(38, 17);
            this.lblPorAnu.TabIndex = 4;
            this.lblPorAnu.Text = "Por:";
            // 
            // lblFechaAnu
            // 
            this.lblFechaAnu.AutoSize = true;
            this.lblFechaAnu.Location = new System.Drawing.Point(105, 176);
            this.lblFechaAnu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAnu.Name = "lblFechaAnu";
            this.lblFechaAnu.Size = new System.Drawing.Size(47, 17);
            this.lblFechaAnu.TabIndex = 3;
            this.lblFechaAnu.Text = "Fecha";
            // 
            // lblPubli
            // 
            this.lblPubli.AutoSize = true;
            this.lblPubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubli.Location = new System.Drawing.Point(15, 176);
            this.lblPubli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPubli.Name = "lblPubli";
            this.lblPubli.Size = new System.Drawing.Size(89, 17);
            this.lblPubli.TabIndex = 2;
            this.lblPubli.Text = "Publicado: ";
            // 
            // txtAnuncio
            // 
            this.txtAnuncio.Location = new System.Drawing.Point(33, 27);
            this.txtAnuncio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnuncio.Multiline = true;
            this.txtAnuncio.Name = "txtAnuncio";
            this.txtAnuncio.Size = new System.Drawing.Size(636, 134);
            this.txtAnuncio.TabIndex = 1;
            this.txtAnuncio.Text = "[Titulo del anuncio] \r\n[Contenido del anuncio]";
            // 
            // lblColorAnu
            // 
            this.lblColorAnu.BackColor = System.Drawing.Color.Teal;
            this.lblColorAnu.Location = new System.Drawing.Point(25, 20);
            this.lblColorAnu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorAnu.Name = "lblColorAnu";
            this.lblColorAnu.Size = new System.Drawing.Size(655, 148);
            this.lblColorAnu.TabIndex = 0;
            this.lblColorAnu.Click += new System.EventHandler(this.lblColorAnu_Click);
            // 
            // bttSelecAnuncio
            // 
            this.bttSelecAnuncio.Location = new System.Drawing.Point(631, 246);
            this.bttSelecAnuncio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttSelecAnuncio.Name = "bttSelecAnuncio";
            this.bttSelecAnuncio.Size = new System.Drawing.Size(120, 28);
            this.bttSelecAnuncio.TabIndex = 3;
            this.bttSelecAnuncio.Text = "Seleccionar";
            this.bttSelecAnuncio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombAnuncio,
            this.ColFecha});
            this.dataGridView1.Location = new System.Drawing.Point(51, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 170);
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
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(47, 28);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 17);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 530);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(867, 530);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbFiltroAccion;
        private System.Windows.Forms.ComboBox cmbFiltroCurso;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFiltroFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutorActivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccionActivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCursoActivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDocActivi;
        private System.Windows.Forms.Label label5;
    }
}