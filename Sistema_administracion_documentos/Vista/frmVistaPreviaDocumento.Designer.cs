namespace Vista {
    partial class frmVistaPreviaDocumento {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ppreviewDoc = new System.Windows.Forms.PrintPreviewControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnEditar = new System.Windows.Forms.Button();
            this.lblEstadoR = new System.Windows.Forms.Label();
            this.lblFechaCreacionR = new System.Windows.Forms.Label();
            this.lblCarpetaR = new System.Windows.Forms.Label();
            this.lblExtensionR = new System.Windows.Forms.Label();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.lblEstadoL = new System.Windows.Forms.Label();
            this.lblFechaCreacionL = new System.Windows.Forms.Label();
            this.lblCarpetaL = new System.Windows.Forms.Label();
            this.lblExtensionL = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaModifR = new System.Windows.Forms.Label();
            this.lblAutorR = new System.Windows.Forms.Label();
            this.lblFechaModifL = new System.Windows.Forms.Label();
            this.lblAutorL = new System.Windows.Forms.Label();
            this.bttnDescargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ppreviewDoc
            // 
            this.ppreviewDoc.Location = new System.Drawing.Point(12, 12);
            this.ppreviewDoc.Name = "ppreviewDoc";
            this.ppreviewDoc.Size = new System.Drawing.Size(528, 648);
            this.ppreviewDoc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnCancelar);
            this.groupBox1.Controls.Add(this.bttnGuardar);
            this.groupBox1.Controls.Add(this.bttnEditar);
            this.groupBox1.Controls.Add(this.lblEstadoR);
            this.groupBox1.Controls.Add(this.lblFechaCreacionR);
            this.groupBox1.Controls.Add(this.lblCarpetaR);
            this.groupBox1.Controls.Add(this.lblExtensionR);
            this.groupBox1.Controls.Add(this.txtboxDescripcion);
            this.groupBox1.Controls.Add(this.txtboxNombre);
            this.groupBox1.Controls.Add(this.lblEstadoL);
            this.groupBox1.Controls.Add(this.lblFechaCreacionL);
            this.groupBox1.Controls.Add(this.lblCarpetaL);
            this.groupBox1.Controls.Add(this.lblExtensionL);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(561, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 472);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del documento";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(324, 425);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttnCancelar.TabIndex = 13;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click_1);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(139, 425);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttnGuardar.TabIndex = 2;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click_1);
            // 
            // bttnEditar
            // 
            this.bttnEditar.Location = new System.Drawing.Point(230, 425);
            this.bttnEditar.Name = "bttnEditar";
            this.bttnEditar.Size = new System.Drawing.Size(75, 23);
            this.bttnEditar.TabIndex = 12;
            this.bttnEditar.Text = "Editar";
            this.bttnEditar.UseVisualStyleBackColor = true;
            this.bttnEditar.Click += new System.EventHandler(this.bttnEditar_Click_1);
            // 
            // lblEstadoR
            // 
            this.lblEstadoR.AutoSize = true;
            this.lblEstadoR.Location = new System.Drawing.Point(185, 381);
            this.lblEstadoR.Name = "lblEstadoR";
            this.lblEstadoR.Size = new System.Drawing.Size(124, 17);
            this.lblEstadoR.TabIndex = 11;
            this.lblEstadoR.Text = "EstadoDocumento";
            // 
            // lblFechaCreacionR
            // 
            this.lblFechaCreacionR.AutoSize = true;
            this.lblFechaCreacionR.Location = new System.Drawing.Point(185, 331);
            this.lblFechaCreacionR.Name = "lblFechaCreacionR";
            this.lblFechaCreacionR.Size = new System.Drawing.Size(121, 17);
            this.lblFechaCreacionR.TabIndex = 10;
            this.lblFechaCreacionR.Text = "FechaDeCreacion";
            // 
            // lblCarpetaR
            // 
            this.lblCarpetaR.AutoSize = true;
            this.lblCarpetaR.Location = new System.Drawing.Point(185, 283);
            this.lblCarpetaR.Name = "lblCarpetaR";
            this.lblCarpetaR.Size = new System.Drawing.Size(130, 17);
            this.lblCarpetaR.TabIndex = 9;
            this.lblCarpetaR.Text = "CarpetaDocumento";
            // 
            // lblExtensionR
            // 
            this.lblExtensionR.AutoSize = true;
            this.lblExtensionR.Location = new System.Drawing.Point(185, 235);
            this.lblExtensionR.Name = "lblExtensionR";
            this.lblExtensionR.Size = new System.Drawing.Size(39, 17);
            this.lblExtensionR.TabIndex = 8;
            this.lblExtensionR.Text = ".algo";
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.Location = new System.Drawing.Point(185, 97);
            this.txtboxDescripcion.Multiline = true;
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.Size = new System.Drawing.Size(316, 118);
            this.txtboxDescripcion.TabIndex = 7;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(185, 52);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(316, 22);
            this.txtboxNombre.TabIndex = 6;
            // 
            // lblEstadoL
            // 
            this.lblEstadoL.AutoSize = true;
            this.lblEstadoL.Location = new System.Drawing.Point(29, 381);
            this.lblEstadoL.Name = "lblEstadoL";
            this.lblEstadoL.Size = new System.Drawing.Size(56, 17);
            this.lblEstadoL.TabIndex = 5;
            this.lblEstadoL.Text = "Estado:";
            // 
            // lblFechaCreacionL
            // 
            this.lblFechaCreacionL.AutoSize = true;
            this.lblFechaCreacionL.Location = new System.Drawing.Point(29, 331);
            this.lblFechaCreacionL.Name = "lblFechaCreacionL";
            this.lblFechaCreacionL.Size = new System.Drawing.Size(129, 17);
            this.lblFechaCreacionL.TabIndex = 4;
            this.lblFechaCreacionL.Text = "Fecha de creación:";
            // 
            // lblCarpetaL
            // 
            this.lblCarpetaL.AutoSize = true;
            this.lblCarpetaL.Location = new System.Drawing.Point(29, 283);
            this.lblCarpetaL.Name = "lblCarpetaL";
            this.lblCarpetaL.Size = new System.Drawing.Size(62, 17);
            this.lblCarpetaL.TabIndex = 3;
            this.lblCarpetaL.Text = "Carpeta:";
            // 
            // lblExtensionL
            // 
            this.lblExtensionL.AutoSize = true;
            this.lblExtensionL.Location = new System.Drawing.Point(29, 235);
            this.lblExtensionL.Name = "lblExtensionL";
            this.lblExtensionL.Size = new System.Drawing.Size(73, 17);
            this.lblExtensionL.TabIndex = 2;
            this.lblExtensionL.Text = "Extensión:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFechaModifR);
            this.groupBox2.Controls.Add(this.lblAutorR);
            this.groupBox2.Controls.Add(this.lblFechaModifL);
            this.groupBox2.Controls.Add(this.lblAutorL);
            this.groupBox2.Location = new System.Drawing.Point(561, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del autor";
            // 
            // lblFechaModifR
            // 
            this.lblFechaModifR.AutoSize = true;
            this.lblFechaModifR.Location = new System.Drawing.Point(188, 86);
            this.lblFechaModifR.Name = "lblFechaModifR";
            this.lblFechaModifR.Size = new System.Drawing.Size(143, 17);
            this.lblFechaModifR.TabIndex = 3;
            this.lblFechaModifR.Text = "FechaDeModificación";
            // 
            // lblAutorR
            // 
            this.lblAutorR.AutoSize = true;
            this.lblAutorR.Location = new System.Drawing.Point(188, 41);
            this.lblAutorR.Name = "lblAutorR";
            this.lblAutorR.Size = new System.Drawing.Size(92, 17);
            this.lblAutorR.TabIndex = 2;
            this.lblAutorR.Text = "NombreAutor";
            // 
            // lblFechaModifL
            // 
            this.lblFechaModifL.AutoSize = true;
            this.lblFechaModifL.Location = new System.Drawing.Point(29, 86);
            this.lblFechaModifL.Name = "lblFechaModifL";
            this.lblFechaModifL.Size = new System.Drawing.Size(153, 17);
            this.lblFechaModifL.TabIndex = 1;
            this.lblFechaModifL.Text = "Fecha de modificación:";
            // 
            // lblAutorL
            // 
            this.lblAutorL.AutoSize = true;
            this.lblAutorL.Location = new System.Drawing.Point(29, 42);
            this.lblAutorL.Name = "lblAutorL";
            this.lblAutorL.Size = new System.Drawing.Size(46, 17);
            this.lblAutorL.TabIndex = 0;
            this.lblAutorL.Text = "Autor:";
            // 
            // bttnDescargar
            // 
            this.bttnDescargar.Location = new System.Drawing.Point(765, 625);
            this.bttnDescargar.Name = "bttnDescargar";
            this.bttnDescargar.Size = new System.Drawing.Size(140, 36);
            this.bttnDescargar.TabIndex = 4;
            this.bttnDescargar.Text = "Descargar";
            this.bttnDescargar.UseVisualStyleBackColor = true;
            this.bttnDescargar.Click += new System.EventHandler(this.bttnDescargar_Click_1);
            // 
            // frmVistaPreviaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 672);
            this.Controls.Add(this.bttnDescargar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ppreviewDoc);
            this.Name = "frmVistaPreviaDocumento";
            this.Text = "Vista Previa Documentos 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl ppreviewDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnEditar;
        private System.Windows.Forms.Label lblEstadoR;
        private System.Windows.Forms.Label lblFechaCreacionR;
        private System.Windows.Forms.Label lblCarpetaR;
        private System.Windows.Forms.Label lblExtensionR;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.Label lblEstadoL;
        private System.Windows.Forms.Label lblFechaCreacionL;
        private System.Windows.Forms.Label lblCarpetaL;
        private System.Windows.Forms.Label lblExtensionL;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFechaModifR;
        private System.Windows.Forms.Label lblAutorR;
        private System.Windows.Forms.Label lblFechaModifL;
        private System.Windows.Forms.Label lblAutorL;
        private System.Windows.Forms.Button bttnDescargar;
    }
}