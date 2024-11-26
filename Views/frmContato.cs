﻿using ProjetoAgenda.Controller;
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
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }


        private void AtualizarDataGrid()
        {
            ContatoController controleContato = new ContatoController();
            DataTable tabela = controleContato.GetContato();
            dgvContato.DataSource = tabela;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {

            string contato = txtContato.Text;
            string telefone = txtTelefone.Text;
            string categoria = txtCategoria.Text;


            ContatoController controleContato = new ContatoController();

            bool resultado = controleContato.AddContato(contato, telefone, categoria);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar");
            }


            DataTable tabela = controleContato.GetContato();

            dgvContato.DataSource = tabela;

            AtualizarDataGrid();
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }
    }
}