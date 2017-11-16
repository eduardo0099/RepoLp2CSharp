using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static Usuario userobj;
        public static List<int> listaId;
        public static int idCarpAct = 0;
        public static List<int> listidCarpPast;
        [STAThread]
        static void Main()
        {
            listidCarpPast = new List<int>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin lg = new frmLogin();
            if(lg.ShowDialog() == DialogResult.OK) {
                Application.Run(new frmPrincipal(lg.NombreUsuario));
            }

            
            //Application.Run(new frmPrincipal());
        }
    }
}
