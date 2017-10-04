using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();
        }

        public frmDocumentos(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
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
    }
}
