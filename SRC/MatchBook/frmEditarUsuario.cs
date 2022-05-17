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


        

        private void btnSubirPagina_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSubirLibro lib = new frmSubirLibro();
            lib.Show();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            gboxModificar.Hide();


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
                    lblFechaNacimiento.Text = "0000-00-00";//reader.GetDateTime(4).ToString();
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
            this.Close();
            frmBuscar fr = new frmBuscar();
            fr.Show();
        }
    }
}
