using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria
{
    public partial class Conta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomeConta = txtNome.Text;
            string cpfConta = txtCpf.Text;
            string telefoneConta = txtTelefone.Text;
            string enderecoConta = txtEndereco.Text;
            TB_CONTA v = new TB_CONTA() { nome = nomeConta, cpf = cpfConta, telefone = telefoneConta, endereco = enderecoConta };
            BancoDBEntities contextConta = new BancoDBEntities();

            string valor = Request.QueryString["idItem"];

            if (String.IsNullOrEmpty(valor))
            {
                contextConta.TB_CONTA.Add(v);
                lblmsg.Text = "Registro Inserido!";
                Clear();
            }
            else
            {
                int id = Convert.ToInt32(valor);
                TB_CONTA conta = contextConta.TB_CONTA.First(c => c.id == id);
                conta.nome = v.nome;
                conta.cpf = v.cpf;
                conta.telefone = v.telefone;
                conta.endereco = v.endereco;
                lblmsg.Text = "Registro Alterado";
            }
            contextConta.SaveChanges();
        }

        private void Clear()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtNome.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;
            TB_CONTA conta = new TB_CONTA();


            if (!String.IsNullOrEmpty(valor))
            {
                BancoDBEntities contextConta = new BancoDBEntities();
                idItem = Convert.ToInt32(valor);
                conta = contextConta.TB_CONTA.First(c => c.id == idItem);

                txtNome.Text = conta.nome;
                txtCpf.Text = conta.cpf;
                txtTelefone.Text = conta.telefone;
                txtEndereco.Text = conta.endereco;
            }
        }
    }
}