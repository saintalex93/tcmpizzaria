<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cadastrapedido.aspx.cs" Inherits="aspx_cadastrapedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="conteudo_cadastrapedido" class="conteudo">
        <asp:Panel ID="pnl_cadastrapedido" runat="server">
            <asp:HyperLink ID="linkCadastrarPed" runat="server" NavigateUrl="~/aspx/cadastrapedido.aspx">Cadastrar Pedidos</asp:HyperLink>
            <asp:HyperLink ID="linkVerPed" runat="server" NavigateUrl="~/aspx/verificarpedido">Verificar Pedidos</asp:HyperLink>

            <h1>Cadastro de Pedidos</h1>

            <asp:Label ID="lblNome" runat="server" Text="Nome do Cliente"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNomeProduto" runat="server" Text="Nome do Produto"></asp:Label>
            <asp:TextBox ID="txtNomeProduto" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />

            <asp:Label ID="lblProdutos" runat="server" Text="Produtos Consumidos"></asp:Label><br />
            <asp:DataGrid ID="datagridProdutos" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundColumn DataField="Nome_Produto" HeaderText="Nome do Produto" ReadOnly="True" ItemStyle-CssClass="ce"></asp:BoundColumn>
                </Columns>
            </asp:DataGrid>
        </asp:Panel>
    </div>
</asp:Content>

