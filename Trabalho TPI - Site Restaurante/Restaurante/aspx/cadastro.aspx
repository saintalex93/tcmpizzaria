<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="aspx_cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <link rel="icon" type="image/png" href="../img/logo.ico" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="conteudo_cadastro" class="conteudo">
        <h1>Cadastro</h1><br />
    <div id="texto_cadastro">
    <h3>O que eu ganho por me cadastrar?</h3>
        <br />
    <p>
        Você poderá ver seus últimos pedidos, na seção 
        
        <a href="pedidos.aspx" title="Clique apenas se estiver logado !!">Meus Pedidos</a>, e participar de surpresas exclusivas !!</p>
        
        </div>
        <br />
        
            <asp:Label  ID ="Label1" runat="server" Text="Campos obrigatórios são marcados com *" Font-Italic="True"></asp:Label>
			    <fieldset id="formulario1" class = "grupoformulario">
                        <legend style="margin: 55px; margin-bottom: 15px;color:#000; font-size: 20px;">Dados Pessoais</legend>
                          
                            <asp:Label ID="lblNome" runat="server" Text="Nome *" style="margin-left: 108px;"></asp:Label>

                            <asp:TextBox ID="txtNome" name="nome" runat="server" MaxLength="70" Width="220px"></asp:TextBox>

                            <%--<asp:RequiredFieldValidator ID="requiredNome" runat="server" ErrorMessage="Nome é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtNome" ValidationGroup="Grupo1" AutoPostBack="false"></asp:RequiredFieldValidator>--%>
                        <br />
                            <asp:Label ID="lblCpf" runat="server" Text="CPF *" style="margin-left: 119px;"></asp:Label>
                            <asp:TextBox ID="txtCpf" runat="server" Width="146px" MaxLength="11"></asp:TextBox>

                            <%--<asp:RequiredFieldValidator ID="requiredCpf" runat="server" ErrorMessage="CPF é obrigatório" Display="Dynamic" CssClass="erros" ControlToValidate="txtCpf" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>
                        <br />
                            <asp:Label ID="lblTel" runat="server" Text="Telefone *" style="margin-left: 89px;"></asp:Label>
                            <asp:TextBox ID="txtTel" runat="server" MaxLength="10" Width="146px"></asp:TextBox>

                            <%--<asp:RequiredFieldValidator ID="requiredTel" runat="server" ErrorMessage="Telefone é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtTel" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>
                        <br />
                            <asp:Label ID="lblCel" runat="server" Text="Celular" style="margin-left: 111px;"></asp:Label>
                            <asp:TextBox ID="txtCel" runat="server" Width="146px" MaxLength="11" style="margin-right: 65px;"></asp:TextBox>
                    <br />
                            <asp:Label ID="lblLogin_Cli" runat="server" Text="Login" style="margin-left: 111px;"></asp:Label>
                            <asp:TextBox ID="txtLogin_Cli" runat="server" Width="146px" MaxLength="30" style="margin-right: 65px;"></asp:TextBox>

                        <br />
                            <asp:Label ID="lblSenha" runat="server" Text="Senha *" style="margin-left: 104px"></asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server" Width="146px" TextMode="Password" MaxLength="20"></asp:TextBox>

                            <%--<asp:RequiredFieldValidator ID="requiredSenha" runat="server" ErrorMessage="Senha é obrigatória *" Display="Dynamic" CssClass="erros" SetFocusOnError="True" ControlToValidate="txtSenha" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>
                        <br />
                            <asp:Label ID="lblSenhaConfirm" runat="server" Text="Confirmar Senha" style="margin-left: 40px"></asp:Label>
                            <asp:TextBox ID="txtSenhaConfirm" runat="server" Width="146px" TextMode="Password" MaxLength="20"></asp:TextBox>

                            <%--<asp:CompareValidator ID="compareSenha" runat="server" ErrorMessage="Suas senhas não são iguais *" ControlToCompare="txtSenha" ControlToValidate="txtSenhaConfirm" ValidationGroup="Grupo1" Display="Dynamic"></asp:CompareValidator>--%>
                </fieldset>

                    <br />

                    <fieldset class = "grupoformulario2">
                        <legend style="margin-left: 55px; margin-bottom: 15px; padding-top: 30px; color:#000; font-size: 20px;">Dados de Localidade</legend>

                    <br />
                        <asp:Label ID="lblRua" runat="server" Text="Nome da Rua *" style="margin-left: 55px;"></asp:Label>
                        <asp:TextBox ID="txtRua" runat="server" MaxLength="50" Width="255px"></asp:TextBox>

                        <%--<asp:RequiredFieldValidator ID="requiredRua" runat="server" ErrorMessage="Rua é obrigatória *" CssClass="erros" Display="Dynamic" ControlToValidate="txtRua" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>
                    <br />
                        <asp:Label ID="lblComplemento" runat="server" Text="Complemento" style="margin-left: 70px;"></asp:Label>
                        <asp:TextBox ID="txtComplemento" runat="server" MaxLength="60" Width="255px"></asp:TextBox>
                    <br />
                        <asp:Label ID="lblNumCasa" runat="server" Text="Número *" style="margin-left: 90px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtNumCasa" runat="server" MaxLength="4" Width="50px" min="1"></asp:TextBox>

                        <%--<asp:RequiredFieldValidator ID="requiredNumCasa" runat="server" ErrorMessage="Número Residencial é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtNumCasa" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>

                    <br />
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro *" style="margin-left: 100px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" MaxLength="30" Width="180px"></asp:TextBox>

                        <%--<asp:RequiredFieldValidator ID="requiredBairro" runat="server" ErrorMessage="Bairro é obrigatório *" Display="Dynamic" CssClass="erros" ControlToValidate="txtBairro" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>
                    <br />
                        <asp:Label ID="lblCep" runat="server" Text="CEP *" style="margin-left: 120px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtCep" runat="server" MaxLength="8" Width="140px"></asp:TextBox>

                        <%--<asp:RequiredFieldValidator ID="requiredCep" runat="server" ErrorMessage="CEP é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtCep" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>--%>
                    <br />

                    </fieldset>

                    <br />

                    <asp:Button ID="btnEnvia" runat="server" Text="Enviar" OnClick="btnEnvia_Click" ValidationGroup="Grupo1" CssClass="button" />

                    <asp:Button ID="btnLimpa" runat="server" Text="Limpar" OnClick="btnLimpa_Click" OnClientClick="LimpaCampos();" CssClass="button" />

                    <asp:Button ID="Preenche" runat="server" Text="Preencher Campos" OnClick="Preenche_Click" Width="125px" Height="25px" />
                    <br />
                    <br />
        <br />
    </div>
</asp:Content>