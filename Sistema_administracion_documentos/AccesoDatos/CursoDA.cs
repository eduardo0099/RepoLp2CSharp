using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

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
    }
}
