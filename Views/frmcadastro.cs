using MySql.Data.MySqlClient;
using ProjetoAgenda.Controller;
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
            // Pegando os dados do formulário
            string nome = txtNome.Text; 
            string usuario = txtUsuario.Text;
            string telefone = txtTelefone.Text;
            string senha = txtSenha.Text;  

            // Instanciando o objeto usando UsuarioController
            UsuarioController controleUsuario = new UsuarioController();

            //Inserindo o usuário
             bool resultado = controleUsuario.AddUsuario(nome, usuario, telefone, senha);

            if (resultado) 
            {
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o usuário.");
            }
        }

    }
}
