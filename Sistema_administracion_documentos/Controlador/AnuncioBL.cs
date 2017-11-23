using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AnuncioBL
    {
        private AnuncioDA accesoD ;

        public AnuncioBL()
        {
            accesoD = new AnuncioDA();
        }

        public void guardarAnuncio(Anuncio an)
        {
            accesoD.guardarAnuncio(an);
        }

        public BindingList<Anuncio> mostrarAnuncio(int idCurso, int idCiclo, int idUsuario, int tipoU)
        {
            BindingList<Anuncio> lista = new BindingList<Anuncio>();
            if (tipoU == 0) //Profesor
                lista = accesoD.mostrarAnuncioDocente(idCurso, idCiclo, idUsuario);
            if (tipoU == 1)//Alumno
                lista = accesoD.mostrarAnuncioAlumno(idCurso, idCiclo, idUsuario);
            return lista;
        }

        public string autor(int idAnuncio)
        {

            string nombre = "jajaja";
            return nombre;
        }

        public void eliminarAnuncio(Anuncio an)
        {
            accesoD.eliminarAnuncio(an);
        }

        public void Actualizar(int id,string titulo,string descripcion)
        {
            accesoD.actualizarAnuncio(id, titulo, descripcion);
        }
    }
}
