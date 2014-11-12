<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cadastrapedido.aspx.cs" Inherits="aspx_cadastrapedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <script type="text/javascript" src="../js/mascara.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="conteudo_cadastrapedido" class="conteudo">

        <asp:Panel ID="pnl_cadastrapedido" runat="server">

            <asp:HyperLink ID="linkCadastrarPed" runat="server" NavigateUrl="~/aspx/cadastrapedido.aspx">Cadastrar Pedidos</asp:HyperLink>
            <asp:HyperLink ID="linkVerPed" runat="server" NavigateUrl="~/aspx/verificarpedido">Verificar Pedidos</asp:HyperLink>

            <h1>Cadastro de Pedidos</h1>
            <br />

            <asp:Panel ID="pnl_CadastrarPedido" runat="server">
            
                <asp:Label ID="lblData" runat="server" Text="Data"></asp:Label>
                <asp:TextBox ID="txtData" Type="date" onKeyPress="formatar('##/##/####', this)" runat="server" MaxLength="10"></asp:TextBox>
                <br />
                <asp:Label ID="lblValor" runat="server" Text="Valor"></asp:Label>
                <asp:TextBox ID="txtValor" onKeyPress="formatar('##,###', this)" runat="server" MaxLength="6"></asp:TextBox>
                <br />
                <asp:Label ID="lblSit" runat="server" Text="Situação"></asp:Label>
                <asp:TextBox ID="txtSit" runat="server" MaxLength="1"></asp:TextBox>(0 para não pago, e 1 para pago)<br />

            </asp:Panel>
           
            <%-- BOTAO QUE FAZ O INSERT EM PEDIDOS --%>

            <asp:Button ID="btnCadastraPedido" runat="server" Text="Cadastrar Pedido" OnClientClick="return validaCampos();" OnClick="btnCadastraPedido_Click" />

             <%-- PAINEL QUE MOSTRA O ULTIMO PEDIDO CRIADO(NAO VAI SER MOSTRADO, SÓ USADO PRA PEGAR O ID DO PEDIDO) --%>

            <asp:Panel ID="pnl_dgUltimoPedido" runat="server" Visible="False">
                <asp:DataGrid ID="dataGridPedido" runat="server" AutoGenerateColumns="False" Caption="Último pedido realizado">

                <Columns>
                    <asp:BoundColumn DataField="Pedido" HeaderText="Código do Pedido" ItemStyle-CssClass="ce">
                        <ItemStyle CssClass="ce" />
                    </asp:BoundColumn>

                    <asp:BoundColumn DataField="Produtos" HeaderText="Produtos" ItemStyle-CssClass="ce"></asp:BoundColumn>

                </Columns>
            

                </asp:DataGrid>
            </asp:Panel>

            <%-- PAINEL QUE MOSTRA OS PRODUTOS PARA O CLIENTE INSERIR PRODUTOS NO PEDIDO(INSERT EM PEDIDO_CLIENTE) --%>

            <asp:Panel ID="pnl_dgProdutos" runat="server" Visible="False">

                <asp:Label ID="lblProduto" runat="server" Text="Produto Consumido"></asp:Label>
                <asp:TextBox ID="txtProduto" runat="server" MaxLength="2"></asp:TextBox>
                <br />
                <asp:Label ID="lblQtd" runat="server" Text="Quantidade"></asp:Label>
                <asp:TextBox ID="txtQtd" runat="server" MaxLength="2"></asp:TextBox>
                <br />

                <asp:DataGrid ID="datagridProdutos" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundColumn DataField="Cod_Produto" ReadOnly="True" ItemStyle-CssClass="ce" HeaderText="Código do Produto"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Nome_Produto" HeaderText="Nome do Produto" ItemStyle-CssClass="ce" ReadOnly="True">
                            <ItemStyle CssClass="ce" />
                        </asp:BoundColumn>
                    </Columns>

                </asp:DataGrid>

                <asp:Button ID="btnCadastrarProdutos" runat="server" Text="Cadastrar Cliente" />

            </asp:Panel>

            <br /><br />

            <asp:Panel ID="pnl_dgAddProduto" runat="server" Visible="False">

                <asp:DataGrid ID="dataGridProduto" runat="server" AutoGenerateColumns="False">


                    <Columns>
                        <asp:BoundColumn DataField="Produtos" HeaderText="Produtos Adicionados nesse Pedido" ItemStyle-CssClass="ce"></asp:BoundColumn>
                    </Columns>


                </asp:DataGrid>
            </asp:Panel>


        <asp:Panel ID="pnl_dgCliente" runat="server" Visible="False">

            <asp:Label ID="lblcpf_usuario" runat="server" Text="CPF do Cliente"></asp:Label>
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox><br />

                <asp:DataGrid ID="DataGridClientes" runat="server">
                    <Columns>
                        <asp:BoundColumn DataField="CodCliente" HeaderText="Código do Cliente" ItemStyle-CssClass="ce"></asp:BoundColumn>
                        <asp:BoundColumn DataField="NomeCliente" HeaderText="Nome do Cliente" ItemStyle-CssClass="ce"></asp:BoundColumn>
                    </Columns>

                </asp:DataGrid>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </asp:Panel>
            </asp:Panel>
    </div>
</asp:Content>

