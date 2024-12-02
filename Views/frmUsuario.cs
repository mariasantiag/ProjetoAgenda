using Org.BouncyCastle.Asn1.Cmp;
using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }


        private void AtualizarDataGrid()
        {
            UsuarioController controleCategoria = new UsuarioController();
            DataTable tabela = controleCategoria.GetUsuario();
            dvgUsuario.DataSource = tabela;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(dvgUsuario.SelectedRows[0].Cells[1].Value);
            UsuarioController categoria = new UsuarioController();
            bool resultado = categoria.ExcluirUsuario(nome);
            AtualizarDataGrid();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;

            string usuario = txtUsuario.Text;

            UsuarioController controleusuario = new UsuarioController();

            bool resultado = controleusuario.AlterarSenha(senha, usuario);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }

            else
            {
                MessageBox.Show("Não foi possivel cadastrar o usuario");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
