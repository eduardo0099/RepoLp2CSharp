namespace Vista {
    partial class frmLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblSep2 = new System.Windows.Forms.Label();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.picContrasena = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.picUserLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblRecuperar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtContrasena);
            this.panel1.Controls.Add(this.lblSep2);
            this.panel1.Controls.Add(this.lblSep1);
            this.panel1.Controls.Add(this.bttnLogin);
            this.panel1.Controls.Add(this.picContrasena);
            this.panel1.Controls.Add(this.picUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 198);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar.Location = new System.Drawing.Point(99, 160);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(119, 13);
            this.lblRecuperar.TabIndex = 7;
            this.lblRecuperar.Text = "¿Olvidó su contraseña?";
            this.lblRecuperar.Click += new System.EventHandler(this.lblRecuperar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.Location = new System.Drawing.Point(64, 39);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(224, 13);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.Location = new System.Drawing.Point(64, 90);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(224, 13);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.Text = "Contrasena";
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            // 
            // lblSep2
            // 
            this.lblSep2.AutoSize = true;
            this.lblSep2.BackColor = System.Drawing.Color.Transparent;
            this.lblSep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSep2.Location = new System.Drawing.Point(62, 94);
            this.lblSep2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSep2.Name = "lblSep2";
            this.lblSep2.Size = new System.Drawing.Size(229, 13);
            this.lblSep2.TabIndex = 6;
            this.lblSep2.Text = "_____________________________________";
            // 
            // lblSep1
            // 
            this.lblSep1.AutoSize = true;
            this.lblSep1.BackColor = System.Drawing.Color.Transparent;
            this.lblSep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSep1.Location = new System.Drawing.Point(62, 43);
            this.lblSep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(229, 13);
            this.lblSep1.TabIndex = 5;
            this.lblSep1.Text = "_____________________________________";
            // 
            // bttnLogin
            // 
            this.bttnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(127, 135);
            this.bttnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(67, 22);
            this.bttnLogin.TabIndex = 4;
            this.bttnLogin.Text = "Acceder";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // picContrasena
            // 
            this.picContrasena.Image = global::Vista.Properties.Resources.usuario;
            this.picContrasena.Location = new System.Drawing.Point(27, 84);
            this.picContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picContrasena.Name = "picContrasena";
            this.picContrasena.Size = new System.Drawing.Size(26, 29);
            this.picContrasena.TabIndex = 2;
            this.picContrasena.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::Vista.Properties.Resources.usuario2;
            this.picUsuario.Location = new System.Drawing.Point(27, 33);
            this.picUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(26, 29);
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // picUserLogo
            // 
            this.picUserLogo.Image = global::Vista.Properties.Resources.loguin;
            this.picUserLogo.Location = new System.Drawing.Point(77, 24);
            this.picUserLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUserLogo.Name = "picUserLogo";
            this.picUserLogo.Size = new System.Drawing.Size(172, 177);
            this.picUserLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUserLogo.TabIndex = 0;
            this.picUserLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(317, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picUserLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUserLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox picContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblSep1;
        private System.Windows.Forms.Label lblSep2;
        private System.Windows.Forms.Label lblRecuperar;
    }
}