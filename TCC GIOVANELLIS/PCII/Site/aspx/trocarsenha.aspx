<%@ Page Title="" Language="C#" MasterPageFile="~/aspx/modelo.master" AutoEventWireup="true" CodeFile="trocarsenha.aspx.cs" Inherits="aspx_trocarsenha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section>
        <div class="bannerInterno">
            <div class="wrapper">
                <h1>Trocar Senha</h1>
            </div>
        </div>
        <article class="trocaSenha">
            <div class="wrapper">
                <fieldset>
                    <legend></legend>
                    <asp:Label ID="lblSenhaAtual" runat="server" Text="Senha Atual"></asp:Label>
                    <asp:TextBox ID="txtSenhaAtual" runat="server" TextMode="Password"></asp:TextBox>

                    <asp:Label ID="lblSenhaNova" runat="server" Text="Senha Nova"></asp:Label>
                    <asp:TextBox ID="txtSenhaNova" runat="server" TextMode="Password"></asp:TextBox>

                    <asp:Label ID="lblSenhaNovaConfirm" runat="server" Text="Confime a nova senha"></asp:Label>
                    <asp:TextBox ID="txtSenhaNovaConfirm" runat="server" TextMode="Password"></asp:TextBox>
                </fieldset>
                <asp:Button ID="btnTrocaSenha" CssClass="btnTrocaSenha" OnClick="btnTrocaSenha_Click" runat="server" Text="Trocar Senha" ValidationGroup="Grupo5" />
            </div>
        </article>
    </section>
</asp:Content>

