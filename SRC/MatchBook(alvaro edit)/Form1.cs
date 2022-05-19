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
                if (ComprobacionCajasInicio())
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
            }
            BBDD.CerrarConexion();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            usuario us = new usuario();
            DateTime fe;
            if (BBDD.Conexion != null)
            {
                if (ComprobacionCajasRegistro())
                {
                    BBDD.AbrirConexion();
                    if (us.ComprobarEmail(BBDD.Conexion, txtemail1.Text))
                    {
                        BBDD.CerrarConexion();
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
                        grbRegistro.Hide();
                        BBDD.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("Email existente");
                    }
                }
            }
            else
            {
                MessageBox.Show("salio mal pa");
            }
        }


        private bool ComprobacionCajasRegistro()
        {
            bool valido = true;
            if (txtemail1.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtemail1, "Debe introducir un email");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtpsw.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtpsw, "Debe introducir una contraseña");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtuser.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtuser, "Debe introducir un nombre de usuario");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtdir.Text == "")
            {
                valido = false;
                errorProvider1.SetError(txtdir, "Debe introducir una dirección");
            }
            else
            {
                errorProvider1.Clear();
            }

            return valido;
        }

        private bool ComprobacionCajasInicio()
        {
            bool valido = true;
            if (txtEmail.Text == "")
            {
                valido = true;
                errorProvider1.SetError(txtEmail, "Debes introducir un email.");
            }
            else
            {
                errorProvider1.Clear();
            }
            return valido;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
