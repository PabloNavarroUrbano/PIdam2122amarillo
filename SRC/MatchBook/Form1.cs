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

        ConexionBD BDdatos = new ConexionBD();

        private void label5_Click(object sender, EventArgs e)
        {
            grbRegistro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            BDdatos.AbrirConexion();
            if (usuario.InicioSesion(BDdatos.Conexion, txtEmail.Text, txtContraseña.Text))
            {
                frmPrincipal principal = new frmPrincipal(txtEmail.Text);
                 principal.Show();
                BDdatos.CerrarConexion();
                /* 11111111H */
            }
            else
            {
                BDdatos.CerrarConexion();
                MessageBox.Show("Usuario/Contraseña incorrectos.");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            int resultado = 1;
            DateTime fe;

            if (BDdatos.AbrirConexion())
            {
                usuario usu = new usuario();
                usu.Username = txtuser.Text;
                fe = Convert.ToDateTime(dtpfecha.Value.ToString(""));
                usu.Fecha_nac = fe;
                usu.Email = txtemail1.Text;
                usu.Pswd = txtpsw.Text;
                usu.Direccion = txtdir.Text;


                resultado = usu.AgregarUsuario(BDdatos.Conexion, usu);
                MessageBox.Show("Listo pa");

                BDdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("salio mal pa");
            }
            BDdatos.CerrarConexion();
        }



    }
}
