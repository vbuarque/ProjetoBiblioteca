using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadLeitor_Click(object sender, EventArgs e)
        {
            frmCadLeitor leitor = new frmCadLeitor();
            leitor.ShowDialog();
        }

        private void btnCadLivros_Click(object sender, EventArgs e)
        {
            frmCadLivro livro = new frmCadLivro();
            livro.ShowDialog();
        }     
    }
}
