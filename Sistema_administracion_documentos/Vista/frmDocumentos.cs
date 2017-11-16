using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Controlador;
namespace Vista
{

    public partial class frmDocumentos : Form
    {
        private CarpetaBL carpetalog;
        private DocumentoBL documentolog;
        private List<Carpeta> listaCarps;
        private List<List<Carpeta>> listaCarpsPasado;
        private List<Documento> listaDocs;
        private List<List<Documento>> listaDocsPasado;
        public frmDocumentos()
        {
            InitializeComponent();
            BindingList<Carpeta> c = new BindingList<Carpeta>();
            c.Add(new Carpeta());
            

        }

        public frmDocumentos(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
            naveDocs.AutoScroll = true;
            naveDocs.VerticalScroll.Visible = true;
            naveDocs.VerticalScroll.Enabled = true;
            naveDocs.HorizontalScroll.Enabled = false;
            naveDocs.HorizontalScroll.Visible = false;
            carpetalog = new CarpetaBL();
            documentolog = new DocumentoBL();
            listaCarpsPasado = new List<List<Carpeta>>();
            listaDocsPasado = new List<List<Documento>>();
            listaCarps = carpetalog.devolverListasCarpetasXPadre(0, 3);
            
            //generarPanelCarp(2,"Cursos en el ciclo","Documentos sobre el ciclo actual", DateTime.Parse("2017-11-01"));
            for (int i = 0; i < listaCarps.Count; i++)
            {
                generarPanelCarp(listaCarps[i].Id, listaCarps[i].Nombre,listaCarps[i].Descripcion,listaCarps[i].FechaCreacion);

            }
            listaDocs = documentolog.obtenerDocumentosCarpeta(0);
            for (int i = 0; i < listaDocs.Count; i++)
            {
                generarPanelDoc(listaDocs[i].Id, listaDocs[i].Nombre, listaDocs[i].Descripcion, listaDocs[i].FechaCreacion);

            }

        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            frmAgregarDoc FrmagregaDocumento = new frmAgregarDoc();
            FrmagregaDocumento.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {

        }

        private void ingresaCarpeta(int idCarpeta)
        {
            //Que ocurre cuando se entra a una carpeta
            //MessageBox.Show(idCarpeta.ToString());
            listaCarpsPasado.Add(listaCarps);
            listaCarps = carpetalog.devolverListasCarpetasXPadre(idCarpeta, 3);
            naveDocs.Controls.Clear();
            for (int i = 0; i < listaCarps.Count; i++)
            {
                generarPanelCarp(listaCarps[i].Id, listaCarps[i].Nombre, listaCarps[i].Descripcion, listaCarps[i].FechaCreacion);
            }
            //Manejo de documentos
            listaDocsPasado.Add(listaDocs);
            listaDocs = documentolog.obtenerDocumentosCarpeta(idCarpeta);
            for (int i = 0; i < listaDocs.Count; i++)
            {
                generarPanelDoc(listaDocs[i].Id, listaDocs[i].Nombre, listaDocs[i].Descripcion, listaDocs[i].FechaCreacion);

            }
        }
        private void ingresaDocumento(int idDocumento)
        {
            //Que ocurre cuando se entra a una carpeta
            MessageBox.Show("IdCarpeta: " + idDocumento + "\nIdUsuario: " + Program.userobj.Id);
            //Mostrrar form de descarga y/o edicion
        }

        private void bttPanelC_2Click(object sender, EventArgs e)
        {
            Panel clickedPanel = (Panel)sender;
            if(clickedPanel.Name == "carpeta")
            {
                ingresaCarpeta(Int32.Parse((String)clickedPanel.Tag));
            }
            else if(clickedPanel.Name == "documento")
            {
                ingresaDocumento(Int32.Parse((String)clickedPanel.Tag));
            }
            
        }

        private void bttLabelC_2Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            if (clickedLabel.Name == "carpeta")
            {
                ingresaCarpeta(Int32.Parse((String)clickedLabel.Tag));
            }
            else if (clickedLabel.Name == "documento")
            {
                ingresaDocumento(Int32.Parse((String)clickedLabel.Tag));
            }
            
        }

