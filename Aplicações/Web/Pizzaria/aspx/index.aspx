<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="aspx_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <link rel="icon" type="image/png" href="../img/marca.ico" />

    <script type="text/javascript" src="../js/reload.js"></script>
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
            
</asp:Content>

