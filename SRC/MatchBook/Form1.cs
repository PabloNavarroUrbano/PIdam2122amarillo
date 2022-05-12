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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            grbRegistro.Hide();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            grbRegistro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ConBBDD.Conexion != null)
            {
                ConBBDD.AbrirConexion();
                frmPrincipal principal = new frmPrincipal(txtEmail.Text);
                principal.Show();
                ConBBDD.CerrarConexion();
            } else
            {
                MessageBox.Show("Usuario/Contraseña incorrectos.");
            } 
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            DateTime fe;
            if (ConBBDD.Conexion != null)
            {
                ConBBDD.AbrirConexion();
                usuario usu = new usuario();
                usu.Username = txtuser.Text;
                fe = Convert.ToDateTime(dtpfecha.Value.ToString(""));
                usu.Fecha_nac = fe;
                usu.Email = txtemail1.Text;
                usu.Pswd = txtpsw.Text;
                usu.Direccion = txtdir.Text;

                int resultado = 1;
                resultado = usu.AgregarUsuario(ConBBDD.Conexion, usu);
                MessageBox.Show("Listo pa");

                ConBBDD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("salio mal pa");
            }
          
        }
    }
}
