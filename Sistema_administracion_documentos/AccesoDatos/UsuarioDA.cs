using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {
    public class UsuarioDA {

        private Usuario user;

        public Usuario User { get => user; set => user = value; }

        private string url = "server=200.16.7.96;" +
                "user=inf282g5;" +
                "database=inf282g5;" +
                "port=3306;" +
                "password=reFuKUxhUijfr8np;";

        public bool validarUsuario(string codigoUsuario, string contrasenaUsuario) {
            //Conexion
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //Comando
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM Admin_Sistema;";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();

            /*
             * Aca se tiene que hacer una consulta a las tablas administradores, personal,
             * profesores y alumnos, es decir, a todos los que puedan acceder al sistema,
             * ya que se desea que ingresen por codigo. Si no fuera por codigo y se accede
             * por correo, seria mas facil, pues no se buscaria el codigo en las tablas
             * que ya mencione. Si se ingresara solo por correo, se haria una busqueda en
             * la tabla usuario.
             */


            //Verificar codigo
            int r_idUsuario = -1;
            while (reader.Read()) {
                string r_codigo = reader.GetString("Codigo");
                if (r_codigo == codigoUsuario) {
                    r_idUsuario = reader.GetInt32("Usuario_IdUsuario");
                    break;
                }
            }
            if (r_idUsuario < 0) return false;
            conn.Close();

            //Verificar contrasena
            conn = new MySqlConnection(url);
            conn.Open();
            cmd.CommandText = "SELECT * FROM Usuario;";
            cmd.Connection = conn;
            MySqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read()) {
                int r_idUsuario2 = reader2.GetInt32("IdUsuario");
                if (r_idUsuario2 == r_idUsuario) {
                    if (reader2.GetString("Password") == contrasenaUsuario) return true;
                }
            }
            conn.Close();
            return false;
        }

        public string obtenerNombreUsuario(string codigoUsuario) {
            //Buscar codigo
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open(); //Se abre conexion
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM Admin_Sistema;";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();

            int r_idUsuario = -1;
            while (reader.Read()) {
                if (reader.GetString("Codigo") == codigoUsuario) {
                    r_idUsuario = reader.GetInt32("Usuario_IdUsuario");
                    break;
                }
            }
            conn.Close();

            if (r_idUsuario < 0) return ""; //Nunca se va a dar, I hope so

            conn = new MySqlConnection(url);
            conn.Open();
            cmd.CommandText = "SELECT* FROM Usuario;";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                if (reader.GetInt32("IdUsuario") == r_idUsuario) {
                    return reader.GetString("Nombre") + " " + reader.GetString("APaterno");
                }
            }
            conn.Close();
            return ""; //Nunca se va a dar
        }

        
        public Usuario obtenerUsuario(string codigoUsuario)
        {
            user = new Usuario();
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open(); //Se abre conexion
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM inf282g5.Admin_Sistema where Codigo =" + codigoUsuario;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int idUsuario = reader.GetInt32("Usuario_IdUsuario");
            conn.Close();


            conn = new MySqlConnection(url);
            conn.Open();
            cmd.CommandText = "SELECT * FROM inf282g5.Usuario where IdUsuario =" + idUsuario;
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();

            user.AMaterno = reader.GetString("AMaterno");
            user.APaterno = reader.GetString("APaterno");
            user.Contrasena = reader.GetString("Password");
            user.Direccion = reader.GetString("Direccion");
            user.Dni = reader.GetString("DNI");
            user.Email = reader.GetString("Email");
            user.Nombres = reader.GetString("Nombre");
            user.NumeroTele = reader.GetString("Telefono");
            if (reader.GetInt32("Habilitado") == 1) user.Habilitado = true;
            else user.Habilitado = false;

            conn.Close();
            return user;
        }
    }
}
