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
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca(string email)
        {
            InitializeComponent();
            lblemail.Text = email;
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            BBDD.AbrirConexion();
            RellenarDtgvBiblio();
            BBDD.CerrarConexion();
        }



        private void RellenarDtgvBiblio()
        {
            dtgBiblioteca.Rows.Clear();
            List<libro> listaLibros = libro.VisualizarGuardados(BBDD.Conexion, lblemail.Text);
            for (int i = 0; i < listaLibros.Count; i++)
            {
                dtgBiblioteca.Rows.Add(listaLibros[i].Nombre, listaLibros[i].Contenido);
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal pri = new frmPrincipal(lblemail.Text);
            pri.Show();
        }
    }
}
