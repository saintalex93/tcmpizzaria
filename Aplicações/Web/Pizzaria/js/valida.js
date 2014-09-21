function validaCadastro() {

    var nome = document.getElementById("txtNome").value;
    var nome_exp = /\w+/;

    var tele = document.getElementById("txtTel").value;

    var cel = document.getElementById("txtCel").value;

    var email = document.getElementById("txtEmail").value;
    var email_exp = /\w+@\w+\.\w{2,3}/;

    var cpf = document.getElementById("txtCpf").value;

    var datanasc = document.getElementById("txtDtNasc").value;

    var senha = document.getElementById("txtSenha").value;
    var senha_confirm = document.getElementById("txtSenhaConfirm").value;

    var estado = document.getElementById("DDLEstado").value;

    var cidade = document.getElementById("txtCidade").value;

    var rua = document.getElementById("txtRua").value;
    var rua_exp = /[a-z]/;

    var num_casa = document.getElementById("txtNumCasa").value;

    var num_apart = document.getElementById("txtNumApart").value;
    var num_apart_exp = /\d*/;
    var num_apart_exp2 = /\d+/;

    var cep = document.getElementById("txtCep").value;
    var cep_exp = /\d{5}\d{3}/;

    var bairro = document.getElementById("txtBairro").value;

    //FIM DE DECLARAÇÃO DAS VARIÁVEIS


    //VALIDAÇÕES DOS CAMPOS

    //VALIDAÇÃO DO NOME

    if (nome.search(nome_exp) || nome.length < 3)
    {
        alert("Insira um nome");
        txtNome.focus();
        return false;
    }

    //VALIDAÇÃO DO TELEFONE

    if (tele.length < 10)
    {
        alert("Número de telefone inválido.\nInsira apenas números.");
        txtTel.focus();
        return false;
    }
    if (isNaN(tele) && tele.length < 13)
    {
        alert("Número de telefone inválido.\nInsira apenas números.");
        txtTel.focus();
        return false;
    }
    if (isNaN(tele) && tele.length == 13)
    {
        txtEmail.focus();
    }

    //VALIDAÇÃO DO CELULAR

    if (cel.length != 0)  // Verifico se o usuário digitou alguma coisa com !=0 (Diferente de 0).
    {
        if (cel.length == 13 || cel.length == 15)
        {
            txtEmail.focus();
        }
        if (isNaN(cel) && cel.length < 13) {   // Se digitou, eu verifico se digitou apenas números com isNaN E se todo o campo é menor que 13(se for menor que 13, ele apagou depois da máscara ser aplicada)
            alert("Celular inválido.\nInsira apenas números.");
            txtCel.focus();
            return false;
        }
        if (cel.length < 10) // Se digitou apenas números, eu verifico se digitou MENOS que 10 números.
        {
            alert("Celular inválido.");
            txtCel.focus();
            return false;
        }

    }

    //VALIDAÇÃO DO EMAIL

    if (email.search(email_exp))
    {
        alert("Email Inválido");
        txtEmail.focus();
        return false;
    }

    //VALIDAÇÃO DO CPF

    if (cpf.length < 11)
    {
        alert("Número de CPF inválido.");
        txtCpf.focus();
        return false;
    }
    if (isNaN(cpf) && cpf.length < 14)
    {
        alert("Número de CPF inválido.\nInsira apenas números.");
        txtCpf.focus();
        return false;
    }


    //VALIDAÇÃO DA DATA DE NASCIMENTO

    if (datanasc.length < 8)
    {
        alert("Data de Nascimento inválida");
        txtDtNasc.focus();
        return false;
    }
    if (isNaN(datanasc) && datanasc.length == 10) // Verifico se NÃO é um número E se o número de caracteres no campo é igual a 10, se for, o campo já recebeu máscara.
    {
        txtSenha.focus();
    }
    if (isNaN(datanasc) && datanasc.length < 10) // Verifico se NÃO é um número E se é menor que 10(se for, o campo já recebeu a máscara e o usuário deletou depois)
    {
        alert("Data de Nascimento Inválida")
        txtDtNasc.focus();
        return false;
    }


    //VALIDAÇÃO DA SENHA

    if (senha.length < 6)
    {
        alert("Suas senhas não possuem mais que 6 dígitos");
        txtSenha.focus();
        return false;
    }
    if (senha != senha_confirm) //Se senha é diferente(!=) de senha2
    {
        alert("Suas senhas não coincidem");
        txtSenhaConfirm.focus();
        return false;
    }


    //2º PARTE DO FORMULÁRIO



    //VALIDAÇÃO DO ESTADO
    if(estado == "Escolha")
    {
        alert("Selecione um estado");
        DDLEstado.focus();
        return false;
    }

    //VALIDAÇÃO DA CIDADE
    if (cidade.length < 5)
    {
        alert("Insira uma cidade");
        txtCidade.focus();
        return false;
    }
    //VALIDAÇÃO DA RUA
    if (rua.length < 7)
    {
        alert("Insira um endereço válido");
        txtRua.focus();
        return false;
    }

    //VALIDAÇÃO DO NÚMERO DA CASA
    if (num_casa.length < 1)
    {
        alert("Número de endereço válido.");
        txtNumCasa.focus();
        return false;
    }
    if (isNaN(num_casa))
    {
        alert("Número de endereço inválido.\nInsira apenas números");
        txtNumCasa.focus();
        return false;
    }

    //VALIDAÇÃO DO NÚMERO DO APARTAMENTO
    if (num_apart.length != 0)
    {
        if (isNaN(num_apart))
        {
            alert("Número de apartamento inválido.\nInsira apenas números.");
            txtNumApart.focus();
            return false;
        }
    }

    //VALIDAÇÃO DO BAIRRO
    if (bairro.length < 10)
    {
        alert("Insira um nome de bairro válido.");
        txtBairro.focus();
        return false;
    }
    //VALIDAÇÃO DO CEP
    if (cep.length < 8)
    {
        alert("Insira um CEP válido.");
        txtCep.focus();
        return false;
    }
    if (isNaN(cep) && cep.length < 9)
    {
        alert("Insira um CEP válido.");
        txtCep.focus();
        return false;
    }
    if (isNan(cep) && cep.length == 9)
    {
        btnEnvia.focus();
    }

}


    function aplicaMascara() // Essa Função vai ser só para aplicar máscaras nos campos
    { 

        var datanasc = document.getElementById("txtDtNasc").value;
        var datanasc_exp = /^(\d{2})(\d{2})(\d{4})$/;

        var cpf = document.getElementById("txtCpf").value;
        var cpf_exp = /^(\d{3})(\d{3})(\d{3})(\d{2})$/;

        var tele = document.getElementById("txtTel").value;
        var tele_exp = /(\d{2})(\d{4})(\d{4})/;

        var cel = document.getElementById("txtCel").value;
        var cel_exp = /(\d{2})(\d{1})(\d{4})(\d{4})/;
        var cel_exp10 = /(\d{2})(\d{4})(\d{4})/;

        var cep = document.getElementById("txtCep").value;
        var cep_exp = /(\d{5})(\d{3})/;

        if (datanasc.length = 8)
        {
            datanasc = datanasc.replace(datanasc_exp, '$1/$2/$3');
            document.getElementById("txtDtNasc").value = datanasc;
        }

        if (cpf.length = 11)
        {
            cpf = cpf.replace(cpf_exp, '$1.$2.$3-$4');
            document.getElementById("txtCpf").value = cpf;
        }
        if (tele.length = 10)
        {
            tele = tele.replace(tele_exp, '($1)$2-$3');
            document.getElementById("txtTel").value = tele;
        }
        if (cel.length = 11)
        {
            cel = cel.replace(cel_exp, '($1)$2-$3-$4');
            document.getElementById("txtCel").value = cel;
        }
        if (cel.length = 10)
        {
            cel = cel.replace(cel_exp10, '($1)$2-$3');
            document.getElementById("txtCel").value = cel;
        }
        if (cep.length = 8)
        {
            cep = cep.replace(cep_exp, '$1-$2');
            document.getElementById("txtCep").value = cep;
        }

    }


    //FUNÇÕES PARA RETIRAR MÁSCARAS DOS CAMPOS QUANDO O USUÁRIO FOCAR O CAMPO QUE TIVER MÁSCARA

