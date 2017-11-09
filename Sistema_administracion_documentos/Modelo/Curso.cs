using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Curso
    {
        private int _id;
        private string _nombre;
        private string _codigo;

        public Curso()
        {

        }

        public Curso(int id, string nombre, string codigo)
        {
            _id = id;
            _nombre = nombre;
            _codigo = codigo;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public int Id { get => _id; set => _id = value; }
    }
}