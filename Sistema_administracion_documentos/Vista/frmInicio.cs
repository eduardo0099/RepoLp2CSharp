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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public frmInicio(Form padre)
        {
            InitializeComponent();
            

            this.MdiParent = padre;
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
