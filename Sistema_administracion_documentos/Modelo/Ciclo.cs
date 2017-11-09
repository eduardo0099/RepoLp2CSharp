using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ciclo
    {
        private int id;
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Boolean vigente;

        public Ciclo()
        {

        }

        public Ciclo(int id, string nombre, DateTime fechaInicio, DateTime fechaFin, bool vigente)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.vigente = vigente;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
    }
}
