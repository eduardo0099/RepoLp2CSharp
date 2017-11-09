using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class GrupoDA
    {
        private string url;
        private PermisoDA accPermisos;

        public GrupoDA()
        {
            url = "server=200.16.7.96;" +
                "user=inf282g5;" +
                "database=inf282g5;" +
                "port=3306;" +
                "password=reFuKUxhUijfr8np;";
            accPermisos = new PermisoDA();
        }

        public List<Grupo> listaDeGruposPresente()
        {
            List<Grupo> listG = new List<Grupo>();
            List<Permiso> listP = new List<Permiso>();
            listP = accPermisos.devolverListaPermisos();

            //Conexion
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            //Comando
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "Select * from Carpeta  where id = (select distinct Carpeta_id from GrupoXCarpeta where Grupo_Id in " +
                "(SELECT Id FROM Grupo where Id = (SELECT distinct Grupo_Id from GrupoXUsuario " +
                "where Usuario_IdUsuario = " +
                "((select Usuario_IdUsuario from Docente where Codigo = 20112728) or " +
                "(select Usuario_IdUsuario from Alumno where Codigo = 20112728)))) and " +
                "Carpeta_id in (Select Carpeta.id from Carpeta where habilitado = 1)); ";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            //Consulta
            

            while (reader.Read())
            {
                int idG = reader.GetInt32("Id");
                int idPermi = reader.GetInt32("Permiso_idPermiso");
                Permiso pAux = null;
                foreach(Permiso pe in listP)
                {
                    if (pe.Id == idPermi)
                    {
                        pAux = pe;
                        break;
                    }
                }
                string nombG = reader.GetString("Nombre");
                Grupo gru = new Grupo();
                gru.Id = idG;
                gru.Permiso = pAux;
                gru.Nombre = nombG;
                listG.Add(gru);

            }

            conn.Close();


            return listG;
        }
    }
}
