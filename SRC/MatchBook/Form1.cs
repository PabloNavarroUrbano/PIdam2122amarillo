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
        ConexionBD BDdatos = new ConexionBD();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (BDdatos.Conexion != null)
            {
                BDdatos.AbrirConexion();

                if (usuario.InicioSesion(BDdatos.Conexion, txtEmail.Text, txtContraseña.Text))
                {
                    this.Hide();
                    frmPrincipal principal = new frmPrincipal(txtEmail.Text);
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos.");
                }

                BDdatos.CerrarConexion();
            }
            BDdatos.CerrarConexion();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            DateTime fe;
            if (BDdatos.Conexion != null)
            {
                BDdatos.AbrirConexion();
                usuario usu = new usuario();
                usu.Username = txtuser.Text;
                fe = Convert.ToDateTime(dtpfecha.Value.ToString(""));
                usu.Fecha_nac = fe;
                usu.Email = txtemail1.Text;
                usu.Pswd = txtpsw.Text;
                usu.Direccion = txtdir.Text;

                int resultado = 1;
                resultado = usu.AgregarUsuario(BDdatos.Conexion, usu);
                MessageBox.Show("Listo pa");

                BDdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("salio mal pa");
            }
            grbRegistro.Hide();
        }



    }
}
