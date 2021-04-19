<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarFilmes.aspx.cs" Inherits="ProjetoLocadora.ConsultarFilmes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong><em>Lista de Filmes</em></strong></div>
        <asp:GridView ID="GVFilmes" runat="server" Width="1297px">
        </asp:GridView>
        <asp:Button ID="VoltaTelaFF" runat="server" PostBackUrl="~/TelaCliente.aspx" Text="&lt;=" />
    </form>
</body>
</html>
