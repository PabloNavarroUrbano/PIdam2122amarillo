
namespace MatchBook
{
    partial class frmSubirLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubirLibro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMatchBook = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnForo = new System.Windows.Forms.Button();
            this.btnSubirPagina = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.lblrandom = new System.Windows.Forms.Label();
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnSubirLibro = new System.Windows.Forms.Button();
            this.txtpaginas = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.grbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMatchBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 105);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(394, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 232);
            this.panel2.TabIndex = 13;
            // 
            // lblMatchBook
            // 
            this.lblMatchBook.AutoSize = true;
            this.lblMatchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMatchBook.Font = new System.Drawing.Font("Cooper Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchBook.ForeColor = System.Drawing.Color.White;
            this.lblMatchBook.Location = new System.Drawing.Point(303, 0);
            this.lblMatchBook.Name = "lblMatchBook";
            this.lblMatchBook.Size = new System.Drawing.Size(526, 96);
            this.lblMatchBook.TabIndex = 8;
            this.lblMatchBook.Text = "MatchBook";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = global::MatchBook.Properties.Resources.menu_button_of_three_horizontal_lines;
            this.btnMenu.Location = new System.Drawing.Point(12, 111);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(68, 56);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnForo);
            this.grpMenu.Controls.Add(this.btnSubirPagina);
            this.grpMenu.Controls.Add(this.btnBuscar);
            this.grpMenu.Controls.Add(this.btnPerfil);
            this.grpMenu.Controls.Add(this.btnPrincipal);
            this.grpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(12, 173);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(184, 319);
            this.grpMenu.TabIndex = 15;
            this.grpMenu.TabStop = false;
            // 
            // btnForo
            // 
            this.btnForo.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForo.ForeColor = System.Drawing.Color.Black;
            this.btnForo.Location = new System.Drawing.Point(6, 249);
            this.btnForo.Name = "btnForo";
            this.btnForo.Size = new System.Drawing.Size(172, 51);
            this.btnForo.TabIndex = 5;
            this.btnForo.Text = "Foro";
            this.btnForo.UseVisualStyleBackColor = true;
            // 
            // btnSubirPagina
            // 
            this.btnSubirPagina.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirPagina.ForeColor = System.Drawing.Color.Black;
            this.btnSubirPagina.Location = new System.Drawing.Point(6, 135);
            this.btnSubirPagina.Name = "btnSubirPagina";
            this.btnSubirPagina.Size = new System.Drawing.Size(172, 51);
            this.btnSubirPagina.TabIndex = 4;
            this.btnSubirPagina.Text = "Subir Página";
            this.btnSubirPagina.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(6, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(172, 51);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Location = new System.Drawing.Point(6, 78);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(172, 51);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.Black;
            this.btnPrincipal.Location = new System.Drawing.Point(6, 21);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(172, 51);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.BackColor = System.Drawing.Color.Transparent;
            this.lblrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrandom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblrandom.Location = new System.Drawing.Point(491, 125);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(134, 25);
            this.lblrandom.TabIndex = 37;
            this.lblrandom.Text = "SUBIR LIBRO";
            // 
            // grbRegistro
            // 
            this.grbRegistro.Controls.Add(this.txtAutor);
            this.grbRegistro.Controls.Add(this.lblAutor);
            this.grbRegistro.Controls.Add(this.txtContenido);
            this.grbRegistro.Controls.Add(this.lblTexto);
            this.grbRegistro.Controls.Add(this.btnSubirLibro);
            this.grbRegistro.Controls.Add(this.txtpaginas);
            this.grbRegistro.Controls.Add(this.lblPaginas);
            this.grbRegistro.Controls.Add(this.txttitulo);
            this.grbRegistro.Controls.Add(this.lblTitulo);
            this.grbRegistro.Location = new System.Drawing.Point(278, 169);
            this.grbRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbRegistro.Size = new System.Drawing.Size(652, 519);
            this.grbRegistro.TabIndex = 36;
            this.grbRegistro.TabStop = false;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(85, 135);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(301, 27);
            this.txtAutor.TabIndex = 36;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAutor.Location = new System.Drawing.Point(81, 108);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(59, 25);
            this.lblAutor.TabIndex = 17;
            this.lblAutor.Text = "Autor";
            // 
            // txtContenido
            // 
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(85, 207);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContenido.MaxLength = 310;
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(481, 231);
            this.txtContenido.TabIndex = 16;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTexto.Location = new System.Drawing.Point(81, 180);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(194, 25);
            this.lblTexto.TabIndex = 15;
            this.lblTexto.Text = "Contenido a mostrar:";
            // 
            // btnSubirLibro
            // 
            this.btnSubirLibro.Location = new System.Drawing.Point(266, 459);
            this.btnSubirLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubirLibro.Name = "btnSubirLibro";
            this.btnSubirLibro.Size = new System.Drawing.Size(91, 30);
            this.btnSubirLibro.TabIndex = 14;
            this.btnSubirLibro.Text = "Subir Libro";
            this.btnSubirLibro.UseVisualStyleBackColor = true;
            this.btnSubirLibro.Click += new System.EventHandler(this.btnSubirLibro_Click_1);
            // 
            // txtpaginas
            // 
            this.txtpaginas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaginas.Location = new System.Drawing.Point(412, 60);
            this.txtpaginas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpaginas.Name = "txtpaginas";
            this.txtpaginas.Size = new System.Drawing.Size(101, 27);
            this.txtpaginas.TabIndex = 7;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPaginas.Location = new System.Drawing.Point(407, 33);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(89, 25);
            this.lblPaginas.TabIndex = 6;
            this.lblPaginas.Text = "Paginas:";
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.Color.White;
            this.txttitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(85, 60);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(301, 27);
            this.txttitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(81, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSubirLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1069, 699);
            this.Controls.Add(this.lblrandom);
            this.Controls.Add(this.grbRegistro);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubirLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSubirLibro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.grbRegistro.ResumeLayout(false);
            this.grbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMatchBook;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnForo;
        private System.Windows.Forms.Button btnSubirPagina;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnSubirLibro;
        private System.Windows.Forms.TextBox txtpaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}