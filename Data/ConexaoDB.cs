﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static internal class ConexaoDB
    {
        static public MySqlConnection CriarConexao()
        {
            // string contendo as informações para conexão
            string stringConexao = "Server=localhost;Database=dbAgenda;User ID=root;Password=root;";

            // criando a conexão
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}
