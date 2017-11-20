using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using System.Net.Mail;
using System.Net;

namespace Vista
{
    public partial class frmRecuperarCuenta : Form
    {
        private UsuarioBL sistemaUsuario;
        public frmRecuperarCuenta()
        {
            InitializeComponent();
            sistemaUsuario = new UsuarioBL();
        }

        private void bttEnviarRecuContra_Click(object sender, EventArgs e) {
            /* Se busca el ID del usuario */
            if (txtUsuRecuContra.Text == "") {
                MessageBox.Show("Ingrese un usuario", "Error");
                return;
            }
            int idUsuario = sistemaUsuario.devolverIDUsuario(txtUsuRecuContra.Text); //Busqueda
            if (idUsuario < 0) {
                MessageBox.Show("El usuario que usted ingreso, no existe", "Error");
                return;
            }

            /* Se busca el correo del usuario */
            if (txtCorreoRecuUsu.Text == "") {
                MessageBox.Show("Ingrese un correo alternativo", "Error");
                return;
            }
            string correo = sistemaUsuario.obtenerCorreoAlternativo(idUsuario); //Busqueda
            if (correo == "") {
                MessageBox.Show("No existe correo alternativo asociado al usuario", "Error");
                return;
            }
            if (correo != txtCorreoRecuUsu.Text) {
                MessageBox.Show("Ingrese correctamente el correo alternativo", "Error");
                return;
            }

            /* Se busca la contrasena */
            string contrasena = sistemaUsuario.obtenerContrasenaUsuario(idUsuario);

            string correoCredencial = "sistemalp2@gmail.com";
            string contraCredencial = "chistema2017";
            string asunto = "Gestor Documental - Informacion de Cuenta";
            string nombre = sistemaUsuario.devolverNombrePorId(idUsuario);
            string contenido = "Estimado " + nombre + ":\n" +
                               "La informacion de su cuenta es la siguiente:\n\n" +
                               "\t\tUsuario: " + txtUsuRecuContra.Text + "\n" +
                               "\t\tContrasena: " + contrasena + "\n\n" +
                               "Ante cualquier consulta no dude en escribirnos a nuestro correo " + correoCredencial + ".\n" +
                               "\nAtte.\nEl equipo de Gestor Documental.";

            /* Se envia el correo */
            using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587)) {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(correoCredencial, contraCredencial);
                MailMessage mensaje = new MailMessage(correoCredencial, correo, asunto, contenido);

                try {
                    cliente.Send(mensaje);
                    MessageBox.Show("El correo fue enviado. Revise su bandeja de entrada.", "Exito");
                }
                catch (Exception exc) {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}
