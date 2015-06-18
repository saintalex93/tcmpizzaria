<%@ Page Title="" Language="C#" MasterPageFile="~/admin/modelo_painel.master" AutoEventWireup="true" CodeFile="gerenciaVaga.aspx.cs" Inherits="admin_gerenciaVaga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article class="gerenciaVaga">
        <h1>Gerenciador de Vagas</h1>

        <%-- ADICIONANDO COMPONENTES AJAX --%>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <asp:GridView ID="gdVagas" runat="server" OnRowCreated="esconderCodigos">
                    <SelectedRowStyle CssClass="linhaSelecionadaVaga" />

                    <Columns>
                        <asp:CommandField SelectText=">>>" ShowSelectButton="true">
                        </asp:CommandField>
                    </Columns>

                    <EmptyDataTemplate>
                        Não existem vagas !
                    </EmptyDataTemplate>
                </asp:GridView>

                <asp:Button ID="btnAlterarEstado" runat="server" Text="Alterar Estado" OnClick="AlterarEstado" />

            </ContentTemplate>
        </asp:UpdatePanel>

    </article>
</asp:Content>

