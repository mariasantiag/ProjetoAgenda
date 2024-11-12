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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
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
            AtualizarDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController categoria = new CategoriaController();
            bool resultado = categoria.ExcluirCategoria(codigo);
            AtualizarDataGrid();

        }
    }
}