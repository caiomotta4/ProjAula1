using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLocadora
{
    public partial class ConsultarFilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            GVFilmes.DataSource = new FilmesDB().GetAll();
            GVFilmes.DataBind();
        }
    }
}