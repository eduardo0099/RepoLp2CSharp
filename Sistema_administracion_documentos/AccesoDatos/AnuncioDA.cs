using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AnuncioDA
    {
        private string cadenabd;
        public AnuncioDA()
        {
            cadenabd = "server=200.16.7.96;user=inf282g5;database=inf282g5;port=3306;password=reFuKUxhUijfr8np;";
        }

        public void guardarAnuncio(Anuncio an)
        {
            MySqlConnection con = new MySqlConnection(cadenabd);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "GUARDAR_ANUNCIO";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_TITULO", an.Titulo);
            comando.Parameters.AddWithValue("_DESCRIPCION", an.Descripcion);
            comando.Parameters.AddWithValue("FECHA", an.Fechacreacion);
            comando.Parameters.AddWithValue("ID_CICLO", an.Ciclo.Id);
            comando.Parameters.AddWithValue("ID_CURSO", an.Curso.Id);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Anuncio> mostrarAnuncioDocente(int idCurso, int idCiclo, int idUsuario)
        {
            BindingList<Anuncio> lista = new BindingList<Anuncio>();
            MySqlConnection con = new MySqlConnection(cadenabd);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "SELECT * FROM Anuncio WHERE Anuncio.CursoXCiclo_Ciclo_idCiclo in (SELECT Ciclo_idCiclo from CursoXCiclo where CursoXCiclo.Curso_idCurso =" + idCurso + " AND CursoXCiclo.Ciclo_idCiclo = " + idCiclo + " AND CursoXCiclo.Docente_Usuario_IdUsuario = " + idUsuario + ")";
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Docente d = new Docente();
                d.Id = idUsuario;
                Ciclo c = new Ciclo();
                c.Id = idCiclo;
                Curso cu = new Curso();
                cu.Id = idCurso;
                Anuncio a = new Anuncio(reader.GetString("Titulo"), reader.GetString("Descripcion"), reader.GetDateTime("FechaCreacion"), d, cu, c);
                lista.Add(a);
            }
            con.Close();
            return lista;
        }

        public BindingList<Anuncio> mostrarAnuncioAlumno(int idCurso, int idCiclo, int idUsuario)
        {
            BindingList<Anuncio> lista = new BindingList<Anuncio>();
            MySqlConnection con = new MySqlConnection(cadenabd);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "SELECT * FROM Anuncio WHERE Anuncio.CursoXCiclo_Curso_idCurso in (SELECT )";
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Docente d = new Docente();
                d.Id = idUsuario;
                Ciclo c = new Ciclo();
                c.Id = idCiclo;
                Curso cu = new Curso();
                cu.Id = idCurso;
                Anuncio a = new Anuncio(reader.GetString("Titulo"), reader.GetString("Descripcion"), reader.GetDateTime("FechaCreacion"), d, cu, c);
                lista.Add(a);
            }
            con.Close();
            return lista;
        }

    }
}
