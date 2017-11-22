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
    }
}
