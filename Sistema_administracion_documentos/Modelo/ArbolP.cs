using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public class ArbolP
    {
        private NodoArbolP inicio;

        public ArbolP(Panel p) //Este panel será el origen de todos: el root tiene id 0
        {
            inicio = new NodoArbolP(p);
        }

        public void agregarPanel(Panel p,int idCarpPadre)
        {
            agregarAlArbol(p, idCarpPadre, inicio);
        }

        public Boolean agregarAlArbol(Panel p, int idCarpPadre, NodoArbolP actual)
        {
            int idActual = Int32.Parse(actual.Dato.Tag.ToString());
            if ((actual.Dato.Name == "carpeta") && (idActual == idCarpPadre))
            {
                actual.agregarHijo(p);
                return true;
            } else if (actual.Dato.Name == "documento")
            {
                return false;
            }
            else
            {
                foreach (NodoArbolP nodo in actual.Hijos)
                {
                    Boolean verif = agregarAlArbol(p, idCarpPadre, nodo);
                    if (verif == true)
                        break;
                }
            }
            return true;
        }

        public List<Panel> devolverListaPanelesHijos(int idCarp)
        {
            NodoArbolP nodoSelec = buscarNodoH(idCarp, inicio);
            List<Panel> listDevPanel = new List<Panel>();

            foreach(NodoArbolP nap in nodoSelec.Hijos)
            {
                listDevPanel.Add(nap.Dato);
            }
            return listDevPanel;
        }

        public NodoArbolP buscarNodoH(int idCarp, NodoArbolP actual)
        {
            int idActual = Int32.Parse(actual.Dato.Tag.ToString());
            if ((actual.Dato.Name == "carpeta") && (idActual == idCarp))
            {
                return actual;
            }

            NodoArbolP nodoBuscado=null;
            foreach (NodoArbolP nod in actual.Hijos)
            {
                nodoBuscado = buscarNodoH(idCarp, nod);
            }
            return nodoBuscado;
            
        }

        public List<Panel> devolverListaPanelesPadres(int idCarp)
        {
            NodoArbolP nodoSelec = buscarNodoP(idCarp, inicio);
            List<Panel> listDevPanel = new List<Panel>();
            int idSelec = Int32.Parse(nodoSelec.Dato.Tag.ToString());
            if (idSelec == 0) //si es root
            {
                listDevPanel.Add(nodoSelec.Dato);
            }
            else
            {
                NodoArbolP nodoSelec2 = buscarNodoP(idSelec, inicio);
                foreach(NodoArbolP nap in nodoSelec2.Hijos)
                {
                    listDevPanel.Add(nap.Dato);
                }
            }
            return listDevPanel;

        }

        public NodoArbolP buscarNodoP(int idCarp, NodoArbolP actual)
        {
            int idActual = Int32.Parse(actual.Dato.Tag.ToString());
            if ((actual.Dato.Name == "carpeta") && (idActual == idCarp))
            {
                return actual;
            }

            NodoArbolP nodoBuscado = null;
            foreach (NodoArbolP nod in actual.Hijos)
            {
                nodoBuscado = buscarNodoH(idCarp, nod);
            }
            return nodoBuscado;

        }
    }
}
