<%@ Page Title="" Language="C#" MasterPageFile="modelo.master" AutoEventWireup="true" CodeFile="pedidos.aspx.cs" Inherits="aspx_pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section>
        <article class="bannerInterno">
            <div class="wrapper">
                <h1>Meus Pedidos</h1>
            </div>
        </article>

        <article class="pedidoAndamento">
            <div class="wrapper">
                <asp:ScriptManager ID="ScriptManager1" runat="server" />
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <h2>Pedido atualmente em andamento</h2>
                        
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </article>

        <article class="pedidos">
            <div class="wrapper">
                <asp:UpdatePanel ID="UpdatePanel2" ChildrenAsTriggers="true" runat="server">
                    <ContentTemplate>
                        
                        <asp:Panel ID="pnlBotoesPedidos" CssClass="buttonsPedidos" runat="server">

                            <asp:Button ID="btnOrdenarData" runat="server" Text="Ordenar pelo mais Recente" CssClass="button" OnClick="btnOrdenarData_Click" ValidationGroup="Group5" />
                            <asp:Button ID="btnOrdenarDataAntiga" runat="server" Text="Ordenar pelo mais Antigo" CssClass="button" OnClick="btnOrdenarDataAntiga_Click" ValidationGroup="Group5" />
                            <asp:Button ID="btnOrdenarPrecoCaro" runat="server" Text="Ordenar pelo mais Caro" CssClass="button" OnClick="btnOrdenarPreco_Click" ValidationGroup="Group5" />
                            <asp:Button ID="btnOrdenarBarato" runat="server" Text="Ordenar pelo mais Barato" CssClass="button" OnClick="btnOrdenarBarato_Click" ValidationGroup="Group5" />
                        </asp:Panel>
                        <asp:DataGrid ID="datagPedidos" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundColumn DataField="Data" HeaderText="Data do Pedido" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}">
                                    <HeaderStyle CssClass="colunaheader" />
                                    <ItemStyle CssClass="clmDataPed" />
                                </asp:BoundColumn>

                                <asp:BoundColumn DataField="Valor" HeaderText="Valor Total" ReadOnly="True" DataFormatString="{0:c}">
                                    <HeaderStyle CssClass="colunaheader" />
                                    <ItemStyle CssClass="clmValorPed" />
                                </asp:BoundColumn>
                            </Columns>
                        </asp:DataGrid>

                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </article>
    </section>
</asp:Content>

