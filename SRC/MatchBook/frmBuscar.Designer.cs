
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMatchBook = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnForo = new System.Windows.Forms.Button();
            this.btnSubirPagina = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.txtbuscartitulo = new System.Windows.Forms.TextBox();
            this.dtgvLibros = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBscar = new System.Windows.Forms.Button();
            this.Id_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibros)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1059, 105);
            this.panel1.TabIndex = 14;
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
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnForo);
            this.grpMenu.Controls.Add(this.btnSubirPagina);
            this.grpMenu.Controls.Add(this.btnBuscar);
            this.grpMenu.Controls.Add(this.btnPerfil);
            this.grpMenu.Controls.Add(this.btnPrincipal);
            this.grpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(12, 184);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(184, 319);
            this.grpMenu.TabIndex = 16;
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
            // 
            // txtbuscartitulo
            // 
            this.txtbuscartitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscartitulo.Location = new System.Drawing.Point(306, 129);
            this.txtbuscartitulo.Name = "txtbuscartitulo";
            this.txtbuscartitulo.Size = new System.Drawing.Size(512, 36);
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
            this.dtgvLibros.Location = new System.Drawing.Point(249, 238);
            this.dtgvLibros.Name = "dtgvLibros";
            this.dtgvLibros.RowHeadersWidth = 51;
            this.dtgvLibros.RowTemplate.Height = 24;
            this.dtgvLibros.Size = new System.Drawing.Size(665, 279);
            this.dtgvLibros.TabIndex = 18;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = global::MatchBook.Properties.Resources.menu_button_of_three_horizontal_lines;
            this.btnMenu.Location = new System.Drawing.Point(12, 122);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(68, 56);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnBscar
            // 
            this.btnBscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBscar.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBscar.ForeColor = System.Drawing.Color.Black;
            this.btnBscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBscar.Image")));
            this.btnBscar.Location = new System.Drawing.Point(814, 128);
            this.btnBscar.Name = "btnBscar";
            this.btnBscar.Size = new System.Drawing.Size(51, 37);
            this.btnBscar.TabIndex = 20;
            this.btnBscar.UseVisualStyleBackColor = false;
            this.btnBscar.Click += new System.EventHandler(this.btnBscar_Click);
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
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1059, 585);
            this.Controls.Add(this.btnBscar);
            this.Controls.Add(this.dtgvLibros);
            this.Controls.Add(this.txtbuscartitulo);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibros)).EndInit();
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
        private System.Windows.Forms.TextBox txtbuscartitulo;
        private System.Windows.Forms.DataGridView dtgvLibros;
        private System.Windows.Forms.Button btnBscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_likes;
    }
}