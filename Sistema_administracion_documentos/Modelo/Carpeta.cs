using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Modelo
{
    [Serializable]
    public class Carpeta
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private BindingList<Grupo> grupos;
        private BindingList<Documento> documentos;

        public Carpeta()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        internal BindingList<Grupo> Grupos { get => grupos; set => grupos = value; }
        internal BindingList<Documento> Documentos { get => documentos; set => documentos = value; }
    }
}
