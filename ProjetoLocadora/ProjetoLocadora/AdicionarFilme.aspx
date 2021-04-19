<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarFilme.aspx.cs" Inherits="ProjetoLocadora.AdicionarFilme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
            font-size: xx-large;
            text-align: center;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style11 {
            width: 359px;
            height: 26px;
        }
        .auto-style12 {
            width: 359px;
        }
        .auto-style13 {
            width: 265px;
            height: 26px;
        }
        .auto-style14 {
            width: 265px;
        }
        .auto-style15 {
            width: 301px;
            height: 26px;
        }
        .auto-style16 {
            width: 301px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Cadastro de Novos Filmes</strong></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style11">Nome do Filme</td>
                <td class="auto-style5">Género</td>
                <td class="auto-style13">Diretor</td>
                <td class="auto-style15">Sinopse</td>
                <td class="auto-style15">Preço</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:TextBox ID="NomeFilme" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="GeneFilme" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="DiretorFilme" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:TextBox ID="SinopseFilme" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:TextBox ID="Preco" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="VoltarTelaF" runat="server" Text="&lt;=" PostBackUrl="~/TelaADM.aspx" />
                    <asp:Button ID="AdcionarFilme" runat="server" Text="Adicionar" OnClick="AdcionarFilme_Click" />
                </td>
                <td>
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GVFilmes" runat="server" Width="1284px">
        </asp:GridView>
    </form>
</body>
</html>
