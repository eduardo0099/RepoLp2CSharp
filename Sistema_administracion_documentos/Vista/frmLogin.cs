using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;

namespace Vista {
    public partial class frmLogin : Form {
        private UsuarioBL sistemaUsuario;
        private string nombreUsuario;
        public bool estado = true;
        private bool limpiarCampoUsuario = false;
        private bool limpiarCampoContra = false;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        public frmLogin() {
            InitializeComponent();
            sistemaUsuario = new UsuarioBL();
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
                MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sistemaUsuario.validarUsuario(txtUsuario.Text, txtContrasena.Text)) {
                NombreUsuario = sistemaUsuario.obtenerNombreUsuario(txtUsuario.Text);
                this.DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Cerrar(object sender, FormClosingEventArgs e) {
            //this.DialogResult = DialogResult.OK;
            this.estado = false;

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                //Filtros
                if (txtUsuario.Text == "") {
                    MessageBox.Show("Ingrese un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtContrasena.Text == "") {
                    MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (sistemaUsuario.validarUsuario(txtUsuario.Text, txtContrasena.Text)) {
                    NombreUsuario = sistemaUsuario.obtenerNombreUsuario(txtUsuario.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                //Filtros
                if (txtUsuario.Text == "") {
                    MessageBox.Show("Ingrese un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtContrasena.Text == "") {
                    MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (sistemaUsuario.validarUsuario(txtUsuario.Text, txtContrasena.Text)) {
                    NombreUsuario = sistemaUsuario.obtenerNombreUsuario(txtUsuario.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                //Filtros
                if (txtUsuario.Text == "") {
                    MessageBox.Show("Ingrese un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtContrasena.Text == "") {
                    MessageBox.Show("Ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (sistemaUsuario.validarUsuario(txtUsuario.Text, txtContrasena.Text)) {
                    NombreUsuario = sistemaUsuario.obtenerNombreUsuario(txtUsuario.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Usuario o contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e) {
            if (!limpiarCampoUsuario) txtUsuario.Text = "";
            limpiarCampoUsuario = true;
        }

        private void txtContrasena_Click(object sender, EventArgs e) {
            if (!limpiarCampoContra) txtContrasena.Text = "";
            limpiarCampoContra = true;
        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            frmRecuperarCuenta ventanaRecuperar = new frmRecuperarCuenta();
            ventanaRecuperar.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
