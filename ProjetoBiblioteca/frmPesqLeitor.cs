using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmPesqLeitor : Form
    {
        public frmPesqLeitor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LEITORES
                    WHERE NOME LIKE '" + txtPesquisa.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLeitor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void frmPesqLeitor_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LEITORES";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvLeitor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvLeitor.CurrentRow;

            Leitores.codigo = linha.Cells["CODIGO"].Value.ToString();
            Leitores.nome = linha.Cells["NOME"].Value.ToString();
            Leitores.email = linha.Cells["EMAIL"].Value.ToString();
            Leitores.telefone = linha.Cells["TELEFONE"].Value.ToString();
            Leitores.celular = linha.Cells["CELULAR"].Value.ToString();
            Leitores.profissao = linha.Cells["PROFISSAO"].Value.ToString();
            Leitores.cep = linha.Cells["CEP"].Value.ToString();
            Leitores.estado = linha.Cells["ESTADO"].Value.ToString();
            Leitores.cidade = linha.Cells["CIDADE"].Value.ToString();
            Leitores.rua = linha.Cells["RUA"].Value.ToString();
            Leitores.numero = linha.Cells["NUMERO"].Value.ToString();
            Leitores.complemento = linha.Cells["COMPLEMENTO"].Value.ToString();
            Leitores.bairro = linha.Cells["BAIRRO"].Value.ToString();
            if (linha.Cells["FOTO"].Value.ToString() != "")
                Leitores.foto = (byte[])linha.Cells["FOTO"].Value;
            else
                Leitores.foto = null;

            Close();
        }

        private void dgvLeitor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvLeitor.CurrentRow;

            Leitores.codigo = linha.Cells["CODIGO"].Value.ToString();
            Leitores.nome = linha.Cells["NOME"].Value.ToString();
            Leitores.email = linha.Cells["EMAIL"].Value.ToString();
            Leitores.telefone = linha.Cells["TELEFONE"].Value.ToString();
            Leitores.celular = linha.Cells["CELULAR"].Value.ToString();
            Leitores.profissao = linha.Cells["PROFISSAO"].Value.ToString();
            Leitores.cep = linha.Cells["CEP"].Value.ToString();
            Leitores.estado = linha.Cells["ESTADO"].Value.ToString();
            Leitores.cidade = linha.Cells["CIDADE"].Value.ToString();
            Leitores.rua = linha.Cells["RUA"].Value.ToString();
            Leitores.numero = linha.Cells["NUMERO"].Value.ToString();
            Leitores.complemento = linha.Cells["COMPLEMENTO"].Value.ToString();
            Leitores.bairro = linha.Cells["BAIRRO"].Value.ToString();
            if (linha.Cells["FOTO"].Value.ToString() != "")
                Leitores.foto = (byte[])linha.Cells["FOTO"].Value;
            else
                Leitores.foto = null;

            Close();
        }
    }
}
