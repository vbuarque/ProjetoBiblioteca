namespace ProjetoBiblioteca
{
    partial class frmPesqLivro
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
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOMBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXEMPLAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANO_LANCAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_BARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLivro
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.TOMBO,
            this.TITULO,
            this.AUTOR,
            this.DATA_CADASTRO,
            this.EDITORA,
            this.EXEMPLAR,
            this.FOTO,
            this.ANO_LANCAMENTO,
            this.COD_BARRAS});
            this.dgvLivro.Location = new System.Drawing.Point(12, 121);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(776, 312);
            this.dgvLivro.TabIndex = 2;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // TOMBO
            // 
            this.TOMBO.DataPropertyName = "TOMBO";
            this.TOMBO.HeaderText = "TOMBO";
            this.TOMBO.Name = "TOMBO";
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "TITULO";
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            // 
            // AUTOR
            // 
            this.AUTOR.DataPropertyName = "AUTOR";
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            // 
            // DATA_CADASTRO
            // 
            this.DATA_CADASTRO.DataPropertyName = "DATA_CADASTRO";
            this.DATA_CADASTRO.HeaderText = "DATA DE CADASTRO";
            this.DATA_CADASTRO.Name = "DATA_CADASTRO";
            // 
            // EDITORA
            // 
            this.EDITORA.DataPropertyName = "EDITORA";
            this.EDITORA.HeaderText = "EDITORA";
            this.EDITORA.Name = "EDITORA";
            // 
            // EXEMPLAR
            // 
            this.EXEMPLAR.DataPropertyName = "EXEMPLAR";
            this.EXEMPLAR.HeaderText = "EXEMPLAR";
            this.EXEMPLAR.Name = "EXEMPLAR";
            // 
            // FOTO
            // 
            this.FOTO.DataPropertyName = "FOTO";
            this.FOTO.HeaderText = "FOTO";
            this.FOTO.Name = "FOTO";
            // 
            // ANO_LANCAMENTO
            // 
            this.ANO_LANCAMENTO.DataPropertyName = "ANO_LANCAMENTO";
            this.ANO_LANCAMENTO.HeaderText = "ANO DE LANÇAMENTO";
            this.ANO_LANCAMENTO.Name = "ANO_LANCAMENTO";
            // 
            // COD_BARRAS
            // 
            this.COD_BARRAS.DataPropertyName = "COD_BARRAS";
            this.COD_BARRAS.HeaderText = "CÓDIGO DE BARRAS";
            this.COD_BARRAS.Name = "COD_BARRAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o nome do Livro:";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.Location = new System.Drawing.Point(245, 82);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(543, 22);
            this.txtNomeLivro.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjetoBiblioteca.Properties.Resources.shut_down_icon;
            this.btnSair.Location = new System.Drawing.Point(745, 4);
            this.btnSair.Margin = new System.Windows.Forms.Padding(11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 45);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::ProjetoBiblioteca.Properties.Resources.magnifier;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(7, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(176, 41);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmPesqLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesqLivro";
            this.Text = "frmPesqLivro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOMBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXEMPLAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANO_LANCAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_BARRAS;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
    }
}