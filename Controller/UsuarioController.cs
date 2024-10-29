using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario (string nome, string usuario, string telefone, string senha)
        {
            // Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            // Comando SQL que será executado
            string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha)";

            // Abri a conexão com o banco
            conexao.Open();

            // Responsável por executar o comando SQL
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            // Estou trocando o valor dos @ pelas informações que serão cadastradas
            // Essas informações vieram dos parametros da função
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@senha", senha);
    
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
    }
}
