using System;
using MatchBook.Recursos;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void AplicarIdioma()
        {
            btnSalir.Text = StringRecursos.btnSalir;
            btnInformacion.Text = StringRecursos.btnInformacion;
            btnCerrarSesion.Text = StringRecursos.btnCerrarSesion;
            btnPrincipal.Text = StringRecursos.btnPrincipal;
            btnPerfil.Text = StringRecursos.btnPerfil;
            btnMiBiblioteca.Text = StringRecursos.btnBiblioteca;
            btnSubirPagina.Text = StringRecursos.btnSubirPagina;
            btnBuscar.Text = StringRecursos.btnBuscar;
            btnForo.Text = StringRecursos.btnForo;
            label1.Text = StringRecursos.lblMiBiblioteca;

        }
        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            grpMenu.Hide();
            cmbLengua.Text = "Castellano";
            AplicarIdioma();
            BBDD.AbrirConexion();
            grbMenu2.Hide();
            lblemail.Hide();
            RellenarDtgvBiblio();
            BBDD.CerrarConexion();
        }
        private void cmbLengua_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cmbLengua.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "English":
                    {
                        cultura = "EN-GB";
                        break;
                    }

            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
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
            this.Hide();
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
            this.Hide();
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
            this.Hide();
            frmBuscar fr = new frmBuscar(lblemail.Text);
            fr.Show();
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            frmForo foro = new frmForo(lblemail.Text);
            this.Hide();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion Form = new frmInicioSesion();
            Form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Process.Start("http://matchbook.com.s3-website-us-east-1.amazonaws.com/español.html");
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
