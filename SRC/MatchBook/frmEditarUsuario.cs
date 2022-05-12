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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        public frmEditarUsuario(string ema)
        {
            InitializeComponent();
            txtemail1.Text = ema;
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

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal frprinc = new frmPrincipal(txtemail1.Text);
            frprinc.Show();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal principal = new frmPrincipal(txtemail1.Text);
            principal.Show();
        }



        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            ConBBDD.AbrirConexion();
            usuario.CambiarDatos(ConBBDD.Conexion, txtcont1.Text, txtuser.Text, txtdir.Text, dtpfecha.Value, txtemail1.Text);

            MessageBox.Show("Datos modificados");
                ConBBDD.CerrarConexion();
               
           

        }
        



    }
}
