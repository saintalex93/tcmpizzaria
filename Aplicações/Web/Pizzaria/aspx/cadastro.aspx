<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="aspx_cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/style2.css" />
    <link rel="icon" type="image/png" href="../img/marca.ico" />

    <script type="text/javascript" src="../js/valida.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h1>Cadastro</h1><br />
    <div id="texto_cadastro">
    <h3>O que eu ganho por me cadastrar?</h3>
        <br />
    <p>
        Você poderá ver seus pedidos,
        na seção <a href="pedidos.aspx" title="Clique apenas se estiver logado !!">Meus Pedidos</a>,
        e ainda participar de <a href="promocoes.aspx">promoções</a> 
        exclusivas feitas para usuários cadastrados.
    </p>
        </div>
            <asp:Label ID="Label1" runat="server" Text="Campos obrigatórios são marcados com *" Font-Italic="True"></asp:Label>
			    <fieldset id="formulario1" class = "grupoformulario" >
                        <legend style="margin-left: 5px;color:#fff;">Dados Pessoais</legend>
                          
                            <asp:Label ID="lblNome" runat="server" Text="Nome *" style="margin-left: 108px;" CssClass="spans" ></asp:Label>
                            <asp:TextBox ID="txtNome" name="nome" runat="server" MaxLength="70" Width="220px"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="requiredNome" runat="server" ErrorMessage="Nome é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtNome" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                        <br />
                            <asp:Label ID="lblTel" runat="server" Text="Telefone *" style="margin-left: 89px;" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtTel" runat="server" MaxLength="10" Width="146px"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="requiredTel" runat="server" ErrorMessage="Telefone é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtTel" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                        <br />
                            <asp:Label ID="lblCel" runat="server" Text="Celular" style="margin-left: 111px;" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtCel" runat="server" Width="146px" MaxLength="11" style="margin-right: 65px;"></asp:TextBox>
                        <br />
                            <asp:Label ID="lblEmail" runat="server" Text="Email *" style="margin-left: 111px;" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" Width="226px" MaxLength="35"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ErrorMessage="Email é obrigatório" CssClass="erros" Display="Dynamic" ControlToValidate="txtEmail" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regexvalidEmail" runat="server" ErrorMessage="Email inválido *" Display="Dynamic" SetFocusOnError="True" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" CssClass="erros" ValidationGroup="Grupo1"></asp:RegularExpressionValidator>

                        <br />
                            <asp:Label ID="lblCpf" runat="server" Text="CPF *" style="margin-left: 119px;" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtCpf" runat="server" Width="146px" MaxLength="11"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="requiredCpf" runat="server" ErrorMessage="CPF é obrigatório" Display="Dynamic" CssClass="erros" ControlToValidate="txtCpf" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                        <br />
                            <asp:Label ID="lblDataNasc" runat="server" Text="Data de Nascimento *" CssClass="spans" style="margin-left: 6px;"></asp:Label>
                            <asp:TextBox ID="txtDtNasc" runat="server" Width="146px" MaxLength="8"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="requiredDtNasc" runat="server" ErrorMessage="Data de Nascimento é obrigatória *" Display="Dynamic" CssClass="erros" ControlToValidate="txtDtNasc" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                        <br />
                            <asp:Label ID="lblSenha" runat="server" Text="Senha *" style="margin-left: 104px" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server" Width="146px" TextMode="Password" MaxLength="20"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="requiredSenha" runat="server" ErrorMessage="Senha é obrigatória *" Display="Dynamic" CssClass="erros" SetFocusOnError="True" ControlToValidate="txtSenha" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                        <br />
                            <asp:Label ID="lblSenhaConfirm" runat="server" Text="Confirmar Senha" style="margin-left: 40px" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtSenhaConfirm" runat="server" Width="146px" TextMode="Password" MaxLength="20"></asp:TextBox>

                            <asp:CompareValidator ID="compareSenha" runat="server" ErrorMessage="Suas senhas não são iguais *" ControlToCompare="txtSenha" ControlToValidate="txtSenhaConfirm" ValidationGroup="Grupo1" Display="Dynamic"></asp:CompareValidator>
                </fieldset>

                    <br />

                    <fieldset class = "grupoformulario2">
                        <legend style="margin-left: 5px;color:#fff;">Dados de Localidade</legend>
                        <asp:Label ID="lblEstado" runat="server" Text="Estado *" style="margin-left: 63px;" CssClass="spans"></asp:Label>
                        <asp:DropDownList ID="DDLEstado" runat="server">
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
                    <br />
                        <asp:Label ID="lblCidade" runat="server" Text="Cidade *" style="margin-left: 62px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtCidade" runat="server" MaxLength="50" Width="199px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="requiredCidade" runat="server" ErrorMessage="Cidade é obrigatória *" CssClass="erros" Display="Dynamic" ControlToValidate="txtCidade" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <br />
                        <asp:Label ID="lblRua" runat="server" Text="Nome da Rua *" style="margin-left: 14px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtRua" runat="server" MaxLength="50" Width="255px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="requiredRua" runat="server" ErrorMessage="Rua é obrigatória *" CssClass="erros" Display="Dynamic" ControlToValidate="txtRua" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <br />
                        <asp:Label ID="lblComplemento" runat="server" Text="Complemento" style="margin-left: 24px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtComplemento" runat="server" MaxLength="60" Width="255px"></asp:TextBox>
                    <br />
                        <asp:Label ID="lblNumCasa" runat="server" Text="Número *" style="margin-left: 56px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtNumCasa" runat="server" MaxLength="4" Width="50px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="requiredNumCasa" runat="server" ErrorMessage="Número Residencial é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtNumCasa" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <br />
                        <asp:Label ID="lblNumApart" runat="server" Text="Nº Apartamento" style="margin-left: 10px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtNumApart" runat="server" MaxLength="4" Width="50px"></asp:TextBox>
                    <br />
                        <asp:Label ID="lblBairro" runat="server" Text="Bairro *" style="margin-left: 70px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" MaxLength="30" Width="180px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="requiredBairro" runat="server" ErrorMessage="Bairro é obrigatório *" Display="Dynamic" CssClass="erros" ControlToValidate="txtBairro" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <br />
                        <asp:Label ID="lblCep" runat="server" Text="CEP *" style="margin-left: 80px;" CssClass="spans"></asp:Label>
                        <asp:TextBox ID="txtCep" runat="server" MaxLength="8" Width="140px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="requiredCep" runat="server" ErrorMessage="CEP é obrigatório *" CssClass="erros" Display="Dynamic" ControlToValidate="txtCep" ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
                    <br />

                    </fieldset>
                    <asp:Button ID="btnEnvia" runat="server" Text="Enviar" OnClick="btnEnvia_Click" OnClientClick="return validaCadastro();" ValidationGroup="Grupo1" CssClass="button" />
                    <asp:Button ID="btnLimpa" runat="server" Text="Limpar" OnClick="btnLimpa_Click" OnClientClick="LimpaCampos();" CssClass="button" />
                    <asp:Button ID="Preenche" runat="server" Text="Preencher Campos" OnClick="Preenche_Click" Width="125px" Height="25px" />
                    <br />
                    <br />
                    <asp:Label ID="lblresposta" runat="server" ForeColor="White"></asp:Label>
        <br />

   
</asp:Content>