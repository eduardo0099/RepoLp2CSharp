using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class UsuarioDA
    {
        private List<Usuario> listaUsuarios;
        private string cadenabd;

        public UsuarioDA()
        {
            cadenabd = "server=200.16.7.96;user=inf282g5;database=inf282g5;port=3306;password=reFuKUxhUijfr8np;";
        }
        public List<Usuario> listarUsuarios()
        {
            listaUsuarios = new List<Usuario>();
            MySqlConnection con = new MySqlConnection(cadenabd);
            con.Open();
            Console.WriteLine("Exito");
            con.Close();
            return listaUsuarios;
        }
    }
}
