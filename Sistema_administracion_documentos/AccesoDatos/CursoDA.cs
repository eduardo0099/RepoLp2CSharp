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

        public List<Curso> listaCursoMat;

        public CursoDA()
        {
            cadenabd = "server=200.16.7.96;user=inf282g5;database=inf282g5;port=3306;password=reFuKUxhUijfr8np;";
        }

        public List<Curso> listaCursoMatriculado(int codigoAlumno)
        {
            listaCursoMat = new List<Curso>();

            MySqlConnection conn = new MySqlConnection(cadenabd);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();

            String textQ = "SELECT * FROM Curso WHERE idCurso = (SELECT DISTINCT CursoXCiclo_Curso_idCurso FROM AlumnoXCursoXCiclo WHERE AlumnoXCursoXCiclo.Alumno_Usuario_IdUsuario = (Select Usuario_IdUsuario from Alumno where codigo = "
                + codigoAlumno + ") and AlumnoXCursoXCiclo.CursoXCiclo_Ciclo_idCiclo = (Select idCiclo from Ciclo where Vigente = 1));";

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


        public BindingList<Curso> cursosDictados(int id_Ciclo,string dni)
        {
            BindingList<Curso> lista = new BindingList<Curso>();
            MySqlConnection conn = new MySqlConnection(cadenabd);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            string sql1 = "Select IdUsuario FROM Usuario where Usuario.DNI=" + dni;
            cmd.Connection = conn;
            cmd.CommandText = sql1;
            MySqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();
            int id = Int32.Parse(reader1.GetString("IdUsuario"));
            reader1.Close();
            string sql2 = "Select Curso_idCurso FROM CursoXCiclo where CursoXCiclo.Docente_Usuario_IdUsuario=" + id + " and CursoXCiclo.Ciclo_idCiclo=" + id_Ciclo;
            cmd.CommandText = sql2;
            MySqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                string sql3 = "Select * from Curso where idCurso=" + reader2.GetString("idCurso");
                cmd.CommandText = sql3;
                MySqlDataReader reader3 = cmd.ExecuteReader();
                reader3.Read();
                Curso c = new Curso(Int32.Parse(reader3.GetString("idCurso")), reader3.GetString("Nombre"), reader3.GetString("Codigo"));
                lista.Add(c);
                reader3.Close();
            }
            conn.Close();
            return lista;
        }
    }
}
