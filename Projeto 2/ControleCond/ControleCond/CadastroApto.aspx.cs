using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleCond
{
    public partial class CadastroApart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string aptoCond = txtApto.Text;
            string moradoresCond = txtMoradores.Text;
            string blocoCond = DDLBloco.Text;
            TB_APARTAMENTO v = new TB_APARTAMENTO() { numero_apto = aptoCond, qtd_moradores = moradoresCond, bloco = blocoCond };
            ControleCondDBEntities contextCond = new ControleCondDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextCond.TB_APARTAMENTO.Add(v);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_APARTAMENTO cond = contextCond.TB_APARTAMENTO.First(c => c.id == id);
                cond.numero_apto = v.numero_apto;
                cond.qtd_moradores = v.qtd_moradores;
                cond.bloco = v.bloco;
                lblmsg.Text = "Registro Alterado";
            }
            contextCond.SaveChanges();
            CarregarLista();
        }

        private void Clear()
        {
            txtApto.Text = "";
            txtMoradores.Text = "";
            txtApto.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            TB_APARTAMENTO cond = new TB_APARTAMENTO();


            if (!String.IsNullOrEmpty(valor))
            {
                ControleCondDBEntities contextCond = new ControleCondDBEntities();
                idItem = Convert.ToInt32(valor);
                cond = contextCond.TB_APARTAMENTO.First(c => c.id == idItem);

                txtApto.Text = cond.numero_apto;
                txtMoradores.Text = cond.qtd_moradores;
                DDLBloco.Text = cond.bloco;
            }
        }

        private void CarregarLista()
        {
            ControleCondDBEntities context = new ControleCondDBEntities();
            List<TB_APARTAMENTO> lstApartamento = context.TB_APARTAMENTO.ToList<TB_APARTAMENTO>();

            GVApartamento.DataSource = lstApartamento;
            GVApartamento.DataBind();
        }

        protected void GVApartamento_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            ControleCondDBEntities contextApartamento = new ControleCondDBEntities();
            TB_APARTAMENTO apartamento = new TB_APARTAMENTO();

            apartamento = contextApartamento.TB_APARTAMENTO.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("CadastroApto.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextApartamento.TB_APARTAMENTO.Remove(apartamento);
                contextApartamento.SaveChanges();
                string msg = "Excluída com sucesso !";
                string titulo = "Informação";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        } 
    }
}