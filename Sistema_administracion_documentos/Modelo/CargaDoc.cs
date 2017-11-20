using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CargaDoc
    {
        private String _Titulo;
        private String _Ruta;
        private String tipoDoc;
        public CargaDoc()
        {

        }

        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
        public string TipoDoc { get => tipoDoc; set => tipoDoc = value; }
    }
}
