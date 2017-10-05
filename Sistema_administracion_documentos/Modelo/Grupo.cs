using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Grupo
    {
        private int _id;
        private string _nombre;
        private string _permisos;
        private BindingList<Usuario> listaUsuarios;

        public Grupo() {

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Permisos { get => _permisos; set => _permisos = value; }
        public BindingList<Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
    }
}
