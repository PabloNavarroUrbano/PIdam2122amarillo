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
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca(string email)
        {
            InitializeComponent();
            lblemail.Text = email;
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            grpMenu.Hide();
            
            BBDD.AbrirConexion();
            RellenarDtgvBiblio();
            BBDD.CerrarConexion();
        }



        private void RellenarDtgvBiblio()
        {
            dtgBiblioteca.Rows.Clear();
            List<libro> listaLibros = libro.VisualizarGuardados(BBDD.Conexion, lblemail.Text);
            for (int i = 0; i < listaLibros.Count; i++)
            {
                dtgBiblioteca.Rows.Add(listaLibros[i].Nombre, listaLibros[i].Contenido);
            }
        }

        private void btnPrincipal_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal pri = new frmPrincipal(lblemail.Text);
            pri.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
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

        private void btnSubirPagina_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro sub = new frmSubirLibro(lblemail.Text);
            sub.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBuscar fr = new frmBuscar();
            fr.Show();
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            frmForo foro = new frmForo(lblemail.Text);
            this.Close();
            foro.Show();
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
            //grbMenu2.Hide();
        }
    }
}
