<%@ Page Title="" Language="C#" MasterPageFile="~/admin/modelo_painel.master" AutoEventWireup="true" CodeFile="gerenciaArea.aspx.cs" Inherits="admin_gerenciaArea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        $(document).ready(function () {
            //Pegando tamanho do container maior, que tem seu conteúdo mudado constantemente
            var tamanhoSection = $('.gerenciaArea').height();
            //Aplicando o tamanho mais 60(30 do padding-top e 30 de padding-bottom) para o menu, para que ele sempre acompanhe a página
            $('.menuPainel').css({ "min-height": tamanhoSection + 60 });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article class="gerenciaArea">
        <h1>Gerenciador de Áreas</h1>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <%-- ADICIONAR AREAS --%>
                <asp:Panel ID="pnlAdicionarArea" CssClass="painelArea" runat="server">
                    <h2>Adicionar Área</h2>
                    <asp:Panel ID="pnlInfos" runat="server">
                        <asp:Label ID="lblNomeArea" runat="server" Text="Digite o nome de uma área: "></asp:Label>
                        <asp:TextBox ID="txtNomeArea" Placeholder="EX: Almoxerifado" runat="server"></asp:TextBox>
                        <asp:DropDownList ID="ddlCategorias" runat="server" OnLoad="carregarCategorias"></asp:DropDownList>
                    </asp:Panel>
                    <asp:Button ID="btnAdicionarArea" runat="server" Text="Adicionar Área" OnClick="adicionarArea" />
                </asp:Panel>

                <%-- EDITAR CATEGORIAS --%>
                <asp:Panel ID="pnlEditarCategoria" CssClass="painelArea" runat="server">
                    <h2>Editar Área</h2>
                    <asp:GridView ID="gdEditaArea" CssClass="gridsArea" runat="server" OnSelectedIndexChanged="selecionaGridArea"  AutoGenerateColumns="False">
                    
                        <Columns>
                            <asp:CommandField SelectText=">>>" ShowSelectButton="true">
                            </asp:CommandField>
                            <asp:BoundField HeaderText="Código da Area" DataField="codArea" />
                            <asp:BoundField HeaderText="Nome da Area" DataField="Nome" />
                        </Columns>

                        <SelectedRowStyle CssClass="linhaSelecionada" />

                    </asp:GridView>

                    <asp:TextBox ID="txtEditarArea" runat="server"></asp:TextBox>
                    <asp:Button ID="btnEditarArea" runat="server" Text="Editar Area" OnClick="editarArea" />
                </asp:Panel>

                <%-- EXCLUIR AreaS --%>
                <asp:Panel ID="pnlRemoverArea" CssClass="painelArea" runat="server">
                    <h2>Remover Área</h2>
                    <asp:GridView ID="gdRemoveArea" CssClass="gridsArea" runat="server" OnSelectedIndexChanged="selecionaGridArea" AutoGenerateColumns="False">

                        <Columns>
                            <asp:commandfield selecttext=">>>" showselectbutton="True">
                            </asp:commandfield>
                            <asp:BoundField HeaderText="Código da Area" DataField="codArea" />
                            <asp:BoundField HeaderText="Nome da Area" DataField="Nome" />
                        </Columns>

                        <SelectedRowStyle CssClass="linhaSelecionada" />

                    </asp:GridView>

                    <asp:TextBox ID="txtRemoverArea" runat="server" ReadOnly="true"></asp:TextBox>
                    <asp:Button ID="btnRemoverArea" runat="server" Text="Remover Area" OnClick="removerArea" />

                </asp:Panel>

            </ContentTemplate>
        </asp:UpdatePanel>
    </article>
</asp:Content>

