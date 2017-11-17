using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace AccesoDatos {
    public class DocumentoDA {
        private string url = "server=200.16.7.96;" +
                "user=inf282g5;" +
                "database=inf282g5;" +
                "port=3306;" +
                "password=reFuKUxhUijfr8np;";
        public DocumentoDA()
        {

        }

        public void insertarDocumento(int idCarpe, int idUsu, String tit, String nomb, String ext, Byte[] arrDato,int tam)
        {
            MySqlConnection con =
                new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "INSERTAR_DOCUMENTO";
            comando.CommandType =
                System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_Carpeta_id", idCarpe);
            comando.Parameters.AddWithValue("_Usuario_id", idUsu);
            comando.Parameters.AddWithValue("_Titulo", tit);
            comando.Parameters.AddWithValue("_Nombre", nomb);
            comando.Parameters.AddWithValue("_Extension", ext);
            comando.Parameters.AddWithValue("_ArrBinDatos", arrDato);
            comando.Parameters.AddWithValue("_TamDatos", tam);
            comando.ExecuteReader();
            con.Close();
        }

        public List<Documento> obtenerDatosDoc(int idCarpe)
        {
            List<Documento> docAuxLista = new List<Documento>();
            MySqlConnection con =
                new MySqlConnection(url);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "LISTAR_DOCUMENTO_ALU_DOC";
            comando.CommandType =
                System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("_idCarpeta", idCarpe);
            MySqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Documento docAux = new Documento();
                docAux.Id = dr.GetInt32("Id");
                docAux.FechaCreacion = dr.GetDateTime("FechaCreacion");
                docAux.Descripcion = dr.GetString("Descripcion");
                docAux.Nombre = dr.GetString("Titulo");
                docAuxLista.Add(docAux);
            }
            return docAuxLista;
        }

        /*************** Ronie ***************/

        public void actualizarNombreDocumento(string nombre, int idDocumento) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ACTUALIZAR_NOMBRE_DOCUMENTO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_nombre", nombre);
            cmd.Parameters.AddWithValue("p_id", idDocumento);

            Console.WriteLine("ENTRO A NOMBRE");
            Console.WriteLine(nombre);
            Console.WriteLine(idDocumento);

            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void actualizarDescripcionDocumento(string descripcion, int idDocumento) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ACTUALIZAR_DESCRIPCION_DOCUMENTO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_desc", descripcion);
            cmd.Parameters.AddWithValue("p_id", idDocumento);

            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void actualizarFechaModDocumento(int idDocumento) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ACTUALIZAR_FECHA_MOD";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", idDocumento);

            MySqlDataReader reader = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Byte[] obtenerDocumento(int idDoc) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "OBTENER_DOCUMENTO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", idDoc);
            cmd.Parameters.Add("p_doc", MySqlDbType.VarBinary);
            cmd.Parameters["p_doc"].Direction = System.Data.ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            Byte[] documento = (Byte[])cmd.Parameters["p_doc"].Value;
            //MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            return documento;
        }

        public int obtenerTamanoDocumento(int idDoc) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "OBTENER_TAMANO_DOCUMENTO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("p_id", idDoc);
            cmd.Parameters.Add("p_tamano", MySqlDbType.Int32);
            cmd.Parameters["p_tamano"].Direction = System.Data.ParameterDirection.Output;

            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();

            string tamano = cmd.Parameters["p_tamano"].Value.ToString();
            //MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            return Int32.Parse(tamano);
        }

        public Documento obtenerObjetoDocumento(int id) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "OBTENER_OBJETO_DOCUMENTO";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //IN
            cmd.Parameters.AddWithValue("p_id", id);
            //OUT
            cmd.Parameters.Add("p_Carpeta_id", MySqlDbType.Int32);
            cmd.Parameters["p_Carpeta_id"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_Usuario_IdUsuario", MySqlDbType.Int32);
            cmd.Parameters["p_Usuario_IdUsuario"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_FechaCreacion", MySqlDbType.Date);
            cmd.Parameters["p_FechaCreacion"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_Titulo", MySqlDbType.String);
            cmd.Parameters["p_Titulo"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_Nombre", MySqlDbType.String);
            cmd.Parameters["p_Nombre"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_extension", MySqlDbType.String);
            cmd.Parameters["p_extension"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_habilitado", MySqlDbType.Int32);
            cmd.Parameters["p_habilitado"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_FechaMod", MySqlDbType.Date);
            cmd.Parameters["p_FechaMod"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_DatosBinDoc", MySqlDbType.VarBinary);
            cmd.Parameters["p_DatosBinDoc"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_tamanoDatos", MySqlDbType.Int32);
            cmd.Parameters["p_tamanoDatos"].Direction = System.Data.ParameterDirection.Output;

            cmd.Parameters.Add("p_Descripcion", MySqlDbType.String);
            cmd.Parameters["p_Descripcion"].Direction = System.Data.ParameterDirection.Output;

            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            //string idUsuario = cmd.Parameters["idUsuario"].Value.ToString();
            
            int _idCarpeta = Int32.Parse(cmd.Parameters["p_Carpeta_id"].Value.ToString());
            int _idUsuario = Int32.Parse(cmd.Parameters["p_Usuario_IdUsuario"].Value.ToString());
            DateTime _fechaCreacion = DateTime.Parse(cmd.Parameters["p_FechaCreacion"].Value.ToString());
            string _nombre = cmd.Parameters["p_Nombre"].Value.ToString();
            string _extension = cmd.Parameters["p_extension"].Value.ToString();
            int habilitado = Int32.Parse(cmd.Parameters["p_habilitado"].Value.ToString()); ;
            DateTime _fechaMod = DateTime.Parse(cmd.Parameters["p_FechaMod"].Value.ToString());
            Byte[] _datosBinary = (Byte[])(cmd.Parameters["p_DatosBinDoc"].Value);
            long _tamañoDatos = Int64.Parse(cmd.Parameters["p_tamanoDatos"].Value.ToString());
            String _descripcion = cmd.Parameters["p_Descripcion"].Value.ToString();
            
            conn.Close();

            Documento doc = new Documento();
            doc.Id = id;
            doc.IdCarpeta = _idCarpeta;
            doc.IdUsuario = _idUsuario;
            doc.FechaCreacion = _fechaCreacion;
            doc.Nombre = _nombre;
            doc.Extension = _extension;
            doc.Habilitado = habilitado;
            doc.FechaMod = _fechaMod;
            doc.DatosBinary = _datosBinary;
            doc.TamañoDatos = _tamañoDatos;
            doc.Descripcion = _descripcion;

            return doc;
        }
    }
}
