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
            this.components = new System.ComponentModel.Container();
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
            this.btnCurso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAutorAnu = new System.Windows.Forms.Label();
            this.lblPorAnu = new System.Windows.Forms.Label();
            this.lblFechaAnu = new System.Windows.Forms.Label();
            this.lblPubli = new System.Windows.Forms.Label();
            this.txtAnuncio = new System.Windows.Forms.TextBox();
            this.lblColorAnu = new System.Windows.Forms.Label();
            this.bttSelecAnuncio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCurso = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anuncioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anuncioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource1)).BeginInit();
            this.pnlEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 429);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actividades";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bienvenido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Vista.Properties.Resources.loguin;
            this.pictureBox1.Image = global::Vista.Properties.Resources.loguin;
            this.pictureBox1.InitialImage = global::Vista.Properties.Resources.loguin;
            this.pictureBox1.Location = new System.Drawing.Point(284, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 84);
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
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
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
            this.dataGridView2.Location = new System.Drawing.Point(18, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(605, 206);
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
            this.cmbFiltroFecha.Location = new System.Drawing.Point(494, 153);
            this.cmbFiltroFecha.Name = "cmbFiltroFecha";
            this.cmbFiltroFecha.Size = new System.Drawing.Size(112, 21);
            this.cmbFiltroFecha.TabIndex = 4;
            this.cmbFiltroFecha.Text = "Hoy";
            // 
            // cmbFiltroAccion
            // 
            this.cmbFiltroAccion.FormattingEnabled = true;
            this.cmbFiltroAccion.Location = new System.Drawing.Point(314, 153);
            this.cmbFiltroAccion.Name = "cmbFiltroAccion";
            this.cmbFiltroAccion.Size = new System.Drawing.Size(143, 21);
            this.cmbFiltroAccion.TabIndex = 3;
            this.cmbFiltroAccion.Text = "Todos las acciones";
            // 
            // cmbFiltroCurso
            // 
            this.cmbFiltroCurso.FormattingEnabled = true;
            this.cmbFiltroCurso.Location = new System.Drawing.Point(100, 153);
            this.cmbFiltroCurso.Name = "cmbFiltroCurso";
            this.cmbFiltroCurso.Size = new System.Drawing.Size(179, 21);
            this.cmbFiltroCurso.TabIndex = 2;
            this.cmbFiltroCurso.Text = "Todos los Cursos";
            this.cmbFiltroCurso.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtros:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 252);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 285);
            this.label1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bttGuardar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.bttEditar);
            this.tabPage1.Controls.Add(this.btnCurso);
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
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(348, 18);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(28, 23);
            this.btnCurso.TabIndex = 6;
            this.btnCurso.Text = "...";
            this.btnCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlEdicion);
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
            // lblAutorAnu
            // 
            this.lblAutorAnu.AutoSize = true;
            this.lblAutorAnu.Location = new System.Drawing.Point(258, 143);
            this.lblAutorAnu.Name = "lblAutorAnu";
            this.lblAutorAnu.Size = new System.Drawing.Size(0, 13);
            this.lblAutorAnu.TabIndex = 5;
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
            // lblFechaAnu
            // 
            this.lblFechaAnu.AutoSize = true;
            this.lblFechaAnu.Location = new System.Drawing.Point(79, 143);
            this.lblFechaAnu.Name = "lblFechaAnu";
            this.lblFechaAnu.Size = new System.Drawing.Size(0, 13);
            this.lblFechaAnu.TabIndex = 3;
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
            // txtAnuncio
            // 
            this.txtAnuncio.Location = new System.Drawing.Point(25, 22);
            this.txtAnuncio.MaxLength = 1000000;
            this.txtAnuncio.Multiline = true;
            this.txtAnuncio.Name = "txtAnuncio";
            this.txtAnuncio.Size = new System.Drawing.Size(478, 110);
            this.txtAnuncio.TabIndex = 1;
            this.txtAnuncio.TextChanged += new System.EventHandler(this.txtAnuncio_TextChanged);
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
            // bttSelecAnuncio
            // 
            this.bttSelecAnuncio.Location = new System.Drawing.Point(473, 200);
            this.bttSelecAnuncio.Name = "bttSelecAnuncio";
            this.bttSelecAnuncio.Size = new System.Drawing.Size(90, 23);
            this.bttSelecAnuncio.TabIndex = 3;
            this.bttSelecAnuncio.Text = "Seleccionar";
            this.bttSelecAnuncio.UseVisualStyleBackColor = true;
            this.bttSelecAnuncio.Click += new System.EventHandler(this.bttSelecAnuncio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechacreacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anuncioBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(38, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 138);
            this.dataGridView1.TabIndex = 2;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Modelo.Usuario);
            // 
            // anuncioBindingSource
            // 
            this.anuncioBindingSource.DataSource = typeof(Modelo.Anuncio);
            // 
            // anuncioBindingSource1
            // 
            this.anuncioBindingSource1.DataSource = typeof(Modelo.Anuncio);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechacreacionDataGridViewTextBoxColumn
            // 
            this.fechacreacionDataGridViewTextBoxColumn.DataPropertyName = "Fechacreacion";
            this.fechacreacionDataGridViewTextBoxColumn.HeaderText = "Fechacreacion";
            this.fechacreacionDataGridViewTextBoxColumn.Name = "fechacreacionDataGridViewTextBoxColumn";
            this.fechacreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bttEditar
            // 
            this.bttEditar.Location = new System.Drawing.Point(38, 200);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(75, 23);
            this.bttEditar.TabIndex = 7;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.txtDes);
            this.pnlEdicion.Controls.Add(this.txtTitulo);
            this.pnlEdicion.Controls.Add(this.lblDescrip);
            this.pnlEdicion.Controls.Add(this.lblTitulo);
            this.pnlEdicion.Location = new System.Drawing.Point(25, 22);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(478, 110);
            this.pnlEdicion.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(14, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            this.lblTitulo.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(17, 45);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblDescrip.TabIndex = 1;
            this.lblDescrip.Text = "Descripcion:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(90, 14);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(363, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(90, 45);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(363, 50);
            this.txtDes.TabIndex = 3;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(120, 201);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 9;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.button3_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anuncioBindingSource1)).EndInit();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlEdicion.PerformLayout();
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
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource anuncioBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource anuncioBindingSource1;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button bttGuardar;
    }
}