<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="pedir.aspx.cs" Inherits="aspx_pedir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="bannerInterno">
        <div class="wrapper">
            <h1>Fazer um Pedido</h1>
        </div>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <article class="pedindo">
                <div class="wrapper">
                    <h2>Escolha os sabores que deseja adicionar ao seu pedido</h2>
                    <div class="pedindoSabores">

                        <asp:Label ID="lblQtdPizzas" runat="server" CssClass="lblQtd" Text="Quantidade de Pizzas"></asp:Label>
                        <asp:DropDownList ID="ddlQtdPizzas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlQtdPizzas_SelectedIndexChanged">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>

                        <%-- PRIMEIRA PIZZA --%>
                        <asp:Panel ID="pnlPrimeiraPizza" CssClass="pnlPrimeiraPizza" runat="server">
                            <asp:Label ID="lblPizza" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>
                            <asp:DropDownList ID="ddlPizzasInteiras" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras2" runat="server" AutoPostBack="True" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras2_SelectedIndexChanged" Visible="False" EnableViewState="True">

                            </asp:DropDownList>

                            <asp:CheckBox ID="chkMeio" runat="server" Text="Meio a Meio?" CssClass="chkList" OnCheckedChanged="chkMeio_CheckedChanged" AutoPostBack="True" />

                            <asp:Button ID="btnMaisPizza" runat="server" Text="" CssClass="btnMaisPizza" />
                            
                        </asp:Panel>
                        <%-- SEGUNDA PIZZA --%>
                        <asp:Panel ID="pnlSegundaPizza" CssClass="pnlSegundaPizza" runat="server" Visible="false">
                            <asp:Label ID="lblPizza2" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>
                            <asp:DropDownList ID="ddlPizzasInteiras3" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras3_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras4" runat="server" AutoPostBack="True" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras4_SelectedIndexChanged" Visible="False"></asp:DropDownList>

                            <asp:CheckBox ID="chkMeio2" runat="server" Text="Meio a Meio?" CssClass="chkList" OnCheckedChanged="chkMeio2_CheckedChanged" AutoPostBack="True" />
                        </asp:Panel>
                        <%-- TERCEIRA PIZZA --%>
                        <asp:Panel ID="pnlTerceiraPizza" CssClass="pnlTerceiraPizza" runat="server" Visible="false">
                            <asp:Label ID="lblPizza3" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>
                            <asp:DropDownList ID="ddlPizzasInteiras5" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras5_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras6" runat="server" AutoPostBack="True" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras6_SelectedIndexChanged" Visible="False"></asp:DropDownList>

                            <asp:CheckBox ID="chkMeio3" runat="server" Text="Meio a Meio?" CssClass="chkList" OnCheckedChanged="chkMeio3_CheckedChanged" AutoPostBack="True" />
                        </asp:Panel>

                        <%-- QUARTA PIZZA --%>
                        <asp:Panel ID="pnlQuartaPizza" CssClass="pnlQuartaPizza" runat="server" Visible="false">
                            <asp:Label ID="lblPizza4" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>
                            <asp:DropDownList ID="ddlPizzasInteiras7" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras8" runat="server" AutoPostBack="True" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras2_SelectedIndexChanged" Visible="False"></asp:DropDownList>

                            <asp:CheckBox ID="chkMeio4" runat="server" Text="Meio a Meio?" CssClass="chkList" OnCheckedChanged="chkMeio4_CheckedChanged" AutoPostBack="True" />
                        </asp:Panel>

                        <%-- QUINTA PIZZA --%>
                        <asp:Panel ID="pnlQuintaPizza" CssClass="pnlQuintaPizza" runat="server" Visible="false">
                            <asp:Label ID="lblPizza5" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>
                            <asp:DropDownList ID="ddlPizzasInteiras9" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras10" runat="server" AutoPostBack="True" OnLoad="carregandoDropDown" OnSelectedIndexChanged="ddlPizzasInteiras2_SelectedIndexChanged" Visible="False"></asp:DropDownList>

                            <asp:CheckBox ID="chkMeio5" runat="server" Text="Meio a Meio?" CssClass="chkList" OnCheckedChanged="chkMeio5_CheckedChanged" AutoPostBack="True" />
                        </asp:Panel>

                        <asp:Label ID="lblPrecoUm" CssClass="lblIndex" runat="server"></asp:Label>
                        <asp:Label ID="lblPrecoDois" CssClass="lblIndex" runat="server"></asp:Label>
                        <asp:Label ID="lblPrecoTres" CssClass="lblIndex" runat="server"></asp:Label>
                        <asp:Label ID="lblPrecoQuatro" CssClass="lblIndex" runat="server"></asp:Label>
                        <asp:Label ID="lblPrecoCinco" CssClass="lblIndex" runat="server"></asp:Label>
                    </div>

                    <asp:Button ID="btnEfetuarPedido" CssClass="btnEfetuarPedido" runat="server" Text="Adicionar ao Pedido" OnClick="btnEfetuarPedido_Click" /> 
                </div>
            </article>

            <article class="produtosPedido" runat="server" id="pnlProdutosPedido">
                <div class="wrapper">
                    <h1>Pizzas no Carrinho</h1>

                    <asp:Label ID="lblPrimeiroSabor" runat="server" Text=""></asp:Label>
                    <asp:Label ID="lblSegundoSabor" runat="server" Text=""></asp:Label>

                    <asp:Label ID="lblTerceiroSabor" runat="server" Text=""></asp:Label>
                    <asp:Label ID="lblQuartoSabor" runat="server" Text=""></asp:Label>

                    <asp:Label ID="lblPreco" runat="server" Text=""></asp:Label>

                    <%-- ENDEREÇO --%>
                        <asp:RadioButtonList ID="RbtnList1" CssClass="rbtnList" runat="server" OnSelectedIndexChanged="RbtnList1_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Value="1" Text="Usar Endereço do Cadastro" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Usar outro endereço"></asp:ListItem>
                        </asp:RadioButtonList>

                        
                        <asp:TextBox ID="txtEnderecoPedido" CssClass="txtEndPedido" ReadOnly="true" BackColor="LightGray" runat="server"></asp:TextBox>

                        <h3>Observações Gerais sobre o seu Pedido</h3>
                        <asp:TextBox ID="txtObservacoes" runat="server" CssClass="txtObservacoes" TextMode="MultiLine"></asp:TextBox>

                    <asp:Button ID="btnConfirmaPedido" CssClass="btnConfirmaPedido" runat="server" Text="Confirmar Pedido" />
                </div>
            </article>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

