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
using ProjetoAgenda.VariableGlobal;

namespace ProjetoAgenda
{
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LogarUsuario("olivia", "olivia12");

            MessageBox.Show(resultado.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.usuario = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserSession.usuario);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
