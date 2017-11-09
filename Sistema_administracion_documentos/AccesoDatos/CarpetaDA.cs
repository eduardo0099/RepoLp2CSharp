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

        public List<int> devolverIdCarpetas(int id)
        {
            List<int> listaAux = new List<int>();

            //Conexion
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //Comando
            MySqlCommand cmd = new MySqlCommand();
            System.Console.Out.WriteLine("id usuario es " + id.ToString());
            cmd.CommandText = "select Carpeta_id from GrupoXCarpeta where (Grupo_Id in ( " +
                "select Grupo_Id from GrupoXUsuario where " +
                "Usuario_IdUsuario = "+ id +
                ") and Carpeta_id in(Select id from Carpeta where habilitado = 0)); ";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            listaAux.Add(2); //Id de Cursos En el Ciclo
            while (reader.Read())
            {
                int varAux = reader.GetInt32("Carpeta_id");
                listaAux.Add(varAux);
                System.Console.Out.WriteLine(varAux.ToString());
            }
            conn.Close();
            return listaAux;
        }
    }
}
