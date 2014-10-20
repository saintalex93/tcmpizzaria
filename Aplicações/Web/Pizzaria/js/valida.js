
function validaCadastro()
{
    var nome = document.getElementById("ContentPlaceHolder1_txtNome").value;
    var nome_exp = /\w+/;

    var tele = document.getElementById("ContentPlaceHolder1_txtTel").value;

    var cel = document.getElementById("ContentPlaceHolder1_txtCel").value;

    var email = document.getElementById("ContentPlaceHolder1_txtEmail").value;
    var email_exp = /\w+@\w+\.\w{2,3}/;

    var cpf = document.getElementById("ContentPlaceHolder1_txtCpf").value;

    var datanasc = document.getElementById("ContentPlaceHolder1_txtDtNasc").value;
    var dia = "";
    var mes = "";
    var ano = "";
    var ultimoDia = "Valor original";

    var senha = document.getElementById("ContentPlaceHolder1_txtSenha").value;
    var senha_confirm = document.getElementById("ContentPlaceHolder1_txtSenhaConfirm").value;

    var estado = document.getElementById("ContentPlaceHolder1_DDLEstado").value;

    var cidade = document.getElementById("ContentPlaceHolder1_txtCidade").value;

    var rua = document.getElementById("ContentPlaceHolder1_txtRua").value;
    var rua_exp = /[a-z]/;

    var complemento = document.getElementById("ContentPlaceHolder1_txtComplemento").value;

    var num_casa = document.getElementById("ContentPlaceHolder1_txtNumCasa").value;

    var num_apart = document.getElementById("ContentPlaceHolder1_txtNumApart").value;
    var num_apart_exp = /\d*/;
    var num_apart_exp2 = /\d+/;

    var cep = document.getElementById("ContentPlaceHolder1_txtCep").value;
    var cep_exp = /\d{5}\d{3}/;

    var bairro = document.getElementById("ContentPlaceHolder1_txtBairro").value;

    //FIM DE DECLARAÇÃO DAS VARIÁVEIS


        //VALIDAÇÕES DOS CAMPOS
    
            //VALIDAÇÃO DO NOME
    
            if (nome.search(nome_exp) || nome.length < 3) {
                alert("Insira um nome");
                ContentPlaceHolder1_txtNome.focus();
                return false;
            }
    
            //VALIDAÇÃO DO TELEFONE
    
            if (tele.length < 10)
            {
                alert("Número de telefone inválido.\nInsira apenas números.");
                ContentPlaceHolder1_txtTel.focus();
                return false;
            }
            if (isNaN(tele) && tele.length < 13)
            {
                alert("Número de telefone inválido.\nInsira apenas números.");
                ContentPlaceHolder1_txtTel.focus();
                return false;
            }
            if (isNaN(tele) && tele.length == 13)
            {
                ContentPlaceHolder1_txtEmail.focus();
            }
    
            //VALIDAÇÃO DO CELULAR
    
            if (cel.length != 0)  // Verifico se o usuário digitou alguma coisa com !=0 (Diferente de 0).
            {
                
                if (isNaN(cel) && cel.length < 13) // Se digitou, eu verifico se digitou apenas números com isNaN E se todo o campo é menor que 13(se for menor que 13, ele apagou depois da máscara ser aplicada)
                {   
                    alert("Celular inválido.\nInsira apenas números.");
                    ContentPlaceHolder1_txtCel.focus();
                    return false;
                }
                if (cel.length < 10) // Se digitou apenas números, eu verifico se digitou MENOS que 10 números.
                {
                    alert("Celular inválido.");
                    ContentPlaceHolder1_txtCel.focus();
                    return false;
                }
                if (cel.length == 13 || cel.length == 15)
                {
                    ContentPlaceHolder1_txtEmail.focus();
                }
    
            }
    
            //VALIDAÇÃO DO EMAIL
    
            if (email.search(email_exp))
            {
                alert("Email Inválido");
                ContentPlaceHolder1_txtEmail.focus();
                return false;
            }
    
            //VALIDAÇÃO DO CPF
    
            if (cpf.length < 11)
            {
                alert("Número de CPF inválido.");
                ContentPlaceHolder1_txtCpf.focus();
                return false;
            }
            if (isNaN(cpf) && cpf.length < 14)
            {
                alert("Número de CPF inválido.\nInsira apenas números.");
                ContentPlaceHolder1_txtCpf.focus();
                return false;
            }
    
        //VALIDAÇÃO DA DATA DE NASCIMENTO
            if (isNaN(datanasc) && datanasc.length < 10)
            {
        alert("Insira apenas números na Data de Nascimento");
        ContentPlaceHolder1_txtDtNasc.focus();
        return false;
            }
    else
    {
        var sessao = 0; //Variável criada para indicar qual parte da data de nascimento se está processando


        for(i = 0; i < datanasc.length; i++)
        {
            if (datanasc[i] == "/") //Se o caracter encontrado for uma barra, quer dizer que já acabou a sessão anterior e agora vem a próxima
                sessao++;
            else
            {
                switch (sessao) //O conteúo dessa variável indica qual sessão da data se está, então ela é passada como parâmetro pro switch
                {
                    case 0: //Se estiver com zero nela, se está processando a primeira parte da data, ou seja, o dia
                        dia += datanasc[i];
                        break;

                    case 1: //Se estiver com 1 nela, é a segunda parte: Mês
                        mes += datanasc[i];
                        break;

                    case 2: //Se estiver com 2 nela, é a terceira: Ano
                        ano += datanasc[i];
                        break;

                    default: //Se não tiver nenhuma das anteriores, um erro aconteceu.
                        alert("Um erro aconteceu. Por favor, atualize a página e tente de novo.");
                        break;
                }
            }
        }
    }

    //Mudar o conteúdo de string pra int
    dia = parseInt(dia, 10);
    mes = parseInt(mes, 10);
    ano = parseInt(ano, 10);

    //Anos bissextos são encontrados matematicamente se ele for divisível por 4, mas não por 100. 
    if (ano % 4 == 0 && ano % 100 != 0)
    {
        /*
        Uma outra parte da validação diz respeito a se o dia que o usuário colocou existe de fato no calendário. 
        Para isso, o computador segue a sequência:
        - Ver o mês que o usuário colocou
        - Ver quantos dias esse mês tem
        - Colocar esse valor em uma segunda variável
        - Usar o conteúdo da segunda variável para ver se o dia do usuário é menor que o último dia do mês, logo, se ele existe.
        */
        switch (mes) 
        {
            case 1: //"É mês 1? Se for, esse tem 31 dias"
                ultimoDia = 31;
                break;

            case 2: //"É mês 2? Se for, esse tem 29 dias" (lembrando que estamos dentro da parte do if que lida com ano bissexto). Etc...
                ultimoDia = 29;
                break;

            case 3:
                ultimoDia = 31;
                break;

            case 4:
                ultimoDia = 30;
                break;

            case 5:
                ultimoDia = 31;
                break;

            case 6:
                ultimoDia = 30;
                break;

            case 7:
                ultimoDia = 31;
                break;

            case 8:
                ultimoDia = 31;
                break;

            case 9:
                ultimoDia = 30;
                break;

            case 10:
                ultimoDia = 31;
                break;

            case 11:
                ultimoDia = 30;
                break;

            case 12:
                ultimoDia = 31;
                break;

            default: //Se não deu nenhuma das opções anteriores, deu merda e tem que recomeçar.
                alert("Data de Nascimento inválida. Reeveja o campo por favor.");
                return false;
                break;
        }
    }
    else //Agora é a mesma coisa com a única diferença de que Fevereiro vai ter 28 dias, porque aqui não é bissexto.
    {

        switch (mes) 
        {
            case 1:
                ultimoDia = 31;
                break;

            case 2:
                ultimoDia = 28;
                break;

            case 3:
                ultimoDia = 31;
                break;

            case 4:
                ultimoDia = 30;
                break;

            case 5:
                ultimoDia = 31;
                break;

            case 6:
                ultimoDia = 30;
                break;

            case 7:
                ultimoDia = 31;
                break;

            case 8:
                ultimoDia = 31;
                break;

            case 9:
                ultimoDia = 30;
                break;

            case 10:
                ultimoDia = 31;
                break;

            case 11:
                ultimoDia = 30;
                break;

            case 12:
                ultimoDia = 31;
                break;

            default:
                alert("Data de Nascimento inválida. Reeveja o campo por favor.");
                return false;
                break;
        }
    }
    
    //Tudo que aconteceu até agora era a criação dos recursos necessários para a verificação e avaliação do input do usuário.
    
    if ( //É aqui que toda validação acontece.
        ano > 2014 //"O ano é maior que o ano atual?" - Tem que validar, porque, se não a pessoa ainda não nasceu, e isso é meio bad.
        || //Operador "ou", porque, se qualquer uma dessas informações estiver errada, a data não é válida
        ano < 0 //Ano não pode ser negativo, porque não podemos esperar Cristo nascer pra poder cadastrar a data de nascimento dos clientes.
        ||
        mes > 12 //Tem que ser um dos doze meses do ano, de preferência.
        ||
        mes < 0 //Mês negativo não, né? Deixar as Leis da Física em paz de vez em quando, pô. Mó trabalho pesado o delas... elas merecem um descanso.
        ||
        dia > ultimoDia //Ver se o dia que o usuário colocou é menor do que o último dia do mês, porque, né...
        ||
        dia < 0 //Dia negativo também não. Mó deselegante.
        )
    {
        alert("A data que você inseriu não é válida. Por favor, reveja os campos preenchidos."); //E, se deu alguma merda em algum lugar, isso aqui aciona.
        ContentPlaceHolder1_txtDtNasc.focus();
        return false;
    }//Essa é toda a validação da data de nascimento. Boa noite e obrigado. - Tuca
   
        //VALIDAÇÃO DA SENHA

    if (senha.length < 5)
    {
            alert("Suas senhas não possuem mais que 6 dígitos");
            ContentPlaceHolder1_txtSenha.focus();
            return false;
        }
        if (senha != senha_confirm) //Se senha é diferente(!=) de senha2
        {
            alert("Suas senhas não coincidem");
            ContentPlaceHolder1_txtSenhaConfirm.focus();
            return false;
        }


        //2º PARTE DO FORMULÁRIO



        //VALIDAÇÃO DO ESTADO
        if (estado == "Escolha")
        {
            alert("Selecione um estado");
            ContentPlaceHolder1_DDLEstado.focus();
            return false;
        }

        //VALIDAÇÃO DA CIDADE
        if (cidade.length < 3)
        {
            alert("Insira uma cidade");
            ContentPlaceHolder1_txtCidade.focus();
            return false;
        }
        //VALIDAÇÃO DA RUA
        if (rua.length < 1)
        {
            alert("Insira um endereço válido");
            ContentPlaceHolder1_txtRua.focus();
            return false;
        }

        //VALIDAÇÃO DO NÚMERO DA CASA
        if (num_casa.length < 1)
        {
            alert("Número de endereço inválido.");
            ContentPlaceHolder1_txtNumCasa.focus();
            return false;
        }
        if (isNaN(num_casa))
        {
            alert("Número de endereço inválido.\nInsira apenas números");
            ContentPlaceHolder1_txtNumCasa.focus();
            return false;
        }

        //VALIDAÇÃO DO NÚMERO DO APARTAMENTO
        if (num_apart.length != 0)
        {
            if (isNaN(num_apart))
            {
                alert("Número de apartamento inválido.\nInsira apenas números.");
                ContentPlaceHolder1_txtNumApart.focus();
                return false;
            }
        }

        //VALIDAÇÃO DO BAIRRO
        if (bairro.length < 4)
        {
            alert("Insira um nome de bairro inválido.");
            ContentPlaceHolder1_txtBairro.focus();
            return false;
        }
        //VALIDAÇÃO DO CEP
        if (cep.length < 8)
        {
            alert("Insira um CEP inválido.");
            ContentPlaceHolder1_txtCep.focus();
            return false;
        }
        if (isNaN(cep) && cep.length < 9)
        {
            alert("Insira um CEP válido.");
            ContentPlaceHolder1_txtCep.focus();
            return false;
        }
        if (isNan(cep) && cep.length == 9)
        {
            ContentPlaceHolder1_btnEnvia.focus();
        }

    }


    function aplicaMascara() // Essa Função vai ser só para aplicar máscaras nos campos
    { 

        var datanasc = document.getElementById("ContentPlaceHolder1_txtDtNasc").value;
        /*var datanasc_exp = /^([0-2][0-9]|3[0|1])(01|0[3-9]|1[0-2])([1|2]{1}[9|0]{1}[0-9]{1}[0-9]{1})$/;
        var datanasc_exp2 = /^([0-2]{1}[0-9]{1})(0{1}2{1})([1|2]{1}[9|0]{1}[0-9]{1}[0-9]{1})$/;*/
        var datanasc_exp = /^(\d{2})(\d{2})(\d{4})$/;

        var cpf = document.getElementById("ContentPlaceHolder1_txtCpf").value;
        var cpf_exp = /^(\d{3})(\d{3})(\d{3})(\d{2})$/;

        var tele = document.getElementById("ContentPlaceHolder1_txtTel").value;
        var tele_exp = /(\d{2})(\d{4})(\d{4})/;

        var cel = document.getElementById("ContentPlaceHolder1_txtCel").value;
        var cel_exp = /(\d{2})(\d{1})(\d{4})(\d{4})/;
        var cel_exp10 = /(\d{2})(\d{4})(\d{4})/;

        var cep = document.getElementById("ContentPlaceHolder1_txtCep").value;
        var cep_exp = /(\d{5})(\d{3})/;

        if (datanasc.length == 8)
        {
                datanasc = datanasc.replace(datanasc_exp, '$1/$2/$3');
                document.getElementById("ContentPlaceHolder1_txtDtNasc").value = datanasc;
        }

        if (cpf.length = 11)
        {
            cpf = cpf.replace(cpf_exp, '$1.$2.$3-$4');
            document.getElementById("ContentPlaceHolder1_txtCpf").value = cpf;
        }
            
        if (tele.length = 10)
        {
            tele = tele.replace(tele_exp, '($1)$2-$3');
            document.getElementById("ContentPlaceHolder1_txtTel").value = tele;
        }
        if (cel.length = 11)
        {
            cel = cel.replace(cel_exp, '($1)$2-$3-$4');
            document.getElementById("ContentPlaceHolder1_txtCel").value = cel;
        }
        if (cel.length = 10)
        {
            cel = cel.replace(cel_exp10, '($1)$2-$3');
            document.getElementById("ContentPlaceHolder1_txtCel").value = cel;
        }
        if (cep.length = 8)
        {
            cep = cep.replace(cep_exp, '$1-$2');
            document.getElementById("ContentPlaceHolder1_txtCep").value = cep;
        }

    }


    //FUNÇÕES PARA RETIRAR MÁSCARAS DOS CAMPOS QUANDO O USUÁRIO FOCAR O CAMPO QUE TIVER MÁSCARA

