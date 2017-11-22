using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;
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

        public String retornarNombreCarpeta(int id)
        {
            return accCarpeta.devolverNombreCarpeta(id);
        }

        public int devolveridCursoDeCarpeta(int idCarpe)
        {
            return accCarpeta.devolveridCursoDeCarpeta(idCarpe);
        }

        public List<int> listarcarpetasIdHijas(int idCarp)
        {
            return accCarpeta.listarcarpetasIdHijas(idCarp);
        }
    }
}
