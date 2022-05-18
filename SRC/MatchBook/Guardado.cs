using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MatchBook
{
    class Guardado
    {
        private usuario id_usuario;
        private libro libroguardado;
        //private List<Guardado> biblio;

        public usuario Id_usuario { get { return id_usuario; } }
        public libro Libroguardado { get { return libroguardado; } }
        //public List<Guardado> Biblio { get { return biblio; } }

        public Guardado(usuario id_usu, libro bib)
        {
            id_usuario = id_usu;
            libroguardado = bib;
        }
        public Guardado() { }


        public int Guardar(MySqlConnection conexion, usuario usu, string li,string txt)
        {
            /*List<Guardado> bibliotecaUsuario = new List<Guardado>();
            bibliotecaUsuario.Add(new Guardado(usu, li));
            biblio = bibliotecaUsuario;*/
            id_usuario = usu;
            

            int retorno;
            string consulta;
            string texto = txt;


            consulta = String.Format("INSERT INTO biblio (email, titulo, contenido) VALUES " +
                "('{0}','{1}','{2}')", usu.Email,li,texto);


            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
            Console.WriteLine("funciona mamawebo");
        }


    }
}
