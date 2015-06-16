<%@ Page Title="" Language="C#" MasterPageFile="modelo.master" AutoEventWireup="true" CodeFile="promocoes.aspx.cs" Inherits="aspx_promocoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section>
        <article class="bannerInterno">
            <div class="wrapper">
                <h1>Promoções</h1>
            </div>
        </article>

        <article class="promocoes">
            <div class="wrapper">
                <asp:DataGrid ID="GridPromo" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundColumn DataField="Nome_Promocao" HeaderText="Nome da Promoção">
                        <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                        <ItemStyle CssClass="clmNomePromo"></ItemStyle>
                    </asp:BoundColumn>

                    <asp:BoundColumn DataField="Descricao" HeaderText="Descrição">
                        <HeaderStyle CssClass="colunaheader"></HeaderStyle>

                        <ItemStyle CssClass="clmDescPromo"></ItemStyle>
                    </asp:BoundColumn>
                </Columns>


                </asp:DataGrid>
            </div>
        </article>
    </section>
</asp:Content>

