
namespace MatchBook
{
    partial class frmBiblioteca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            this.lblMatchBook = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgBiblioteca = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnForo = new System.Windows.Forms.Button();
            this.btnSubirPagina = new System.Windows.Forms.Button();
            this.btnMatchBook = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBiblioteca)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMatchBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 105);
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
            // dtgBiblioteca
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dtgBiblioteca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBiblioteca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBiblioteca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBiblioteca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.titulo});
            this.dtgBiblioteca.Location = new System.Drawing.Point(232, 192);
            this.dtgBiblioteca.Name = "dtgBiblioteca";
            this.dtgBiblioteca.RowHeadersWidth = 51;
            this.dtgBiblioteca.RowTemplate.Height = 24;
            this.dtgBiblioteca.Size = new System.Drawing.Size(887, 347);
            this.dtgBiblioteca.TabIndex = 18;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Usuario";
            this.id_usuario.MinimumWidth = 6;
            this.id_usuario.Name = "id_usuario";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.MinimumWidth = 6;
            this.titulo.Name = "titulo";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(220, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 69);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mi biblioteca";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnBiblioteca);
            this.grpMenu.Controls.Add(this.btnForo);
            this.grpMenu.Controls.Add(this.btnSubirPagina);
            this.grpMenu.Controls.Add(this.btnMatchBook);
            this.grpMenu.Controls.Add(this.btnPerfil);
            this.grpMenu.Controls.Add(this.btnPrincipal);
            this.grpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(12, 174);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(184, 365);
            this.grpMenu.TabIndex = 19;
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
            // btnMatchBook
            // 
            this.btnMatchBook.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchBook.ForeColor = System.Drawing.Color.Black;
            this.btnMatchBook.Location = new System.Drawing.Point(6, 192);
            this.btnMatchBook.Name = "btnMatchBook";
            this.btnMatchBook.Size = new System.Drawing.Size(172, 51);
            this.btnMatchBook.TabIndex = 6;
            this.btnMatchBook.Text = "MatchBook";
            this.btnMatchBook.UseVisualStyleBackColor = true;
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
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(12, 111);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(68, 56);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.UseCompatibleTextRendering = true;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.Color.Black;
            this.btnBiblioteca.Location = new System.Drawing.Point(6, 306);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(172, 51);
            this.btnBiblioteca.TabIndex = 7;
            this.btnBiblioteca.Text = "Biblioteca";
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1209, 643);
            this.Controls.Add(this.dtgBiblioteca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.panel1);
            this.Name = "frmBiblioteca";
            this.Text = "frmBiblioteca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBiblioteca)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatchBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgBiblioteca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnForo;
        private System.Windows.Forms.Button btnSubirPagina;
        private System.Windows.Forms.Button btnMatchBook;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button btnBiblioteca;
    }
}