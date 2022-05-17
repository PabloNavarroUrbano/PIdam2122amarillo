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
            if (BBDD.Conexion != null)
            {
                BBDD.AbrirConexion();

                if (usuario.InicioSesion(BBDD.Conexion, txtEmail.Text, txtContraseña.Text))
                {
                    this.Hide();
                    frmPrincipal principal = new frmPrincipal(txtEmail.Text);
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos.");
                }

                BBDD.CerrarConexion();
            }
            BBDD.CerrarConexion();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            DateTime fe;
            if (BBDD.Conexion != null)
            {
                BBDD.AbrirConexion();
                usuario usu = new usuario();
                usu.Username = txtuser.Text;
                fe = Convert.ToDateTime(dtpfecha.Value.ToString(""));
                usu.Fecha_nac = fe;
                usu.Email = txtemail1.Text;
                usu.Pswd = txtpsw.Text;
                usu.Direccion = txtdir.Text;

                int resultado = 1;
                resultado = usu.AgregarUsuario(BBDD.Conexion, usu);
                MessageBox.Show("Listo pa");

                BBDD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("salio mal pa");
            }
            grbRegistro.Hide();
        }



    }
}
