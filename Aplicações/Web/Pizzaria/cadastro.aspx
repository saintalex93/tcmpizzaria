<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="cadastro" %>
<!DOCTYPE HTML>
<html lang = "pt-BR">
<head>

<!--Formato de comentário-->

<link rel="stylesheet" type="text/css" href="css/style2.css">
    <script type="text/javascript" src="js/valida.js"></script>
    <script type="text/javascript" src="js/mascara.js"></script>

<meta charset = "UTF - 8"/	>

<title>Pizzaria - TCM - Cadastro de usuário</title>

</head>

<body>
	
	<div id = "tudo">
		<div id = "cabecalho">
		

		<div id = "logo">
			
			<a href="index.html">Pizzaria TCM</a>
			
		</div>

			
			<div class = "menu">
				<a href="cardapio.html">Cardápio</a> |
				<a href="cadastro.aspx">Login / Cadastro</a> |
				<a href="promocoes.html">Promoções</a> |
				<a href="contato.html">Contato</a>
			</div>
	
			<div id = "carrossel">Carrossel de imagens</div>
	
		</div>	

		<div id = "conteudo">

				<h1>Cadastro de usuário</h1>
				<form id="form_cadastro" runat="server" >
				    <fieldset class = "grupoformulario" >
                        <legend style="margin-left: 5px">Dados Pessoais</legend>
                            <asp:Label ID="Label1" runat="server" Text="Campos obrigatórios são marcados com (*)"></asp:Label>
                        <br />
                        <br />
                            <asp:Label ID="lblNome" runat="server" Text="Nome Completo"></asp:Label>
                            <asp:TextBox ID="txtNome" name="nome" runat="server" MaxLength="70" Width="267px"></asp:TextBox>
                            <asp:Label ID="lblObrigatório" runat="server" Text="(*)"></asp:Label>
                        <br />
                            <asp:Label ID="lblTel" runat="server" Text="Telefone"></asp:Label>
                            <asp:TextBox ID="txtTel" runat="server" MaxLength="10" Width="146px"></asp:TextBox>
                            <asp:Label ID="lblObrigatório2" runat="server" Text="(*)"></asp:Label>
                        <br />
                            <asp:Label ID="lblCel" runat="server" Text="Celular"></asp:Label>
                            <asp:TextBox ID="txtCel" runat="server" Width="146px" MaxLength="11"></asp:TextBox>
                        <br />
                            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" Width="226px" MaxLength="30"></asp:TextBox>
                        <br />
                            <asp:Label ID="lblCpf" runat="server" Text="CPF"></asp:Label>
                            <asp:TextBox ID="txtCpf" runat="server" Width="146px" MaxLength="11"></asp:TextBox>
                            <asp:Label ID="lblObrigatório3" runat="server" Text="(*)"></asp:Label>
                        <br />
                            <asp:Label ID="lblDataNasc" runat="server" Text="Data de Nascimento"></asp:Label>
                            <asp:TextBox ID="txtDtNasc" runat="server" Width="146px" MaxLength="8"></asp:TextBox>
                            <asp:Label ID="lblObrigatório4" runat="server" Text="(*)"></asp:Label>
                        <br />
                            <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server" Width="146px" TextMode="Password" MaxLength="20"></asp:TextBox>
                            <asp:Label ID="lblObrigatório5" runat="server" Text="(*)"></asp:Label>
                        <br />
                            <asp:Label ID="lblSenhaConfirm" runat="server" Text="Confirmar Senha"></asp:Label>
                            <asp:TextBox ID="txtSenhaConfirm" runat="server" Width="146px" TextMode="Password" MaxLength="20"></asp:TextBox>

                            <asp:Label ID="lblObrigatório6" runat="server" Text="(*)"></asp:Label>
                    
                        </fieldset>

                    <br />

                    <fieldset class = "grupoformulario">
                        <legend style="margin-left: 5px">Dados de Localidade</legend>
                        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                        <asp:DropDownList ID="DDLEstado" runat="server">
                            <asp:ListItem Value="Escolha">Escolha um Estado</asp:ListItem>
                            <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                            <asp:ListItem Value="AC">Acre</asp:ListItem>
                            <asp:ListItem Value="AL">Alagoas</asp:ListItem>
                            <asp:ListItem Value="AP">Amapá</asp:ListItem>
                            <asp:ListItem Value="AM">Amazonas</asp:ListItem>
                            <asp:ListItem Value="BA">Bahia</asp:ListItem>
                            <asp:ListItem Value="CE">Ceará</asp:ListItem>
                            <asp:ListItem Value="DF">Distrito Federal</asp:ListItem>
                            <asp:ListItem Value="ES">Espírito Santo</asp:ListItem>
                            <asp:ListItem Value="GO">Goiás</asp:ListItem>
                            <asp:ListItem Value="MA">Maranhão</asp:ListItem>
                            <asp:ListItem Value="MT">Mato Grosso</asp:ListItem>
                            <asp:ListItem Value="MS">Mato Grosso do Sul</asp:ListItem>
                            <asp:ListItem Value="MG">Minas Gerais</asp:ListItem>
                            <asp:ListItem Value="PA">Pará</asp:ListItem>
                            <asp:ListItem Value="PB">Paraíba</asp:ListItem>
                            <asp:ListItem Value="PR">Paraná</asp:ListItem>
                            <asp:ListItem Value="PE">Pernambuco</asp:ListItem>
                            <asp:ListItem Value="PI">Piauí</asp:ListItem>
                            <asp:ListItem Value="RJ">Rio de Janeiro</asp:ListItem>
                            <asp:ListItem Value="RN">Rio Grande do Norte</asp:ListItem>
                            <asp:ListItem Value="RS">Rio Grande do Sul</asp:ListItem>
                            <asp:ListItem Value="RO">Rondônia</asp:ListItem>
                            <asp:ListItem Value="RR">Roraima</asp:ListItem>
                            <asp:ListItem Value="SC">Santa Catarina</asp:ListItem>
                            <asp:ListItem Value="SE">Sergipe</asp:ListItem>
                            <asp:ListItem Value="TO">Tocantins</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblObrigatório7" runat="server" Text="(*)"></asp:Label>
                    <br />
                        <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
                        <asp:TextBox ID="txtCidade" runat="server" MaxLength="50" Width="199px"></asp:TextBox>
                        <asp:Label ID="lblObrigatório8" runat="server" Text="(*)"></asp:Label>
                    <br />
                        <asp:Label ID="lblRua" runat="server" Text="Nome da Rua"></asp:Label>
                        <asp:TextBox ID="txtRua" runat="server" MaxLength="50" Width="281px"></asp:TextBox>
                        <asp:Label ID="lblObrigatório9" runat="server" Text="(*)"></asp:Label>
                    <br />
                        <asp:Label ID="lblNumCasa" runat="server" Text="Número"></asp:Label>
                        <asp:TextBox ID="txtNumCasa" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
                        <asp:Label ID="lblObrigatório10" runat="server" Text="(*)"></asp:Label>
                    <br />
                        <asp:Label ID="lblNumApart" runat="server" Text="Nº Apartamento"></asp:Label>
                        <asp:TextBox ID="txtNumApart" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
                    <br />
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro"></asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" MaxLength="30" Width="195px"></asp:TextBox>
                        <asp:Label ID="lblObrigatório11" runat="server" Text="(*)"></asp:Label>
                    <br />
                        <asp:Label ID="lblCep" runat="server" Text="CEP"></asp:Label>
                        <asp:TextBox ID="txtCep" runat="server" MaxLength="8" Width="140px"></asp:TextBox>
                        <asp:Label ID="lblObrigatório12" runat="server" Text="(*)"></asp:Label>
                    <br />

                    </fieldset>
                     <asp:Button ID="btnEnvia" runat="server" Text="Enviar" onclientclick="return validaCadastro()" OnClick="btnEnvia_Click" />
                    <asp:Button ID="btnLimpa" runat="server" Text="Limpar" OnClick="btnLimpa_Click" />
                    
                    <br />
                    <br />
                    <asp:Label ID="lblresposta" runat="server"></asp:Label>

            </form>
                    <br />
                    
                    
		
		<div id = "rodape">

			

			<hr style = "display: block; height: 1px;
            border: 0; border-top: 1px solid #fff;
            margin: 1em 0; padding: 0;"/>
		
			<div id = "informacoes">
			
				Telefone: 3333-3333 - Aberto de Segunda à Sexta das 18h às 24h
				<br />
				Rua Logradouro, 654, São Paulo - SP
				<br />

				<div id = "copyright">©Todos os direitos reservados.</div>

			</div>


		</div>	
	</div>
        </div>

    

</body>
</html>
