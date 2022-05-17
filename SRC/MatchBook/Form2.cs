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
        int id;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            BBDD.CerrarConexion();
            BBDD.AbrirConexion();
            id = li.SacarID(BBDD.Conexion);
            string text;
            string titu;
            text = li.VisualizarContenido(BBDD.Conexion, id);
            titu = li.VisualizarTitulo(BBDD.Conexion, id);
            txtitulo.Text = titu;
            txtPagina.Text = text;
            BBDD.CerrarConexion();
            grbMenu2.Hide();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (grpMenu.Visible == true)

                //comentario
            {
                grpMenu.Visible = false;
            }else if (grpMenu.Visible == false)
            {
                grpMenu.Visible = true;
            }
            grbMenu2.Hide();
        }



            private void btnCerrarSesion_Click(object sender, EventArgs e)
            {
                this.Hide();
                frmInicioSesion Form = new frmInicioSesion();
                Form.Show();

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
            frmSubirLibro sub = new frmSubirLibro();
            sub.Show();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            int id;
            id = li.SacarID(BBDD.Conexion);
            string text;
            string titu;
            text = li.VisualizarContenido(BBDD.Conexion, id);
            txtPagina.Text = text;
            titu = li.VisualizarTitulo(BBDD.Conexion, id);
            txtitulo.Text = titu;
            BBDD.CerrarConexion();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            li.DarLike(BBDD.Conexion, id);
            BBDD.CerrarConexion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         this.Close();
            frmBuscar fr = new frmBuscar();
            fr.Show();   
        }

        private void btnMasCosas_Click(object sender, EventArgs e)
        {
            grbMenu2.Show();
            grpMenu.Hide();
        }
    }
}
