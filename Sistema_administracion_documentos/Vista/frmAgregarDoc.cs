using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Controlador;
using System.Threading;

namespace Vista
{
    public partial class frmAgregarDoc : Form
    {
        private BindingList<CargaDoc> docsACargar;
        private int idCarpetaActual;
        private DocumentoBL documentolog;
        private CarpetaBL carpetalog;
        private CicloBL ciclolog;
        public frmAgregarDoc()
        {
            carpetalog = new CarpetaBL();
            ciclolog = new CicloBL();
            String val = carpetalog.retornarNombreCarpeta(Program.idCarpAct);
            MessageBox.Show("Su archivo se agregará en la carpeta: " + val, "Anuncio", MessageBoxButtons.OK);
            InitializeComponent();
            docsACargar = new BindingList<CargaDoc>();
            dgvListaDocs.DataSource = docsACargar;
            dgvListaDocs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            documentolog = new DocumentoBL();
            if (Program.userobj.Cargo == 0)
            {
                cmbTipoDoc.Text = "Normal";
                cmbTipoDoc.Items.Add("Evaluación");
                cmbTipoDoc.Items.Add("Normal");

            }
            else if (Program.userobj.Cargo == 2)
            {
                cmbTipoDoc.Items.Add("Administrativo");
                cmbTipoDoc.Text = "Administrativo";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAgregarDoc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtArchSelec.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            long fSize = fs.Length;

            if (fSize <= 1000000)
            {
                if ((cmbTipoDoc.Text != "") && (txtTit.Text != ""))
                {
                    byte[] rawData = new byte[fSize];
                    fs.Read(rawData, 0, (int)fSize);
                    fs.Close();
                    //dgvListaDocs
                    CargaDoc auxCargaDoc = new CargaDoc();
                    auxCargaDoc.Titulo = txtTit.Text;
                    auxCargaDoc.Ruta = txtArchSelec.Text;
                    auxCargaDoc.TipoDoc = cmbTipoDoc.Text;
                    docsACargar.Add(auxCargaDoc);
                }
                else
                {
                    MessageBox.Show("Falta llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("No se puede agregar archivo mayores a 1MB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Eliminar un archivo de la lista
            int index = dgvListaDocs.CurrentRow.Index;
            docsACargar.RemoveAt(index);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (docsACargar.Count != 0)
            {
                //Grabar la lista de documentos a la carpeta
                Char delimiter = '\\';
                Char delimiter2 = '.';
                frmCarga frmc = new frmCarga();
                //frmc.Visible = true;
                frmc.ShowDialog();

                foreach (CargaDoc cd in docsACargar)
                {

                    FileStream fs = new FileStream(cd.Ruta, FileMode.OpenOrCreate, FileAccess.Read);
                    byte[] fileData = new byte[fs.Length];
                    fs.Read(fileData, 0, System.Convert.ToInt32(fs.Length));
                    String[] substrings = cd.Ruta.Split(delimiter);

                    String nombArchivo = "";
                    foreach (String substring in substrings)
                    {
                        nombArchivo = substring;
                    }
                    String[] subNombArch = nombArchivo.Split(delimiter2);
                    int idAgreg = documentolog.agregarDocumento(Program.idCarpAct, Program.userobj.Id, cd.Titulo, subNombArch[0], subNombArch[1], fileData, System.Convert.ToInt32(fs.Length));
                    int cicloActual = ciclolog.busquedaCicloVingente();
                    if (cd.TipoDoc == "Evaluación")
                    {
                        int idCusoActual = carpetalog.devolveridCursoDeCarpeta(Program.idCarpAct);
                        documentolog.insertarDocEvaluacion(idAgreg, cicloActual, idCusoActual);

                    }
                    else if (cd.TipoDoc == "Administrativo")
                    {
                        MessageBox.Show("es de admi");
                    }
                    else
                    {
                        int idCusoActual = carpetalog.devolveridCursoDeCarpeta(Program.idCarpAct);
                        documentolog.insertarDocDocente(idAgreg, cicloActual, idCusoActual);
                    }

                }
                //try
                //{
                //    Thread t = new Thread(prueba);
                //    t.Start();

                //}
                //catch (Exception ex)
                //{

                //}
                

                //frmc.Visible = false;
                //frmc.Dispose();
                MessageBox.Show("Documento guardado correctamente", "Aviso", MessageBoxButtons.OK);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No hay documentos para cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void prueba()
        {
            Thread.Sleep(5000);

        }
    }
}
