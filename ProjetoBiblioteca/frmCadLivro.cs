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
    public partial class frmCadLivro : Form
    {
        bool tirarFoto = true;
        public frmCadLivro()
        {
            InitializeComponent();
            ConectaWebCam.pcbFoto = pcbFoto;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (tirarFoto)
                {
                    btnTirarFoto.Text = "Tirar foto";
                    tirarFoto = false;
                    // Procurar a WebCam
                    ConectaWebCam.ProcurarDispositivo();
                    // Ligar a WebCam
                    ConectaWebCam.VerificaWebCamLigada();
                }
                else
                {
                    btnTirarFoto.Text = "Ligar WebCam";
                    tirarFoto = true;
                    ConectaWebCam.TiraFotoSalvaBanco();

                    //ConectaWebCam.VerificaWebCamLigada();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtTituloLivro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTituloLivro, "Preencha o campo Titulo do livro!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTituloLivro, "");
            }

            if (txtAutor.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtAutor, "Preencha o campo Autor!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtAutor, "");
            }

            if (txtTombo.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtTombo, "Preencha o campo Tombo!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtTombo, "");
            }

            if (txtEditora.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtEditora, "Preencha o campo Editora!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtEditora, "");
            }

            if (mskAnoLivro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskAnoLivro, "Preencha o campo Ano de Lançamento!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskAnoLivro, "");
            }

            if (txtExemplar.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtExemplar, "Preencha o campo Exemplar!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtExemplar, "");
            }

            if (mskDataCadastro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskDataCadastro, "Preencha o campo Data de Cadastro!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskDataCadastro, "");
            }

            if (txtCodigoBarras.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtCodigoBarras, "Preencha o campo Código de Barras!");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtCodigoBarras, "");
            }

            try
            {
                Conexao.Conectar();
                string sql = @"INSERT INTO LIVROS VALUES (@tombo, @titulo, @autor, @data_cadastro, @editora, @exemplar, @foto, @ano_lancamento, @cod_barras)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("tombo", txtTombo.Text);
                cmd.Parameters.AddWithValue("titulo", txtTituloLivro.Text);
                cmd.Parameters.AddWithValue("autor", txtAutor.Text);
                cmd.Parameters.AddWithValue("data_cadastro", mskDataCadastro.Text);
                cmd.Parameters.AddWithValue("editora", txtEditora.Text);
                cmd.Parameters.AddWithValue("exemplar", txtExemplar.Text);
                cmd.Parameters.AddWithValue("ano_lancamento", mskAnoLivro.Text);
                cmd.Parameters.AddWithValue("cod_barras", txtCodigoBarras.Text);
                SqlParameter fotoParam = new SqlParameter("foto", SqlDbType.Image);
                if (ConectaWebCam.imagem != null)
                {
                    fotoParam.Value = ConectaWebCam.imagem;
                }
                else
                {
                    fotoParam.Value = DBNull.Value;
                }
                cmd.Parameters.Add(fotoParam);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro cadastrado com sucesso!");

                Util.LimparCampos(this);
                txtTituloLivro.Focus();
                pcbFoto.Image = Properties.Resources.open_book_menu;
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

        private void frmCadLivro_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Livros.codigo = "";
            frmPesqLivro pesq = new frmPesqLivro();
            pesq.ShowDialog();
            if (Livros.codigo != "")
            {
                txtTituloLivro.Text = Leitores.nome;
                txtAutor.Text = Leitores.email;
                mskAnoLivro.Text = Leitores.telefone;
                mskCelular.Text = Leitores.celular;
                txtProfissao.Text = Leitores.profissao;
                mskCEP.Text = Leitores.cep;
                cmbEstado.Text = Leitores.estado;
                cmbCidade.Text = Leitores.cidade;
                txtRua.Text = Leitores.rua;
                txtNumero.Text = Leitores.numero;
                txtComplemento.Text = Leitores.complemento;
                txtBairro.Text = Leitores.bairro;
                if (Leitores.foto != null)
                {
                    MemoryStream ms = new MemoryStream(Leitores.foto);
                    Image img = Image.FromStream(ms);
                    pcbFoto.Image = img;
                }
                else
                {
                    pcbFoto.Image = Properties.Resources.default_user_1;
                }

                // Habilitar os botões Alterar e Excluir
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                // Desabilite o botão Cadastrar
                btnCadastrar.Enabled = false;
            }
    }
}
