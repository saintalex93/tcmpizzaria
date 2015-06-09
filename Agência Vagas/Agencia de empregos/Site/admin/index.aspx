<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="admin_index" %>

<!DOCTYPE html>
<html lang="pt-br">

<head runat="server">
    <title>Giovanelli's Empregos</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/estilo_agencia.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnlAdm" CssClass="painelAdm" runat="server">
            <div>
                <h2>Acesso Restrito</h2>
                <p>Login:</p>
                <asp:TextBox ID="txtLoginAdm" runat="server"></asp:TextBox>
                <p>Senha:</p>
                <asp:TextBox ID="txtSenhaAdm" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnLoginAdm" runat="server" Text="Login" OnClick="Login" />
            </div>
        </asp:Panel>
    </form>
</body>
</html>
