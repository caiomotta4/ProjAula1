using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLocadora
{
    public partial class AdicionarFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void AdcionarFilme_Click(object sender, EventArgs e)
        {
            Filmes filmes = getData();
            var db = new FilmesDB();

            if (filmes.Id == 0)
            {
                if (db.Insert(filmes))
                {
                    LblMsg.Text = "Filme Adicionado!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro!";
            }
        }
        private void LoadGrid()
        {
            GVFilmes.DataSource = new FilmesDB().GetAll();
            GVFilmes.DataBind();
        }

        private Filmes getData()
        {
            return new Filmes()
            {
                NomeFilme = NomeFilme.Text,
                GeneFilme = GeneFilme.Text,
                DiretorFilme = DiretorFilme.Text,
                SinopseFilme = SinopseFilme.Text,
                Preco = Preco.Text
            };
        }
    }
}