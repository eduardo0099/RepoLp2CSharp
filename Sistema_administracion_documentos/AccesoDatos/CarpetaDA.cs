using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MySql.Data.MySqlClient;

namespace AccesoDatos {
    public class CarpetaDA {

        private string url;

        public CarpetaDA()
        {
            url = "server=200.16.7.96;" +
                "user=inf282g5;" +
                "database=inf282g5;" +
                "port=3306;" +
                "password=reFuKUxhUijfr8np;";
        }

        public String devolverNombreCarpeta(int idCarpe)
        {
            String nombAux = "";
            //Conexion
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //Comando
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT nombre FROM Carpeta where id=" + idCarpe;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nombAux = reader.GetString("nombre");
            }
            conn.Close();
            return nombAux;
        }

        public int devolveridCursoDeCarpeta(int idCarp)
        {
            int idRet = -1;
            MySqlConnection con =
                new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "OBTENER_CURSO_X_CARPETA";
            comando.CommandType =
                System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_IdCarp", idCarp);
            comando.Parameters.Add("valCur", MySqlDbType.Int32);
            comando.Parameters["valCur"].Direction = System.Data.ParameterDirection.Output;

            comando.ExecuteReader();
            idRet = Int32.Parse(comando.Parameters["valCur"].Value.ToString());
            con.Close();
            return idRet;

        }

        public List<Carpeta> devolverListasCarpetasXPadre(int idCarpe,int idUsu)
        {
            List<Carpeta> listaAux = new List<Carpeta>();
            
            //Conexion
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "LISTAR_CARPETA_ALU_DOC";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("idUsu", idUsu);
            comando.Parameters.AddWithValue("idCarpPadre", idCarpe);
            MySqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                Carpeta carpAux = new Carpeta();
                carpAux.Id = dr.GetInt32("id");
                carpAux.FechaCreacion = dr.GetDateTime("fechaCreacion");
                carpAux.Descripcion = dr.GetString("descripcion");
                carpAux.Nombre = dr.GetString("nombre");
                listaAux.Add(carpAux);
                System.Console.WriteLine(carpAux.Id + carpAux.Nombre + carpAux.FechaCreacion + carpAux.Descripcion);
            }
            if (idCarpe == 0)
            {
                Carpeta cxc = new Carpeta();
                cxc.Id = 2;
                cxc.Nombre = "Cursos en el Ciclo";
                cxc.Descripcion = "Documentos sobre el ciclo actual";
                cxc.FechaCreacion = DateTime.Parse("2017-11-01");
                listaAux.Add(cxc);
            }
            con.Close();
            return listaAux;
        }

        public List<int> listarcarpetasIdHijas(int idCarpe)
        {
            List<int> listaRet = new List<int>();

            //Conexion
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "OBTENER_HIJOS_CARPETA";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("ID_PADRE", idCarpe);
            MySqlDataReader dr = comando.ExecuteReader();
            while(dr.Read())
            {
                int idAux = dr.GetInt32("id");
                listaRet.Add(idAux);
            }
            return listaRet;
        }
    }
}
