using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

    }
}
