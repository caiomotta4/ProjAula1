using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleCond
{
    public partial class CadastroMorador : System.Web.UI.Page
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
            string nomeCond = txtNome.Text;
            string idadeCond = txtIdade.Text;
            string cpfCond = txtCpf.Text;
            string blocoCond = DDLBloco.Text;
            string aptoCond = DDLApartamento.Text;
            TB_MORADOR v = new TB_MORADOR() { nome = nomeCond, idade = idadeCond, cpf = cpfCond, bloco = blocoCond, apto = aptoCond };
            ControleCondDBEntities contextCond = new ControleCondDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextCond.TB_MORADOR.Add(v);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_MORADOR cond = contextCond.TB_MORADOR.First(c => c.id == id);
                cond.nome = v.nome;
                cond.idade = v.idade;
                cond.cpf = v.cpf;
                cond.bloco = v.bloco;
                cond.apto = v.apto;
                lblmsg.Text = "Registro Alterado";
            }
            contextCond.SaveChanges();
            CarregarLista();
        }

        private void Clear()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtCpf.Text = "";
            txtNome.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            TB_MORADOR cond = new TB_MORADOR();


            if (!String.IsNullOrEmpty(valor))
            {
                ControleCondDBEntities contextCond = new ControleCondDBEntities();
                idItem = Convert.ToInt32(valor);
                cond = contextCond.TB_MORADOR.First(c => c.id == idItem);

                txtNome.Text = cond.nome;
                txtIdade.Text = cond.idade;
                txtCpf.Text = cond.cpf;
                DDLBloco.Text = cond.bloco;
                DDLApartamento.Text = cond.apto;
            }
        }

        private void CarregarLista()
        {
            ControleCondDBEntities context = new ControleCondDBEntities();
            List<TB_MORADOR> lstMorador = context.TB_MORADOR.ToList<TB_MORADOR>();

            GVMorador.DataSource = lstMorador;
            GVMorador.DataBind();
        }

        protected void GVMorador_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            ControleCondDBEntities contextMorador = new ControleCondDBEntities();
            TB_MORADOR morador = new TB_MORADOR();

            morador = contextMorador.TB_MORADOR.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("CadastroMorador.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextMorador.TB_MORADOR.Remove(morador);
                contextMorador.SaveChanges();
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