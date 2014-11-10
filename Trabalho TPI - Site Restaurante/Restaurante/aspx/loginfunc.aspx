<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginfunc.aspx.cs" Inherits="aspx_loginfunc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ratatouille Restaurant Acesso</title>
    <link rel="stylesheet" type="text/css" href="../css/estilologinfunc.css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Acesso de Funcionários</h1>
        <asp:Panel ID="pnlLoginFunc" runat="server">
            <asp:Label ID="lblLoginFunc" runat="server" Text="Login"></asp:Label>
            <asp:TextBox ID="txtLoginFunc" runat="server" BorderWidth="1"></asp:TextBox>
            <br />
            <asp:Label ID="lblSenhaFunc" runat="server" Text="Senha"></asp:Label>
            <asp:TextBox ID="txtSenhaFunc" runat="server" BorderWidth="1" TextMode="Password"></asp:TextBox>

            <asp:Label ID="lblErrado" runat="server" Text="" Visible="False"></asp:Label>

            <asp:Button ID="btnLoginFunc" runat="server" Text="Login" CssClass="button" OnClick="btnLoginFunc_Click" /><br />
            <asp:HyperLink ID="linkHome" NavigateUrl="~/aspx/index.aspx" runat="server">Voltar ao site</asp:HyperLink>
        </asp:Panel>

        
    </form>
</body>
</html>
