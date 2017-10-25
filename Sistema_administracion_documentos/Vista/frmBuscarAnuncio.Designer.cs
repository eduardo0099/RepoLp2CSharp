namespace Vista
{
    partial class frmBuscarAnuncio
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
            this.btnSeleccionarAnuncio = new System.Windows.Forms.Button();
            this.buscarAnuncioDataGridView = new System.Windows.Forms.DataGridView();
            this.buscarAnuncioTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarAnuncio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAnuncioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarAnuncio
            // 
            this.btnSeleccionarAnuncio.Location = new System.Drawing.Point(614, 29);
            this.btnSeleccionarAnuncio.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarAnuncio.Name = "btnSeleccionarAnuncio";
            this.btnSeleccionarAnuncio.Size = new System.Drawing.Size(150, 52);
            this.btnSeleccionarAnuncio.TabIndex = 8;
            this.btnSeleccionarAnuncio.Text = "Seleccionar";
            this.btnSeleccionarAnuncio.UseVisualStyleBackColor = true;
            this.btnSeleccionarAnuncio.Click += new System.EventHandler(this.btnSeleccionarAnuncio_Click);
            // 
            // buscarAnuncioDataGridView
            // 
            this.buscarAnuncioDataGridView.AllowUserToAddRows = false;
            this.buscarAnuncioDataGridView.AllowUserToDeleteRows = false;
            this.buscarAnuncioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarAnuncioDataGridView.Location = new System.Drawing.Point(40, 102);
            this.buscarAnuncioDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.buscarAnuncioDataGridView.Name = "buscarAnuncioDataGridView";
            this.buscarAnuncioDataGridView.ReadOnly = true;
            this.buscarAnuncioDataGridView.RowTemplate.Height = 33;
            this.buscarAnuncioDataGridView.Size = new System.Drawing.Size(724, 467);
            this.buscarAnuncioDataGridView.TabIndex = 7;
            // 
            // buscarAnuncioTextBox
            // 
            this.buscarAnuncioTextBox.Location = new System.Drawing.Point(40, 38);
            this.buscarAnuncioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.buscarAnuncioTextBox.Name = "buscarAnuncioTextBox";
            this.buscarAnuncioTextBox.Size = new System.Drawing.Size(376, 31);
            this.buscarAnuncioTextBox.TabIndex = 6;
            // 
            // btnBuscarAnuncio
            // 
            this.btnBuscarAnuncio.Location = new System.Drawing.Point(440, 29);
            this.btnBuscarAnuncio.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarAnuncio.Name = "btnBuscarAnuncio";
            this.btnBuscarAnuncio.Size = new System.Drawing.Size(166, 52);
            this.btnBuscarAnuncio.TabIndex = 5;
            this.btnBuscarAnuncio.Text = "Buscar";
            this.btnBuscarAnuncio.UseVisualStyleBackColor = true;
            // 
            // frmBuscarAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 612);
            this.Controls.Add(this.btnSeleccionarAnuncio);
            this.Controls.Add(this.buscarAnuncioDataGridView);
            this.Controls.Add(this.buscarAnuncioTextBox);
            this.Controls.Add(this.btnBuscarAnuncio);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBuscarAnuncio";
            this.Text = "frmBuscarAnuncio";
            this.Load += new System.EventHandler(this.frmBuscarAnuncio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarAnuncioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarAnuncio;
        private System.Windows.Forms.DataGridView buscarAnuncioDataGridView;
        private System.Windows.Forms.TextBox buscarAnuncioTextBox;
        private System.Windows.Forms.Button btnBuscarAnuncio;
    }
}