using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MatchBook
{
    class BBDD
    {
        private static MySqlConnection conexion = null;
        private static readonly object padlock = new object();


        private BBDD() { }

        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (conexion == null)
                    {
                        conexion = new MySqlConnection();
                        string server = "server=database-1.camnos0tv0v7.us-east-1.rds.amazonaws.com;";
                        string port = "port=3306;";
                        string database = "database=MatchBook;";
                        string usuario = "uid=admin;";
                        string password = "pwd=matchbook69;";
                        conexion.ConnectionString = server + port + database + usuario + password;
                    }
                    return conexion;
                }
            }
        }

        public static void AbrirConexion()
        {
            if (conexion != null)
            {
                conexion.Open();
            }
        }
        public static void CerrarConexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}