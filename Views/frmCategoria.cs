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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(txtCategoria.Text);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar");
            }

            CategoriaController controlaCategoria = new CategoriaController();
            DataTable tabela = controlaCategoria.GetCategorias();

            dgvCategoria.DataSource = tabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();

            dgvCategoria.DataSource = tabela;
        }
    }
}
