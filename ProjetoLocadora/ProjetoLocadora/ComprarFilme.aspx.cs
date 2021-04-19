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
    public partial class ComprarFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void FimCompra_Click(object sender, EventArgs e)
        {
            Compra compra = getData();
            var db = new CompraDB();

            if (compra.Id == 0)
            {
                if (db.Insert(compra))
                {
                    LblMsg.Text = "Compra Finalizada com Sucesso!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro!";
            }
        }

        private void LoadGrid()
        {
            GVCompra.DataSource = new CompraDB().GetAll();
            GVCompra.DataBind();
        }

        private Compra getData()
        {
            return new Compra()
            {
                IDFilme = IDFilme.Text,
                NomeF = NomeF.Text,
                IDCliente = IDCliente.Text,
                NomeC = NomeC.Text
            };
        }

    }
}