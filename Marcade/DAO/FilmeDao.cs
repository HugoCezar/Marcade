using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Marcade.DAO
{
    public class FilmeDao
    {
        public void IncluirFilme(DTO.Filme filme)
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
            {
                string queryString = @"insert into filme(id,titulo,ano,genero,assistido,ator,diretor) 
                                    values (@id, @titulo, @ano, @genero, @assistido, @ator, @diretor)";

                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", filme.Id);
                command.Parameters.AddWithValue("@titulo", filme.Titulo);
                command.Parameters.AddWithValue("@ano", filme.Ano);
                command.Parameters.AddWithValue("@genero", filme.Genero);
                command.Parameters.AddWithValue("@assistido", filme.Assistido);
                command.Parameters.AddWithValue("@ator", filme.Ator);
                command.Parameters.AddWithValue("@diretor", filme.Diretor);

                try
                {
                    connection.Open();
                    int valor = command.ExecuteNonQuery();

                    if (valor <= 0)
                    {
                        throw new Exception("Não foi possivel inserir o filme");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }

        public void AtualizarFilme(DTO.Filme filme)
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
            {
                string mysql = "UPDATE Filme SET @id=id, @titulo=titulo, @ano=ano, @genero=genero, @assistido=assistido, @ator=ator, @diretor=diretor WHERE @id=id";
                MySqlCommand cmd = new MySqlCommand(mysql, connection);
                cmd.Parameters.AddWithValue("@id", filme.Id);
                cmd.Parameters.AddWithValue("@titulo", filme.Titulo);
                cmd.Parameters.AddWithValue("@ano", filme.Ano);
                cmd.Parameters.AddWithValue("@genero", filme.Genero);
                cmd.Parameters.AddWithValue("@assistido", filme.Assistido);
                cmd.Parameters.AddWithValue("@ator", filme.Ator);
                cmd.Parameters.AddWithValue("@diretor", filme.Diretor);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }  
        }

        public void DeletarFilme(DTO.Filme filme)
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
                try
                {
                    string mysql = "DELETE FROM Filme WHERE @id = id";
                    MySqlCommand cmd = new MySqlCommand(mysql, connection);
                    cmd.Parameters.AddWithValue("@id", filme.Id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
        }

        public List<DTO.Filme> ListaDeFilmes()
        {
            using (MySqlConnection connection = Utils.ConectarBancoDados.ObterConexao())
                using (MySqlCommand cmd = new MySqlCommand("Select * from Filme", connection))
                try
                {
                    connection.Open();
                    List<DTO.Filme> listaFilmes = new List<DTO.Filme>();
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            DTO.Filme filme = new DTO.Filme();
                            filme.Id = (int)leitor["id"];
                            filme.Titulo = leitor["titulo"].ToString();
                            filme.Ano = leitor["ano"].ToString();
                            filme.Genero = leitor["genero"].ToString();
                            filme.Assistido = leitor["assistido"].ToString();
                            filme.Ator = leitor["ator"].ToString();
                            filme.Diretor = leitor["diretor"].ToString();
                        }
                    }
                    return listaFilmes;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao acessar o banco" + ex.Message);
                }
        }

        public DataTable SelecionarFilmes()
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
            try
                {
                    string mysql = "SELECT * FROM Filme WHERE assistido = 'Sim'";
                    MySqlCommand cmd = new MySqlCommand(mysql, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public DataTable FilmesNaoAssistidos()
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
                try
                {
                    string mysql = "SELECT * FROM Filme WHERE assistido = 'Não'";
                    MySqlCommand cmd = new MySqlCommand(mysql, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public DTO.Filme SelecionarFilmePeloId(int id)
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
            try
                {
                    string mysql = "SELECT * FROM Filme WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(mysql, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    MySqlDataReader leitor;

                    DTO.Filme filme = new DTO.Filme();
                    leitor = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    
                    while (leitor.Read())
                    {
                        filme.Id = Convert.ToInt32(leitor["id"]);
                        filme.Titulo = leitor["titulo"].ToString();
                        filme.Ano = leitor["ano"].ToString();
                        filme.Genero = leitor["genero"].ToString();
                        filme.Assistido = leitor["assistido"].ToString();
                        filme.Ator = leitor["ator"].ToString();
                        filme.Diretor = leitor["diretor"].ToString();
                    }
                    return filme;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public DTO.Filme ObterFilmePeloTitulo(string titulo)
        {
            using (MySqlConnection connection =
                        Utils.ConectarBancoDados.ObterConexao())
            {
                string queryString = "SELECT * FROM Filme WHERE titulo = @titulo";
                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@titulo", titulo);
                connection.Open();
                MySqlDataReader leitor;

                DTO.Filme filme = new DTO.Filme();
                leitor = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (leitor.Read())
                {
                    filme.Id = Convert.ToInt32(leitor["id"]);
                    filme.Titulo = leitor["titulo"].ToString();
                    filme.Ano = leitor["ano"].ToString();
                    filme.Genero = leitor["genero"].ToString();
                    filme.Assistido = leitor["assistido"].ToString();
                    filme.Ator = leitor["ator"].ToString();
                    filme.Diretor = leitor["diretor"].ToString();
                }
                return filme;
            }
        }
    }
}
