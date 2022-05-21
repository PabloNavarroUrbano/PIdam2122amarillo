using System;
using MatchBook.Recursos;
using System.Globalization;
using System.Threading;
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
        private void AplicarIdioma()
        {
            lblEmail.Text = StringRecursos.lblEmail;
            label1.Text = StringRecursos.lblContraseña;
            btnEntrar.Text = StringRecursos.btnBuscar;
            label5.Text = StringRecursos.lblRegistro;
            label6.Text = StringRecursos.lblEmail;
            label7.Text = StringRecursos.lblContraseña;
            label8.Text = StringRecursos.lblUsuario;
            label9.Text = StringRecursos.lblDirección;
            label10.Text = StringRecursos.lblFechaNacimiento;
            btnRegistro.Text = StringRecursos.btnregistro;
            bntExit.Text = StringRecursos.btnSalir;
            label4.Text = StringRecursos.lblAMor;


        }
        private void frm1_Load(object sender, EventArgs e)
        {
            grbRegistro.Hide();
            cmbLengua.Text = "Castellano";
            AplicarIdioma();
        }
        private void cmbLengua_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cmbLengua.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "English":
                    {
                        cultura = "EN-GB";
                        break;
                    }
                    
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
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
                        MessageBox.Show("Te has registrado correctamente.");
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
                MessageBox.Show("Algo ha salido mal...");
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

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
