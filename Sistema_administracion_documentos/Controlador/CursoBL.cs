using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CursoBL
    {
        public BindingList<Curso> cursosDictados(int id_Ciclo, int id_Usuario)
        {
            BindingList<Curso> lista = new BindingList<Curso>();
            CursoDA accesoDatos = new CursoDA();
            lista = accesoDatos.cursosDictados(id_Ciclo, id_Usuario);
            return lista;
        }
    }
}
