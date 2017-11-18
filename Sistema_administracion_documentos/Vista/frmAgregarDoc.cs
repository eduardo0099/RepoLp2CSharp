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
namespace Vista
{
    public partial class frmAgregarDoc : Form
    {
        private BindingList<CargaDoc> docsACargar;
        private int idCarpetaActual;
        private DocumentoBL documentolog;
        private CarpetaBL carpetalog;
        public frmAgregarDoc()
        {
            carpetalog = new CarpetaBL();
            String val = carpetalog.retornarNombreCarpeta(Program.idCarpAct);
            MessageBox.Show("Su archivo se agregará en la carpeta: "+ val,"Anuncio",MessageBoxButtons.OK);
            InitializeComponent();
            docsACargar = new BindingList<CargaDoc>();
            dgvListaDocs.DataSource = docsACargar;
            documentolog = new DocumentoBL();
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
            byte[] rawData = new byte[fSize];
            fs.Read(rawData, 0, (int)fSize);
            fs.Close();
            //dgvListaDocs
            CargaDoc auxCargaDoc = new CargaDoc();
            auxCargaDoc.Titulo = txtTit.Text;
            auxCargaDoc.Ruta = txtArchSelec.Text;
            docsACargar.Add(auxCargaDoc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Eliminar un archivo de la lista
            int index = dgvListaDocs.CurrentRow.Index;
            docsACargar.RemoveAt(index);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Grabar la lista de documentos a la carpeta
            Char delimiter = '\\';
            Char delimiter2 = '.';
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
                documentolog.agregarDocumento(Program.idCarpAct, Program.userobj.Id, cd.Titulo, subNombArch[0], subNombArch[1], fileData, System.Convert.ToInt32(fs.Length));
                MessageBox.Show("Documento guardado correctamente", "Aviso", MessageBoxButtons.OK);
            }
        }
    }
}
