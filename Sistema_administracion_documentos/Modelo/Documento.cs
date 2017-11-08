using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Documento
    {
        private int idCarpeta;
        private int idUsuario;
        private DateTime _fechaCreacion;
        private string _nombre;
        private string _extension;
        private int habilitado;
        private DateTime _fechaMod;
        private Byte[] _datosBinary;
        private long _tamañoDatos;
        private String _descripcion;

        public Documento()
        {

        }

        public int IdCarpeta { get => idCarpeta; set => idCarpeta = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime FechaCreacion { get => _fechaCreacion; set => _fechaCreacion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Extension { get => _extension; set => _extension = value; }
        public int Habilitado { get => habilitado; set => habilitado = value; }
        public DateTime FechaMod { get => _fechaMod; set => _fechaMod = value; }
        public byte[] DatosBinary { get => _datosBinary; set => _datosBinary = value; }
        public long TamañoDatos { get => _tamañoDatos; set => _tamañoDatos = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}