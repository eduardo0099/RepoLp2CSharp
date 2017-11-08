using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAgregarDoc : Form
    {
        public frmAgregarDoc()
        {
            InitializeComponent();

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

        }
    }
}
