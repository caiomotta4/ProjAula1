<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaCliente.aspx.cs" Inherits="ProjetoLocadora.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 100%;
            height: 145px;
        }
        .auto-style6 {
            width: 135px;
            height: 29px;
            text-align: center;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style8 {
            width: 135px;
            text-align: center;
            height: 50px;
        }
        .auto-style9 {
            width: 260px;
            height: 29px;
            text-align: center;
        }
        .auto-style10 {
            width: 260px;
            text-align: center;
            height: 50px;
        }
        .auto-style11 {
            width: 260px;
            height: 27px;
            text-align: center;
        }
        .auto-style12 {
            width: 135px;
            height: 27px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; font-weight: 700; text-decoration: underline; color: #000000; font-size: xx-large">
            <p style="font-style: normal; font-family: Elephant; font-size: 48px;">
                <em>STAR VIDEO</em></p>
        </div>
        <p>
            &nbsp;</p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style9">Conta</td>
                <td class="auto-style6">Filmes</td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style11">
            <asp:Button runat="server" Text="Cadastrar" PostBackUrl="~/TelaCadastro.aspx" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="ConsultarFilme" runat="server" Text="Consultar" PostBackUrl="~/ConsultarFilmes.aspx" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="ComprarFilme" runat="server" Text="Comprar" />
                </td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
