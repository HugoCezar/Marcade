using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcade.Formularios
{
    public partial class ListaDeFilmesAssistidos : Form
    {
        public ListaDeFilmesAssistidos()
        {
            InitializeComponent();
        }

        private void ListaDeFilmesAssistidos_Load(object sender, EventArgs e)
        {
            Facade.FilmeFacade filmeFacade = new Facade.FilmeFacade();
            dgvListaDeFilmes.DataSource = filmeFacade.SelecionarFilmes();
        }
    }
}
