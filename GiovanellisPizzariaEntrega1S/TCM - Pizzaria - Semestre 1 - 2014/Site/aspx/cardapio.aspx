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

                <asp:GridView ID="gdCardapio" runat="server" AutoGenerateColumns="true" ShowHeaderWhenEmpty="true">

                </asp:GridView>
            </div>
        </article>
    </section>
</asp:Content>

