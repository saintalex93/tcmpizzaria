<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" Debug="true"  AutoEventWireup="true" CodeFile="pedir.aspx.cs" Inherits="aspx_pedir2" %>

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

                    <asp:Panel ID="pnlAvisos" CssClass="pnlAviso" runat="server">
                        <asp:Label ID="lblAviso" runat="server" CssClass="lblAviso" Text="* Você pode adicionar 5 sabores de cada vez ao seu pedido"></asp:Label>

                        <asp:Label ID="lblErro" runat="server" Text="" Visible="false"></asp:Label>
                    </asp:Panel>

                    <asp:Panel ID="pnlPedindoPizzas" CssClass="pedindoPizzas" runat="server">

                        <%-- PRIMEIRA PIZZA --%>
                        <asp:Panel ID="pnlPrimeiraPizza" CssClass="pnlPizza" runat="server">

                            <asp:Label ID="lblPizza" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>

                            <asp:DropDownList ID="ddlPizzasInteiras1" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras2" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza2" AutoPostBack="True" Visible="False">
                            </asp:DropDownList>

                            <asp:CheckBox ID="chkMeio" runat="server" Text="Meio a Meio?" OnCheckedChanged="chkTroca" CssClass="chkList" AutoPostBack="True" />

                            <asp:Label ID="lblQtd" runat="server" Text="Quantidade" CssClass="lblQtd"></asp:Label>

                            <asp:TextBox ID="txtQtd" runat="server" CssClass="txtQtd" Text="1" type="number" min="1" max="30" AutoPostBack="True" OnTextChanged="trocandoQtd"></asp:TextBox>

                            <p>Preço: </p>
                            <asp:Label ID="lblPreco" CssClass="lblPreco" runat="server" Text="0"></asp:Label>

                        </asp:Panel>

                        <%-- SEGUNDA PIZZA --%>
                        <asp:Panel ID="pnlPizzaDin2" CssClass="pnlPizza" Visible="false" runat="server">

                            <asp:Label ID="lblPizza2" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>

                            <asp:DropDownList ID="ddlPizzasInteiras3" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras4" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza2" AutoPostBack="True" Visible="False">
                            </asp:DropDownList>

                            <asp:CheckBox ID="chkMeio2" runat="server" Text="Meio a Meio?" OnCheckedChanged="chkTroca" CssClass="chkList" AutoPostBack="True" />

                            <asp:Label ID="lblQtd2" runat="server" Text="Quantidade" CssClass="lblQtd"></asp:Label>

                            <asp:TextBox ID="txtQtd2" runat="server" CssClass="txtQtd" Text="1" type="number" min="1" AutoPostBack="True" OnTextChanged="trocandoQtd"></asp:TextBox>

                            <p>Preço: </p>
                            <asp:Label ID="lblPreco2" CssClass="lblPreco" runat="server" Text="0"></asp:Label>

                        </asp:Panel>

                        <%-- TERCEIRA PIZZA --%>
                        <asp:Panel ID="pnlPizzaDin3" CssClass="pnlPizza" Visible="false" runat="server">

                            <asp:Label ID="lblPizza3" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>

                            <asp:DropDownList ID="ddlPizzasInteiras5" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras6" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza2" AutoPostBack="True" Visible="False">
                            </asp:DropDownList>

                            <asp:CheckBox ID="chkMeio3" runat="server" Text="Meio a Meio?" OnCheckedChanged="chkTroca" CssClass="chkList" AutoPostBack="True" />

                            <asp:Label ID="lblQtd3" runat="server" Text="Quantidade" CssClass="lblQtd"></asp:Label>

                            <asp:TextBox ID="txtQtd3" runat="server" CssClass="txtQtd" Text="1" type="number" min="1" AutoPostBack="True" OnTextChanged="trocandoQtd"></asp:TextBox>

                            <p>Preço: </p>
                            <asp:Label ID="lblPreco3" CssClass="lblPreco" runat="server" Text="0"></asp:Label>

                        </asp:Panel>

                        <%-- QUARTA PIZZA --%>
                        <asp:Panel ID="pnlPizzaDin4" CssClass="pnlPizza" Visible="false" runat="server">

                            <asp:Label ID="lblPizza4" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>

                            <asp:DropDownList ID="ddlPizzasInteiras7" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras8" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza2" AutoPostBack="True" Visible="False">
                            </asp:DropDownList>

                            <asp:CheckBox ID="chkMeio4" runat="server" Text="Meio a Meio?" OnCheckedChanged="chkTroca" CssClass="chkList" AutoPostBack="True" />

                            <asp:Label ID="lblQtd4" runat="server" Text="Quantidade" CssClass="lblQtd"></asp:Label>

                            <asp:TextBox ID="txtQtd4" runat="server" CssClass="txtQtd" Text="1" type="number" min="1" AutoPostBack="True" OnTextChanged="trocandoQtd"></asp:TextBox>

                            <p>Preço: </p>
                            <asp:Label ID="lblPreco4" CssClass="lblPreco" runat="server" Text="0"></asp:Label>

                        </asp:Panel>

                        <%-- QUINTA PIZZA --%>
                        <asp:Panel ID="pnlPizzaDin5" CssClass="pnlPizza" Visible="false" runat="server">

                            <asp:Label ID="lblPizza5" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>

                            <asp:DropDownList ID="ddlPizzasInteiras9" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza" AutoPostBack="True">
                            </asp:DropDownList>

                            <asp:DropDownList ID="ddlPizzasInteiras0" runat="server" OnLoad="carregandoDropDown" OnSelectedIndexChanged="trocaPizza2" AutoPostBack="True" Visible="False">
                            </asp:DropDownList>

                            <asp:CheckBox ID="chkMeio5" runat="server" Text="Meio a Meio?" OnCheckedChanged="chkTroca" CssClass="chkList" AutoPostBack="True" />

                            <asp:Label ID="lblQtd5" runat="server" Text="Quantidade" CssClass="lblQtd"></asp:Label>

                            <asp:TextBox ID="txtQtd5" runat="server" CssClass="txtQtd" Text="1" type="number" min="1" AutoPostBack="True" OnTextChanged="trocandoQtd"></asp:TextBox>

                            <p>Preço: </p>
                            <asp:Label ID="lblPreco5" CssClass="lblPreco" runat="server" Text="0"></asp:Label>

                        </asp:Panel>

                        <!-- FIM PAINEIS DE PIZZAS -->  

                        <!-- ADD PIZZA -->
                        <div class="buttonsAdd">
                            <asp:Button ID="btnAddPizza" runat="server" CssClass="btnAddPizza" Text="Adicionar Pizza" OnClick="adicionarPizza" />
                            <asp:Button ID="btnRemoverPizza" runat="server" CssClass="btnAddPizza" Text="Remover Pizza" OnClick="removerPizza" />
                        </div>
                        <!-- FIM ADD PIZZA -->

                        <asp:Button ID="btnAddPizzaCarrinho" runat="server" CssClass="btnAddCarrinho" OnClick="AdicionarProdutosCarrinho" Text="Adicionar ao Carrinho" />
                    </asp:Panel>

                </div>
            </article>

            <article class="pedindoBebida">
                <div class="wrapper">
                    <asp:Panel ID="pnlPedindoBebidas" runat="server">
                        
                        <asp:Panel ID="pnlBebida" CssClass="pnlBebida" runat="server">
                            <asp:Label ID="lblBebidas1" CssClass="lblBebida" runat="server" Text="Bebidas"></asp:Label>

                            <asp:DropDownList ID="ddlBebidas" OnLoad="carregandoBebidas" runat="server"></asp:DropDownList>
                            <p>Preço: </p>
                            <asp:Label ID="lblPrecoBebida" runat="server" Text=""></asp:Label>
                        </asp:Panel>

                        <%-- SEGUNDA BEBIDA --%>
                        <asp:Panel ID="pnlBebidaDin1" CssClass="pnlBebida" runat="server" Visible="false">
                            <asp:Label ID="lblBebidas2" CssClass="lblBebida" runat="server" Text="Bebidas"></asp:Label>

                            <asp:DropDownList ID="ddlBebidasDin1" OnLoad="carregandoBebidas" runat="server"></asp:DropDownList>

                            <p>Preço: </p>
                            <asp:Label ID="lblPrecoBebida1" CssClass="lblPreco" runat="server" Text=""></asp:Label>
                        </asp:Panel>

                        <%-- TERCEIRA BEBIDA --%>
                        <asp:Panel ID="pnlBebidaDin2" CssClass="pnlBebida" runat="server" Visible="false">
                            <asp:Label ID="lblBebidas3" CssClass="lblBebida" runat="server" Text="Bebidas"></asp:Label>

                            <asp:DropDownList ID="ddlBebidasDin2" OnLoad="carregandoBebidas" runat="server"></asp:DropDownList>
                            <p>Preço: </p>
                            <asp:Label ID="lblPrecoBebida2" CssClass="lblPreco" runat="server" Text=""></asp:Label>
                        </asp:Panel>

                        <%-- QUARTA BEBIDA --%>
                        <asp:Panel ID="pnlBebidaDin3" CssClass="pnlBebida" runat="server" Visible="false">
                            <asp:Label ID="lblBebida4" CssClass="lblBebida" runat="server" Text="Bebidas"></asp:Label>

                            <asp:DropDownList ID="ddlBebidasDin3" OnLoad="carregandoBebidas" runat="server"></asp:DropDownList>
                            <p>Preço: </p>
                            <asp:Label ID="lblPrecoBebida3" CssClass="lblPreco" runat="server" Text=""></asp:Label>
                        </asp:Panel>

                        <%-- QUINTA BEBIDA --%>
                        <asp:Panel ID="pnlBebidaDin4" CssClass="pnlBebida" runat="server" Visible="false">
                            <asp:Label ID="lblBebida5" CssClass="lblBebida" runat="server" Text="Bebidas"></asp:Label>

                            <asp:DropDownList ID="ddlBebidasDin4" OnLoad="carregandoBebidas" runat="server"></asp:DropDownList>
                            <p>Preço: </p>
                            <asp:Label ID="lblPrecoBebida5" CssClass="lblPreco" runat="server" Text=""></asp:Label>
                        </asp:Panel>

                        <div class="buttonsAddBebida">
                            <asp:Button ID="btnAddBebida" OnClick="adicionarBebida" runat="server" Text="Adicionar Bebida" />
                            <asp:Button ID="btnRemoverBebida" OnClick="removerBebida" runat="server" Text="Remover Bebida" />
                        </div>

                        <asp:Button ID="btnAdicionarBebidasCarrinho" runat="server" CssClass="btnAddCarrinho" OnClick="AdicionarProdutosCarrinho" Text="Adicionar ao Carrinho" />

                    </asp:Panel>
                </div>
            </article>

            <asp:Panel ID="pnlCarrinhoPedido" runat="server" CssClass="carrinhoPedido" Visible="false">
                <div class="wrapper">
                    <h2>Seu Pedido</h2>
                    <asp:GridView ID="gdCarrinho" CssClass="produtosCarrinho" runat="server" AutoGenerateColumns="true">
                        
                    </asp:GridView>

                    <asp:Panel ID="pnlPrecoTotal" CssClass="pnlPrecoTotal" runat="server">
                        <asp:Label ID="lblPrecoTot" runat="server" Text="Preço Total: R$"></asp:Label>
                        <asp:Label ID="lblPrecoTotal" runat="server" Text="0"></asp:Label>
                    </asp:Panel>

                    <asp:Button ID="btnLimpaCarrinho" CssClass="btnLimpaCarrinho" runat="server" Text="Limpar Carrinho" OnClick="limparCarrinho" />

                   <!-- ENDEREÇO -->
                    <h2>Confirmação de Endereço</h2>
                    <asp:Panel ID="pnlEndereco" runat="server" CssClass="pnlEnd">
                        <asp:RadioButtonList ID="rbtnEnd" CssClass="rbtnList" runat="server" OnSelectedIndexChanged="trocarEndereco" AutoPostBack="True">
                            <asp:ListItem Value="1" Text="Usar Endereço do Cadastro" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Usar outro endereço"></asp:ListItem>
                        </asp:RadioButtonList>

                        <asp:Panel ID="pnlEnderecoAlt" runat="server" CssClass="enderecoAlt">
                            <asp:Label ID="lblTituloEnderecoAlt" Visible="false" runat="server" CssClass="tituloEndAlt" Text="Endereço Alternativo"></asp:Label>
                            <!--Logradouro alternativo ou NÃO -->
                            <asp:Label ID="lblLogradouro" Text="Logradouro *" Visible="false" runat="server" ></asp:Label>
                            <asp:TextBox ID="txtEnderecoPedido" CssClass="txtEndPedido" ReadOnly="true" runat="server"></asp:TextBox>
                            <!-- Bairro alternativo -->
                            <asp:Label ID="lblBairro" Visible="false" Text="Bairro *" runat="server"></asp:Label>
                            <asp:TextBox ID="txtBairro" Visible="false" runat="server"></asp:TextBox>
                            <!--Número alternativo -->
                            <asp:Label ID="lblNumAlt" Visible="false" Text="Número *" runat="server"></asp:Label>
                            <asp:TextBox ID="txtNum" Visible="false" type="number" min="1" runat="server"></asp:TextBox>
                            <!--Número de apartamento alternativo(Não obrigatório) -->
                            <asp:Label ID="lblNumApartAlt" Visible="false" Text="Número do Apartamento" runat="server"></asp:Label>
                            <asp:TextBox ID="txtNumApart" Visible="false" type="number" min="1" runat="server"></asp:TextBox>

                        </asp:Panel>

                        <h3>Observações Gerais sobre o seu Pedido</h3>
                        <asp:TextBox ID="txtObservacoes" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </asp:Panel>
                    <!-- FIM ENDEREÇO -->
                    <asp:Button ID="btnFinalizaPedido" CssClass="btnFinaliza" runat="server" Text="Finalizar Pedido" OnClick="finalizaPedido" />
                </div>
            </asp:Panel>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

