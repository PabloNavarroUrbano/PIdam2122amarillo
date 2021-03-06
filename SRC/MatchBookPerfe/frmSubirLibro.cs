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
    public partial class frmSubirLibro : Form
    {
        public frmSubirLibro(string email)
        {
            InitializeComponent();
             lblidusu.Text=email;
        }

        public frmSubirLibro()
        {
            InitializeComponent();
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
            lblTitulo.Text = StringRecursos.lblTitulo;
            lblAutor.Text = StringRecursos.lblAutor;
            lblTexto.Text = StringRecursos.lblContenido;
            lblPaginas.Text = StringRecursos.lblPagina;
            btnSubirLibro.Text = StringRecursos.btnSubir;
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

        private void btnSubirLibro_Click_1(object sender, EventArgs e)
        {
            if (BBDD.Conexion != null)
            {
                if (ComprobacionCajasSubir())
                {
                    int resultado = 1;
                    BBDD.AbrirConexion();
                    libro lib = new libro();
                    lib.Nombre = txttitulo.Text;
                    lib.Autor = txtAutor.Text;
                    lib.Paginas = Convert.ToInt32(txtpaginas.Text);
                    lib.Contenido = txtContenido.Text;

                    resultado = lib.AgregarLibro(BBDD.Conexion, lib, lblidusu.Text);
                    MessageBox.Show("Subido correctamente.");
                    BBDD.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("No fue.");
            }
            txtAutor.Text = "";
            txtContenido.Text= "";
            txtpaginas.Text = "";
            txttitulo.Text = "";

        }


        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal pri = new frmPrincipal();
            pri.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarUsuario edi = new frmEditarUsuario();
            edi.Show();
        }

        private void frmSubirLibro_Load(object sender, EventArgs e)
        {
            grbMenu2.Hide();
            grpMenu.Hide();
            txtContenido.MaxLength = 310;
            cmbLengua.Text = "Castellano";
            AplicarIdioma();
        }
        private bool ComprobacionCajasSubir()
        {
            bool valido = true;
            if (txttitulo.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txttitulo, "Debes introducir un nombre de autor");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtpaginas.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtpaginas, "Debes introducir el número de páginas");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtAutor.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtAutor, "Debes introducir un nombre de autor");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtContenido.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtContenido, "Debes introducir contenido");
            }
            else
            {
                errorProvider1.Clear();
            }
            return valido;
        }

        private void btnPrincipal_Click_1(object sender, EventArgs e)
        {
            frmPrincipal prin = new frmPrincipal(lblidusu.Text);
            this.Hide();
            prin.Show();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarUsuario edit = new frmEditarUsuario(lblidusu.Text);
            edit.Show();
        }

        private void btnMiBiblioteca_Click(object sender, EventArgs e)
        {
            frmBiblioteca biblio = new frmBiblioteca(lblidusu.Text);
            this.Hide();
            biblio.Show();
        }

        private void btnSubirPagina_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro sub = new frmSubirLibro(lblidusu.Text);
            sub.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscar fr = new frmBuscar(lblidusu.Text);
            fr.Show();
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            frmForo foro = new frmForo(lblidusu.Text);
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
            grbMenu2.Hide();
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
