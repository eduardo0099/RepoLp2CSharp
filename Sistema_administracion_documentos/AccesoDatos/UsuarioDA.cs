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
            /*
            //Conexion
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //Comando
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM Admin_Sistema;";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();

            
             // Aca se tiene que hacer una consulta a las tablas administradores, personal,
             // profesores y alumnos, es decir, a todos los que puedan acceder al sistema,
             // ya que se desea que ingresen por codigo. Si no fuera por codigo y se accede
             // por correo, seria mas facil, pues no se buscaria el codigo en las tablas
             // que ya mencione. Si se ingresara solo por correo, se haria una busqueda en
             // la tabla usuario.
             


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
            return false;*/

            /* Buscar alumno */
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "BUSCAR_USUARIO_EN_ALUMNO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("codigoUsuario", codigoUsuario);
            cmd.Parameters.Add("idUsuario", MySqlDbType.Int32);
            cmd.Parameters["idUsuario"].Direction = System.Data.ParameterDirection.Output;

            MySqlDataReader reader = cmd.ExecuteReader();
            string idUsuario = cmd.Parameters["idUsuario"].Value.ToString();
            conn.Close();

            if (idUsuario == "") {
                /* Buscar profesor */
                conn = new MySqlConnection(url);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "BUSCAR_USUARIO_EN_DOCENTE";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("codigoUsuario", codigoUsuario);
                cmd.Parameters.Add("idUsuario", MySqlDbType.Int32);
                cmd.Parameters["idUsuario"].Direction = System.Data.ParameterDirection.Output;

                reader = cmd.ExecuteReader();
                idUsuario = cmd.Parameters["idUsuario"].Value.ToString();
                conn.Close();

                if (idUsuario == "") return false;
            }

            /* Buscar contrasena */
            conn = new MySqlConnection(url);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "BUSCAR_CONTRASENA_USUARIO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("n_IdUsuario", idUsuario);
            cmd.Parameters.Add("contrasena", MySqlDbType.String);
            cmd.Parameters["contrasena"].Direction = System.Data.ParameterDirection.Output;

            reader = cmd.ExecuteReader();
            string contrasena = cmd.Parameters["contrasena"].Value.ToString();
            conn.Close();

            /* Verificar contrasena */
            if (contrasena == contrasenaUsuario) return true;
            else return false;
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

        public string devolverNombrePorID(int id) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DEVOLVER_NOMBRE_USUARIO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", id);
            cmd.Parameters.Add("p_nombre", MySqlDbType.String);
            cmd.Parameters["p_nombre"].Direction = System.Data.ParameterDirection.Output;

            MySqlDataReader reader = cmd.ExecuteReader();
            //string idUsuario = cmd.Parameters["idUsuario"].Value.ToString();
            string nombreUsuario = cmd.Parameters["p_nombre"].Value.ToString();
            conn.Close();
            return nombreUsuario;
        }

        /***************Manfred**************/

        public void actualizarUsuario(Usuario user)
        {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ACTUALIZAR_USUARIO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("_ID", user.Id);
            //cmd.Parameters.Add("_ID", MySqlDbType.UInt32);
            //cmd.Parameters["_ID"].Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_PASSWORD", user.Contrasena);
            //cmd.Parameters.Add("_PASSWORD", MySqlDbType.VarChar);
            //cmd.Parameters["_PASSWORD"].Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_EMAILALT", user.EmailAlt);
            //cmd.Parameters.Add("_EMAILALT", MySqlDbType.VarChar);
            //cmd.Parameters["_EMAILALT"].Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_DIRECCION", user.Direccion);
            //cmd.Parameters.Add("_DIRECCION", MySqlDbType.VarChar);
            //cmd.Parameters["_DIRECCION"].Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.AddWithValue("_TELEFONO", user.NumeroTele);
            //cmd.Parameters.Add("_TELEFONO", MySqlDbType.UInt32);
            //cmd.Parameters["_TELEFONO"].Direction = System.Data.ParameterDirection.Input;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public Usuario obtenerUsuario(string codigoUsuario)
        {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "BUSCAR_USUARIO_EN_ALUMNO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("codigoUsuario", codigoUsuario);
            cmd.Parameters.Add("idUsuario", MySqlDbType.Int32);
            cmd.Parameters["idUsuario"].Direction = System.Data.ParameterDirection.Output;

            MySqlDataReader reader = cmd.ExecuteReader();
            string idUsuarioAux = cmd.Parameters["idUsuario"].Value.ToString();
            conn.Close();

            if (idUsuarioAux == "")
            {
                conn = new MySqlConnection(url);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "BUSCAR_USUARIO_EN_DOCENTE";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("codigoUsuario", codigoUsuario);
                cmd.Parameters.Add("idUsuario", MySqlDbType.Int32);
                cmd.Parameters["idUsuario"].Direction = System.Data.ParameterDirection.Output;

                reader = cmd.ExecuteReader();
                reader.Read();
                idUsuarioAux = cmd.Parameters["idUsuario"].Value.ToString();
                conn.Close();
            }

            //
            int idUsuario = Int32.Parse(idUsuarioAux); 
            user = new Usuario();
            conn = new MySqlConnection(url);
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = conn;
            conn.Open();
            cmd2.CommandText = "SELECT * FROM inf282g5.Usuario where IdUsuario =" + idUsuarioAux;
            reader = cmd2.ExecuteReader();
            reader.Read();
            user.Id = idUsuario;
            user.AMaterno = reader.GetString("AMaterno");
            user.APaterno = reader.GetString("APaterno");
            user.Contrasena = reader.GetString("Password");
            user.Dni = reader.GetString("DNI");
            user.Email = reader.GetString("Email");
            user.Nombres = reader.GetString("Nombre");
            
            try
            {
                user.NumeroTele = reader.GetString("Telefono"); 
            }
            catch(Exception e)
            {
                user.NumeroTele = "no asignado";
                
            }
            try
            {
                user.Direccion = reader.GetString("Direccion");
            }
            catch (Exception e)
            {
                user.Direccion = "no asignado";
            }
            try
            {
                user.EmailAlt = reader.GetString("EmailAlternativo");
            }
            catch (Exception e)
            {
                user.Direccion = "no asignado";
            }

            if (reader.GetInt32("Habilitado") == 1) user.Habilitado = true;
            else user.Habilitado = false;

            conn.Close();
            return user;
        }
    }
}
