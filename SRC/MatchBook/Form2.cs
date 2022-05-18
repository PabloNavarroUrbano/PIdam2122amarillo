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
            txtitulo.Text = titu;
            txtPagina.Text = text;
            BBDD.CerrarConexion();
            cont = 0;
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
            txtitulo.Text = titu;
            cont = 0;
            BBDD.CerrarConexion();
        }


        private void btnLike_Click(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            if (cont==0)
            {
                li.DarLike(BBDD.Conexion, id);
                cont++;
            }
            else if (cont==1)
            {
                li.QuitarLike(BBDD.Conexion, id);
                cont--;
            }
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

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion Form = new frmInicioSesion();
            Form.Show();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
