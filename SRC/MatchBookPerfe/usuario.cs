using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBook
{
    class usuario
    {

        private string username;
        private DateTime fecha_nac;
        private string email;
        private string pswd;
        private string direccion;

        public string Username { get { return username; } set { username = value; } }
        public DateTime Fecha_nac { get { return fecha_nac; } set { fecha_nac = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Pswd { get { return pswd; } set { pswd = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }



        public usuario(string us, DateTime fec, string em, string ps, string di)
        {
            this.username = us;
            this.fecha_nac = fec;
            this.email = em;
            this.pswd = ps;
            this.direccion = di;
        }


        public usuario()
        {

        }

        public usuario(string email)
        {
            this.email = email;
        }

        //Lista donde guardamos las instancias de los usuarios
        static List<usuario> plant = new List<usuario>();




        public static bool InicioSesion(MySqlConnection conexion, string email, string cont)
        {

            string consulta = string.Format("SELECT * FROM usuario WHERE email = '{0}' AND pswd = '{1}'", email, cont);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
                reader.Close();
            }
            else
            {
                return false;
                reader.Close();
            }

        }




        /// <summary>
        /// Con este metodo agregamos un usuario a la base de datos, dependiendo de si un campo es true o false, sera administrador o no
        /// </summary>
        /// <param name="conexion"> base de datos </param>
        /// <param name="emp"> el empleado </param>
        /// <returns> devuelve el numero del comando</returns>
        public int AgregarUsuario(MySqlConnection conexion, usuario emp)
        {
            int retorno;

            usuario emple = new usuario(emp.username, emp.fecha_nac, emp.email, emp.pswd, emp.direccion);
            plant.Add(emple);
            string consulta;


            consulta = String.Format("INSERT INTO usuario (username, fecha_nac, email, pswd, direccion) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}')", emp.Username, emp.Fecha_nac, emp.Email, emp.Pswd, emp.Direccion);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int CambiarDatos(string pswd, string username, string dir, string email, string email1)
        {
            usuario usu = new usuario();
            int retorno;
            string consulta = String.Format("UPDATE usuario SET username='{0}', pswd='{1}', direccion='{2}' ,email='{3}'" +
                " WHERE email='{4}'", username, pswd, dir, email, email1);

            BBDD.AbrirConexion();

            MySqlCommand comando = new MySqlCommand(consulta, BBDD.Conexion);

            retorno = comando.ExecuteNonQuery();

            BBDD.CerrarConexion();

            return retorno;

        }

        public bool ComprobarEmail(MySqlConnection conexion, string email)
        {
            string consulta = string.Format("SELECT * FROM usuario" +
                " WHERE email = '{0}'", email);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        
                public int SacarID(MySqlConnection conexion, string email)
                {
                    int retorno;
                    string consulta = string.Format("SELECT id_usuario from usuario WHERE email='{0}'", email);

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        retorno = Convert.ToInt32(reader.GetString(0));
                        reader.Close();
                        return retorno;

                    }
                    else
                    {
                        retorno = 1;
                        reader.Close();
                        return retorno;

                    }
                }
        



    }
}