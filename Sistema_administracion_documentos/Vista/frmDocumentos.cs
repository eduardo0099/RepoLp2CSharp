using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
namespace Vista
{
    public partial class frmDocumentos : Form
    {
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

            treeView1.Nodes.Add("LP2");
            treeView1.Nodes.Add("LP1");
            treeView1.Nodes.Add("SI2");
            treeView1.Nodes.Add("SI3");
            treeView1.Nodes.Add("FP");
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
    }
}
