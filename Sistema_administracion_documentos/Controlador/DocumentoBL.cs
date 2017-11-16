using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Controlador {
    public class DocumentoBL {

        private DocumentoDA accDocumento;
        public DocumentoBL()
        {
            accDocumento = new DocumentoDA();
        }

        public void agregarDocumento(int idCarpe, int idUsu, String tit, String nomb, String ext, Byte[] arrDato, int tam){
            accDocumento.insertarDocumento(idCarpe, idUsu, tit, nomb, ext, arrDato, tam);
        }
    }
}
