using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public class NodoArbolP
    {
        private Panel dato;
        private List<NodoArbolP> hijos;

        public NodoArbolP(Panel d)
        {
            dato = d;
            hijos = new List<NodoArbolP>();
        }

        public Panel Dato { get => dato; set => dato = value; }
        public List<NodoArbolP> Hijos { get => hijos; set => hijos = value; }

        public void agregarHijo(Panel d)
        {
            NodoArbolP nodoAux = new NodoArbolP(d);
            hijos.Add(nodoAux);
        }

        public List<Panel> listaHijosPanel()
        {
            List<Panel> listaHijos = new List<Panel>();

            foreach(NodoArbolP nod in hijos)
            {
                listaHijos.Add(nod.Dato);
            }

            return listaHijos;
        }
    }
}
