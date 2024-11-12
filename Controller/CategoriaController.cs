using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        { 
            MySqlConnection conexao = null;
            try {

                conexao = ConexaoDB.CriarConexao();

                // Comando SQL que será executado
                string sql = "INSERT INTO tbCategoria (categoria) VALUES (@categoria)";

                // Abri a conexão com o banco
                conexao.Open();

                // Responsável por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Estou trocando o valor dos @ pelas informações que serão cadastradas
                // Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@categoria", categoria);

                // Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();


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
                MessageBox.Show($"ERRO AO CADASTRAR A CATEGORIA: {erro.Message}");
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                // Cria conexão, usei a classe ConexaoDB que já havia criado
                conexao = ConexaoDB.CriarConexao();

                // Select que vai retornar os dados
                string sql = @"SELECT cod_categoria AS 'Código', categoria AS 'Categoria'
                                FROM tbCategoria;";

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
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");

                return new DataTable();
            }

            finally {
                conexao.Close();
            }

        }

        public bool ExcluirCategoria(int cod_categoria)
        {
            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = "DELETE FROM tbCategoria WHERE cod_categoria = @cod_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

                int LinhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (LinhasAfetadas > 0)
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
                MessageBox.Show($"Erro ao recuperar categoria:{erro.Message}");
                return false;
            }

        }

    }
}

