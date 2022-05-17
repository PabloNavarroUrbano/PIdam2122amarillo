using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchBook
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {

        }
        private void RellenarDtgvLibro()
        {
            dtgvLibros.Rows.Clear();
            List<libro> listaLibros = libro.BuscarLibro(BBDD.Conexion, txtbuscartitulo.Text);
            for (int i = 0; i < listaLibros.Count; i++)
            {
                dtgvLibros.Rows.Add(listaLibros[i].ID, listaLibros[i].Nombre, listaLibros[i].Autor, listaLibros[i].Paginas, listaLibros[i].Num_likes);
            }

            
        }



        private void btnBscar_Click(object sender, EventArgs e)
        {
            if (BBDD.Conexion!=null)
            {
                BBDD.AbrirConexion();
                RellenarDtgvLibro();
                BBDD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }




    }
}
