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
    public partial class TelaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = getData();
            var db = new ClienteDB();

            if (cliente.Id == 0)
            {
                if (db.Insert(cliente))
                {
                    LblMsg.Text = "Cadastrado com Sucesso!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro!";
            }
        }

        private void LoadGrid()
        {
            GVCliente.DataSource = new ClienteDB().GetAll();
            GVCliente.DataBind();
        }

        private Cliente getData()
        {
            return new Cliente()
            {
                Name = Name.Text,
                Telephone = Telephone.Text,
                NumeroCartao = NumeroCartao.Text,
                Validade = Validade.Text,
                CodSeguranca = CodSeguranca.Text,
                Endereco = Endereco.Text,
                Cidade = Cidade.Text,
                Pais = Pais.Text,
                CEP = CEP.Text

            };
        }
    }
}