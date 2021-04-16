
namespace ProjetoBiblioteca
{
    partial class frmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadLogin = new System.Windows.Forms.Button();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnCadLeitor = new System.Windows.Forms.Button();
            this.btnCadLivros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCadLogin);
            this.panel1.Controls.Add(this.btnDevolucao);
            this.panel1.Controls.Add(this.btnEmprestimo);
            this.panel1.Controls.Add(this.btnCadLeitor);
            this.panel1.Controls.Add(this.btnCadLivros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 515);
            this.panel1.TabIndex = 0;
            // 
            // btnCadLogin
            // 
            this.btnCadLogin.FlatAppearance.BorderSize = 0;
            this.btnCadLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadLogin.Image = global::ProjetoBiblioteca.Properties.Resources.login_ico;
            this.btnCadLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadLogin.Location = new System.Drawing.Point(12, 212);
            this.btnCadLogin.Name = "btnCadLogin";
            this.btnCadLogin.Size = new System.Drawing.Size(211, 74);
            this.btnCadLogin.TabIndex = 14;
            this.btnCadLogin.Text = "Login";
            this.btnCadLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadLogin.UseVisualStyleBackColor = true;
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.FlatAppearance.BorderSize = 0;
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDevolucao.Image = global::ProjetoBiblioteca.Properties.Resources.book_and_pen64;
            this.btnDevolucao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucao.Location = new System.Drawing.Point(12, 372);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(211, 74);
            this.btnDevolucao.TabIndex = 13;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolucao.UseVisualStyleBackColor = true;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmprestimo.Image = global::ProjetoBiblioteca.Properties.Resources.book_and_pen64;
            this.btnEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmprestimo.Location = new System.Drawing.Point(12, 292);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(211, 74);
            this.btnEmprestimo.TabIndex = 12;
            this.btnEmprestimo.Text = "Empréstimo";
            this.btnEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            // 
            // btnCadLeitor
            // 
            this.btnCadLeitor.FlatAppearance.BorderSize = 0;
            this.btnCadLeitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadLeitor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadLeitor.Image = global::ProjetoBiblioteca.Properties.Resources.girl_reading_a_book_for_class;
            this.btnCadLeitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadLeitor.Location = new System.Drawing.Point(12, 132);
            this.btnCadLeitor.Name = "btnCadLeitor";
            this.btnCadLeitor.Size = new System.Drawing.Size(211, 74);
            this.btnCadLeitor.TabIndex = 11;
            this.btnCadLeitor.Text = "Leitores";
            this.btnCadLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadLeitor.UseVisualStyleBackColor = true;
            this.btnCadLeitor.Click += new System.EventHandler(this.btnCadLeitor_Click);
            // 
            // btnCadLivros
            // 
            this.btnCadLivros.FlatAppearance.BorderSize = 0;
            this.btnCadLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadLivros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadLivros.Image = global::ProjetoBiblioteca.Properties.Resources.book_and_pen64;
            this.btnCadLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadLivros.Location = new System.Drawing.Point(12, 52);
            this.btnCadLivros.Name = "btnCadLivros";
            this.btnCadLivros.Size = new System.Drawing.Size(211, 74);
            this.btnCadLivros.TabIndex = 10;
            this.btnCadLivros.Text = "Livros";
            this.btnCadLivros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadLivros.UseVisualStyleBackColor = true;
            this.btnCadLivros.Click += new System.EventHandler(this.btnCadLivros_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjetoBiblioteca.Properties.Resources.close_circular_button_of_a_cross;
            this.btnSair.Location = new System.Drawing.Point(586, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 42);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(873, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnCadLogin;
        public System.Windows.Forms.Button btnDevolucao;
        public System.Windows.Forms.Button btnEmprestimo;
        public System.Windows.Forms.Button btnCadLeitor;
        public System.Windows.Forms.Button btnCadLivros;
        private System.Windows.Forms.Button btnSair;
    }
}