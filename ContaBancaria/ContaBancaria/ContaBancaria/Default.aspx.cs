using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            BancoDBEntities context = new BancoDBEntities();
            List<TB_CONTA> lstConta = context.TB_CONTA.ToList<TB_CONTA>();

            GVConta.DataSource = lstConta;
            GVConta.DataBind();
        }

        protected void GVConta_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            BancoDBEntities contextConta = new BancoDBEntities();
            TB_CONTA conta = new TB_CONTA();

            conta = contextConta.TB_CONTA.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Conta.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextConta.TB_CONTA.Remove(conta);
                contextConta.TB_CONTA.Remove(conta);
                contextConta.SaveChanges();
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