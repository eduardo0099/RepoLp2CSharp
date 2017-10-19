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
            this.button2 = new System.Windows.Forms.Button();
            this.buscarAnuncioDataGridView = new System.Windows.Forms.DataGridView();
            this.buscarAnuncioTextBox = new System.Windows.Forms.TextBox();
            this.buscarAnuncioButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAnuncioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buscarAnuncioDataGridView
            // 
            this.buscarAnuncioDataGridView.AllowUserToAddRows = false;
            this.buscarAnuncioDataGridView.AllowUserToDeleteRows = false;
            this.buscarAnuncioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarAnuncioDataGridView.Location = new System.Drawing.Point(20, 53);
            this.buscarAnuncioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.buscarAnuncioDataGridView.Name = "buscarAnuncioDataGridView";
            this.buscarAnuncioDataGridView.ReadOnly = true;
            this.buscarAnuncioDataGridView.RowTemplate.Height = 33;
            this.buscarAnuncioDataGridView.Size = new System.Drawing.Size(362, 243);
            this.buscarAnuncioDataGridView.TabIndex = 7;
            // 
            // buscarAnuncioTextBox
            // 
            this.buscarAnuncioTextBox.Location = new System.Drawing.Point(20, 20);
            this.buscarAnuncioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.buscarAnuncioTextBox.Name = "buscarAnuncioTextBox";
            this.buscarAnuncioTextBox.Size = new System.Drawing.Size(207, 20);
            this.buscarAnuncioTextBox.TabIndex = 6;
            // 
            // buscarAnuncioButton
            // 
            this.buscarAnuncioButton.Location = new System.Drawing.Point(236, 15);
            this.buscarAnuncioButton.Margin = new System.Windows.Forms.Padding(2);
            this.buscarAnuncioButton.Name = "buscarAnuncioButton";
            this.buscarAnuncioButton.Size = new System.Drawing.Size(68, 27);
            this.buscarAnuncioButton.TabIndex = 5;
            this.buscarAnuncioButton.Text = "Buscar";
            this.buscarAnuncioButton.UseVisualStyleBackColor = true;
            // 
            // frmBuscarAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buscarAnuncioDataGridView);
            this.Controls.Add(this.buscarAnuncioTextBox);
            this.Controls.Add(this.buscarAnuncioButton);
            this.Name = "frmBuscarAnuncio";
            this.Text = "frmBuscarAnuncio";
            this.Load += new System.EventHandler(this.frmBuscarAnuncio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarAnuncioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView buscarAnuncioDataGridView;
        private System.Windows.Forms.TextBox buscarAnuncioTextBox;
        private System.Windows.Forms.Button buscarAnuncioButton;
    }
}