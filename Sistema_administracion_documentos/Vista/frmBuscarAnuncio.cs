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
    public partial class frmBuscarAnuncio : Form
    {
        private Anuncio selectedAnuncio;

        public Anuncio SelectedAnuncio { get => selectedAnuncio; set => selectedAnuncio = value; }

        public frmBuscarAnuncio()
        {
            InitializeComponent();
        }

        private void frmBuscarAnuncio_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarAnuncio_Click(object sender, EventArgs e)
        {
            try{
                selectedAnuncio = (Anuncio)buscarAnuncioDataGridView.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception) { }
        }
    }
}
