<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComprarFilme.aspx.cs" Inherits="ProjetoLocadora.ComprarFilme" %>

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
            height: 26px;
        }
        .auto-style3 {
            width: 351px;
        }
        .auto-style4 {
            height: 26px;
            width: 351px;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style6 {
            width: 351px;
            height: 25px;
        }
        .auto-style7 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <em><strong>Finalizar Compra!<br />
            </strong></em>
        </div>
        <table class="auto-style5">
            <tr>
                <td class="auto-style6">Informação do Filme Desejado:</td>
                <td class="auto-style7">Suas Informações:</td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Nome:&nbsp;
                    <asp:TextBox ID="IDFilme" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    Nome Completo:&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="IDCliente" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="NomeF" runat="server"></asp:TextBox>
                </td>
                <td>ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="NomeC" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Button ID="VoltarTelaC" runat="server" PostBackUrl="~/TelaCliente.aspx" Text="&lt;=" />
            <asp:Button ID="FimCompra" runat="server" Text="Finalizar Compra" OnClick="FimCompra_Click" />
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
        </p>
        <asp:GridView ID="GVCompra" runat="server" Width="1281px">
        </asp:GridView>
    </form>
</body>
</html>
