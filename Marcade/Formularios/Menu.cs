using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcade
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro telaCadastro = new frmCadastro ();
            telaCadastro.ShowDialog();
        }

        private void pROCURARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaPesquisa telaPesquisa = new frmTelaPesquisa();
            telaPesquisa.ShowDialog();
        }

        private void aSSISTIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcade.Formularios.frmAssistidos telaAssistidos = new Marcade.Formularios.frmAssistidos();
            telaAssistidos.ShowDialog();
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcade.Formularios.frmInformacao telaInfo = new Marcade.Formularios.frmInformacao();
            telaInfo.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formularios.ListaDeFilmesAssistidos ListaDeFilmes = new Formularios.ListaDeFilmesAssistidos();
            ListaDeFilmes.Show();
        }
    }
}
