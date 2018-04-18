using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marcade.Facade
{
    public class FilmeFacade
    {
        private DAO.FilmeDao filmeDAO;

        public FilmeFacade()
        {
            filmeDAO = new DAO.FilmeDao();
        }

        public void IncluirFilme(DTO.Filme filme)
        {
            filmeDAO.IncluirFilme(filme);
        }

        public void AtualizarFilme(DTO.Filme filme)
        {
            filmeDAO.AtualizarFilme(filme);
        }

        public void DeletarFilme(DTO.Filme filme)
        {
            try
            {
                filmeDAO.DeletarFilme(filme);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DTO.Filme> ListaDeFilmes()
        {
            try
            {
                return filmeDAO.ListaDeFilmes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelecionarFilmes()
        {
            DataTable tb = new DataTable();
            try
            {
                tb = filmeDAO.SelecionarFilmes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DataTable FilmesNaoAssistidos()
        {
            DataTable tb = new DataTable();
            try
            {
                tb = filmeDAO.FilmesNaoAssistidos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tb;
        }

        public DTO.Filme SelecionarFilmePeloId(int id)
        {
            try
            {
                return filmeDAO.SelecionarFilmePeloId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO.Filme ObterFilmePeloTitulo(string titulo)
        {
            try
            {
                return filmeDAO.ObterFilmePeloTitulo(titulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
