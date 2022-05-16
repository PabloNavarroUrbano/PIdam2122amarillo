using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MatchBook
{
    class libro
    {
        private string nombre;
        private int paginas;
        private string contenido;
        private int num_likes;
        private string autor;


        public libro(string nom, int pag, string con, string au)
        {
            nombre = nom;
            paginas = pag;
            contenido = con;
            autor = au;
        }

        public libro()
        {

        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Paginas { get { return paginas; } set { paginas = value; } }
        public string Contenido { get { return contenido; } set { contenido = value; } }
        public int Num_likes { get { return num_likes; } set { num_likes = value; } }
        public string Autor { get { return autor; } set { autor = value; } }

        static List<libro> libros = new List<libro>();


        public int AgregarLibro(MySqlConnection conexion, libro lib)
        {
            int retorno;

            libro li = new libro(lib.nombre, lib.paginas, lib.autor, lib.contenido);
            libros.Add(li);
            string consulta;


            consulta = String.Format("INSERT INTO libro (titulo, autor, paginas, contenido_texto) VALUES " +
                "('{0}','{1}','{2}','{3}')", lib.Nombre, lib.Autor, lib.Paginas, lib.Contenido);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
            Console.WriteLine("un descanso timidin");
        }


        public int SacarID(MySqlConnection conexion)
        {
            int retorno;
            string consulta;

            consulta = "SELECT ROUND(RAND()*MAX(id_libro)+1) FROM libro;";


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


        public int SacarMAX(MySqlConnection conexion)
        {
            int retorno;
            string consulta;

            consulta = String.Format("SELECT * from libro");


            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                retorno = Convert.ToInt32(reader);
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




        public string VisualizarContenido(MySqlConnection conexion, int id)
        {
            string retorno;

            string consulta;

            consulta = String.Format("SELECT contenido_texto FROM libro WHERE id_libro = '{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                retorno = reader.GetString(0);
                reader.Close();
                return retorno;
            }
            else
            {
                retorno = "nono";
                reader.Close();
                return retorno;
            }
        }

        public int DarLike(MySqlConnection conexion, int id)
        {
            int retorno;
            string consulta;
            
            consulta = String.Format("UPDATE libro SET num_likes=num_likes+1 WHERE id_libro='{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
            Console.WriteLine("un descanso timidin");
        }





        


    }
}
