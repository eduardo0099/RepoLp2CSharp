using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class PermisoDA
    {
        private string url;

        public PermisoDA()
        {
            url = "server=200.16.7.96;" +
                "user=inf282g5;" +
                "database=inf282g5;" +
                "port=3306;" +
                "password=reFuKUxhUijfr8np;";
        }

        public List<Permiso> devolverListaPermisos()
        {
            List<Permiso> listaP = new List<Permiso>();

            //Conexion
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //Comando
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM Permiso";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            //Consulta
            

            while (reader.Read())
            {
                int idP = reader.GetInt32("idPermiso");
                string nombP = reader.GetString("Nombre");
                Permiso pAux = new Permiso(idP, nombP);
                listaP.Add(pAux);
            }

            conn.Close();

            return listaP;
        }
    }
}
