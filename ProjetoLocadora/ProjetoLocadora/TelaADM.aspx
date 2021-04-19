<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaADM.aspx.cs" Inherits="ProjetoLocadora.TelaADM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            text-decoration: underline;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 263px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><em>Seja Bem Vindo Caio!</em></strong></div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Cadastrar um novo Filme:</td>
                <td>
                    <asp:Button ID="CadastroFilme" runat="server" Text="Cadastrar" PostBackUrl="~/AdicionarFilme.aspx" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
