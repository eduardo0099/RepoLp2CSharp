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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDocumentoToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // registrarDocumentoToolStripMenuItem
            // 
            this.registrarDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirDocumentoToolStripMenuItem,
            this.modificarDocumentoToolStripMenuItem,
            this.eliminarDocumentoToolStripMenuItem,
            this.buscarDocumentoToolStripMenuItem});
            this.registrarDocumentoToolStripMenuItem.Name = "registrarDocumentoToolStripMenuItem";
            this.registrarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registrarDocumentoToolStripMenuItem.Text = "Gestionar documentos";
            // 
            // añadirDocumentoToolStripMenuItem
            // 
            this.añadirDocumentoToolStripMenuItem.Name = "añadirDocumentoToolStripMenuItem";
            this.añadirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.añadirDocumentoToolStripMenuItem.Text = "Añadir documento";
            // 
            // modificarDocumentoToolStripMenuItem
            // 
            this.modificarDocumentoToolStripMenuItem.Name = "modificarDocumentoToolStripMenuItem";
            this.modificarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modificarDocumentoToolStripMenuItem.Text = "Modificar documento";
            // 
            // eliminarDocumentoToolStripMenuItem
            // 
            this.eliminarDocumentoToolStripMenuItem.Name = "eliminarDocumentoToolStripMenuItem";
            this.eliminarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.eliminarDocumentoToolStripMenuItem.Text = "Eliminar documento";
            // 
            // buscarDocumentoToolStripMenuItem
            // 
            this.buscarDocumentoToolStripMenuItem.Name = "buscarDocumentoToolStripMenuItem";
            this.buscarDocumentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.buscarDocumentoToolStripMenuItem.Text = "Buscar documento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 323);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pantalla principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarDocumentoToolStripMenuItem;
    }
}

