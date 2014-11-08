<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cardapio.aspx.cs" Inherits="aspx_cardapio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <link rel="icon" type="image/png" href="../img/marca.ico" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            
    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" Caption="Cardápio">
        <Columns>

            <asp:BoundColumn DataField="Nome_Produto" HeaderText="Sabores de Pizzas" ReadOnly="True" ItemStyle-CssClass="ce" HeaderStyle-CssClass="colunaheader">
                <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                <ItemStyle CssClass="ce"></ItemStyle>
            </asp:BoundColumn>

            <asp:BoundColumn DataField="Ingred_Prod" HeaderText="Ingredientes" ReadOnly="True" ItemStyle-CssClass="ce_ingred" HeaderStyle-CssClass="colunaheader">

            </asp:BoundColumn>

            <asp:BoundColumn DataField="Valor_Venda" HeaderText="Preço" HeaderStyle-CssClass="colunaheader" ReadOnly="True" ItemStyle-CssClass="cd" DataFormatString="{0:c}">
                <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                <ItemStyle CssClass="cd"></ItemStyle>
            </asp:BoundColumn>

        </Columns>
    </asp:DataGrid>

</asp:Content>

