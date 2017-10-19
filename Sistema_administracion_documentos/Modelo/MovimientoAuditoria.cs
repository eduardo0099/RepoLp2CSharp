using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class MovimientoAuditoria
    {
        private int id;
        private DateTime fecha;
        private string accion;
        private Usuario usuario;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Accion { get => accion; set => accion = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }
}