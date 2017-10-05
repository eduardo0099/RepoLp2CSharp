using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Documento
    {
        private int _id;
        private DateTime _fechaCreacion;
        private string _nombre;
        private string _descripcion;
        private DateTime _fechaMod;
        private Usuario _creador;

        public Documento() {

        }

        public int Id { get => _id; set => _id = value; }
        public DateTime FechaCreacion { get => _fechaCreacion; set => _fechaCreacion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime FechaMod { get => _fechaMod; set => _fechaMod = value; }
        public Usuario Creador { get => _creador; set => _creador = value; }
    }
}
