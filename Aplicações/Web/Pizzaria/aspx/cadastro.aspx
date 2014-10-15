<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="aspx_cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <link rel="icon" type="image/png" href="../img/marca.ico" />

    <script type="text/javascript" src="../js/valida.js"></script>
    <script type="text/javascript" src="../js/login.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h1>Cadastro</h1>
			    <fieldset class = "grupoformulario" >
                        <legend style="margin-left: 5px;color:#fff;">Dados Pessoais</legend>
                            <asp:Label ID="Label1" runat="server" Text="Campos obrigatórios são marcados com (*)"></asp:Label>
                        <br />
                        <br />
                            <asp:Label ID="lblNome" runat="server" Text="Nome Completo"></asp:Label>
                            <asp:TextBox ID="txtNome" name="nome" runat="server" MaxLength="70" Width="267px"></asp:TextBox>
                            <asp:Label ID="Label2" runat="server" Text="(*)"></asp:Label>
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
                        <legend style="margin-left: 5px;color:#fff;">Dados de Localidade</legend>
                        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
                        <asp:DropDownList ID="DDLEstado" runat="server">
                            <asp:ListItem Value="Escolha">Escolha um Estado</asp:ListItem>
                            <asp:ListItem Value="SP">SP</asp:ListItem>
                            <asp:ListItem Value="AC">AC</asp:ListItem>
                            <asp:ListItem Value="AL">AL</asp:ListItem>
                            <asp:ListItem Value="AP">AP</asp:ListItem>
                            <asp:ListItem Value="AM">AM</asp:ListItem>
                            <asp:ListItem Value="BA">BA</asp:ListItem>
                            <asp:ListItem Value="CE">CE</asp:ListItem>
                            <asp:ListItem Value="DF">DF</asp:ListItem>
                            <asp:ListItem Value="ES">ES</asp:ListItem>
                            <asp:ListItem Value="GO">GO</asp:ListItem>
                            <asp:ListItem Value="MA">MA</asp:ListItem>
                            <asp:ListItem Value="MT">MT</asp:ListItem>
                            <asp:ListItem Value="MS">MS</asp:ListItem>
                            <asp:ListItem Value="MG">MG</asp:ListItem>
                            <asp:ListItem Value="PA">PA</asp:ListItem>
                            <asp:ListItem Value="PB">PB</asp:ListItem>
                            <asp:ListItem Value="PR">PR</asp:ListItem>
                            <asp:ListItem Value="PE">PE</asp:ListItem>
                            <asp:ListItem Value="PI">PI</asp:ListItem>
                            <asp:ListItem Value="RJ">RJ</asp:ListItem>
                            <asp:ListItem Value="RN">RN</asp:ListItem>
                            <asp:ListItem Value="RS">RS</asp:ListItem>
                            <asp:ListItem Value="RO">RO</asp:ListItem>
                            <asp:ListItem Value="RR">RR</asp:ListItem>
                            <asp:ListItem Value="SC">SC</asp:ListItem>
                            <asp:ListItem Value="SE">SE</asp:ListItem>
                            <asp:ListItem Value="TO">TO</asp:ListItem>
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
                        <asp:Label ID="lblComplemento" runat="server" Text="Complemento"></asp:Label>
                        <asp:TextBox ID="txtComplemento" runat="server" MaxLength="40" Width="281px"></asp:TextBox>
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
                    <asp:Button ID="btnEnvia" runat="server" Text="Enviar" OnClick="btnEnvia_Click"  OnClientClick="return validaCadastro();" />
                    <asp:Button ID="btnLimpa" runat="server" Text="Limpar" OnClick="btnLimpa_Click" />
                <asp:Button ID="Preenche" runat="server" Text="Preencher Campos" OnClick="Preenche_Click" Width="125px" />
                    <br />
                    <br />
                    <asp:Label ID="lblresposta" runat="server" ForeColor="White"></asp:Label>
        <br />

   
</asp:Content>