using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
namespace Controlador {
    public class DocumentoBL {

        private DocumentoDA accDocumento;
        public DocumentoBL()
        {
            accDocumento = new DocumentoDA();
        }

        public int agregarDocumento(int idCarpe, int idUsu, String tit, String nomb, String ext, Byte[] arrDato, int tam) {
            return accDocumento.insertarDocumento(idCarpe, idUsu, tit, nomb, ext, arrDato, tam);
        }
        public List<Documento> obtenerDocumentosCarpeta(int idCarpe)
        {
            return accDocumento.obtenerDatosDoc(idCarpe);
        }

        public void actualizarNombreDocumento(string nombre, int idDocumento) {
            accDocumento.actualizarNombreDocumento(nombre, idDocumento);
        }

        public void actualizarDescripcionDocumento(string descripcion, int idDocumento) {
            accDocumento.actualizarDescripcionDocumento(descripcion, idDocumento);
        }

        public void actualizarFechaModDocumento(int idDocumento) {
            accDocumento.actualizarFechaModDocumento(idDocumento);
        }

        public Documento obtenerObjetoDocumento(int id) {
            return accDocumento.obtenerObjetoDocumento(id);
        }

        public void insertarDocDocente(int idDoc, int idCiclo, int idCurso)
        {
            accDocumento.insertarDocDocente(idDoc, idCiclo, idCurso);
        }
        public void insertarDocEvaluacion(int idDoc, int idCiclo, int idCurso)
        {
            accDocumento.insertarDocEvaluacion(idDoc, idCiclo, idCurso);
        }
        public void insertarDocAdmin(int idDoc, DateTime fechaIni, DateTime fechaFin)
        {
            accDocumento.insertarDocAdmin(idDoc, fechaIni, fechaFin);
        }
        public bool verificarAutoria(int idDoc, int idUsu)
        {
            return accDocumento.verificarAutoria(idDoc, idUsu);
        }
        public void eliminarDocumento(int idDoc, int idUsu)
        {
            accDocumento.eliminarDocumento(idDoc, idUsu);
        }

        public List<Documento> devolverListaDocXCARPXPAL(int idCarp, String pal)
        {
            return accDocumento.devolverListaDocXCARPXPAL(idCarp, pal);
        }
    }
}