function retiraMascaraTel()
    {

    var tele = document.getElementById("ContentPlaceHolder1_txtTel").value;
        var tele_exp = /[^0-9]+/g;

        if (tele.length = 14)
        {
            tele = tele.replace(tele_exp, '');
            document.getElementById("ContentPlaceHolder1_txtTel").value = tele;
        }

    }

function retiraMascaraDtNasc()
    {
    var datanasc = document.getElementById("ContentPlaceHolder1_txtDtNasc").value;
        var datanasc_exp = /[^0-9]+/g;

        if (datanasc.length = 10)
        {
            datanasc = datanasc.replace(datanasc_exp, '');
            document.getElementById("ContentPlaceHolder1_txtDtNasc").value = datanasc;
        }

    }


function retiraMascaraCel()
    {
    var cel = document.getElementById("ContentPlaceHolder1_txtCel").value;
        var cel_exp = /[^0-9]+/g;

        if (cel.length = 15)
        {
            cel = cel.replace(cel_exp, '');
            document.getElementById("ContentPlaceHolder1_txtCel").value = cel;
        }
    }


function retiraMascaraCpf()
    {
    var cpf = document.getElementById("ContentPlaceHolder1_txtCpf").value;
    var cpf_exp = /[^0-9]+/g;

        if (cpf.length = 14)
        {
            cpf = cpf.replace(cpf_exp, '');
            document.getElementById("ContentPlaceHolder1_txtCpf").value = cpf;
        }
    }


function retiraMascaraCep()
    {
    var cep = document.getElementById("ContentPlaceHolder1_txtCep").value;
        var cep_exp = /[^0-9]+/g;

        if (cep.length = 9)
        {
            cep = cep.replace(cep_exp, '');
            document.getElementById("ContentPlaceHolder1_txtCep").value = cep;
        }
    }
