using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AnuncioBL
    {
        public void guardarAnuncio(Anuncio an)
        {
            AnuncioDA accesoDatos = new AnuncioDA();
            accesoDatos.guardarAnuncio(an);
        }
    }
}
