using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Personal : Usuario
    {
        private string codigoPer;
        private string cargo;

        Personal()
        {

        }

        public string CodigoPer { get => codigoPer; set => codigoPer = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}