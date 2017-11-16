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
    }
}
