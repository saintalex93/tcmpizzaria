<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="pedidos.aspx.cs" Inherits="aspx_pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <link rel="icon" type="image/png" href="../img/marca.ico" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DataGrid ID="datagPedidos" runat="server" AutoGenerateColumns="False" Caption="Meus Pedidos" HeaderStyle-CssClass="colunaheader">

        <Columns>
            <asp:BoundColumn DataField="Data" HeaderText="Data do Pedido" ReadOnly="True" HeaderStyle-CssClass="colunaheader" ItemStyle-CssClass="ce"></asp:BoundColumn>
            <asp:BoundColumn DataField="Valor" HeaderText="Valor Total do Pedido" ReadOnly="True" HeaderStyle-CssClass="colunaheader" ItemStyle-CssClass="ce"></asp:BoundColumn>
        </Columns>
<HeaderStyle CssClass="colunaheader"></HeaderStyle>
        
    </asp:DataGrid>

</asp:Content>

