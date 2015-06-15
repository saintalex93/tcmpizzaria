<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>
<html lang="pt-br"> 

<head runat="server">
    <title>Giovanelli's Empregos</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="css/estilo_agencia.css" />
    <link rel="shortcut icon" type="image/x-icon" href="imagens/favicon.ico" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script>
        $(function () {
            $('a[href*=#]:not([href=#])').click(function () {
                if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname)
                {
                    var target = $(this.hash);
                    target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                    if (target.length)
                    {
                        $('html,body').animate({
                            scrollTop: target.offset().top
                        }, 1000);
                        return false;
                    }
                }
            });
        });
    </script>
</head>

<body>
    <form id="form1" runat="server">

        <header>
            <div class="wrapper">
                <div class="logo">
                    <a href="index.aspx"><img src="imagens/logo_agencia.png" /></a>
                </div>
                <nav class="menuTopo">
                    <ul>
                        <li><asp:HyperLink ID="linkHome" NavigateUrl="index.aspx" runat="server">Home</asp:HyperLink></li>
                        <li><asp:HyperLink ID="linkBuscaVaga" NavigateUrl="index.aspx#pnlBuscarVagas" runat="server">Buscar Vagas</asp:HyperLink></li>
                        <li><asp:HyperLink ID="linkLancaVaga" NavigateUrl="aspx/lancarvaga.aspx" runat="server">Lançar Vagas</asp:HyperLink></li>
                    </ul>
                </nav>

                <asp:Panel ID="pnlLogin" CssClass="pnlLogin" runat="server">
                    <p>Login :</p>
                    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                    <p>Senha :</p>
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Button ID="btnLogar" runat="server" OnClick="Logar" Text="Login" />
                </asp:Panel>

                <asp:Panel ID="pnlLogout" CssClass="pnlLogout" runat="server" Visible="false">
                    <p>Seja bem vindo,</p>
                    <asp:Label ID="lblNomeFunc" runat="server"></asp:Label>
                    <asp:Button ID="btnLogout" runat="server" OnClick="Logout" Text="Logout" />
                </asp:Panel>

            </div>
        </header>

        <!-- *** INICIO DO CONTEÚDO *** -->

        <section>
            <article class="procurando">
                <div class="wrapper">
                    <h2>Encontre vagas online ou publique suas vagas !!</h2>
                    <h3>O que você deseja?</h3>
                    <div class="buttonGroup">
                        <a href="index.aspx#pnlBuscarVagas">Buscar Vagas</a>
                        <a href="aspx/lancarvaga.aspx">Lançar Vagas</a>
                    </div>
                </div>
            </article>

            <article class="institucional">
                <div class="wrapper">
                    <!-- AQUI ENTRA A PARTE INSTITUCIONAL -->
                    <p>PARTE INSTITUCIONAL DA AGÊNCIA</p>
                </div>
            </article>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <article ID="pnlBuscarVagas" class="buscarVagas" runat="server" ClientIDMode="Static">
                        <div class="wrapper">
                            <div class="grid">
                                <!-- AQUI ENTRA O GRID DE VAGAS -->
                        
                            <asp:Label ID="label" runat="server" Text="Buscar vagas por título"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtBuscarTitulo" style="margin-top: 5px;" runat="server"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                            <br />
                            <br />
                            <asp:GridView
                                ID="gridVagas" 
                                runat="server" 
                                name="gridVagas"
                                CssClass="gridHome" 
                                style="border-collapse: separate;"
                                ShowHeaderWhenEmpty="true"
                                >
                                <EmptyDataTemplate>
                                     Oh noes! Nenhuma vaga foi encontrada! D:
                                </EmptyDataTemplate>
                    
                            </asp:GridView>

                            <asp:SqlDataSource 
                                ID="SqlDataSource1"
                                runat="server"
                                ConnectionString="<%$ ConnectionStrings:conexaoGiovanelliEmpregos %>"
                                SelectCommand="USP_BuscarVagas"
                                SelectCommandType="StoredProcedure">
                            </asp:SqlDataSource>

                            </div>
                    
                        </div>
                    </article>

                </ContentTemplate>
            </asp:UpdatePanel>
        </section>

        <!-- *** FIM DO CONTEÚDO *** -->

        <footer>
            <div class="wrapper">
                <div class="infosRodape">
                    <p>Giovanelli's Empregos - Todos os Direitos Reservados</p>
                    <p>Rua Dalvo Trombetas, nº 56 – Fundos</p>
                    <p>Horário de atendimento: Seg. à Sab. Das 09:00 às 18:00</p>
                </div>
            </div>
        </footer>

    </form>
</body>
</html>
