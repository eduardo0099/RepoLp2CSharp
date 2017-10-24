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
        [STAThread]
        static void Main()
        {
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
