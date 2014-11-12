<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="conta.aspx.cs" Inherits="aspx_conta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
     <link rel="icon" type="image/png" href="../img/marca.ico" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    
    <nav id="menu_gerencia">
        <ul>
            <li><asp:HyperLink ID="altera_dados" runat="server" NavigateUrl="altera_conta.aspx"> Alterar dados</asp:HyperLink></li>
            <li><asp:HyperLink ID="desativa_conta" runat="server" NavigateUrl="desativa_conta.aspx">Desativar conta</asp:HyperLink></li>
            <li><asp:HyperLink ID="deleta_conta" runat="server" NavigateUrl="deleta_conta.aspx">Deletar conta</asp:HyperLink></li>
        </ul>
    </nav>

    <section id="sua_conta">

            <!-- CRIAR CÓDIGO PARA MOSTRAR UMA "INDEX" DO GERENCIAMENTO -->
    </section>
</asp:Content>

