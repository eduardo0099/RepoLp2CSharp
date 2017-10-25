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
            estadoInitsial();
        }

        private void frmManejoDeAnuncios_Load(object sender, EventArgs e)
        {

        }

        private void nuevoAnuncioToolStripButton_Click(object sender, EventArgs e)
        {
            nombreDeCursoComboBox.Enabled = true;
            txtTitulo.Enabled = true;
            txtAnunsio.Enabled = true;
            buscarAnuncioToolStripButton.Enabled = false;
            nuevoAnuncioToolStripButton.Enabled = false;
            cancelarToolStripButton.Enabled = true;
            guardarAnuncioToolStripButton.Enabled = true;
        }

        private void buscarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            frmBuscarAnuncio formBuscarAnuncio = new frmBuscarAnuncio();
            //formBuscarAnuncio.Show();
            formBuscarAnuncio.Owner = this;
            if (formBuscarAnuncio.ShowDialog() == DialogResult.OK)
            {
                txtAnunsio.Text = formBuscarAnuncio.SelectedAnuncio.Descripcion;
                txtTitulo.Text = formBuscarAnuncio.SelectedAnuncio.Titulo;
                nombreDeCursoComboBox.Text = formBuscarAnuncio.SelectedAnuncio.Curso.CodCurso;
                modificarAnuncioToolStripButton.Enabled = true;
                eleminarAnuncioToolStripButton.Enabled = true;
                guardarAnuncioToolStripButton.Enabled = false;
                nuevoAnuncioToolStripButton.Enabled = false;
                cancelarToolStripButton.Enabled = true;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            // guardar el anuncio.
            estadoInitsial();
            MessageBox.Show("No esta listo", "Guardar anuncio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void eleminarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            DialogResult eliminateResult = MessageBox.Show("Está seguro?", "Esta voy a eliminar el anuncio!", MessageBoxButtons.YesNo);
            if (eliminateResult == DialogResult.Yes)
            {

            }
        }

        private void ModificarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            nombreDeCursoComboBox.Enabled = true;
            txtTitulo.Enabled = true;
            txtAnunsio.Enabled = true;
        }
        
        private void cancelarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult cancelarResult = MessageBox.Show("Está seguro?", "Esta voy a limpiar todo!", MessageBoxButtons.YesNo);
            if (cancelarResult == DialogResult.Yes)
            {
                estadoInitsial();
            }
        }

        private void limpiaTodo()
        {
            nombreDeCursoComboBox.Text = "";
            txtAnunsio.Text = "";
            txtTitulo.Text = "";
        }

        private void estadoInitsial()
        {
            limpiaTodo();
            nombreDeCursoComboBox.Enabled = false;
            txtTitulo.Enabled = false;
            txtAnunsio.Enabled = false;
            nuevoAnuncioToolStripButton.Enabled = true;
            buscarAnuncioToolStripButton.Enabled = true;
            guardarAnuncioToolStripButton.Enabled = false;
            modificarAnuncioToolStripButton.Enabled = false;
            eleminarAnuncioToolStripButton.Enabled = false;
            cancelarToolStripButton.Enabled = false;
        }
    }
}
