using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Curso
    {
        private string _codCurso;
        private string _horario;
        private Docente _docente;
        private BindingList<Alumno> alumnos;

        public Curso() {

        }

        public string CodCurso { get => _codCurso; set => _codCurso = value; }
        public string Horario { get => _horario; set => _horario = value; }
        public Docente Docente { get => _docente; set => _docente = value; }
        public BindingList<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
    }
}
