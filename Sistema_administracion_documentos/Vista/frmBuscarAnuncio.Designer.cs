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
            this.buscarAnuncioButton = new System.Windows.Forms.Button();
            this.buscarAnuncioTextBox = new System.Windows.Forms.TextBox();
            this.buscarAnuncioDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAnuncioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarAnuncioButton
            // 
            this.buscarAnuncioButton.Location = new System.Drawing.Point(473, 46);
            this.buscarAnuncioButton.Name = "buscarAnuncioButton";
            this.buscarAnuncioButton.Size = new System.Drawing.Size(135, 51);
            this.buscarAnuncioButton.TabIndex = 0;
            this.buscarAnuncioButton.Text = "Buscar";
            this.buscarAnuncioButton.UseVisualStyleBackColor = true;
            // 
            // buscarAnuncioTextBox
            // 
            this.buscarAnuncioTextBox.Location = new System.Drawing.Point(41, 56);
            this.buscarAnuncioTextBox.Name = "buscarAnuncioTextBox";
            this.buscarAnuncioTextBox.Size = new System.Drawing.Size(410, 31);
            this.buscarAnuncioTextBox.TabIndex = 1;
            // 
            // buscarAnuncioDataGridView
            // 
            this.buscarAnuncioDataGridView.AllowUserToAddRows = false;
            this.buscarAnuncioDataGridView.AllowUserToDeleteRows = false;
            this.buscarAnuncioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarAnuncioDataGridView.Location = new System.Drawing.Point(41, 120);
            this.buscarAnuncioDataGridView.Name = "buscarAnuncioDataGridView";
            this.buscarAnuncioDataGridView.ReadOnly = true;
            this.buscarAnuncioDataGridView.RowTemplate.Height = 33;
            this.buscarAnuncioDataGridView.Size = new System.Drawing.Size(723, 468);
            this.buscarAnuncioDataGridView.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmBuscarAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buscarAnuncioDataGridView);
            this.Controls.Add(this.buscarAnuncioTextBox);
            this.Controls.Add(this.buscarAnuncioButton);
            this.Name = "frmBuscarAnuncio";
            this.Text = "Buscar Anuncio";
            ((System.ComponentModel.ISupportInitialize)(this.buscarAnuncioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarAnuncioButton;
        private System.Windows.Forms.TextBox buscarAnuncioTextBox;
        private System.Windows.Forms.DataGridView buscarAnuncioDataGridView;
        private System.Windows.Forms.Button button2;
    }
}