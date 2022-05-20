using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MatchBook
{
    public partial class frmForo : Form
    {
        public frmForo(string email)
        {
            InitializeComponent();
            BBDD.AbrirConexion();
            libro buscado = new libro();
            List<string> listabook = buscado.CargarListaLibro(BBDD.Conexion);
            comboBox1.DataSource = listabook;
            comboBox2.DataSource = listabook;
            BBDD.CerrarConexion();
            lblUsu.Text = email;
        }

        private void btnMasCosas_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btnSubirLibro_Click(object sender, EventArgs e)
        {
            if (BBDD.Conexion != null)
            {
                int resultado = 1;
                BBDD.AbrirConexion();
                Reseña res = new Reseña();
                res.Resenya = txtResenya.Text;
                res.Fecha = DateTime.Now;



                resultado = res.AgregarResenya(BBDD.Conexion, res, lblUsu.Text,comboBox1.Text);
                MessageBox.Show("Listo pa");
                BBDD.CerrarConexion();
            }else
            {
                MessageBox.Show("No fue.");
            }
            txtResenya.Text = "";
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal prin = new frmPrincipal(lblemail.Text);
            this.Close();
            prin.Show();
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

        private void frmForo_Load(object sender, EventArgs e)
        {
            grbMenu2.Hide();
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

        private void btnBuscarRes_Click(object sender, EventArgs e)
        {
            if (BBDD.Conexion != null)
            {
                BBDD.AbrirConexion();
                Reseña res = new Reseña();

                txtResenya2.Text = res.ObtieneResenyas(BBDD.Conexion, comboBox2.Text);
                
                BBDD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No fue.");
            }
            txtResenya.Text = "";
        }

        public int cont = 1;
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (BBDD.Conexion != null)
            {
                BBDD.AbrirConexion();
                Reseña res = new Reseña();
                string texto = res.ObtieneResenyasNext(BBDD.Conexion, comboBox2.Text, cont);
                if (texto == "Todavía no esisten reseñas de este libro.")
                {
                    cont = 0;
                }
                else
                {
                    txtResenya2.Text = texto;
                }


                txtResenya2.Text = res.ObtieneResenyasNext(BBDD.Conexion, comboBox2.Text, cont);
                cont = cont + 1;
                BBDD.CerrarConexion();

            }
            else
            {
                MessageBox.Show("No fue.");
            }
            txtResenya.Text = "";
        }
    }
}
