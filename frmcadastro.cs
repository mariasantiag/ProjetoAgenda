using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
