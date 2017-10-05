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
            this.AsuntoTextBox = new System.Windows.Forms.TextBox();
            this.anunsioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreDeCursoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuevoAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buscarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ModificarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eleminarAnuncioToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Asunto:";
            // 
            // AsuntoTextBox
            // 
            this.AsuntoTextBox.Enabled = false;
            this.AsuntoTextBox.Location = new System.Drawing.Point(77, 69);
            this.AsuntoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AsuntoTextBox.Name = "AsuntoTextBox";
            this.AsuntoTextBox.Size = new System.Drawing.Size(254, 20);
            this.AsuntoTextBox.TabIndex = 20;
            // 
            // anunsioTextBox
            // 
            this.anunsioTextBox.Enabled = false;
            this.anunsioTextBox.Location = new System.Drawing.Point(77, 103);
            this.anunsioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.anunsioTextBox.Multiline = true;
            this.anunsioTextBox.Name = "anunsioTextBox";
            this.anunsioTextBox.Size = new System.Drawing.Size(291, 149);
            this.anunsioTextBox.TabIndex = 19;
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
            // nombreDeCursoComboBox
            // 
            this.nombreDeCursoComboBox.Enabled = false;
            this.nombreDeCursoComboBox.FormattingEnabled = true;
            this.nombreDeCursoComboBox.Location = new System.Drawing.Point(125, 36);
            this.nombreDeCursoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreDeCursoComboBox.Name = "nombreDeCursoComboBox";
            this.nombreDeCursoComboBox.Size = new System.Drawing.Size(206, 21);
            this.nombreDeCursoComboBox.TabIndex = 17;
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
            this.toolStripButton1,
            this.ModificarAnuncioToolStripButton,
            this.eleminarAnuncioToolStripButton});
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // ModificarAnuncioToolStripButton
            // 
            this.ModificarAnuncioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ModificarAnuncioToolStripButton.Enabled = false;
            this.ModificarAnuncioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ModificarAnuncioToolStripButton.Image")));
            this.ModificarAnuncioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarAnuncioToolStripButton.Name = "ModificarAnuncioToolStripButton";
            this.ModificarAnuncioToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.ModificarAnuncioToolStripButton.Text = "Modificar";
            this.ModificarAnuncioToolStripButton.Click += new System.EventHandler(this.ModificarAnuncioToolStripButton_Click_1);
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
            // frmManejoDeAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AsuntoTextBox);
            this.Controls.Add(this.anunsioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreDeCursoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmManejoDeAnuncios";
            this.Text = "frmManejoDeAnuncios";
            this.Load += new System.EventHandler(this.frmManejoDeAnuncios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AsuntoTextBox;
        private System.Windows.Forms.TextBox anunsioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nombreDeCursoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuevoAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton buscarAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton ModificarAnuncioToolStripButton;
        private System.Windows.Forms.ToolStripButton eleminarAnuncioToolStripButton;
    }
}