        private Panel generarPanelCarp(int idCarp, String tituloCarpeta, String descripcion, DateTime fechaCrea)
        {
            //Imagen Carpeta
            Label labCarp = new Label();
            Image i = Image.FromFile("carpeta50.png");
            labCarp.Size = new Size(i.Width, i.Height);
            labCarp.Image = i;
            labCarp.Location = new Point(42, 12);
            labCarp.Tag = idCarp.ToString();
            labCarp.DoubleClick += bttLabelC_2Click;
            labCarp.Name = "carpeta";
            //Titulo Carpeta
            Label labTit = new Label();
            labTit.Size = new Size(400, 20);
            labTit.Text = tituloCarpeta;
            labTit.Location = new Point(105, 12);
            labTit.ForeColor = Color.FromArgb(255, 255, 255);
            labTit.Font = new Font(labTit.Font.Name, 10, FontStyle.Bold);
            labTit.Tag = idCarp.ToString();
            labTit.DoubleClick += bttLabelC_2Click;
            labTit.Name = "carpeta";
            //Descripcion
            Label labDes = new Label();
            labDes.Size = new Size(400, 20);
            labDes.Text = descripcion;
            labDes.Location = new Point(105, 33);
            labDes.ForeColor = System.Drawing.Color.White;
            labDes.Tag = idCarp.ToString();
            labDes.DoubleClick += bttLabelC_2Click;
            labDes.Name = "carpeta";
            //Fecha creacion
            Label labCrea = new Label();
            labCrea.Size = new Size(400, 20);
            labCrea.Text = "Fecha creación: " + fechaCrea.ToLongDateString();
            labCrea.Location = new Point(105, 53);
            labCrea.ForeColor = System.Drawing.Color.White;
            labCrea.Tag = idCarp.ToString();
            labCrea.DoubleClick += bttLabelC_2Click;
            labCrea.Name = "carpeta";
            //CheckBoX
            CheckBox checSec = new CheckBox();
            checSec.Location = new Point(12, 12);
            checSec.Size = new Size(15, 15);
            //Panel
            Panel p = new Panel();
            p.Name = "carpeta";
            p.BackColor = Color.FromArgb(0, 97, 129);
            p.Size = new Size(575, 75);
            p.Tag = idCarp.ToString();
            p.DoubleClick += bttPanelC_2Click;

            p.Controls.Add(labCarp);
            p.Controls.Add(labTit);
            p.Controls.Add(labDes);
            p.Controls.Add(labCrea);
            p.Controls.Add(checSec);

            naveDocs.Controls.Add(p);
            naveDocs.Invalidate();
            return p;
        }
        private Panel generarPanelDoc(int idDocu, String tituloDocum, String descripcionD, DateTime fechaCrea)
        {
            //Imagen Documento
            Label labDoc = new Label();
            Image i = Image.FromFile("documento50.png");
            labDoc.Size = new Size(i.Width, i.Height);
            labDoc.Image = i;
            labDoc.Location = new Point(42, 12);
            labDoc.Tag = idDocu.ToString();
            labDoc.DoubleClick += bttLabelC_2Click;
            labDoc.Name = "documento";
            //Titulo Carpeta
            Label labTit = new Label();
            labTit.Size = new Size(400, 20);
            labTit.Text = tituloDocum;
            labTit.Location = new Point(105, 12);
            labTit.Name = "documento";
            labTit.ForeColor = Color.FromArgb(0, 92, 153);
            labTit.Font = new Font(labTit.Font.Name, 10, FontStyle.Bold);
            labTit.Tag = idDocu.ToString();
            labTit.DoubleClick += bttLabelC_2Click;
            //Descripcion
            Label labDes = new Label();
            labDes.Size = new Size(400, 20);
            labDes.Text = descripcionD;
            labDes.Location = new Point(105, 33);
            labDes.ForeColor = System.Drawing.Color.Black;
            labDes.Tag = idDocu.ToString();
            labDes.DoubleClick += bttLabelC_2Click;
            labDes.Name = "documento";
            //Fecha creacion
            Label labCrea = new Label();
            labCrea.Size = new Size(400, 20);
            labCrea.Text = "Fecha creación: " + fechaCrea.ToLongDateString();
            labCrea.Location = new Point(105, 53);
            labCrea.ForeColor = System.Drawing.Color.Black;
            labCrea.Tag = idDocu.ToString();
            labCrea.DoubleClick += bttLabelC_2Click;
            labCrea.Name = "documento";
            //CheckBoX
            CheckBox checSec = new CheckBox();
            checSec.Location = new Point(12, 12);
            checSec.Size = new Size(15, 15);
            //Panel
            Panel p = new Panel();
            p.Name = "documento";
            p.BackColor = Color.FromArgb(255, 255, 255);
            p.Size = new Size(575, 75);
            p.Tag = idDocu.ToString();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.DoubleClick += bttPanelC_2Click;

            p.Controls.Add(labDoc);
            p.Controls.Add(labTit);
            p.Controls.Add(labDes);
            p.Controls.Add(labCrea);
            p.Controls.Add(checSec);

            naveDocs.Controls.Add(p);
            naveDocs.Invalidate();
            
            return p;
        }

        private void bttRegresar_Click(object sender, EventArgs e)
        {
            if (listaCarpsPasado.Count != 0)
            {
                listaCarps = listaCarpsPasado[listaCarpsPasado.Count - 1];
                listaCarpsPasado.RemoveAt(listaCarpsPasado.Count - 1);
                naveDocs.Controls.Clear();
                for (int i = 0; i < listaCarps.Count; i++)
                {
                    generarPanelCarp(listaCarps[i].Id, listaCarps[i].Nombre, listaCarps[i].Descripcion, listaCarps[i].FechaCreacion);
                }

                listaDocs = listaDocsPasado[listaDocsPasado.Count - 1];
                listaDocsPasado.RemoveAt(listaDocsPasado.Count - 1);
                for (int i = 0; i < listaDocs.Count; i++)
                {
                    generarPanelDoc(listaDocs[i].Id, listaDocs[i].Nombre, listaDocs[i].Descripcion, listaDocs[i].FechaCreacion);

                }
            }
            else
            {
                MessageBox.Show("No se puede retroceder más");
            }
        }
    }
}
