using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Marcade.Utils
{
    public class ConectarBancoDados
    {
        private static string conexao = "Server=localhost;Database=filmes;Uid=root;Pwd=mysql";

        public static MySqlConnection ObterConexao()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conexao);
            return mySqlConnection;
        }
    }
}