function retiraMascaraTel()
    {

        var tele = document.getElementById("txtTel").value;
        var tele_exp = /[^0-9]+/g;

        if (tele.length = 14)
        {
            tele = tele.replace(tele_exp, '');
            document.getElementById("txtTel").value = tele;
        }

    }

function retiraMascaraDtNasc()
    {
        var datanasc = document.getElementById("txtDtNasc").value;
        var datanasc_exp = /[^0-9]+/g;

        if (datanasc.length = 10)
        {
            datanasc = datanasc.replace(datanasc_exp, '');
            document.getElementById("txtDtNasc").value = datanasc;
        }
    }


function retiraMascaraCel()
    {
        var cel = document.getElementById("txtCel").value;
        var cel_exp = /[^0-9]+/g;

        if (cel.length = 15)
        {
            cel = cel.replace(cel_exp, '');
            document.getElementById("txtCel").value = cel;
        }
    }


function retiraMascaraCpf()
    {
    var cpf = document.getElementById("txtCpf").value;
    var cpf_exp = /[^0-9]+/g;

        if (cpf.length = 14)
        {
            cpf = cpf.replace(cpf_exp, '');
            document.getElementById("txtCpf").value = cpf;
        }
    }


function retiraMascaraCep()
{
        var cep = document.getElementById("txtCep").value;
        var cep_exp = /[^0-9]+/g;

        if (cep.length = 9)
        {
            cep = cep.replace(cep_exp, '');
            document.getElementById("txtCep").value = cep;
        }

    }
