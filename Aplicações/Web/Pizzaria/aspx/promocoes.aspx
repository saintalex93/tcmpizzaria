<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="promocoes.aspx.cs" Inherits="aspx_promocoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <link rel="icon" type="image/png" href="../img/marca.ico" />

    <script type="text/javascript" src="../js/login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" Caption="Promoções">
        <Columns>
            <asp:BoundColumn DataField="Nome_Promocao"></asp:BoundColumn>
            <asp:BoundColumn DataField="Descricao"></asp:BoundColumn>
        </Columns>


    </asp:DataGrid>
    
</asp:Content>

