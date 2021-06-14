<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CadastroBloco.aspx.cs" Inherits="ControleCond.Cadastrobloco" %>
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
                    <h2><a href="#">Cadastro de Blocos</a> <span></span></h2>
                    <p></p>
                </div>
            </div>
        </article>
        <div class="form-group">
            <label for="numero_bloco">Número do Bloco:</label>
            <asp:TextBox class="form-control" name="txtBloco" ID="txtBloco"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="qtd_apartamentos">Quantidade de Apartamentos:</label>
            <asp:TextBox class="form-control" name="txtQtdApto" ID="txtQtdApto"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="qtd_andar">Quantidade de Andares:</label>
            <asp:TextBox class="form-control" name="txtQtdAndar" ID="txtQtdAndar"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="total_moradores">Total de Moradores:</label>
            <asp:TextBox class="form-control" name="txtTotalMoradores" ID="txtTotalMoradores"
                runat="server"></asp:TextBox>
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

        <asp:GridView ID="GVBloco" runat="server" CellPadding="4" CssClass="table" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="GVBloco_RowCommand">
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
                <asp:BoundField DataField="numero_bloco" HeaderText="Número do Bloco" />
                <asp:BoundField DataField="qtd_apartamentos" HeaderText="Quantidade de Apartamentos" />
                <asp:BoundField DataField="qtd_andar" HeaderText="Quantidade de Andares" />
                <asp:BoundField DataField="total_moradores" HeaderText="Total de Moradores" />
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
