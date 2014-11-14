<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="cadastrapedido.aspx.cs" Inherits="aspx_cadastrapedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/style.css" />
    <link rel="icon" type="image/png" href="../img/logo.ico" />
    <script type="text/javascript" src="../js/mascara.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="conteudo_cadastrapedido" class="conteudo">

        <asp:Panel ID="pnl_cadastrapedido" runat="server">

            <asp:Label ID="lblTitulo" class="titulo" runat="server" Text="Cadastro de Pedidos"></asp:Label>
            <br />

            <asp:Panel ID="pnl_CadastrarPedido" runat="server" style="float: left;">
            
                <asp:Label ID="lblData" runat="server" Text="Data"></asp:Label>
                <asp:TextBox ID="txtData" onKeyPress="formatar('##/##/####', this)" runat="server" MaxLength="10"></asp:TextBox>
                <br />
                <asp:Label ID="lblValor" runat="server" Text="Valor"></asp:Label>
                <asp:TextBox ID="txtValor" onKeyPress="formatar('##,##', this)" runat="server" MaxLength="5"></asp:TextBox>
                <br />
                <asp:Label ID="lblCodCli" runat="server" Text="Código do Cliente"></asp:Label>
                <asp:TextBox ID="txtCodCli" runat="server" MaxLength="3"></asp:TextBox>
                <br />
                 <asp:Label ID="lblSit" runat="server" Text="Situação"></asp:Label>
                <asp:TextBox ID="txtSit" runat="server" MaxLength="1"></asp:TextBox><br />
                <span>(0 para não pago, e 1 para pago)</span><br />

            <asp:Button ID="btnCadastraPedido" runat="server" style="margin-top: 10px;" CssClass="button" Text="Cadastrar Pedido" OnClick="btnCadastraPedido_Click" ValidationGroup="valGroup1" />
                
            </asp:Panel>

            <%-- PAINEL QUE PUXA OS CLIENTES CADASTRADOS --%>

            <asp:Panel ID="pnl_dgCliente" style="float: right;" runat="server">

            <asp:Label ID="lblcpf_usuario" runat="server" Text="CPF do Cliente"></asp:Label>
            <asp:TextBox ID="txtCpf" onKeyPress="formatar('###.###.###-##', this)" runat="server" MaxLength="14"></asp:TextBox><br />

                <asp:Button ID="btnPesquisarCliente" runat="server" CssClass="button" style="margin: 10px 0px;" Text="Pesquisar um Cliente" OnClick="btnPesquisarCliente_Click" ValidationGroup="valGroup2" />

                <asp:DataGrid ID="datagridClientes" runat="server" AutoGenerateColumns="False">

                    <Columns>

                        <asp:BoundColumn DataField="Cod_Cliente" HeaderText="Código do Cliente" ItemStyle-CssClass="ce"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Nome_Cliente" HeaderText="Nome do Cliente" ItemStyle-CssClass="ce"></asp:BoundColumn>

                    </Columns>

                </asp:DataGrid>
            
        </asp:Panel>

            
        </asp:Panel>
        
    </div>
</asp:Content>

