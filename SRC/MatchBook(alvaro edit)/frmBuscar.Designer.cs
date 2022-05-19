
namespace MatchBook
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMatchBook = new System.Windows.Forms.Label();
            this.txtbuscartitulo = new System.Windows.Forms.TextBox();
            this.dtgvLibros = new System.Windows.Forms.DataGridView();
            this.Id_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnMiBiblioteca = new System.Windows.Forms.Button();
            this.btnForo = new System.Windows.Forms.Button();
            this.btnSubirPagina = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.grbMenu2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnMasCosas = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.grbMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMatchBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1853, 190);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(691, 596);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 419);
            this.panel2.TabIndex = 13;
            // 
            // lblMatchBook
            // 
            this.lblMatchBook.AutoSize = true;
            this.lblMatchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMatchBook.Font = new System.Drawing.Font("Cooper Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchBook.ForeColor = System.Drawing.Color.White;
            this.lblMatchBook.Location = new System.Drawing.Point(530, 0);
            this.lblMatchBook.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMatchBook.Name = "lblMatchBook";
            this.lblMatchBook.Size = new System.Drawing.Size(938, 172);
            this.lblMatchBook.TabIndex = 8;
            this.lblMatchBook.Text = "MatchBook";
            // 
            // txtbuscartitulo
            // 
            this.txtbuscartitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscartitulo.Location = new System.Drawing.Point(402, 232);
            this.txtbuscartitulo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbuscartitulo.Name = "txtbuscartitulo";
            this.txtbuscartitulo.Size = new System.Drawing.Size(893, 58);
            this.txtbuscartitulo.TabIndex = 17;
            // 
            // dtgvLibros
            // 
            this.dtgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_libro,
            this.titulo,
            this.autor,
            this.paginas,
            this.num_likes});
            this.dtgvLibros.Location = new System.Drawing.Point(374, 312);
            this.dtgvLibros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtgvLibros.Name = "dtgvLibros";
            this.dtgvLibros.RowHeadersWidth = 51;
            this.dtgvLibros.RowTemplate.Height = 24;
            this.dtgvLibros.Size = new System.Drawing.Size(1118, 665);
            this.dtgvLibros.TabIndex = 18;
            // 
            // Id_libro
            // 
            this.Id_libro.HeaderText = "Id_libro";
            this.Id_libro.MinimumWidth = 6;
            this.Id_libro.Name = "Id_libro";
            this.Id_libro.Width = 125;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "titulo";
            this.titulo.MinimumWidth = 6;
            this.titulo.Name = "titulo";
            this.titulo.Width = 125;
            // 
            // autor
            // 
            this.autor.HeaderText = "autor";
            this.autor.MinimumWidth = 6;
            this.autor.Name = "autor";
            this.autor.Width = 125;
            // 
            // paginas
            // 
            this.paginas.HeaderText = "paginas";
            this.paginas.MinimumWidth = 6;
            this.paginas.Name = "paginas";
            this.paginas.Width = 125;
            // 
            // num_likes
            // 
            this.num_likes.HeaderText = "num_likes";
            this.num_likes.MinimumWidth = 6;
            this.num_likes.Name = "num_likes";
            this.num_likes.Width = 125;
            // 
            // btnBscar
            // 
            this.btnBscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBscar.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBscar.ForeColor = System.Drawing.Color.Black;
            this.btnBscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBscar.Image")));
            this.btnBscar.Location = new System.Drawing.Point(1290, 232);
            this.btnBscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBscar.Name = "btnBscar";
            this.btnBscar.Size = new System.Drawing.Size(89, 67);
            this.btnBscar.TabIndex = 20;
            this.btnBscar.UseVisualStyleBackColor = false;
            this.btnBscar.Click += new System.EventHandler(this.btnBscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMenu2
            // 
            this.btnMenu2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu2.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.ForeColor = System.Drawing.Color.Black;
            this.btnMenu2.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu2.Image")));
            this.btnMenu2.Location = new System.Drawing.Point(21, 199);
            this.btnMenu2.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(119, 102);
            this.btnMenu2.TabIndex = 22;
            this.btnMenu2.UseCompatibleTextRendering = true;
            this.btnMenu2.UseVisualStyleBackColor = false;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnMiBiblioteca);
            this.grpMenu.Controls.Add(this.btnForo);
            this.grpMenu.Controls.Add(this.btnSubirPagina);
            this.grpMenu.Controls.Add(this.btnBuscar);
            this.grpMenu.Controls.Add(this.btnPerfil);
            this.grpMenu.Controls.Add(this.btnPrincipal);
            this.grpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(21, 312);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(5);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Padding = new System.Windows.Forms.Padding(5);
            this.grpMenu.Size = new System.Drawing.Size(322, 665);
            this.grpMenu.TabIndex = 21;
            this.grpMenu.TabStop = false;
            // 
            // btnMiBiblioteca
            // 
            this.btnMiBiblioteca.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiBiblioteca.ForeColor = System.Drawing.Color.Black;
            this.btnMiBiblioteca.Location = new System.Drawing.Point(10, 245);
            this.btnMiBiblioteca.Margin = new System.Windows.Forms.Padding(5);
            this.btnMiBiblioteca.Name = "btnMiBiblioteca";
            this.btnMiBiblioteca.Size = new System.Drawing.Size(301, 92);
            this.btnMiBiblioteca.TabIndex = 7;
            this.btnMiBiblioteca.Text = "Mi bilbioteca";
            this.btnMiBiblioteca.UseVisualStyleBackColor = true;
            this.btnMiBiblioteca.Click += new System.EventHandler(this.btnMiBiblioteca_Click);
            // 
            // btnForo
            // 
            this.btnForo.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForo.ForeColor = System.Drawing.Color.Black;
            this.btnForo.Location = new System.Drawing.Point(10, 555);
            this.btnForo.Margin = new System.Windows.Forms.Padding(5);
            this.btnForo.Name = "btnForo";
            this.btnForo.Size = new System.Drawing.Size(301, 92);
            this.btnForo.TabIndex = 5;
            this.btnForo.Text = "Foro";
            this.btnForo.UseVisualStyleBackColor = true;
            this.btnForo.Click += new System.EventHandler(this.btnForo_Click_1);
            // 
            // btnSubirPagina
            // 
            this.btnSubirPagina.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirPagina.ForeColor = System.Drawing.Color.Black;
            this.btnSubirPagina.Location = new System.Drawing.Point(10, 348);
            this.btnSubirPagina.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubirPagina.Name = "btnSubirPagina";
            this.btnSubirPagina.Size = new System.Drawing.Size(301, 92);
            this.btnSubirPagina.TabIndex = 4;
            this.btnSubirPagina.Text = "Subir Página";
            this.btnSubirPagina.UseVisualStyleBackColor = true;
            this.btnSubirPagina.Click += new System.EventHandler(this.btnSubirPagina_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(10, 451);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(301, 92);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Location = new System.Drawing.Point(10, 141);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(301, 92);
            this.btnPerfil.TabIndex = 2;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click_1);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.Black;
            this.btnPrincipal.Location = new System.Drawing.Point(10, 38);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(301, 92);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // grbMenu2
            // 
            this.grbMenu2.Controls.Add(this.btnSalir);
            this.grbMenu2.Controls.Add(this.btnInformacion);
            this.grbMenu2.Controls.Add(this.btnCerrarSesion);
            this.grbMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMenu2.Location = new System.Drawing.Point(1524, 306);
            this.grbMenu2.Margin = new System.Windows.Forms.Padding(5);
            this.grbMenu2.Name = "grbMenu2";
            this.grbMenu2.Padding = new System.Windows.Forms.Padding(5);
            this.grbMenu2.Size = new System.Drawing.Size(320, 375);
            this.grbMenu2.TabIndex = 24;
            this.grbMenu2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(10, 245);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(301, 92);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.Color.Black;
            this.btnInformacion.Location = new System.Drawing.Point(10, 141);
            this.btnInformacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(301, 92);
            this.btnInformacion.TabIndex = 2;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Location = new System.Drawing.Point(10, 38);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(301, 92);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnMasCosas
            // 
            this.btnMasCosas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMasCosas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasCosas.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasCosas.ForeColor = System.Drawing.Color.Black;
            this.btnMasCosas.Image = ((System.Drawing.Image)(resources.GetObject("btnMasCosas.Image")));
            this.btnMasCosas.Location = new System.Drawing.Point(1706, 210);
            this.btnMasCosas.Margin = new System.Windows.Forms.Padding(5);
            this.btnMasCosas.Name = "btnMasCosas";
            this.btnMasCosas.Size = new System.Drawing.Size(138, 100);
            this.btnMasCosas.TabIndex = 42;
            this.btnMasCosas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMasCosas.UseVisualStyleBackColor = false;
            this.btnMasCosas.Click += new System.EventHandler(this.btnMasCosas_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(269, 220);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(0, 29);
            this.lblemail.TabIndex = 44;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1853, 1060);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnMasCosas);
            this.Controls.Add(this.grbMenu2);
            this.Controls.Add(this.btnMenu2);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnBscar);
            this.Controls.Add(this.dtgvLibros);
            this.Controls.Add(this.txtbuscartitulo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grbMenu2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMatchBook;
        private System.Windows.Forms.TextBox txtbuscartitulo;
        private System.Windows.Forms.DataGridView dtgvLibros;
        private System.Windows.Forms.Button btnBscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_likes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnMiBiblioteca;
        private System.Windows.Forms.Button btnForo;
        private System.Windows.Forms.Button btnSubirPagina;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.GroupBox grbMenu2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnMasCosas;
        private System.Windows.Forms.Label lblemail;
    }
}