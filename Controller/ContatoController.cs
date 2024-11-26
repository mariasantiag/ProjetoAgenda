﻿using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {

        public bool AddContato(string contato, string telefone, string categoria)
        {
            try
            {
                // Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                // Comando SQL que será executado
                string sql = "INSERT INTO tbContatos (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);";

                // Abri a conexão com o banco
                conexao.Open();

                // Responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);
               

                // Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                // Fechei a conexão
                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao efetuar o cadastro: {erro.Message}");
                return false;
            }

        }

        public DataTable GetContato()
        {
            MySqlConnection conexao = null;

            try
            {
                // Cria conexão, usei a classe ConexaoDB que já havia criado
                conexao = ConexaoDB.CriarConexao();

                // Select que vai retornar os dados
                string sql = @"SELECT contato AS 'Contato', telefone AS 'Telefone', categoria AS 'Categoria' from tbContatos";

                // Abri a conexão
                conexao.Open();

                // Ao inves de utilizar o MySqlCommand, vou utilizar o MySqlDataAdapter pois quero trabalhar
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                // Criei uma tabela vazia
                DataTable tabela = new DataTable();

                // O adaptador vai preencher a tabela com os dados
                adaptador.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar contato: {erro.Message}");

                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }

        }
    }
}