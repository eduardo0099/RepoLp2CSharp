using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class frmInfoPersonal : Form
    {
        private UsuarioBL usuarioBL = new UsuarioBL();

        public frmInfoPersonal()
        {
            InitializeComponent();
            estadoInit();
        }

        public void estadoInit()
        {
            txtContActual.Enabled = false;
            txtContNuevo.Enabled = false;
            txtRepetirContNuevo.Enabled = false;
            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            btnEditar.Visible = true;
            txtCorreo.Enabled = false;
            txtCorreoAlt.Enabled = false;
            txtDireccion.Enabled = false;
            txtNumero.Enabled = false;
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtNumero.Text = "";
            try
            {
                txtDNI.Text = Program.userobj.Dni;
                txtNombres.Text = Program.userobj.Nombres;
                txtApellidos.Text = Program.userobj.APaterno + " " + Program.userobj.AMaterno;
                txtCorreo.Text = Program.userobj.Email;
                txtCorreoAlt.Text = Program.userobj.EmailAlt;
                txtDireccion.Text = Program.userobj.Direccion;
                txtNumero.Text = Program.userobj.NumeroTele;
            }catch(Exception e) { } // if it doesn't work the feelds are blank
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            txtCorreoAlt.Enabled = true;
            txtDireccion.Enabled = true;
            txtNumero.Enabled = true;
            txtContActual.Enabled = true;
            txtContNuevo.Enabled = true;
            txtRepetirContNuevo.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContActual.Text != "" && txtContNuevo.Text != "")
            {
                if (txtContActual.Text == Program.userobj.Contrasena && txtContNuevo.Text == txtRepetirContNuevo.Text)
                {
                    Program.userobj.Contrasena = txtContNuevo.Text;
                }
                else {
                    MessageBox.Show("Entrada está incorrecta, cambia de la contraseña ha fallado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContActual.Text = "";
                    txtContNuevo.Text = "";
                    txtRepetirContNuevo.Text = "";
                    return;
                }
            }
            if (txtCorreoAlt.Text != "")
            {
                Program.userobj.EmailAlt = txtCorreoAlt.Text;
            }
            if (txtDireccion.Text != "")
            {
                Program.userobj.Direccion = txtDireccion.Text;
            }
            if (txtNumero.Text != "")
            {
                Program.userobj.NumeroTele = txtNumero.Text;
            }
            usuarioBL.actualizarUsuario(Program.userobj);
            MessageBox.Show("Nuevo informacion ha guardado", "Success!", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro", "todos los cambias van a cancelar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                estadoInit();
            }
        }
    }
}
