using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmCadLeitor : Form
    {
        bool tirarFoto = true;

        public frmCadLeitor()
        {
            InitializeComponent();
            ConectaWebCam.pcbFoto = pcbFoto;
        }

        public void LocalizarCEP()
        {
            using (var ws = new WSCEP.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mskCEP.Text);
                    cmbEstado.Text = resultado.uf;
                    cmbCidade.Text = resultado.cidade;
                    txtRua.Text = resultado.end;
                    txtBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }

            if (mskCelular.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCelular, "Preencha o campo celular");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCelular, "");
            }

            if (mskCEP.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCEP, "Preencha o campo CEP");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCEP, "");
            }

            if (cmbEstado.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbEstado, "Preencha o campo estado");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbEstado, "");
            }

            if (cmbCidade.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbEstado, "Preencha o campo cidade");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbCidade, "");
            }

            if (txtRua.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtRua, "Preencha o campo RUA");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtRua, "");
            }

            if (txtNumero.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNumero, "Preencha o campo NÚMERO");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNumero, "");
            }

            if (txtBairro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtBairro, "Preencha o campo BAIRRO");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtBairro, "");
            }

            try
            {
                Conexao.Conectar();
                string sql = @"INSERT INTO LEITORES ([NOME]
           ,[EMAIL]
           ,[TELEFONE]
           ,[CELULAR]
           ,[PROFISSAO]
           ,[CEP]
           ,[ESTADO]
           ,[CIDADE]
           ,[RUA]
           ,[NUMERO]
           ,[COMPLEMENTO]
           ,[BAIRRO]
           ,[FOTO]) VALUES (@nome, @email,
                    @telefone, @celular, @profissao, @cep, @estado, @cidade, @rua,
                    @numero, @complemento, @bairro, @foto)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("telefone", mskTelefone.Text);
                cmd.Parameters.AddWithValue("celular", mskCelular.Text);
                cmd.Parameters.AddWithValue("profissao", txtProfissao.Text);
                cmd.Parameters.AddWithValue("cep", mskCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtRua.Text);
                cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                // Adicionar imagem NULL ao banco de dados
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
                //cmd.Parameters.AddWithValue("data", DateTime.Now.ToShortDateString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Leitor cadastrado com sucesso!");

                Util.LimparCampos(this);
                txtNome.Focus();
                pcbFoto.Image = Properties.Resources.default_user_1;
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

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void frmCadLeitor_Load(object sender, EventArgs e)
        {
            mskDataCadastro.Text = DateTime.Now.ToShortDateString();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Leitores.codigo = "";
            frmPesqLeitor pesq = new frmPesqLeitor();
            pesq.ShowDialog();
            if (Leitores.codigo != "")
            {
                txtNome.Text = Leitores.nome;
                txtEmail.Text = Leitores.email;
                mskTelefone.Text = Leitores.telefone;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM LEITORES WHERE CODIGO = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", Leitores.codigo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Leitor excluido com sucesso!");

                Util.LimparCampos(this);
                mskDataCadastro.Text = DateTime.Now.ToShortDateString();
                txtNome.Focus();

                btnCadastrar.Enabled = true;

                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }

            if (mskCelular.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCelular, "Preencha o campo celular");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCelular, "");
            }

            if (mskCEP.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCEP, "Preencha o campo CEP");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCEP, "");
            }

            if (cmbEstado.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbEstado, "Preencha o campo estado");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbEstado, "");
            }

            if (cmbCidade.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(cmbEstado, "Preencha o campo cidade");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cmbCidade, "");
            }

            if (txtRua.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtRua, "Preencha o campo RUA");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtRua, "");
            }

            if (txtNumero.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNumero, "Preencha o campo NÚMERO");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNumero, "");
            }

            if (txtBairro.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtBairro, "Preencha o campo BAIRRO");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtBairro, "");
            }

            try
            {
                Conexao.Conectar();

                string sql = @"UPDATE LEITORES SET NOME = @NOME,
                    EMAIL = @EMAIL, TELEFONE = @TELEFONE,
                    CELULAR = @CELULAR, PROFISSAO = @PROFISSAO, CEP = @CEP,
                    ESTADO = @ESTADO, CIDADE = @CIDADE, RUA = @RUA, 
                    NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO,
                    BAIRRO = @BAIRRO, FOTO = @FOTO
                    WHERE CODIGO = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("telefone", mskTelefone.Text);
                cmd.Parameters.AddWithValue("celular", mskCelular.Text);
                cmd.Parameters.AddWithValue("profissao", txtProfissao.Text);
                cmd.Parameters.AddWithValue("cep", mskCEP.Text);
                cmd.Parameters.AddWithValue("estado", cmbEstado.Text);
                cmd.Parameters.AddWithValue("cidade", cmbCidade.Text);
                cmd.Parameters.AddWithValue("rua", txtRua.Text);
                cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                // Adicionar imagem NULL ao banco de dados
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
                //cmd.Parameters.AddWithValue("data", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("codigo", Leitores.codigo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Leitor alterado com sucesso!");

                Util.LimparCampos(this);
                mskDataCadastro.Text = DateTime.Now.ToShortDateString();
                txtNome.Focus();

                btnCadastrar.Enabled = true;

                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
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

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
