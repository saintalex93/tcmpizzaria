<%@ Page Title="" Language="C#" MasterPageFile="modelo.master" AutoEventWireup="true" CodeFile="cadastro.aspx.cs" Inherits="aspx_cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript" src="../js/valida.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section>
            <div class="bannerInterno">
                <div class="wrapper">
                    <h1>Cadastro</h1>
                </div>
            </div>
            <article class="descCadastro">
                <div class="wrapper">
                    <h3>O que eu ganho por me cadastrar?</h3>

                    <p>
                        Você poderá ver seus pedidos,
                        na seção <a href="pedidos.aspx" title="Clique apenas se estiver logado !!">Meus Pedidos</a>,
                        e ainda participar de <a href="promocoes.aspx">promoções</a> 
                        exclusivas feitas para usuários cadastrados.
                    </p>
                </div>
            </article>
            <div class="descForm">
                <div class="wrapper">
                    <p>Campos obrigatórios são marcados com *</p>
                </div>
            </div>
			    <fieldset class="formulario1" >
                    <legend>Dados Pessoais</legend>
                    <div class="wrapper">          
                            <asp:Label ID="lblNome" runat="server" Text="Nome *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtNome" name="nome" runat="server" MaxLength="70" Width="220px"></asp:TextBox>

                            <asp:Label ID="lblTel" runat="server" Text="Telefone *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtTel" runat="server" MaxLength="10" Width="155px"></asp:TextBox>

                            <asp:Label ID="lblCel" runat="server" Text="Celular" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtCel" runat="server" Width="155px" MaxLength="11"></asp:TextBox>

                            <asp:Label ID="lblEmail" runat="server" Text="Email *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" Width="226px" MaxLength="35"></asp:TextBox>

                            <asp:Label ID="lblCpf" runat="server" Text="CPF *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtCpf" runat="server" Width="155px" MaxLength="11"></asp:TextBox>

                            <asp:Label ID="lblDataNasc" runat="server" Text="Data de Nascimento *" CssClass="spans" ></asp:Label>
                            <asp:TextBox ID="txtDtNasc" runat="server" Width="155px" MaxLength="8"></asp:TextBox>
                            
                            <asp:Label ID="lblSenha" runat="server" Text="Senha *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server" Width="155px" TextMode="Password" MaxLength="20"></asp:TextBox>

                            <asp:Label ID="lblSenhaConfirm" runat="server" Text="Confirmar Senha" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtSenhaConfirm" runat="server" Width="155px" TextMode="Password" MaxLength="20"></asp:TextBox>
                        </div>
                </fieldset>

                    <fieldset class="formulario2">
                        <legend>Dados de Localidade</legend>
                        <div class="wrapper">
                            <asp:Label ID="lblEstado" runat="server" Text="Estado *" CssClass="spans"></asp:Label>
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

                            <asp:Label ID="lblCidade" runat="server" Text="Cidade *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtCidade" runat="server" MaxLength="50" Width="199px"></asp:TextBox>

                            <asp:Label ID="lblRua" runat="server" Text="Nome da Rua *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtRua" runat="server" MaxLength="50" Width="255px"></asp:TextBox>

                            <asp:Label ID="lblComplemento" runat="server" Text="Complemento" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtComplemento" runat="server" MaxLength="60" Width="255px"></asp:TextBox>

                            <asp:Label ID="lblNumCasa" runat="server" Text="Número *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtNumCasa" runat="server" MaxLength="4" Width="50px" type="number" min="1"></asp:TextBox>

                            <asp:Label ID="lblNumApart" runat="server" Text="Nº Apartamento" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtNumApart" runat="server" MaxLength="4" Width="50px"></asp:TextBox>

                            <asp:Label ID="lblBairro" runat="server" Text="Bairro *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtBairro" runat="server" MaxLength="30" Width="180px"></asp:TextBox>

                            <asp:Label ID="lblCep" runat="server" Text="CEP *" CssClass="spans"></asp:Label>
                            <asp:TextBox ID="txtCep" runat="server" MaxLength="8" Width="140px"></asp:TextBox>
                        </div>
                    </fieldset>
                    <div class="buttonsCadastro">
                        <div class="wrapper">
                            <asp:Button ID="btnEnvia" runat="server" Text="Cadastrar" OnClick="btnEnvia_Click" OnClientClick="return validaCadastro();" ValidationGroup="Grupo1" />
                            <asp:Button ID="btnLimpa" runat="server" Text="Limpar" OnClick="btnLimpa_Click" OnClientClick="LimpaCampos();" />
                            <asp:Button ID="Preenche" CssClass="btnPreenche" runat="server" Text="Preencher Campos" OnClick="Preenche_Click" />
                        </div>
                    </div>
                    <div class="resposta">
                        <div class="wrapper">
                            <asp:Label ID="lblresposta" runat="server" Text="lblresposta"></asp:Label>
                        </div>
                    </div>
        </section>
</asp:Content>

