<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaCadastro.aspx.cs" Inherits="ProjetoLocadora.TelaCadastro" %>

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
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <em><strong>Cadastrar Conta<br />
            </strong></em>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Nome</td>
                <td>Telefone</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="Telephone" runat="server" Height="25px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Número do Cartão</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="NumeroCartao" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Código de Segurança</td>
                <td>Data de Validade</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="CodSeguranca" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="Validade" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Endereço de Cobrança</td>
                <td>Cidade</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="Endereco" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="Cidade" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">País</td>
                <td>Código Postal (CEP)</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="Pais" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="CEP" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="TelaCliente" runat="server" PostBackUrl="~/TelaCliente.aspx" Text="&lt;=" />
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
                </td>
                <td>
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GVCliente" runat="server" Width="1281px">
        </asp:GridView>
    </form>
</body>
</html>
