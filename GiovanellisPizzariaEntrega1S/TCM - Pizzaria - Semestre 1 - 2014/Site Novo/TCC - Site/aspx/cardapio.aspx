<%@ Page Title="" Language="C#" MasterPageFile="modelo.master" AutoEventWireup="true" CodeFile="cardapio.aspx.cs" Inherits="aspx_cardapio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section>
        <article class="bannerInterno">
            <div class="wrapper">
                <h1>Cardápio</h1>
            </div>
        </article>
        <article class="cardapio">
            <div class="wrapper">
                <h2>Clique em um sabor para adicioná-lo ao seu pedido.</h2>
                <asp:DataGrid ID="dtCardapio" runat="server" AutoGenerateColumns="False">
                    <Columns>

                    <asp:BoundColumn DataField="Nome_Produto" HeaderText="Sabores de Pizzas" ReadOnly="True">
                        <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                        <ItemStyle CssClass="clmSabor"></ItemStyle>
                    </asp:BoundColumn>

                    <asp:BoundColumn DataField="Ingred_Prod" HeaderText="Ingredientes" ReadOnly="True">
                        <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                        <ItemStyle CssClass="clmIngred"></ItemStyle>
                    </asp:BoundColumn>

                    <asp:BoundColumn DataField="Valor_Venda" HeaderText="Preço" ReadOnly="True" DataFormatString="{0:c}">
                        <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                        <ItemStyle CssClass="clmPreco"></ItemStyle>
                    </asp:BoundColumn>

                </Columns>
                </asp:DataGrid>
            </div>
        </article>
    </section>
</asp:Content>

