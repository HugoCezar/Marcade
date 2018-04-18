using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Marcade
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
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

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            txtTitulo.Focus();
            for (int data = 1940; data <= DateTime.Now.Year; data++)
                cboAno.Items.Add(data);
            rbtSim.Checked = true;            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            DTO.Filme filme = new DTO.Filme();
            filme.Titulo = txtTitulo.Text;
            filme.Ano = cboAno.Text;
            filme.Genero = cboGenero.Text;
            if (rbtSim.Checked == true)
                filme.Assistido = rbtSim.Text;
            else if (rbtNao.Checked == true)
                filme.Assistido = rbtNao.Text;
            filme.Ator = txtAtor.Text;
            filme.Diretor = txtDiretor.Text;

            try
            {
                Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();
                filmeFacade.IncluirFilme(filme);

                MessageBox.Show("Incluido com sucesso");
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir" + ex.Message.ToString());
            }
        }
    } 
}
