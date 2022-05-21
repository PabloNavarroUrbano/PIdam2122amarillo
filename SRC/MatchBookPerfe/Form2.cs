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
    public partial class frmPrincipal : Form
    {
        

        public frmPrincipal()
        {
            libro li = new libro();
            InitializeComponent();
            btnMenu2.FlatAppearance.BorderSize = 0;
            btnAnyadir.FlatAppearance.BorderSize = 0;
            btnLike.FlatAppearance.BorderSize = 0;
            btnDerecha.FlatAppearance.BorderSize = 0;
            grpMenu.Visible = false;
      


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
        }

        public frmPrincipal(string email)
        {
            InitializeComponent();
            btnMenu2.FlatAppearance.BorderSize = 0;
            btnAnyadir.FlatAppearance.BorderSize = 0;
            btnLike.FlatAppearance.BorderSize = 0;
            btnDerecha.FlatAppearance.BorderSize = 0;
            grpMenu.Visible = false;
            lblemail.Text = email;
        }

        libro li = new libro();
        usuario usu = new usuario();
        int idusuario;
        int id;
        int cont = 0;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            BBDD.CerrarConexion();
            BBDD.AbrirConexion();
            idusuario = usu.SacarID(BBDD.Conexion, lblemail.Text);
            id = li.SacarID(BBDD.Conexion);
            string text;
            string titu;
            text = li.VisualizarContenido(BBDD.Conexion, id);
            titu = li.VisualizarTitulo(BBDD.Conexion, id);
            lblLikes.Text = li.ObtieneLikes(BBDD.Conexion, id).ToString();
            txtitulo.Text = titu;
            txtPagina.Text = text;
            BBDD.CerrarConexion();
            cont = 0;
            grbMenu2.Hide();
            cmbLengua.Text = "Castellano";
            AplicarIdioma();
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



        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarUsuario edit = new frmEditarUsuario(lblemail.Text);
            edit.Show();
        }

        private void btnSubirPagina_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro sub = new frmSubirLibro(lblemail.Text);
            sub.Show();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            id = li.SacarID(BBDD.Conexion);
            string text;
            string titu;
            text = li.VisualizarContenido(BBDD.Conexion, id);
            txtPagina.Text = text;
            titu = li.VisualizarTitulo(BBDD.Conexion, id);
            lblLikes.Text = li.ObtieneLikes(BBDD.Conexion, id).ToString();
            txtitulo.Text = titu;
            cont = 0;
            Bitmap likeno = new Bitmap(Properties.Resources.like);
            btnLike.Image = likeno;
            BBDD.CerrarConexion();
        }


        private void btnLike_Click(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            if (cont==0)
            {
                li.DarLike(BBDD.Conexion, id);
                cont++;
                Bitmap like = new Bitmap(Properties.Resources.likee);
                btnLike.Image = like;
                lblLikes.Text = li.ObtieneLikes(BBDD.Conexion, id).ToString();
            }
            else if (cont==1)
            {
                li.QuitarLike(BBDD.Conexion, id);
                cont--;
                Bitmap likeno = new Bitmap(Properties.Resources.like);
                btnLike.Image = likeno;
                lblLikes.Text = li.ObtieneLikes(BBDD.Conexion, id).ToString();
            }
            BBDD.CerrarConexion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscar fr = new frmBuscar(lblemail.Text);
            fr.Show();   
        }

        private void btnMasCosas_Click(object sender, EventArgs e)
        {
            grbMenu2.Show();
            grpMenu.Hide();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion Form = new frmInicioSesion();
            Form.Show();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Process.Start("http://matchbook.com.s3-website-us-east-1.amazonaws.com/español.html");
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            int id;
            id = li.SacarID(BBDD.Conexion);
            string titulo = li.VisualizarTitulo(BBDD.Conexion, id);
            string texto = txtPagina.Text;
            libro lib = new libro(titulo);
            string title = txtitulo.Text;
            usuario usu = new usuario(lblemail.Text);
            Guardado gua = new Guardado(usu, lib);
            gua.Guardar(BBDD.Conexion, usu, title, texto);
            BBDD.CerrarConexion();
        }

        private void btnMiBiblioteca_Click(object sender, EventArgs e)
        {

            frmBiblioteca biblio = new frmBiblioteca(lblemail.Text);
            this.Hide();
            biblio.Show();
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            frmForo foro = new frmForo(lblemail.Text);
            this.Hide();
            foro.Show();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {

            frmPrincipal prin = new frmPrincipal(lblemail.Text);
            this.Hide();
            prin.Show();

        }

        private void btnMenu_Click(object sender, EventArgs e)
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

        private void btnMasCosas_Click_1(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
