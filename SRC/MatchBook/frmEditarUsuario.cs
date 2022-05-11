﻿using System;
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
        ConexionBD BDdatos = new ConexionBD();

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



        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            BDdatos.AbrirConexion();
            if (usuario.InicioSesion(BDdatos.Conexion, txtEmail.Text, txtContraseña.Text))
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                BDdatos.CerrarConexion();
               
            }
            else
            {
                BDdatos.CerrarConexion();
                MessageBox.Show("Usuario/Contraseña incorrectos.");
            }
        }
        



    }
}
