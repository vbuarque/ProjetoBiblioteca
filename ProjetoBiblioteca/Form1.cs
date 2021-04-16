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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM LOGIN
                               WHERE LOGIN = @login AND SENHA = @senha";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("login", txtLogin.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr["TIPO_USER"].ToString() == "Administrador")
                    {
                        frmMenu menu = new frmMenu();
                        Visible = false;
                        menu.ShowDialog();
                        Visible = true;
                        Util.LimparCampos(this);
                        txtLogin.Focus();
                    }
                    else
                    {
                        frmMenu menu = new frmMenu();
                        Visible = false;
                        menu.btnCadLogin.Visible = false;
                        menu.ShowDialog();
                        Visible = true;
                        Util.LimparCampos(this);
                        txtLogin.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                }
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
    }
}
