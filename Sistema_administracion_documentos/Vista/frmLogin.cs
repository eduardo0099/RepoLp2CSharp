using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista {
    public partial class frmLogin : Form {
        private string masterUser = "FreddyPaz";
        private string masterKey = "123456";
        public frmLogin() {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void frmLogin_Load(object sender, EventArgs e) {

        }

        private void bttnLogin_Click(object sender, EventArgs e) {
            //Filtros
            if (txtUsuario.Text == "") {
                MessageBox.Show("Ingrese un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtContrasena.Text == "") {
                MessageBox.Show("Ingrese una contrasena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtUsuario.Text == masterUser && txtContrasena.Text == masterKey) {
                this.Hide();
                string nombreUsuario = txtUsuario.Text;
                frmPrincipal ventanaPrincipal = new frmPrincipal(nombreUsuario);
                ventanaPrincipal.Show();
            }
            else {
                MessageBox.Show("Usuario o contrasena incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void bttnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e) {
            
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e) {
            
        }

        private void txtSelectUser_Click(object sender, EventArgs e) {
            txtUsuario.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e) {
            txtContrasena.Text = "";
        }
    }
}
