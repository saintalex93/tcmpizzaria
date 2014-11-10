<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="aspx_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <link rel="icon" type="image/png" href="../img/logo.ico" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="conteudo_index" class="conteudo">
		<nav class = "painel">
            <ul style="list-style: none;">
				<li> <img id="conhecer" src = "../img/conhecer-chefs3.jpg" /> </li>

                <li> <img id="conhecercoz" src="../img/conhecer-cozinha.jpg" /> </li>
				
            </ul>
		</nav>
    </div>
</asp:Content>

