using ProjetoAgenda.Controller;
using ProjetoAgenda.Views;

namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            // Se a caixa de usuário for diferente de vazio e a quantidade caracteres na senha for 8 ou maior, ele conseguirá logar
            if (txtUsuario.Text != "" && txtSenha.Text.Length >= 8)
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmcadastro Cadastro = new frmcadastro();
            Cadastro.Show();
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario(txtUsuario.Text, txtSenha.Text);

            MessageBox.Show(resultado.ToString());

            if (resultado) {
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.Show();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }
    }
} 
