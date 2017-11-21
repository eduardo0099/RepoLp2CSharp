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
        private UsuarioBL usuariolog;
        private List<Carpeta> listaCarps;
        private List<List<Carpeta>> listaCarpsPasado;
        private List<Documento> listaDocs;
        private List<List<Documento>> listaDocsPasado;
        private List<String> ruta;
        private String rutaTextoLabel;
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
            usuariolog = new UsuarioBL();
            ruta = new List<string>();
            listaCarpsPasado = new List<List<Carpeta>>();
            listaDocsPasado = new List<List<Documento>>();
            Program.idCarpAct = 0;
            ruta.Add("Root");
            lblRuta.Text = " - Root ";
            listaCarps = carpetalog.devolverListasCarpetasXPadre(0,Program.userobj.Id);
            
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
            if (Program.userobj.Cargo == 0) //Profesor
            {
                toolStripButton1.Visible = true;
                toolStripSeparator1.Visible = true;
                toolStripButton2.Visible = true;
                toolStripSeparator2.Visible = true;
                toolStripButton3.Visible = true;
            }
            else if (Program.userobj.Cargo == 2) //Personal
            {
                toolStripButton1.Visible = true;
                toolStripSeparator1.Visible = true;
                toolStripButton2.Visible = true;
                toolStripSeparator2.Visible = true;
                toolStripButton3.Visible = true;
            }
            else //Alumno
            {
                toolStripButton1.Visible = false;
                toolStripSeparator1.Visible = false;
                toolStripButton2.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripButton3.Visible = false;
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
            //1 es administrador
            //2 es consumidor 
            //3 es contribuidor
            if (usuariolog.verificarPermiso(Program.userobj.Id,Program.idCarpAct,1) || usuariolog.verificarPermiso(Program.userobj.Id, Program.idCarpAct, 3))
            {
                frmAgregarDoc FrmagregaDocumento = new frmAgregarDoc();
                FrmagregaDocumento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usted no tiene permisos para agregar documentos en esta carpeta", "¡Permisos!", MessageBoxButtons.OK);
            }
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
            listaCarps = carpetalog.devolverListasCarpetasXPadre(idCarpeta, Program.userobj.Id);
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
            Program.listidCarpPast.Add(Program.idCarpAct);
            Program.idCarpAct = idCarpeta;
        }
        private void ingresaDocumento(int idDocumento)
        {
            Documento doc = documentolog.obtenerObjetoDocumento(idDocumento);
            frmVistaPreviaDocumento ventanaVistaPrevia = new frmVistaPreviaDocumento(doc, Program.idCarpAct, Program.userobj.Id);
            
            if (ventanaVistaPrevia.ShowDialog() == DialogResult.OK) {

            }
            //Que ocurre cuando se entra a una carpeta
            //MessageBox.Show("IdCarpeta: " + idDocumento + "\nIdUsuario: " + Program.userobj.Id);
            //Mostrrar form de descarga y/o edicion
        }

        private void bttPanelC_2Click(object sender, EventArgs e)
        {
            Panel clickedPanel = (Panel)sender;
            if(clickedPanel.Name == "carpeta")
            {
                ingresaCarpeta(Int32.Parse((String)clickedPanel.Tag));
                ruta.Add(clickedPanel.Controls[1].Text);
                rutaTextoLabel = "";
                foreach (String rut in ruta)
                {
                    rutaTextoLabel += " - " + rut; 
                }
                lblRuta.Text = rutaTextoLabel;
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
                ruta.Add(clickedLabel.Controls[0].Name);
                rutaTextoLabel = "";
                foreach (String rut in ruta)
                {
                    rutaTextoLabel += " - " + rut;
                }
                lblRuta.Text = rutaTextoLabel;
            }
            else if (clickedLabel.Name == "documento")
            {
                ingresaDocumento(Int32.Parse((String)clickedLabel.Tag));
            }
        }

        private Panel generarPanelCarp(int idCarp, String tituloCarpeta, String descripcion, DateTime fechaCrea)
        {
            //Label aux
            Label labAux1 = new Label();
            labAux1.Text = "";
            labAux1.Name = tituloCarpeta;
            labAux1.Size = new Size(0, 0);
            //Label aux
            Label labAux2 = new Label();
            labAux2.Text = "";
            labAux2.Name = tituloCarpeta;
            labAux2.Size = new Size(0, 0);
            //Label aux
            Label labAux3 = new Label();
            labAux3.Text = "";
            labAux3.Name = tituloCarpeta;
            labAux3.Size = new Size(0, 0);
            //Label aux
            Label labAux4 = new Label();
            labAux4.Text = "";
            labAux4.Name = tituloCarpeta;
            labAux4.Size = new Size(0, 0);
            //Imagen Carpeta
            Label labCarp = new Label();

            labCarp.Controls.Add(labAux1);
            Image i = Image.FromFile("carpeta50.png");
            labCarp.Size = new Size(i.Width, i.Height);
            labCarp.Image = i;
            labCarp.Location = new Point(42, 12);
            labCarp.Tag = idCarp.ToString();
            labCarp.DoubleClick += bttLabelC_2Click;
            labCarp.Name = "carpeta";
            //Titulo Carpeta
            Label labTit = new Label();
            labTit.Controls.Add(labAux2);
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
            labDes.Controls.Add(labAux3);
            //Fecha creacion
            Label labCrea = new Label();
            labCrea.Size = new Size(400, 20);
            labCrea.Text = "Fecha creación: " + fechaCrea.ToLongDateString();
            labCrea.Location = new Point(105, 53);
            labCrea.ForeColor = System.Drawing.Color.White;
            labCrea.Tag = idCarp.ToString();
            labCrea.DoubleClick += bttLabelC_2Click;
            labCrea.Name = "carpeta";
            labCrea.Controls.Add(labAux4);
            //CheckBoX
            //CheckBox checSec = new CheckBox();
            //checSec.Location = new Point(12, 12);
            //checSec.Size = new Size(15, 15);
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
            //p.Controls.Add(checSec);
            
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
            //CheckBoX
            CheckBox checSec;
            if (Program.userobj.Cargo != 1)
            {
                checSec = new CheckBox();
                checSec.Location = new Point(12, 12);
                checSec.Size = new Size(15, 15);
                p.Controls.Add(checSec);
            }
            
            
            naveDocs.Controls.Add(p);
            naveDocs.Invalidate();
            
            return p;
        }

        private void bttRegresar_Click(object sender, EventArgs e)
        {

            if (listaCarpsPasado.Count != 0)
            {
                ruta.RemoveAt(ruta.Count - 1);
                rutaTextoLabel = "";
                foreach (String rut in ruta)
                {
                    rutaTextoLabel += " - " + rut;
                }
                lblRuta.Text = rutaTextoLabel;
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
                Program.idCarpAct = Program.listidCarpPast[Program.listidCarpPast.Count - 1];
                Program.listidCarpPast.RemoveAt(Program.listidCarpPast.Count - 1);
            }
            else
            {
                MessageBox.Show("No se puede retroceder más");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Eliminar
            foreach(Panel pan in naveDocs.Controls)
            {
                //if (((CheckBox)pan.Controls[4]).Checked)
                //{
                //    MessageBox.Show(pan.Tag + "");
                //}
            }
        }
    }
}
