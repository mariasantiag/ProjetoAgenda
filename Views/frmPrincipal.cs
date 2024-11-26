using ProjetoAgenda.VariableGlobal;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string bemvindo = $"Seja bem-vindo {UserSession.usuario}";
            lblBoaVindas.Text = bemvindo;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria Categoria = new frmCategoria();
            Categoria.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario Usuario = new frmUsuario();
            Usuario.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void lblBoaVindas_Click(object sender, EventArgs e)
        {

        }
    }
}
