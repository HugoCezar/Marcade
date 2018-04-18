using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marcade
{
    public partial class frmTelaPesquisa : Form
    {
        public frmTelaPesquisa()
        {
            InitializeComponent();
        }

        public void LimparTela()
        {
            txtTitulo.Text = "";
            cboAno.Text = "";
            cboGenero.Text = "";
            rbtSim.Checked = false;
            rbtNao.Checked = false;
            txtAtor.Text = "";
            txtDiretor.Text = "";
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            LimparTela();
            txtBuscarId.Focus();
            Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();
            dgvFilmes.DataSource = filmeFacade.SelecionarFilmes();
        }

        private void btnPesquisarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBuscarId.Text);
            DTO.Filme filme = new DTO.Filme();
            
            try
            {
                Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();
                
                filme = filmeFacade.SelecionarFilmePeloId(id);
                txtCodigo.Text = filme.Id.ToString();
                txtTitulo.Text = filme.Titulo;
                cboAno.Text = filme.Ano;
                cboGenero.Text = filme.Genero;
                if (filme.Assistido == "SIM")
                    rbtSim.Checked = true;
                else
                    rbtNao.Checked = true;
                txtAtor.Text = filme.Ator;
                txtDiretor.Text = filme.Diretor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnPesquisarTitulo_Click(object sender, EventArgs e)
        {
            string titulo = txtBuscarTitulo.Text;
            DTO.Filme filme = new DTO.Filme();

            try
            {
                Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();

                filme = filmeFacade.ObterFilmePeloTitulo(titulo);
                txtCodigo.Text = filme.Id.ToString();
                txtTitulo.Text = filme.Titulo;
                cboAno.Text = filme.Ano;
                cboGenero.Text = filme.Genero;
                if (filme.Assistido == "SIM")
                    rbtSim.Checked = true;
                else
                    rbtNao.Checked = true;
                txtAtor.Text = filme.Ator;
                txtDiretor.Text = filme.Diretor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DTO.Filme filme = new DTO.Filme();
            filme.Titulo = txtTitulo.Text;
            filme.Ano = cboAno.Text;
            filme.Genero = cboGenero.Text;
            if (rbtSim.Checked == true)
                filme.Assistido = "Sim";
            else if (rbtNao.Checked == true)
                filme.Assistido = "Não";
            filme.Ator = txtAtor.Text;
            filme.Diretor = txtDiretor.Text;

            try
            {
                Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();
                filmeFacade.AtualizarFilme(filme);

                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Você tem certeza!", "", MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                DTO.Filme filme = new DTO.Filme();
                filme.Id = Convert.ToInt32(txtBuscarId.Text);

                try
                {
                    Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();
                    filmeFacade.DeletarFilme(filme);
                    MessageBox.Show("Filme Excluído!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar" + ex.Message.ToString());
                }
            }
        }

        private void dgvFilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFilmes.SelectedRows[0].Cells[0].Value.ToString();
            txtTitulo.Text = dgvFilmes.SelectedRows[0].Cells[1].Value.ToString();
            cboAno.Text = dgvFilmes.SelectedRows[0].Cells[2].Value.ToString(); 
            cboGenero.Text = dgvFilmes.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
