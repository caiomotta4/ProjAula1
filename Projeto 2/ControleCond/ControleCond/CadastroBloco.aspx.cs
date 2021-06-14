using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleCond
{
    public partial class Cadastrobloco : System.Web.UI.Page
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
            string blocoCond = txtBloco.Text;
            string aptoCond = txtQtdApto.Text;
            string andarCond = txtQtdAndar.Text;
            string moradoresCond = txtTotalMoradores.Text;
            TB_BLOCO v = new TB_BLOCO() { numero_bloco = blocoCond, qtd_apartamentos = aptoCond, qtd_andar = andarCond, total_moradores = moradoresCond };
            ControleCondDBEntities contextCond = new ControleCondDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextCond.TB_BLOCO.Add(v);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_BLOCO cond = contextCond.TB_BLOCO.First(c => c.id == id);
                cond.numero_bloco = v.numero_bloco;
                cond.qtd_apartamentos = v.qtd_apartamentos;
                cond.qtd_andar = v.qtd_andar;
                cond.total_moradores = v.total_moradores;
                lblmsg.Text = "Registro Alterado";
            }
            contextCond.SaveChanges();
            CarregarLista();
        }

        private void Clear()
        {
            txtBloco.Text = "";
            txtQtdApto.Text = "";
            txtQtdAndar.Text = "";
            txtTotalMoradores.Text = "";
            txtBloco.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            TB_BLOCO cond = new TB_BLOCO();


            if (!String.IsNullOrEmpty(valor))
            {
                ControleCondDBEntities contextCond = new ControleCondDBEntities();
                idItem = Convert.ToInt32(valor);
                cond = contextCond.TB_BLOCO.First(c => c.id == idItem);

                txtBloco.Text = cond.numero_bloco;
                txtQtdApto.Text = cond.qtd_apartamentos;
                txtQtdAndar.Text = cond.qtd_andar;
                txtTotalMoradores.Text = cond.total_moradores;
            }
        }

        private void CarregarLista()
        {
            ControleCondDBEntities context = new ControleCondDBEntities();
            List<TB_BLOCO> lstBloco = context.TB_BLOCO.ToList<TB_BLOCO>();

            GVBloco.DataSource = lstBloco;
            GVBloco.DataBind();
        }

        protected void GVBloco_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            ControleCondDBEntities contextBloco = new ControleCondDBEntities();
            TB_BLOCO bloco = new TB_BLOCO();

            bloco = contextBloco.TB_BLOCO.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("CadastroBloco.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextBloco.TB_BLOCO.Remove(bloco);
                contextBloco.SaveChanges();
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