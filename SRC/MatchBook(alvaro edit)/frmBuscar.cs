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
            grpMenu.Hide();
            grbMenu2.Hide();
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
                if (ComprobacionCajasBuscar())
                {
                    BBDD.AbrirConexion();
                    RellenarDtgvLibro();
                    BBDD.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private bool ComprobacionCajasBuscar()
        {
            bool valido = true;
            if (txtbuscartitulo.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtbuscartitulo, "Debes introducir el título de un libro");
            }
            else
            {
                errorProvider1.Clear();
            }
            return valido;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmEditarUsuario perf = new frmEditarUsuario();
            this.Close();
            perf.Show();
        }

        private void btnSubirPagina_Click(object sender, EventArgs e)
        {
            frmSubirLibro lib = new frmSubirLibro();
            this.Close();
            lib.Show();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal prin = new frmPrincipal(lblemail.Text);
            this.Close();
            prin.Show();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarUsuario edit = new frmEditarUsuario(lblemail.Text);
            edit.Show();
        }

        private void btnMiBiblioteca_Click(object sender, EventArgs e)
        {
            frmBiblioteca biblio = new frmBiblioteca(lblemail.Text);
            this.Close();
            biblio.Show();
        }

        private void btnSubirPagina_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro sub = new frmSubirLibro(lblemail.Text);
            sub.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmBuscar fr = new frmBuscar();
            fr.Show();
        }

        private void btnForo_Click_1(object sender, EventArgs e)
        {
            frmForo foro = new frmForo(lblemail.Text);
            this.Close();
            foro.Show();
        }



        private void btnMasCosas_Click(object sender, EventArgs e)
        {
            if (grbMenu2.Visible == true)

            //comentario
            {
                grbMenu2.Visible = false;
            }
            else if (grbMenu2.Visible == false)
            {
                grbMenu2.Visible = true;
            }
            grpMenu.Hide();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            if (grpMenu.Visible == true)

            //comentario
            {
                grpMenu.Visible = false;
            }
            else if (grpMenu.Visible == false)
            {
                grpMenu.Visible = true;
            }
            grbMenu2.Hide();
        }
    }
}
