using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Anuncio
    {
        private int id;
        private string titulo;
        private string descripcion;
        private DateTime fechacreacion;
        private Docente docenteCreador;
        private Curso curso;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fechacreacion { get => fechacreacion; set => fechacreacion = value; }
        public Docente DocenteCreador { get => docenteCreador; set => docenteCreador = value; }
        public Curso Curso { get => curso; set => curso = value; }
    }
}
