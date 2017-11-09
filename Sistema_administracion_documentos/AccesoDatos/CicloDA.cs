using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CicloDA
    {
        private string cadenabd;
        public CicloDA()
        {
            cadenabd = "server=200.16.7.96;user=inf282g5;database=inf282g5;port=3306;password=reFuKUxhUijfr8np;";
        }
        public int busquedaCicloVingente()
        {
            MySqlConnection con = new MySqlConnection(cadenabd);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            string sql = "SELECT idCiclo FROM Ciclo WHERE Ciclo.Vigente=1";
            comando.Connection = con;
            comando.CommandText = sql;
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            int ciclo = int.Parse(reader.GetString("idCiclo"));
            return ciclo;
        }
    }
}
