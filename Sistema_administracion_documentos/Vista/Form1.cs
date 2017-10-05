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
    public partial class Form1 : Form
    {
        private int height = Screen.PrimaryScreen.Bounds.Height;
        private int width = Screen.PrimaryScreen.Bounds.Width;
        Form frmDocumento;
        Form frmInicio;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            //MaximizeBox = false;
            Color colorPrincipal = new Color();
            colorPrincipal = Color.FromArgb(0, 97, 129);
            picHeader.BackColor = colorPrincipal;
            picLogo.BackColor = colorPrincipal;
            lblBienvenida.Location =  new Point(width-200, 15);
            lblNombreUsuario.Location = new Point(width - 200, 30);
            lblBienvenida.BackColor = colorPrincipal;
            lblNombreUsuario.BackColor = colorPrincipal;
            btnCerrarSes.Location = new Point(width - 85, 65);
            tolMenuDer.Width = width/7;
            frmDocumento = new frmDocumentos(this);
            frmDocumento.Width = width - tolMenuDer.Width - 5;
            frmDocumento.Height = height - picHeader.Height - 50;

            frmInicio = new frmInicio(this);
            frmDocumento.Width = width - tolMenuDer.Width - 5;
            frmDocumento.Height = height - picHeader.Height - 50;
            frmInicio.Visible = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            frmDocumento.Visible = true;
            //otras formularios false
            frmInicio.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmInicio.Visible = true;
            //otras formularios false
            frmDocumento.Visible = false;
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmManejoDeAnuncios formAnuncio = new frmManejoDeAnuncios();
            formAnuncio.Show();
        }
    }
}
