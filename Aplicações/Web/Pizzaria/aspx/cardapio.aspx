<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cardapio.aspx.cs" Inherits="aspx_cardapio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Cardápio"></asp:Label>
    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundColumn DataField="Nome_Produto" HeaderText="Sabores" ReadOnly="True"></asp:BoundColumn>
            <asp:BoundColumn DataField="Valor_Venda" HeaderText="Preços"></asp:BoundColumn>
        </Columns>
</asp:DataGrid>
</asp:Content>

