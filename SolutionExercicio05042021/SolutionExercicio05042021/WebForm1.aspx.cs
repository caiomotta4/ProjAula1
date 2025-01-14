﻿using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolutionExercicio05042021
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Ferramenta ferramenta = getData();
            var db = new FerramentaDB();

            if (db.Insert(ferramenta))
            {
                LblMsg.Text = "Registro inserido!";
                LoadGrid();
            }
            else
                LblMsg.Text = "Erro ao inserir registro";
        }

        private Ferramenta getData()
        {
            return new Ferramenta()
            {
                Descricao = txtDescricao.Text,
                Tipo = txtTipo.Text,
                Marca = txtMarca.Text,
                Preco = txtPreco.Text
            };
        }

        private void LoadGrid()
        {
            GVFerramenta.DataSource = new FerramentaDB().GetAll();
            GVFerramenta.DataBind();
        }
    }
}