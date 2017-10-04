namespace Vista
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tolMenuDer = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSes = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.picHeader = new System.Windows.Forms.PictureBox();
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
            this.tolMenuDer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.tolMenuDer.Location = new System.Drawing.Point(0, 94);
            this.tolMenuDer.Name = "tolMenuDer";
            this.tolMenuDer.Size = new System.Drawing.Size(136, 331);
            this.tolMenuDer.TabIndex = 2;
            this.tolMenuDer.Text = "toolStrip1";
            this.tolMenuDer.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenida.Location = new System.Drawing.Point(588, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(100, 12);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "Bienvenido: ";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreUsuario.Location = new System.Drawing.Point(588, 25);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreUsuario.Size = new System.Drawing.Size(154, 12);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Eduardo Gamarra Gómez";
            // 
            // btnCerrarSes
            // 
            this.btnCerrarSes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSes.Location = new System.Drawing.Point(693, 66);
            this.btnCerrarSes.Name = "btnCerrarSes";
            this.btnCerrarSes.Size = new System.Drawing.Size(78, 22);
            this.btnCerrarSes.TabIndex = 7;
            this.btnCerrarSes.Text = "Cerrar sesión";
            this.btnCerrarSes.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.picLogo.Image = global::Vista.Properties.Resources.pucp_logo;
            this.picLogo.Location = new System.Drawing.Point(14, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(201, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(134, 19);
            this.toolStripButton2.Text = "Inicio";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(134, 19);
            this.toolStripButton1.Text = "Documentos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(779, 94);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 3;
            this.picHeader.TabStop = false;
            this.picHeader.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 425);
            this.Controls.Add(this.btnCerrarSes);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tolMenuDer);
            this.Controls.Add(this.picHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "Form1";
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
    }
}

