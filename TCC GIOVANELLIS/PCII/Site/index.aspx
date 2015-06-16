<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Debug="true" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giovannelli's Pizzaria</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" type="text/css" href="css/estilo_pizzaria.css" />
    <link rel="shortcut icon" href="imagens/favicon2.ico" type="image/x-icon"/>
    <meta name="description" content="Giovanelli's Pizzaria" />
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/jquery.bxslider.css" />
    <script src="js/jquery.bxslider.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.bxslider').bxSlider({
                auto: true,
                mode: 'fade',
                speed: 900,
                pause: 6000,
                controls: true,
                infiniteLoop: true
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="wrapper">
                <div class="logo">
                    <a href="index.aspx"><img src="imagens/marca.png" /></a>
                </div>
                <nav class="menuTopo">
                <ul>
                    <li><asp:HyperLink ID="linkHome" NavigateUrl="index.aspx" runat="server">Home</asp:HyperLink></li>
                    <li><asp:HyperLink ID="linkCardapio" NavigateUrl="aspx/cardapio.aspx" runat="server">Cardápio</asp:HyperLink></li>
                    <li><asp:HyperLink ID="linkCadastro" NavigateUrl="aspx/cadastro.aspx" runat="server">Cadastro</asp:HyperLink></li>
                        <li>
                            <asp:HyperLink ID="linkConta" CssClass="cursor" runat="server" visible="false">Minha Conta</asp:HyperLink>
                        <ul>
                            <li><asp:HyperLink ID="linkPedir" NavigateUrl="aspx/pedir.aspx" runat="server">Fazer um Pedido</asp:HyperLink></li>
                            <li><asp:HyperLink ID="linkPedidos" NavigateUrl="aspx/pedidos.aspx" runat="server">Meus Pedidos</asp:HyperLink></li>
                            <li><asp:HyperLink ID="linkTrocaDados" NavigateUrl="aspx/trocardados.aspx" runat="server">Trocar Dados</asp:HyperLink></li>
                            <li><asp:HyperLink ID="linkTrocaSenha" NavigateUrl="aspx/trocarsenha.aspx" runat="server">Trocar Senha</asp:HyperLink> </li>
                        </ul>
                    </li>
                    <li><asp:HyperLink ID="linkPromo" NavigateUrl="aspx/promocoes.aspx" runat="server">Promoções</asp:HyperLink></li>
                </ul>
            </nav>
                <!-- PAINEL LOGIN -->
                <asp:Panel ID="pnl" CssClass="boxLogin" runat="server">
                    <asp:Label ID="lblEmail" CssClass="lblEmail" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" CssClass="txtEmail" runat="server"></asp:TextBox>

                    <asp:Label ID="lblSenha" CssClass="lblSenha" runat="server" Text="Senha"></asp:Label>
                    <asp:TextBox ID="txtSenha" CssClass="txtSenha" TextMode="Password" runat="server"></asp:TextBox>

                    <asp:Label ID="lblLoginInc" CssClass="lblLoginInc" runat="server" Text=""></asp:Label>

                    <asp:Button ID="btnLogar" CssClass="btnLogar" runat="server" Text="Login" OnClick="btnLogar_Click" />
                    <asp:HyperLink ID="link_NovoPorAqui" NavigateUrl="aspx/cadastro.aspx" runat="server">Novo por aqui?</asp:HyperLink>
                </asp:Panel>
                <!-- FIM LOGIN -->

                <!-- PAINEL LOGOUT -->
                <asp:Panel ID="pnl_logado" CssClass="boxLogout" runat="server" Visible="False">
                    <asp:Button ID="btnLogout" runat="server" CssClass="btnLogout" Text="Logout" OnClick="btnLogout_Click" />
                    <asp:Label ID="lblBemVindo" runat="server" CssClass="lblBemVindo" Text="Seja Bem Vindo, "></asp:Label>
                    <asp:Label ID="lblNomeUsuario" runat="server" CssClass="lblNomeUsuario" Text="" ></asp:Label>
                    
                    <div class="carrinho">
                        <asp:Label ID="lblMeuCarrinho" CssClass="lblMeuCarrinho" runat="server" Text="Meu Carrinho"></asp:Label>
                        <img src="imagens/motoboy.png" />
                        <asp:Label ID="lblProdutosCarrinho" runat="server" Text=""></asp:Label>
                    </div>
                </asp:Panel>
            <!-- FIM LOGOUT -->
            </div>
        </header>

        <nav class="banner">
            <ul class="bxslider">
                <li><a href="aspx/pedir.aspx"><img src="imagens/slide1.jpg" /></a></li>
                <li><a href="aspx/promocoes.aspx"><img src="imagens/slide2.jpg" /></a></li>
                <li><a href="aspx/cardapio.aspx"><img src="imagens/slide3.jpg" /></a></li>
            </ul>
        </nav>

        <section>
            <article class="melhores">
                <div class="wrapper">
                    <div class="tag1">
                        <img src="imagens/icone_bebida.png" />
                        <h3>As Melhores</h3>
                        <h3>Bebidas</h3>
                        <p>Temos bebidas exóticas e a qualquer gosto, venha experimentar.</p>
                    </div>
                    <div class="tag2">
                        <img src="imagens/icone_comida.png" />
                        <h3>os Melhores</h3>
                        <h3>Sabores</h3>
                        <p>As melhores pizzas, você só encontra aqui.Os seus sabores favoritos feitos com a qualidade e carinho que só a Giovannelli's Pizzaria oferece.</p>
                    </div>
                    <div class="tag3">
                        <img src="imagens/icone_sobremesa.png" />
                        <h3>as Melhores</h3>
                        <h3>Sobremesas</h3>
                        <p>Além de pizzas, temos deliciosas sobremesas, incluindo o nosso famoso Petit Gateau.</p>
                    </div>
                </div>
            </article>

            <article class="chamada">
                <div class="wrapper">
                    <h1>Receitas Originais e Clássicas</h1>
                    <h2>Pizzas Italianas e outros sabores</h2>
                    <div class="btnPedir"><a href="aspx/pedir.aspx">Faça seu Pedido</a></div>
                </div>
            </article>

            <article class="chamadaCardapio">
                <div class="wrapper">
                    <h1>Visite nosso Cardápio</h1>
                    <h2>Veja os sabores em destaque</h2>

                    <div class="chamadacdp1">
                        <div class="pizza_chamada1">
                            <a href="aspx/cardapio.aspx"><img src="imagens/chamada_cardapio1.png" /></a>
                        </div>
                        <h3>A Moda</h3>
                    </div>

                    <div class="chamadacdp2">
                        <div class="pizza_chamada2">
                            <a href="aspx/cardapio.aspx"><img src="imagens/chamada_cardapio2.png" /></a>
                        </div>
                        <h3>Brócolis</h3>
                    </div>

                    <div class="chamadacdp3">
                        <div class="pizza_chamada3">
                            <a href="aspx/cardapio.aspx"><img src="imagens/chamada_cardapio3.png" /></a>
                        </div>
                        <h3>Napolitana</h3>
                    </div>

                    <div class="chamadacdp4">
                        <div class="pizza_chamada4">
                            <a href="aspx/cardapio.aspx"><img src="imagens/chamada_cardapio4.png" /></a>
                        </div>
                        <h3>Pepperonni</h3>
                    </div>
                    <div class="chamadacdp5">
                        <div class="pizza_chamada5">
                            <a href="aspx/cardapio.aspx"><img src="imagens/chamada_cardapio5.png" /></a>
                        </div>
                        <h3>Rúcula</h3>
                    </div>
                
                </div>
                <div class="clearfix"></div>
            </article>
        </section>

        <footer>
            <div class="wrapper">
                <nav class="menuRodape">
                    <ul>
                        <li><asp:HyperLink ID="linkHome_rodape" NavigateUrl="index.aspx" runat="server">Home</asp:HyperLink></li>
                        <li><asp:HyperLink ID="linkCardapio_rodape" NavigateUrl="aspx/cardapio.aspx" runat="server">Cardápio</asp:HyperLink></li>
                        <li><asp:HyperLink ID="linkCadastro_rodape" NavigateUrl="aspx/cadastro.aspx" runat="server">Cadastro</asp:HyperLink></li>
                        <li><asp:HyperLink ID="linkPromo_rodape" NavigateUrl="aspx/promocoes.aspx" runat="server">Promoções</asp:HyperLink></li>
                        <li><asp:HyperLink ID="linkPedir_rodape" NavigateUrl="aspx/pedir.aspx" runat="server">Fazer Pedido</asp:HyperLink></li>
                    </ul>
                </nav>
                <div class="logoRodape">
                    <img src="imagens/marca.png" />
                </div>
                <p>Giovannelli's Pizzaria 2015 - Todos os Direitos Reservados</p>
            </div>
        </footer>
    </form>
</body>
</html>




    