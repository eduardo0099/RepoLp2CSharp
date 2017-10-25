namespace Vista
{
    partial class frmRecuperarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarCuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuRecuContra = new System.Windows.Forms.TextBox();
            this.txtCorreoRecuUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bttEnviarRecuContra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "\t¿Olvidó su contraseña? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor, ingrese su identificación de usuario para recuperar su contraseña.";
            // 
            // txtUsuRecuContra
            // 
            this.txtUsuRecuContra.Location = new System.Drawing.Point(155, 72);
            this.txtUsuRecuContra.Name = "txtUsuRecuContra";
            this.txtUsuRecuContra.Size = new System.Drawing.Size(177, 20);
            this.txtUsuRecuContra.TabIndex = 2;
            // 
            // txtCorreoRecuUsu
            // 
            this.txtCorreoRecuUsu.Location = new System.Drawing.Point(155, 98);
            this.txtCorreoRecuUsu.Name = "txtCorreoRecuUsu";
            this.txtCorreoRecuUsu.Size = new System.Drawing.Size(177, 20);
            this.txtCorreoRecuUsu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo Alternativo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "*";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(15, 126);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(419, 76);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // bttEnviarRecuContra
            // 
            this.bttEnviarRecuContra.Location = new System.Drawing.Point(200, 208);
            this.bttEnviarRecuContra.Name = "bttEnviarRecuContra";
            this.bttEnviarRecuContra.Size = new System.Drawing.Size(75, 23);
            this.bttEnviarRecuContra.TabIndex = 9;
            this.bttEnviarRecuContra.Text = "Enviar";
            this.bttEnviarRecuContra.UseVisualStyleBackColor = true;
            // 
            // frmRecuperarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 240);
            this.Controls.Add(this.bttEnviarRecuContra);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreoRecuUsu);
            this.Controls.Add(this.txtUsuRecuContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRecuperarCuenta";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuRecuContra;
        private System.Windows.Forms.TextBox txtCorreoRecuUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bttEnviarRecuContra;
    }
}