using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Alumno : Usuario
    {
        private int codigo;
        private string especialidad;

        public Alumno()
        {

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
