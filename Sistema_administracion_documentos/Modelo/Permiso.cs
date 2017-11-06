using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Permiso
    {
        private int id;
        private string nombre;

        public Permiso()
        {
        }

        public Permiso(int i, string n)
        {
            id = i;
            nombre = n;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
