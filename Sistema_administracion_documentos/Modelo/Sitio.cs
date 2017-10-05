using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Sitio
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private BindingList<Carpeta> listaCarpetas;
        private BindingList<MovimientoAuditoria> listaAuditorias;
        private BindingList<Grupo> listGrupos;
        private BindingList<Usuario> listUsuarios;

        public Sitio() {

        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public BindingList<Carpeta> ListaCarpetas { get => listaCarpetas; set => listaCarpetas = value; }
        public BindingList<MovimientoAuditoria> ListaAuditorias { get => listaAuditorias; set => listaAuditorias = value; }
        public BindingList<Grupo> ListGrupos { get => listGrupos; set => listGrupos = value; }
        public BindingList<Usuario> ListUsuarios { get => listUsuarios; set => listUsuarios = value; }
    }
}
