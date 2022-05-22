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
        private int id;
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

        public libro(string titulo)
        {
            this.nombre = titulo;
        }

        public libro(string titulo, string cont)
        {
            this.nombre = titulo;
            this.contenido = cont;
        }

        public libro(int idl, string nom, string au, int pag,  int numlikes)
        {
            id = idl;
            nombre = nom;
            autor = au;
            paginas = pag;
            num_likes = numlikes;
        }



        public int ID { get { return id; } set{id = value;} }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Paginas { get { return paginas; } set { paginas = value; } }
        public string Contenido { get { return contenido; } set { contenido = value; } }
        public int Num_likes { get { return num_likes; } set { num_likes = value; } }
        public string Autor { get { return autor; } set { autor = value; } }

        static List<libro> libros = new List<libro>();



        /// <summary>
        /// Agregamos un libro a la base de datos de forma timida
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="lib"> constructor de libro </param>
        /// <param name="email"> el email del usuario que ha subido el libro</param>
        /// <returns></returns>
        public int AgregarLibro(MySqlConnection conexion, libro lib, string email)
        {
            int retorno;

            libro li = new libro(lib.nombre, lib.paginas, lib.autor, lib.contenido);
            usuario us = new usuario(email);
            libros.Add(li);
            string consulta;


            consulta = String.Format("INSERT INTO libro (titulo, autor, paginas, contenido_texto, id_usuario_fk) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}')", lib.Nombre, lib.Autor, lib.Paginas, lib.Contenido, us.SacarID(conexion, email));


            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
            Console.WriteLine("un descanso timidin");
        }

        /// <summary>
        /// Sacamos una id aleatoria de todos los usuarios que hay en la base de datos
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns> la id en int </returns>
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

        /// <summary>
        /// Sacamos la id de un libro dependiendo de su titulo
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="titu"> nombre del libro</param>
        /// <returns> la id en int </returns>
        public int ObtieneIDLibro(MySqlConnection conexion, string titu)
        {
            int retorno;
            string consulta;

            consulta = String.Format("SELECT id_libro from libro WHERE titulo = '{0}'", titu);


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

        /// <summary>
        /// numero maximo de libros
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns> </returns>
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

        /// <summary>
        /// Nos muestra el contenido de texto de los libros dependiendo de su id 
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="id"> la id del libro </param>
        /// <returns></returns>
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
                retorno = "Texto de prueba" +
                    "";
                reader.Close();
                return retorno;
            }
        }

        /// <summary>
        /// mostramos el titulo de la aplicacion dependiendo de su id
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string VisualizarTitulo(MySqlConnection conexion, int id)
        {
            string retorno;

            string consulta;

            consulta = String.Format("SELECT titulo FROM libro WHERE id_libro = '{0}'", id);

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

        }

        public int QuitarLike(MySqlConnection conexion, int id)
        {
            int retorno;
            string consulta;

            consulta = String.Format("UPDATE libro SET num_likes=num_likes-1 WHERE id_libro='{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;

        }

        public int ObtieneLikes(MySqlConnection conexion, int id)
        {
            int retorno;
            string consulta;
            consulta = String.Format("SELECT num_likes FROM libro WHERE id_libro = '{0}'", id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                retorno = reader.GetInt32(0);
                reader.Close();
                return retorno;
            }
            else
            {

                retorno = 0;
                reader.Close();
                return retorno;
            }
        }

        /// <summary>
        /// Buscamos un libro dependiendo de si coincide con el nombre en la base de datos
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static List<libro> BuscarLibro(MySqlConnection conexion, string titulo)
        {
            List<libro> lista = new List<libro>();
            string consulta = String.Format("SELECT id_libro,titulo,autor,paginas,num_likes FROM libro WHERE titulo LIKE '%{0}%'", titulo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)  
            {

                while (reader.Read())
                {
                    libro user = new libro(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetInt16(3), reader.GetInt16(4));
                    lista.Add(user);
                }
            }
            reader.Close();

            return lista;
        }

        public static List<libro> VisualizarGuardados(MySqlConnection conexion, string email)
        {
            List<libro> lista = new List<libro>();
            string consulta = String.Format("SELECT titulo, contenido FROM biblio WHERE email= '{0}';", email);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    libro user = new libro (reader.GetString(0), reader.GetString(1));
                    lista.Add(user);
                }
            }
            reader.Close();

            return lista;
        }

        public List<string> CargarListaLibro(MySqlConnection conexion)
        {
            List<string> listalibro = new List<string>();

            string consulta = String.Format("SELECT titulo FROM libro");
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    string buscado = (reader.GetString(0));
                    listalibro.Add(buscado.ToString());
                }
            }
            reader.Close();

            return listalibro;
            
        }
            

    }
}
