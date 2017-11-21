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
        private int idDocumento;
        private int idCarpeta;
        private Documento docParam;

        public enum estado { Inicial, Editar, Eliminado };
        private Dictionary<string, string> dia;
        private string[] mes = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto",
        "septiembre", "octubre", "noviembre", "diciembre"};

        public frmVistaPreviaDocumento(Documento doc, int idCarpetaAux, int idUsuario) {
            docParam = new Documento();
            docParam = doc;
            InitializeComponent();

            sistemaUsuario = new UsuarioBL();
            sistemaDocumento = new DocumentoBL();
            estadoCampos(estado.Inicial);
            dia = new Dictionary<string, string>();
            inicializarMapas();
            /* IDs de los usuarios y documento*/
            idUsuarioDocumento = doc.IdUsuario;
            idUsuarioLogueado = idUsuario;
            idDocumento = doc.Id;
            idCarpeta = idCarpetaAux;

            /* Auditoria */
            sistemaUsuario.registrarMovimientoUsuario(idDocumento, idUsuarioLogueado);

            /* Rellenar los campos del documento */
            txtboxNombre.Text = doc.Nombre; nombreDocumento = doc.Nombre;
            txtboxDescripcion.Text = doc.Descripcion; descripcionDocumento = doc.Descripcion;
            lblExtensionR.Text = doc.Extension; extensionDocumento = doc.Extension;
            //lblCarpetaR.Text = nombreCarp;

            //Dia de creacion
            lblFechaCreacionR.Text = dia[doc.FechaCreacion.DayOfWeek.ToString()] + ", " +
                                     doc.FechaCreacion.Day.ToString() + " de " +
                                     mes[doc.FechaCreacion.Month - 1] + " de " +
                                     doc.FechaCreacion.Year;
            
            if (doc.Habilitado == 1) lblEstadoR.Text = "Habilitado";
            else {
                lblExtensionL.Text = "El documento fue eliminado";
                estadoCampos(estado.Eliminado);
            }

            /* Rellenar los campos del autor */
            lblAutorR.Text = sistemaUsuario.devolverNombrePorId(doc.IdUsuario);
            lblFechaModifR.Text = dia[doc.FechaMod.DayOfWeek.ToString()] + ", " +
                                  doc.FechaMod.Day.ToString() + " de " +
                                  mes[doc.FechaMod.Month - 1] + " de " +
                                  doc.FechaMod.Year;

            /* Vista previa del documento */
            

        }

        public void inicializarMapas() {
            //Dias
            dia["Monday"] = "lunes";
            dia["Tuesday"] = "martes";
            dia["Wednesday"] = "miercoles";
            dia["Thursday"] = "jueves";
            dia["Friday"] = "viernes";
            dia["Saturday"] = "sabado";
            dia["Sunday"] = "domingo;";
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
            sfd.Filter = "PDF|*.pdf";
            
            /* Se abre la ventana */
            if (sfd.ShowDialog() == DialogResult.OK) {
                string path = sfd.FileName;
                File.WriteAllBytes(path, docParam.DatosBinary);
            }
        }

        private void bttnGuardar_Click_1(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Se modificaran los datos", "¿Esta seguro que desea guardar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                /* Se modifica el nombre y la descripcion*/
                nombreDocumento = txtboxNombre.Text;
                descripcionDocumento = txtboxDescripcion.Text;

                MessageBox.Show("nombre: " + nombreDocumento + "\ndescripcion" + descripcionDocumento + "\niddocumento" + idDocumento);

                sistemaDocumento.actualizarNombreDocumento(nombreDocumento, idDocumento);
                sistemaDocumento.actualizarDescripcionDocumento(descripcionDocumento, idDocumento);
                sistemaDocumento.actualizarFechaModDocumento(idDocumento);

                estadoCampos(estado.Inicial);
            }
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
