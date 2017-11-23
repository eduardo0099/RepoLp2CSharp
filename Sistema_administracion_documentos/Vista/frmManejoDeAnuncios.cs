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
        private Curso cursoSeleccionado;

        public frmManejoDeAnuncios()
        {
            InitializeComponent();
            estadoInitsial();
            listaCursos = new BindingList<Curso>();
            logicaN = new CicloBL();
            logicaCurso = new CursoBL();
            logicaAnuncio = new AnuncioBL();
            cicloVigente = logicaN.busquedaCicloVingente();
            listaCursos = logicaCurso.cursosDictados(cicloVigente,Program.userobj.Id);
        }

        private void frmManejoDeAnuncios_Load(object sender, EventArgs e)
        {

        }

        private void nuevoAnuncioToolStripButton_Click(object sender, EventArgs e)
        {
            cboCursos.Enabled = true;
            txtTitulo.Enabled = true;
            txtAnunsio.Enabled = true;
            //buscarAnuncioToolStripButton.Enabled = false;
            nuevoAnuncioToolStripButton.Enabled = false;
            cancelarToolStripButton.Enabled = true;
            guardarAnuncioToolStripButton.Enabled = true;
            cboCursos.ValueMember = "Nombre";
            foreach(Curso c in listaCursos)
            {
                cboCursos.Items.Add(c);
            }
        }

        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (this.txtTitulo.Text == "")
                MessageBox.Show("Falta ingresar el titulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.txtAnunsio.Text == "")
                MessageBox.Show("Falta ingresar la descripcion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.txtAnunsio.Text == "" && this.txtTitulo.Text == "")
                MessageBox.Show("Falta ingresar el titulo y la descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.cboCursos.Text == "")
                MessageBox.Show("Falta seleccionar el curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // guardar el anuncio.
                int i = cboCursos.SelectedIndex;
                Curso c = listaCursos[i];
                Docente d = new Docente();
                d.Id = Program.userobj.Id;
                Ciclo cl = new Ciclo();
                cl.Id = cicloVigente;
                anuncio = new Anuncio(this.txtTitulo.Text, this.txtAnunsio.Text, DateTime.Now, d, c, cl);
                logicaAnuncio.guardarAnuncio(anuncio);
                MessageBox.Show("Se guardo correctamente", "Anuncio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estadoInitsial();
            }
        }

        private void eleminarAnuncioToolStripButton_Click_1(object sender, EventArgs e)
        {
            DialogResult eliminateResult = MessageBox.Show("Está seguro?", "Estonces se eliminara el anuncio!", MessageBoxButtons.YesNo);
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
            //buscarAnuncioToolStripButton.Enabled = true;
            guardarAnuncioToolStripButton.Enabled = false;
            //modificarAnuncioToolStripButton.Enabled = false;
            //eleminarAnuncioToolStripButton.Enabled = false;
            cancelarToolStripButton.Enabled = false;
        }
    }
}
