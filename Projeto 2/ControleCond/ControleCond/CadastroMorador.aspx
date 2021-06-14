<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CadastroMorador.aspx.cs" Inherits="ControleCond.CadastroMorador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript"> function MostrarPopupMensagem() { $("#modalMsg").modal('show'); }
        function EsconderPopupDados() { $("#modalDados").modal('hide'); } </script>
    <!-- /.modal -->
    <div class="modal fade" id="modalMsg">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                    <h4 class="modal-title" id="h1" runat="server">Modal title</h4>
                </div>
                <div class="modal-body">
                    <p>
                        <label id="lblMsgPopup" runat="server"></label>
                    </p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Ok</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>
    <form id="form1" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2><a href="#">Cadastro de Moradores</a> <span></span></h2>
                    <p></p>
                </div>
            </div>
        </article>
        <div class="form-group">
            <label for="nome">Nome do Morador:</label>
            <asp:TextBox class="form-control" name="txtNome" ID="txtNome"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="idade">Idade do Morador:</label>
            <asp:TextBox class="form-control" name="txtIdade" ID="txtIdade"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="cpf">CPF do Morador:</label>
            <asp:TextBox class="form-control" name="txtCpf" ID="txtCpf"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="bloco">Número do Bloco:</label>
            <br />
            <asp:DropDownList ID="DDLBloco" runat="server" Width="185px" DataSourceID="Bloco" DataTextField="numero_bloco" DataValueField="numero_bloco">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Bloco" runat="server" ConnectionString="Data Source=LAPTOP-G0S256OR\SQLEXPRESS;Initial Catalog=ControleCondDB;Integrated Security=True;" SelectCommand="SELECT * FROM [TB_BLOCO]"></asp:SqlDataSource>
        </div>
        <div class="form-group">
            <label for="apto">Número do Apartamento:</label>
            <br />
            <asp:DropDownList ID="DDLApartamento" runat="server" Width="185px" DataSourceID="Apartamento" DataTextField="numero_apto" DataValueField="numero_apto">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Apartamento" runat="server" ConnectionString="Data Source=LAPTOP-G0S256OR\SQLEXPRESS;Initial Catalog=ControleCondDB;Integrated Security=True;" SelectCommand="SELECT * FROM [TB_APARTAMENTO]"></asp:SqlDataSource>
        </div>
        <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Salvar"
            OnClick="btnCadastrar_Click" />

        <br />
        <% if (!String.IsNullOrEmpty(lblmsg.Text))
        {%>
    <div class="alert alert-success">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;s;</a>
        <strong>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></strong>
    </div>
        <%} %>
    <br />

        <asp:GridView ID="GVMorador" runat="server" CellPadding="4" CssClass="table" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="GVMorador_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="nome" HeaderText="Nome" />
                <asp:BoundField DataField="idade" HeaderText="Idade" />
                <asp:BoundField DataField="cpf" HeaderText="CPF" />
                <asp:BoundField DataField="bloco" HeaderText="Número do Bloco" />
                <asp:BoundField DataField="apto" HeaderText="Número do Apartamento" />
                <asp:TemplateField HeaderText="Ações">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnAlterarMidia" CommandName="ALTERAR" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn btn-info" Text="Alterar" />
                        <asp:LinkButton runat="server" ID="btnExcluirMidia" CommandName="EXCLUIR" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn btn-primary" Text="Excluir" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </form>

</asp:Content>
