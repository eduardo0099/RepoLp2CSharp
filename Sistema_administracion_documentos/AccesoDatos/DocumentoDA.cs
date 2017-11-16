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
    }
}
