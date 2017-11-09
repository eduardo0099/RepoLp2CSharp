namespace Vista
{
    partial class frmManejoDeAnuncios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoDeAnuncios));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAnunsio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuevoAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buscarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guardarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.modificarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eleminarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(77, 69);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(254, 20);
            this.txtTitulo.TabIndex = 20;
            // 
            // txtAnunsio
            // 
            this.txtAnunsio.Enabled = false;
            this.txtAnunsio.Location = new System.Drawing.Point(77, 103);
            this.txtAnunsio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnunsio.Multiline = true;
            this.txtAnunsio.Name = "txtAnunsio";
            this.txtAnunsio.Size = new System.Drawing.Size(291, 149);
            this.txtAnunsio.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Anuncio:";
            // 
            // cboCursos
            // 
            this.cboCursos.Enabled = false;
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(125, 36);
            this.cboCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(206, 21);
            this.cboCursos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre de curso:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAnuncioToolStripButton,
            this.buscarAnuncioToolStripButton,
            this.guardarAnuncioToolStripButton,
            this.modificarAnuncioToolStripButton,
            this.eleminarAnuncioToolStripButton,
            this.cancelarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(393, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nuevoAnuncioToolStripButton
            // 
            this.nuevoAnuncioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nuevoAnuncioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoAnuncioToolStripButton.Image")));
            this.nuevoAnuncioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoAnuncioToolStripButton.Name = "nuevoAnuncioToolStripButton";
            this.nuevoAnuncioToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.nuevoAnuncioToolStripButton.Text = "Nuevo";
            this.nuevoAnuncioToolStripButton.Click += new System.EventHandler(this.nuevoAnuncioToolStripButton_Click);
            // 
            // buscarAnuncioToolStripButton
            // 
            this.buscarAnuncioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buscarAnuncioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("buscarAnuncioToolStripButton.Image")));
            this.buscarAnuncioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscarAnuncioToolStripButton.Name = "buscarAnuncioToolStripButton";
            this.buscarAnuncioToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.buscarAnuncioToolStripButton.Text = "Buscar";
            this.buscarAnuncioToolStripButton.Click += new System.EventHandler(this.buscarAnuncioToolStripButton_Click_1);
            // 
            // guardarAnuncioToolStripButton
            // 
            this.guardarAnuncioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.guardarAnuncioToolStripButton.Enabled = false;
            this.guardarAnuncioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarAnuncioToolStripButton.Image")));
            this.guardarAnuncioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarAnuncioToolStripButton.Name = "guardarAnuncioToolStripButton";
            this.guardarAnuncioToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.guardarAnuncioToolStripButton.Text = "Guardar";
            this.guardarAnuncioToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // modificarAnuncioToolStripButton
            // 
            this.modificarAnuncioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modificarAnuncioToolStripButton.Enabled = false;
            this.modificarAnuncioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarAnuncioToolStripButton.Image")));
            this.modificarAnuncioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarAnuncioToolStripButton.Name = "modificarAnuncioToolStripButton";
            this.modificarAnuncioToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.modificarAnuncioToolStripButton.Text = "Modificar";
            this.modificarAnuncioToolStripButton.Click += new System.EventHandler(this.ModificarAnuncioToolStripButton_Click_1);
            // 
            // eleminarAnuncioToolStripButton
            // 
            this.eleminarAnuncioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eleminarAnuncioToolStripButton.Enabled = false;
            this.eleminarAnuncioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("eleminarAnuncioToolStripButton.Image")));
            this.eleminarAnuncioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eleminarAnuncioToolStripButton.Name = "eleminarAnuncioToolStripButton";
            this.eleminarAnuncioToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.eleminarAnuncioToolStripButton.Text = "Eleminar";
            this.eleminarAnuncioToolStripButton.Click += new System.EventHandler(this.eleminarAnuncioToolStripButton_Click_1);
            // 
            // cancelarToolStripButton
            // 
            this.cancelarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelarToolStripButton.Enabled = false;
            this.cancelarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelarToolStripButton.Image")));
            this.cancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelarToolStripButton.Name = "cancelarToolStripButton";
            this.cancelarToolStripButton.Size = new System.Drawing.Size(57, 22);
            this.cancelarToolStripButton.Text = "Cancelar";
            this.cancelarToolStripButton.Click += new System.EventHandler(this.cancelarToolStripButton_Click);
            // 
            // frmManejoDeAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtAnunsio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmManejoDeAnuncios";
            this.Text = "Manejo De Anuncios";
            this.Load += new System.EventHandler(this.frmManejoDeAnuncios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAnunsio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuevoAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton buscarAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton guardarAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton modificarAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton eleminarAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelarToolStripButton;
    }
}