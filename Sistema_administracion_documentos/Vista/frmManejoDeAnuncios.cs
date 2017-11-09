using Controlador;
using Modelo;
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
        private int cicloVigente;//id del ciclo vigente
        private CicloBL logicaN;
        private CursoBL logicaCurso;
        private BindingList<Curso> listaCursos;
        private Anuncio anuncio;
        private AnuncioBL logicaAnuncio;
        public frmManejoDeAnuncios()
        {
            InitializeComponent();
            estadoInitsial();
            listaCursos = new BindingList<Curso>();
            logicaN = new CicloBL();
            logicaCurso = new CursoBL();
            logicaAnuncio = new AnuncioBL();
            cicloVigente = logicaN.busquedaCicloVingente();
            listaCursos = logicaCurso.cursosDictados(cicloVigente,Program.userobj.Dni);
        }

        private void frmManejoDeAnuncios_Load(object sender, EventArgs e)
        {

        }

        private void nuevoAnuncioToolStripButton_Click(object sender, EventArgs e)
        {
            cboCursos.Enabled = true;
            txtTitulo.Enabled = true;
            txtAnunsio.Enabled = true;
            buscarAnuncioToolStripButton.Enabled = false;
            nuevoAnuncioToolStripButton.Enabled = false;
            cancelarToolStripButton.Enabled = true;
            guardarAnuncioToolStripButton.Enabled = true;
            cboCursos.ValueMember = "_nombre";
            foreach(Curso c in listaCursos)
            {
                cboCursos.Items.Add(c);
            }
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
                cboCursos.Text = formBuscarAnuncio.SelectedAnuncio.Curso.Codigo;
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
            Curso c = new Curso();
            Docente d = new Docente();
            Ciclo cl = new Ciclo();
            anuncio = new Anuncio(this.txtTitulo.Text, this.txtAnunsio.Text, DateTime.Today, d, c, cl);
            logicaAnuncio.guardarAnuncio(anuncio);
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
            cboCursos.Enabled = true;
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
            cboCursos.Text = "";
            txtAnunsio.Text = "";
            txtTitulo.Text = "";
        }

        private void estadoInitsial()
        {
            limpiaTodo();
            cboCursos.Enabled = false;
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
