using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class frmBusqueda : Form
    {
        private List<int> idsCarpetas;
        private List<int> idsFiltradosCarp;
        private List<Documento> listaResultado;
        private CarpetaBL carpetaLog;
        private DocumentoBL documentolog;
        private UsuarioBL usuarioLog;

        public List<Documento> ListaResultado { get => listaResultado; set => listaResultado = value; }

        public frmBusqueda()
        {
            InitializeComponent();
            idsCarpetas = new List<int>();
            idsFiltradosCarp = new List<int>();
            carpetaLog = new CarpetaBL();
            usuarioLog = new UsuarioBL();
            documentolog = new DocumentoBL();
            ListaResultado = new List<Documento>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpia
            System.Console.WriteLine("Imprime:");
            
            //Busca
            idsCarpetas = carpetaLog.listarcarpetasIdHijas(Program.idCarpAct);
            //foreach(int asd in idsCarpetas)
            //{
            //    System.Console.WriteLine("hija:" + asd);
            //}
            //filtra permisos
            foreach(int idC in idsCarpetas)
            {
                if (usuarioLog.verificarPermiso(Program.userobj.Id, idC, 2))
                {
                    idsFiltradosCarp.Add(idC);
                }
                else if(usuarioLog.verificarPermiso(Program.userobj.Id, idC, 3))
                {
                    idsFiltradosCarp.Add(idC);
                }
            }
            
            List<Documento> listaResParcial = new List<Documento>();
            foreach (int idCa in idsFiltradosCarp)
            {
                listaResParcial = documentolog.devolverListaDocXCARPXPAL(idCa, txtPalBusq.Text);
                foreach(Documento docum in listaResParcial)
                {
                    ListaResultado.Add(docum);
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            txtPalBusq.Text = "";
        }
    }
}
