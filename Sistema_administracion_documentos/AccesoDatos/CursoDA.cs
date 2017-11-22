using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AccesoDatos
{
    public class CursoDA
    {
        private string cadenabd;

        public BindingList<Curso> listaCursoMat;

        public CursoDA()
        {
            cadenabd = "server=200.16.7.96;user=inf282g5;database=inf282g5;port=3306;password=reFuKUxhUijfr8np;";
        }

        public BindingList<Curso> listaCursoMatriculado(int idUsuario,int idCiclo)
        {
            listaCursoMat = new BindingList<Curso>();

            MySqlConnection conn = new MySqlConnection(cadenabd);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();

            String textQ = "SELECT * FROM Curso WHERE Curso.idCurso in (SELECT CursoXCiclo_Curso_idCurso FROM AlumnoXCursoXCiclo WHERE AlumnoXCursoXCiclo.Alumno_Usuario_IdUsuario = "+ idUsuario + " and AlumnoXCursoXCiclo.CursoXCiclo_Ciclo_idCiclo = "+idCiclo+");";
            cmd.Connection = conn;
            cmd.CommandText = textQ;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Int32.Parse(reader.GetString("idCurso"));
                string nombre = reader.GetString("Nombre");
                string codigo = reader.GetString("Codigo");
                Curso newCurso = new Curso();
                newCurso.Id = id;
                newCurso.Nombre = nombre;
                newCurso.Codigo = codigo;
                listaCursoMat.Add(newCurso);
            }

            conn.Close();
            return listaCursoMat;
        }


        public BindingList<Curso> cursosDictados(int id_Ciclo,int id_Usuario)
        {
            BindingList<Curso> lista = new BindingList<Curso>();
            MySqlConnection conn = new MySqlConnection(cadenabd);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string sql = "SELECT * FROM Curso WHERE Curso.idCurso in (SELECT Curso_idCurso FROM CursoXCiclo WHERE CursoXCiclo.Docente_Usuario_IdUsuario ="+ id_Usuario+ " and CursoXCiclo.Ciclo_idCiclo ="+ id_Ciclo+"); ";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Curso c = new Curso(Int32.Parse(reader.GetString("idCurso")), reader.GetString("Nombre"), reader.GetString("Codigo"));
                lista.Add(c);
            }
            conn.Close();
            return lista;
        }
    }
}
