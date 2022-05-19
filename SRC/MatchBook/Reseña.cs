using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MatchBook
{
    internal class Reseña
    {
        private int cantLikes;
        private string resenya;
        private DateTime fecha;


        public int CantLikes { get { return cantLikes; } set { cantLikes = value; } }
        public string Resenya { get { return resenya; } set { resenya = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }

        static List<Reseña> listaresenyas = new List<Reseña>();

        public Reseña()
        {

        }
        public Reseña(string res,DateTime fec)
        {
            Resenya = res;
            fecha = fec;
        }

        public int AgregarResenya(MySqlConnection conexion, Reseña res, string email, string titulo)
        {
            int retorno;
            libro lib = new libro();
            lib.ID = lib.ObtieneIDLibro(conexion,titulo);
            Reseña rese = new Reseña(res.Resenya, res.Fecha);
            usuario us = new usuario(email);
            listaresenyas.Add(rese);
            string consulta;
            


            consulta = String.Format("INSERT INTO valoracion (reseña, fecha, id_usuario, id_libro) VALUES " +
                "('{0}','{1}','{2}','{3}')", rese.Resenya, rese.Fecha, us.SacarID(conexion, email),lib.ID);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
            Console.WriteLine("un descanso timidin");
        }
    }


}
