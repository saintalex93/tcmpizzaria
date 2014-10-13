<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="aspx_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <script type="text/javascript" src="../js/login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id = "carrossel">
			
				<object width="100%" height="100%"  data="../flash/carrossel.swf"></object>
			
			</div>

			<div class = "painel">
				<img src = "../img/painelMelhorPizza.jpg" height = "220" width = "220" />
			</div>

			
			
			
			<div id = "linksFaixa">
				<div class = "faixa">
				
<!--				<a href = "../html/promocoes.html"><img src = "../img/faixaPromocoes.png" height = "100" width = "700" /></a> -->

                    <object width="100%" height="100%"  data="../flash/faixaCadastro.swf"></object>
				
				</div>
				
					<div class = "faixa">
				
<!--				<a href = "../html/promocoes.html"><img src = "../img/faixaPromocoes.png" height = "100" width = "700" /></a> -->

                    <object width="100%" height="100%"  data="../flash/faixaCardapio.swf"></object>
				
				</div>
			</div>
     <form id="Form1" runat="server">
        
        <div id="Login">
            <fieldset>
            <legend>Faça seu Login</legend>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="txtLogin" runat="server" Width="200px"></asp:TextBox><br />
            <asp:Label ID="senha" runat="server" Text="Senha"></asp:Label><br />
            <asp:TextBox ID="txtLogin_Senha" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClientClick="return recuperarlogin()" OnClick="btnLogin_Click" />
            <asp:Button ID="btnEsqueciSenha" runat="server" Text="Esqueci minha senha" /><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/aspx/cadastro.aspx">Ainda não é cadastrado?</asp:HyperLink><br />
            <asp:Label ID="lblLoginInc" runat="server"></asp:Label>
                </fieldset>
            </div>
            
    </form>
</asp:Content>

