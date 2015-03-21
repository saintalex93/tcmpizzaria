<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="pedir.aspx.cs" Inherits="aspx_pedir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="bannerInterno">
        <div class="wrapper">
            <h1>Fazer um Pedido</h1>
        </div>
    </div>
    <article class="pedindo">
        <div class="wrapper">
            <h2>Escolha os sabores que deseja adicionar ao seu pedido</h2>
            <div class="pedindoSabores">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

                        <asp:Label ID="lblPizza" CssClass="lblPizza" runat="server" Text="Pizza"></asp:Label>
                        <asp:DropDownList ID="ddlPizzasInteiras" runat="server" OnLoad="ddlPizzasInteiras_Load" OnSelectedIndexChanged="ddlPizzasInteiras_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>

                        <asp:DropDownList ID="ddlPizzasInteiras2" runat="server" AutoPostBack="True" OnLoad="ddlPizzasInteiras2_Load" OnSelectedIndexChanged="ddlPizzasInteiras2_SelectedIndexChanged" Visible="False"></asp:DropDownList>

                        <asp:CheckBox ID="chkMeio" runat="server" Text="Meio a Meio?" CssClass="chkList" OnCheckedChanged="chkMeio_CheckedChanged" AutoPostBack="True" />

                        <asp:RadioButtonList ID="RbtnList1" CssClass="rbtnList" runat="server" OnSelectedIndexChanged="RbtnList1_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Value="1" Text="Usar Endereço do Cadastro" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Usar outro endereço"></asp:ListItem>
                        </asp:RadioButtonList>

                        <asp:TextBox ID="txtEnderecoPedido" CssClass="txtEndPedido" ReadOnly="true" BackColor="LightGray" runat="server"></asp:TextBox>

                        <h3>Observações Gerais sobre o seu Pedido</h3>
                        <asp:TextBox ID="txtObservacoes" runat="server" CssClass="txtObservacoes" TextMode="MultiLine"></asp:TextBox>

                        <asp:Label ID="lblIndex" runat="server" Text=""></asp:Label>
                    </ContentTemplate>
                    <%--<Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlPizzasInteiras" EventName="SelectedIndexChanged" />
                        <asp:AsyncPostBackTrigger ControlID="chkListMeio1" EventName="SelectedIndexChanged" />
                    </Triggers>--%>
                </asp:UpdatePanel>
            </div>

            <asp:Button ID="btnEfetuarPedido" CssClass="btnEfetuarPedido" runat="server" Text="Efetuar Pedido" OnClick="btnEfetuarPedido_Click" />

            
                
        </div>
    </article>
</asp:Content>

