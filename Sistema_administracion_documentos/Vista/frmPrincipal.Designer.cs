namespace Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tolMenuDer = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSes = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.btnDetallesPersonal = new System.Windows.Forms.Button();
            this.tolMenuDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // tolMenuDer
            // 
            this.tolMenuDer.AutoSize = false;
            this.tolMenuDer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tolMenuDer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolMenuDer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tolMenuDer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.tolMenuDer.Location = new System.Drawing.Point(0, 116);
            this.tolMenuDer.Name = "tolMenuDer";
            this.tolMenuDer.Size = new System.Drawing.Size(181, 547);
            this.tolMenuDer.TabIndex = 2;
            this.tolMenuDer.Text = "toolStrip1";
            this.tolMenuDer.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(179, 24);
            this.toolStripButton2.Text = "Inicio";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(179, 24);
            this.toolStripButton1.Text = "Documentos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(179, 24);
            this.toolStripButton3.Text = "Nuevo anuncio";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenida.Location = new System.Drawing.Point(837, 20);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(133, 15);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "Bienvenido,";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(837, 41);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreUsuario.Size = new System.Drawing.Size(205, 15);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // btnCerrarSes
            // 
            this.btnCerrarSes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarSes.Location = new System.Drawing.Point(938, 82);
            this.btnCerrarSes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSes.Name = "btnCerrarSes";
            this.btnCerrarSes.Size = new System.Drawing.Size(104, 27);
            this.btnCerrarSes.TabIndex = 7;
            this.btnCerrarSes.Text = "Cerrar sesión";
            this.btnCerrarSes.UseVisualStyleBackColor = true;
            this.btnCerrarSes.Click += new System.EventHandler(this.btnCerrarSes_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.picLogo.Image = global::Vista.Properties.Resources.pucp_logo;
            this.picLogo.Location = new System.Drawing.Point(19, 7);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(268, 102);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(1062, 116);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 3;
            this.picHeader.TabStop = false;
            this.picHeader.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDetallesPersonal
            // 
            this.btnDetallesPersonal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDetallesPersonal.Location = new System.Drawing.Point(826, 82);
            this.btnDetallesPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetallesPersonal.Name = "btnDetallesPersonal";
            this.btnDetallesPersonal.Size = new System.Drawing.Size(104, 27);
            this.btnDetallesPersonal.TabIndex = 9;
            this.btnDetallesPersonal.Text = "Ver tu info";
            this.btnDetallesPersonal.UseVisualStyleBackColor = true;
            this.btnDetallesPersonal.Click += new System.EventHandler(this.btnDetallesPersonal_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 663);
            this.Controls.Add(this.btnDetallesPersonal);
            this.Controls.Add(this.btnCerrarSes);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tolMenuDer);
            this.Controls.Add(this.picHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 710);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tolMenuDer.ResumeLayout(false);
            this.tolMenuDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tolMenuDer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnCerrarSes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button btnDetallesPersonal;
    }
}

