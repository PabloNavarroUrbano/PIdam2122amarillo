﻿using MySql.Data.MySqlClient;
using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MatchBook
{
    // Clase para gestionar las operaciones con la Base de Datos
    class ConexionBD
    {
        private MySqlConnection conexion;

        public MySqlConnection Conexion { get { return conexion; } }

        public ConexionBD()
        {
            // Conexión Local
            string server = "server=localhost;";
            string port = "port=3306;";
            string database = "database=matchbook;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string convert = "Convert Zero Datetime=True;";
            string connectionstring = server + port + database + usuario + password + convert;

            conexion = new MySqlConnection(connectionstring);
        }

        // Método que se encarga de abrir la conexión
        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        // Método que se encarga de cerrar la conexión
        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

    }
}
