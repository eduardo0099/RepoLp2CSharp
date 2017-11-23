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
        
        private CicloBL logicaN;
        private CursoBL logicaCurso;
        private BindingList<Curso> listaCursos;
        private BindingList<Anuncio> listaAnuncio;
        private AnuncioBL logicaAnuncio;
        private Curso cursoSeleccionado;
        private Anuncio anuncioSeleccionado;
        private int i;
        public frmInicio(Form padre)
        {
            InitializeComponent();
            this.txtAnuncio.Enabled = false;
            this.MdiParent = padre;
            this.pnlEdicion.Visible = false;
            listaCursos = new BindingList<Curso>();
            logicaN = new CicloBL();
            logicaCurso = new CursoBL();
            logicaAnuncio = new AnuncioBL();
            listaAnuncio = new BindingList<Anuncio>();
            Program.cicloVigente = logicaN.busquedaCicloVingente();
            if (Program.userobj.Cargo == 0) //PROFESOR
                listaCursos = logicaCurso.cursosDictados(Program.cicloVigente, Program.userobj.Id);
            if (Program.userobj.Cargo == 1)
            { //ALUMNO
                listaCursos = logicaCurso.listaCursoMatriculado(Program.cicloVigente, Program.userobj.Id);
                

            }
            this.bttEditar.Visible = false;
            this.bttGuardar.Visible = false;
            this.button2.Visible = false;
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
            if (comboBox1.Text != "")
            {
                i = comboBox1.SelectedIndex;
                cursoSeleccionado = listaCursos[i];
                listaAnuncio = logicaAnuncio.mostrarAnuncio(cursoSeleccionado.Id, Program.cicloVigente, Program.userobj.Id, Program.userobj.Cargo);
                dataGridView1.DataSource = listaAnuncio;
            }
            else
            {
                MessageBox.Show("No selecciono  un curso", "Anuncio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttSelecAnuncio_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem != null)
            {
                anuncioSeleccionado = (Anuncio)dataGridView1.CurrentRow.DataBoundItem;
                txtAnuncio.Text = anuncioSeleccionado.Titulo + "\r\n---------------------------------------\r\n" + anuncioSeleccionado.Descripcion;
                lblFechaAnu.Text = anuncioSeleccionado.Fechacreacion.ToString();
                if (Program.userobj.Cargo == 0)
                {//Profesor
                    lblAutorAnu.Text = Program.userobj.Nombres + " " + Program.userobj.APaterno;
                    this.bttEditar.Visible = true;
                    this.button2.Visible = true;
                }
                else
                    //lblAutorAnu.Text = logicaAnuncio.autor(Program.cicloVigente,cursoSeleccionado.Id);
                this.bttEditar.Visible = true;
                this.button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccionar un anuncio", "Anuncio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAnuncio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bttGuardar.Visible = true;
            this.button2.Visible = false;
            this.pnlEdicion.Visible = true;
            this.txtTitulo.Text = anuncioSeleccionado.Titulo;
            this.txtDes.Text = anuncioSeleccionado.Descripcion;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logicaAnuncio.eliminarAnuncio(anuncioSeleccionado);
            estadoInicial();
            listaAnuncio.RemoveAt(i);
            MessageBox.Show("Se elimino correctamente", "Anuncio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.button2.Visible = false;
            estadoInicial();
        }

        private void estadoInicial()
        {
            txtAnuncio.Text = "";
            lblAutorAnu.Text = "";
            lblFechaAnu.Text = "";
            this.pnlEdicion.Visible = false;
            bttGuardar.Visible = false;
            bttEditar.Visible = false;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            logicaAnuncio.Actualizar(anuncioSeleccionado.Id, txtTitulo.Text, txtDes.Text);
            MessageBox.Show("Se guardo correctamente", "Anuncio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            estadoInicial();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
