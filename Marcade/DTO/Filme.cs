using System;
using System.Collections.Generic;
using System.Text;

namespace Marcade.DTO
{
    public class Filme
    {
        private int id;
        private string titulo;
        private string ano;
        private string genero;
        private string assistido;
        private string ator;
        private string diretor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Assistido
        {
            get { return assistido; }
            set { assistido = value; }
        }

        public string Ator
        {
            get { return ator; }
            set { ator = value; }
        }

        public string Diretor
        {
            get { return diretor; }
            set { diretor = value; }
        }
    }
}
