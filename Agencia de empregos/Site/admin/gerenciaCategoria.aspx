<%@ Page Title="" Language="C#" MasterPageFile="~/admin/modelo_painel.master" AutoEventWireup="true" CodeFile="gerenciaCategoria.aspx.cs" Inherits="admin_gerenciaCategoria" %>
<%@ MasterType VirtualPath="/admin/modelo_painel.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            //Pegando tamanho do container maior, que tem seu conteúdo mudado constantemente
            var tamanhoSection = $('.gerenciaCategoria').height();
            //Aplicando o tamanho mais 60(30 do padding-top e 30 de padding-bottom) para o menu, para que ele sempre acompanhe a página
            $('.menuPainel').css({ "min-height": tamanhoSection + 60 });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <article class="gerenciaCategoria">
        <h1>Gerenciador de Categorias</h1>

        <%-- ADICIONANDO COMPONENTES AJAX --%>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <%-- ADICIONAR CATEGORIAS --%>
                <asp:Panel ID="pnlAdicionarCategoria" CssClass="painelCategoria" runat="server">
                    <h2>Adicionar Categoria</h2>
                    <asp:Panel ID="pnlInfos" runat="server">
                        <asp:Label ID="lblNomeCategoria" runat="server" Text="Digite o nome de uma categoria: "></asp:Label>
                        <asp:TextBox ID="txtNomeCategoria" Placeholder="EX: Administração" runat="server"></asp:TextBox>
                    </asp:Panel>
                    <asp:Button ID="btnAdicionarCategoria" runat="server" Text="Adicionar Categoria" OnClick="adicionarCategoria" />
                </asp:Panel>

                <%-- EDITAR CATEGORIAS --%>
                <asp:Panel ID="pnlEditarCategoria" CssClass="painelCategoria" runat="server">
                    <h2>Editar Categoria</h2>
                    <asp:GridView ID="gdEditaCategoria" CssClass="gridsCategoria" runat="server" OnSelectedIndexChanged="selecionaGridCategoria"  AutoGenerateColumns="False">
                    
                        <Columns>
                            <asp:CommandField SelectText=">>>" ShowSelectButton="true">
                            </asp:CommandField>
                            <asp:BoundField HeaderText="Código da Categoria" DataField="codCategoria" />
                            <asp:BoundField HeaderText="Nome da Categoria" DataField="Nome" />
                        </Columns>

                        <SelectedRowStyle CssClass="linhaSelecionada" />

                    </asp:GridView>

                    <asp:TextBox ID="txtEditarCategoria" runat="server"></asp:TextBox>
                    <asp:Button ID="btnEditarCategoria" runat="server" Text="Editar Categoria" OnClick="editarCategoria" />
                </asp:Panel>
                <%-- EXCLUIR CATEGORIAS --%>
                <asp:Panel ID="pnlRemoverCategoria" CssClass="painelCategoria" runat="server">
                    <h2>Remover Categoria</h2>
                    <asp:GridView ID="gdRemoveCategoria" CssClass="gridsCategoria" runat="server" OnSelectedIndexChanged="selecionaGridCategoria" AutoGenerateColumns="False">

                        <Columns>
                            <asp:commandfield selecttext=">>>" showselectbutton="True">
                            </asp:commandfield>
                            <asp:BoundField HeaderText="Código da Categoria" DataField="codCategoria" />
                            <asp:BoundField HeaderText="Nome da Categoria" DataField="Nome" />
                        </Columns>

                        <SelectedRowStyle CssClass="linhaSelecionada" />

                    </asp:GridView>

                    <asp:TextBox ID="txtRemoverCategoria" runat="server" ReadOnly="true"></asp:TextBox>
                    <asp:Button ID="btnRemoverCategoria" runat="server" Text="Remover Categoria" OnClick="removerCategoria" />

                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </article>

</asp:Content>

