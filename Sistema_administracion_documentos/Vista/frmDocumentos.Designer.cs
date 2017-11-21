namespace Vista
{
    partial class frmDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentos));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.naveDocs = new System.Windows.Forms.FlowLayoutPanel();
            this.bttRegresar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 36);
            this.toolStripButton1.Text = "Agregar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 36);
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(104, 36);
            this.toolStripButton3.Text = "Eliminar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1300, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // naveDocs
            // 
            this.naveDocs.AutoScroll = true;
            this.naveDocs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.naveDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.naveDocs.Location = new System.Drawing.Point(52, 113);
            this.naveDocs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.naveDocs.Name = "naveDocs";
            this.naveDocs.Size = new System.Drawing.Size(1200, 644);
            this.naveDocs.TabIndex = 2;
            // 
            // bttRegresar
            // 
            this.bttRegresar.Location = new System.Drawing.Point(1104, 58);
            this.bttRegresar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(150, 44);
            this.bttRegresar.TabIndex = 3;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = true;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(116, 58);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 25);
            this.lblRuta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ruta:";
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.naveDocs);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 829);
            this.Name = "frmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocumentos";
            this.Load += new System.EventHandler(this.frmDocumentos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel naveDocs;
        private System.Windows.Forms.Button bttRegresar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label label1;
    }
}