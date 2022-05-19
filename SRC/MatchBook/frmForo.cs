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
    public partial class frmForo : Form
    {
        public frmForo(string email)
        {
            InitializeComponent();
            BBDD.AbrirConexion();
            libro buscado = new libro();
            List<string> listabook = buscado.CargarListaLibro(BBDD.Conexion);
            comboBox1.DataSource = listabook;
            comboBox2.DataSource = listabook;
            BBDD.CerrarConexion();
            lblUsu.Text = email;
        }

        private void btnMasCosas_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btnSubirLibro_Click(object sender, EventArgs e)
        {
            if (BBDD.Conexion != null)
            {
                int resultado = 1;
                BBDD.AbrirConexion();
                Reseña res = new Reseña();
                res.Resenya = txtResenya.Text;
                res.Fecha = DateTime.Now;



                resultado = res.AgregarResenya(BBDD.Conexion, res, lblUsu.Text,comboBox1.Text);
                MessageBox.Show("Listo pa");
                BBDD.CerrarConexion();
            }else
            {
                MessageBox.Show("No fue.");
            }
            txtResenya.Text = "";
        }
    }
}
