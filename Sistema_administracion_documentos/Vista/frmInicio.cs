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
    public partial class frmInicio : Form
    {
        private int cicloVigente;//id del ciclo vigente
        private CicloBL logicaN;
        private CursoBL logicaCurso;
        private BindingList<Curso> listaCursos;
        private BindingList<Anuncio> listaAnuncio;
        private AnuncioBL logicaAnuncio;
        private Curso cursoSeleccionado;
        private Anuncio anuncioSeleccionado;
        public frmInicio(Form padre)
        {
            InitializeComponent();
            this.MdiParent = padre;
            listaCursos = new BindingList<Curso>();
            logicaN = new CicloBL();
            logicaCurso = new CursoBL();
            logicaAnuncio = new AnuncioBL();
            listaAnuncio = new BindingList<Anuncio>();
            cicloVigente = logicaN.busquedaCicloVingente();
            if(Program.userobj.Cargo == 0) //PROFESOR
                listaCursos = logicaCurso.cursosDictados(cicloVigente, Program.userobj.Id);
            if (Program.userobj.Cargo == 1) //ALUMNO
                listaCursos = logicaCurso.listaCursoMatriculado(cicloVigente, Program.userobj.Id);
            comboBox1.ValueMember = "Nombre";
            foreach (Curso c in listaCursos)
            {
                comboBox1.Items.Add(c);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lblColorAnu_Click(object sender, EventArgs e)
        {

        }

        private void cmbFiltroCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            int i = comboBox1.SelectedIndex;
            cursoSeleccionado = listaCursos[i];
            listaAnuncio = logicaAnuncio.mostrarAnuncio(cursoSeleccionado.Id, cicloVigente, Program.userobj.Id, Program.userobj.Cargo);
            dataGridView1.DataSource = listaAnuncio;
        }

        private void bttSelecAnuncio_Click(object sender, EventArgs e)
        {
            anuncioSeleccionado = (Anuncio)dataGridView1.CurrentRow.DataBoundItem;
            txtAnuncio.Text = anuncioSeleccionado.Titulo + "\r\n---------------------------------------\r\n"+ anuncioSeleccionado.Descripcion;
            lblFechaAnu.Text = anuncioSeleccionado.Fechacreacion.ToString();
            if (Program.userobj.Cargo == 0)//Profesor
                lblAutorAnu.Text = Program.userobj.Nombres + " " + Program.userobj.APaterno;
            else
                lblAutorAnu.Text = logicaAnuncio.autor(anuncioSeleccionado.Id);
        }

        private void txtAnuncio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
