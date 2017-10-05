using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Administrador: Usuario
    {
        private int codigo;
        private string cargo;

        public Administrador() {

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
