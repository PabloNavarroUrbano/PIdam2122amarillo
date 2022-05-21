using System;
using MatchBook.Recursos;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        private void AplicarIdioma()
        {
            btnSalir.Text = StringRecursos.btnSalir;
            btnInformacion.Text = StringRecursos.btnInformacion;
            btnCerrarSesion.Text = StringRecursos.btnCerrarSesion;
            btnPrincipal.Text = StringRecursos.btnPrincipal;
            btnPerfil.Text = StringRecursos.btnPerfil;
            btnMiBiblioteca.Text = StringRecursos.btnBiblioteca;
            btnSubirPagina.Text = StringRecursos.btnSubirPagina;
            btnBuscar.Text = StringRecursos.btnBuscar;
            btnForo.Text = StringRecursos.btnForo;
            label11.Text = StringRecursos.lblPerfil;
            lblUsername.Text = StringRecursos.lblUsuario;
            lblDireccion.Text = StringRecursos.lblDirección;
            lblEmail.Text = StringRecursos.lblEmail;
            lblContrasenya.Text = StringRecursos.lblContraseña;
            checkBox1.Text = StringRecursos.lblMostrarContrasenya;
            label5.Text = StringRecursos.lblConfirmarCon;
        }



        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frprinc = new frmPrincipal(txtemail1.Text);
            frprinc.Show();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal(txtemail1.Text);
            principal.Show();
        }


        

        private void btnSubirPagina_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro lib = new frmSubirLibro();
            lib.Show();
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

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            grpMenu.Hide();
            grbMenu2.Hide();
            gboxModificar.Hide();
            cmbLengua.Text = "Castellano";
            AplicarIdioma();


            string consulta = String.Format("SELECT username,email,direccion,pswd,fecha_nac FROM usuario WHERE email='{0}'", txtemail1.Text);
            BBDD.AbrirConexion();


            MySqlCommand comando = new MySqlCommand(consulta, BBDD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lblUsername.Text = reader.GetString(0);
                    lblEmail.Text = reader.GetString(1);
                    lblDireccion.Text = reader.GetString(2);
                    lblContrasenya.Text = "*******";//reader.GetString(3);
                    //lblFechaNacimiento.Text = "0000-00-00";//reader.GetDateTime(4).ToString();
                }
            }

            BBDD.CerrarConexion();
        }


      

        private int button1_Click(object sender, EventArgs e)
        {
            int retorno;

            string consulta = String.Format("UPDATE usuario SET username='{0}',email='{1}',pswd='{2}',direccion='{3}' WHERE " +
                "email='{4}'", tbxUsername.Text, tbxEmaill.Text, tbxContraseña.Text, tbxDireccion.Text,txtemail1.Text);


            MySqlCommand comando = new MySqlCommand(consulta, BBDD.Conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

       

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            usuario usu = new usuario();
            string consulta = String.Format("SELECT username,email,direccion,pswd FROM usuario WHERE email='{0}';",txtemail1.Text);
            BBDD.AbrirConexion();


            MySqlCommand comando = new MySqlCommand(consulta, BBDD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbxUsername.Text = reader.GetString(0);
                    tbxEmaill.Text = reader.GetString(1);
                    tbxDireccion.Text = reader.GetString(2);
                    tbxContraseña.Text = reader.GetString(3);
                    tbxContraseña2.Text = reader.GetString(3);
                }
            }


            BBDD.CerrarConexion();

            gboxModificar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
      
            usuario.CambiarDatos( tbxContraseña.Text, tbxUsername.Text, tbxDireccion.Text, tbxEmaill.Text, txtemail1.Text);
            MessageBox.Show("Listo pa");
            this.Close();
            frmEditarUsuario uwu = new frmEditarUsuario(txtemail1.Text);
            uwu.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            gboxModificar.Hide();
        }

        private void gboxModificar_Enter_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tbxContraseña.PasswordChar == '*')
            {
                tbxContraseña.PasswordChar = '\0';
            }
            else if (tbxContraseña.PasswordChar == '\0')
            {
                tbxContraseña.PasswordChar = '*';
            }

            if (tbxContraseña2.PasswordChar == '*')
            {
                tbxContraseña2.PasswordChar = '\0';
            }
            else if (tbxContraseña2.PasswordChar == '\0')
            {
                tbxContraseña2.PasswordChar = '*';
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscar fr = new frmBuscar(txtemail1.Text);
            fr.Show();
        }

        private void btnPrincipal_Click_1(object sender, EventArgs e)
        {
            frmPrincipal prin = new frmPrincipal(txtemail1.Text);
            this.Hide();
            prin.Show();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarUsuario edit = new frmEditarUsuario(txtemail1.Text);
            edit.Show();
        }

        private void btnMiBiblioteca_Click(object sender, EventArgs e)
        {
            frmBiblioteca biblio = new frmBiblioteca(txtemail1.Text);
            this.Hide();
            biblio.Show();
        }

        private void btnSubirPagina_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro sub = new frmSubirLibro(txtemail1.Text);
            sub.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscar fr = new frmBuscar(txtemail1.Text);
            fr.Show();
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            frmForo foro = new frmForo(txtemail1.Text);
            this.Hide();
            foro.Show();
        }




        private void btnMasCosas_Click(object sender, EventArgs e)
        {
            if (grbMenu2.Visible == true)

            //comentario
            {
                grbMenu2.Visible = false;
            }
            else if (grbMenu2.Visible == false)
            {
                grbMenu2.Visible = true;
            }
            grpMenu.Hide();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            if (grpMenu.Visible == true)

            //comentario
            {
                grpMenu.Visible = false;
            }
            else if (grpMenu.Visible == false)
            {
                grpMenu.Visible = true;
            }
            grbMenu2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion Form = new frmInicioSesion();
            Form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            Process.Start("http://matchbook.com.s3-website-us-east-1.amazonaws.com/español.html");
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
