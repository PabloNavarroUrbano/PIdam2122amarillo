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
            InitializeComponent();
            btnMenu.FlatAppearance.BorderSize = 0;
            btnAnyadir.FlatAppearance.BorderSize = 0;
            btnLike.FlatAppearance.BorderSize = 0;
            btnDerecha.FlatAppearance.BorderSize = 0;
            btnIzquierda.FlatAppearance.BorderSize = 0;
            grpMenu.Visible = false;
        }
        public frmPrincipal(string email)
        {
            InitializeComponent();
            btnMenu.FlatAppearance.BorderSize = 0;
            btnAnyadir.FlatAppearance.BorderSize = 0;
            btnLike.FlatAppearance.BorderSize = 0;
            btnDerecha.FlatAppearance.BorderSize = 0;
            btnIzquierda.FlatAppearance.BorderSize = 0;
            grpMenu.Visible = false;
            lblemail.Text = email;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (grpMenu.Visible == true)
            {
                grpMenu.Visible = false;
            }else if (grpMenu.Visible == false)
            {
                grpMenu.Visible = true;
            }
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
    }
}
