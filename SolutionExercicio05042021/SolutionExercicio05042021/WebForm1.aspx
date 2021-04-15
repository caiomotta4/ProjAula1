<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SolutionExercicio05042021.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Descrição</td>
                <td>
                    <asp:TextBox ID="txtDescricao" runat="server" Width="221px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Tipo</td>
                <td>
                    <asp:TextBox ID="txtTipo" runat="server" Width="219px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Marca</td>
                <td>
                    <asp:TextBox ID="txtMarca" runat="server" Width="217px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Preço</td>
                <td>
                    <asp:TextBox ID="txtPreco" runat="server" Width="215px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GVFerramenta" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
