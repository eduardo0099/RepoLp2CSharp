using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.IO;

namespace Vista {
    public partial class frmVistaPreviaDocumento : Form {
        private UsuarioBL sistemaUsuario;
        private DocumentoBL sistemaDocumento;
        private string nombreDocumento;
        private string descripcionDocumento;
        private string extensionDocumento;
        private int idUsuarioDocumento;
        private int idUsuarioLogueado;

        public enum estado { Inicial, Editar, Eliminado };

        public frmVistaPreviaDocumento(Documento doc, string nombreCarp, int idUsuario) {
            InitializeComponent();
            sistemaUsuario = new UsuarioBL();
            sistemaDocumento = new DocumentoBL();
            estadoCampos(estado.Inicial);

            /* IDs de los usuarios */
            idUsuarioDocumento = doc.IdUsuario;
            idUsuarioLogueado = idUsuario;

            /* Rellenar los campos del documento */
            txtboxNombre.Text = doc.Nombre; nombreDocumento = doc.Nombre;
            txtboxDescripcion.Text = doc.Descripcion; descripcionDocumento = doc.Descripcion;
            lblExtensionR.Text = doc.Extension; extensionDocumento = doc.Extension;
            lblCarpetaR.Text = nombreCarp;
            lblFechaCreacionR.Text = doc.FechaCreacion.ToString();
            if (doc.Habilitado == 1) lblEstadoR.Text = "Habilitado";
            else {
                lblExtensionL.Text = "El documento fue eliminado";
                estadoCampos(estado.Eliminado);
            }

            /* Rellenar los campos del autor */
            lblAutorR.Text = sistemaUsuario.devolverNombrePorId(doc.IdUsuario);
            lblFechaModifR.Text = doc.FechaMod.ToString();
        }

        public void estadoCampos(estado est) {
            switch (est) {
                case estado.Inicial:
                    txtboxNombre.Enabled = false;
                    txtboxDescripcion.Enabled = false;
                    bttnGuardar.Enabled = false;
                    bttnEditar.Enabled = true;
                    bttnCancelar.Enabled = false;
                    break;
                case estado.Editar:
                    txtboxNombre.Enabled = true;
                    txtboxDescripcion.Enabled = true;
                    bttnGuardar.Enabled = true;
                    bttnEditar.Enabled = false;
                    bttnCancelar.Enabled = true;
                    break;
                case estado.Eliminado:
                    txtboxNombre.Enabled = false;
                    txtboxDescripcion.Enabled = false;
                    bttnGuardar.Enabled = false;
                    bttnEditar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    bttnDescargar.Enabled = false;
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void bttnEditar_Click(object sender, EventArgs e) {
            
        }

        private void bttnCancelar_Click(object sender, EventArgs e) {
            
        }

        private void bttnGuardar_Click(object sender, EventArgs e) {
            
        }

        private void bttnDescargar_Click(object sender, EventArgs e) {
            
        }

        private void bttnDescargar_Click_1(object sender, EventArgs e) {
            /* Se descarga el archivo */
            SaveFileDialog sfd = new SaveFileDialog();

            /* Configuracion de la ventana y documento */
            sfd.Title = "Guardar documento";
            sfd.FileName = nombreDocumento;
            sfd.DefaultExt = extensionDocumento;

            /* Extensiones */
            /*sfd.Filter = "Archivo de Texto|*.txt";
            sfd.Filter = "Documento de Word|*.docx";
            sfd.Filter = "PDF|*.pdf";
            sfd.Filter = "Presentacion de Power Point|*.ppt";
            sfd.Filter = "Libro de Excel|*.xlsx";
            sfd.Filter = "JPEG|*.jpg";
            sfd.Filter = "PNG|*.png";
            sfd.Filter = "BMP|*.bmp";
            sfd.Filter = "GIF|*.gif";
            sfd.Filter = "Pagina Web|*.html";*/

            /* Se abre la ventana */
            if (sfd.ShowDialog() == DialogResult.OK) {
                string path = sfd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write("Holi");
                bw.Dispose();
            }
        }

        private void bttnGuardar_Click_1(object sender, EventArgs e) {
            /* Se modifica el nombre y la descripcion*/
            nombreDocumento = txtboxNombre.Text;
            descripcionDocumento = txtboxDescripcion.Text;
            sistemaDocumento.actualizarNombreDocumento(nombreDocumento);
            sistemaDocumento.actualizarDescripcionDocumento(descripcionDocumento);
        }

        private void bttnEditar_Click_1(object sender, EventArgs e) {
            if (idUsuarioDocumento == idUsuarioLogueado)
                estadoCampos(estado.Editar);
            else
                MessageBox.Show("Solo el autor puede editar el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bttnCancelar_Click_1(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Los cambios no se guardaran", "¿Seguro que desea cancelar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                txtboxNombre.Text = nombreDocumento;
                txtboxDescripcion.Text = descripcionDocumento;
                estadoCampos(estado.Inicial);
            }
        }
    }
}
