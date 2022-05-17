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
    public partial class frmSubirLibro : Form
    {
        public frmSubirLibro()
        {
            InitializeComponent();
        }

        private void btnSubirLibro_Click_1(object sender, EventArgs e)
        {
            if (BBDD.Conexion != null)
            {
                int resultado = 1;
                BBDD.AbrirConexion();
                libro lib = new libro();
                lib.Nombre = txttitulo.Text;
                lib.Autor = txtAutor.Text;
                lib.Paginas = Convert.ToInt32(txtpaginas.Text);
                lib.Contenido = txtContenido.Text;

                resultado = lib.AgregarLibro(BBDD.Conexion, lib);
                MessageBox.Show("Listo pa");
                BBDD.CerrarConexion();
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (grpMenu.Visible == true)
            {
                grpMenu.Visible = false;
            }
            else if (grpMenu.Visible == false)
            {
                grpMenu.Visible = true;
            }
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
            grpMenu.Hide();
            txtContenido.MaxLength = 310;
        }

    }
}
