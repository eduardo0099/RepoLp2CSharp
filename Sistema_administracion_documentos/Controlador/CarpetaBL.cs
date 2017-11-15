using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;
using AccesoDatos;
namespace Controlador {
    public class CarpetaBL {
        private CarpetaDA accCarpeta;
        public CarpetaBL()
        {
            accCarpeta = new CarpetaDA();
        }
        public List<Carpeta> devolverListasCarpetasXPadre(int idPadreCarp,int idUsu)
        {
            return accCarpeta.devolverListasCarpetasXPadre(idPadreCarp,idUsu);
        }
    }
}
