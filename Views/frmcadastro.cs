using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }
        private void habilitarCadastrar()
        {

            if (txtNome.Text != "" && txtUsuario.Text != "" && txtSenha.Text.Length >= 8 && txtSenha.Text == txtRepitaaSenha.Text)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }

        private void frmcadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void txtRepitaaSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastrar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            // abrindo conexao
            conexao.Open();

            // criando o comando SQL para inserir o usuário
            string sql = $"INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha)";
            
            // criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            comando.Parameters.AddWithValue("@nome", txtSenha.Text);

            // executando a instrução SQL no bancoV
            comando.ExecuteNonQuery();

            // fechando a conexão com o banco
            conexao.Close();

            MessageBox.Show("Cadastro efetuado com sucesso! \n Você já pode realizar o login");
            this.Close();
        }
    }
}
