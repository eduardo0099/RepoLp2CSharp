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
    public partial class frmManejoDeAnuncios : Form
    {
        public frmManejoDeAnuncios()
        {
            InitializeComponent();
        }


        private void frmManejoDeAnuncios_Load(object sender, EventArgs e)
        {

        }

        private void nuevoAnuncioToolStripButton_Click(object sender, EventArgs e)
        {
            nombreDeCursoComboBox.Enabled = true;
            AsuntoTextBox.Enabled = true;
            anunsioTextBox.Enabled = true;
        }

        private void buscarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            frmBuscarAnuncio formBuscarAnuncio = new frmBuscarAnuncio();
            formBuscarAnuncio.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void eleminarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            DialogResult eliminateResult = MessageBox.Show("Está seguro?", "somethin", MessageBoxButtons.YesNo);
            if (eliminateResult == DialogResult.Yes)
            {

            }
        }

        private void ModificarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            nombreDeCursoComboBox.Enabled = true;
            AsuntoTextBox.Enabled = true;
            anunsioTextBox.Enabled = true;
        }
    }
}
