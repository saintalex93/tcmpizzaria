
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
    //Validação de conteúdo por expressão regular
        var datanasc_exp = /^([0-2]{1}[0-9]{1}|3{1}[0|1]{1})\/(01{2}|0{1}[3-9]{1}|1{1}[0-2]{1})\/([1|2]{1}[9|0]{1}[0-9]{1}[0-9]{1})$/;
        var datanasc_exp2 = /^([0-2]{1}[0-9]{1})\/(0{1}2{1})\/([1|2]{1}[9|0]{1}[0-9]{1}[0-9]{1})$/;

        var senha = document.getElementById("ContentPlaceHolder1_txtSenha").value;
        var senha_confirm = document.getElementById("ContentPlaceHolder1_txtSenhaConfirm").value;

        var estado = document.getElementById("ContentPlaceHolder1_DDLEstado").value;

        var cidade = document.getElementById("ContentPlaceHolder1_txtCidade").value;

        var rua = document.getElementById("ContentPlaceHolder1_txtRua").value;
        var rua_exp = /[a-z]/;

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
        if (isNaN(tele) && tele.length < 13) {
            alert("Número de telefone inválido.\nInsira apenas números.");
            ContentPlaceHolder1_txtTel.focus();
            return false;
        }
        if (isNaN(tele) && tele.length == 13) {
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
            if (cel.length == 13 || cel.length == 15) {
                ContentPlaceHolder1_txtEmail.focus();
            }

        }

        //VALIDAÇÃO DO EMAIL

        if (email.search(email_exp)) {
            alert("Email Inválido");
            ContentPlaceHolder1_txtEmail.focus();
            return false;
        }

        //VALIDAÇÃO DO CPF

        if (cpf.length < 11) {
            alert("Número de CPF inválido.");
            ContentPlaceHolder1_txtCpf.focus();
            return false;
        }
        if (isNaN(cpf) && cpf.length < 14) {
            alert("Número de CPF inválido.\nInsira apenas números.");
            ContentPlaceHolder1_txtCpf.focus();
            return false;
        }

    //VALIDAÇÃO DA DATA DE NASCIMENTO
        alert(datanasc);
        
        for(i = 0; datanasc.length <= 10; i++)
        {
            
        }

        if (isNaN(datanasc) && datanasc.length < 10) {
            alert("Insira apenas números na Data de Nascimento");
            ContentPlaceHolder1_txtDtNasc.focus();
            return false;
        }

        if (datanasc_exp2.test(datanasc) == false && datanasc_exp.test(datanasc) == false) {
            alert("Data de Nascimento inválida");
            ContentPlaceHolder1_txtDtNasc.focus();
            return false;
        }
        else {
            ContentPlaceHolder1_txtSenha.focus();
        }
        if (datanasc.length != 10) {
            alert("Data de Nascimento inválida");
            ContentPlaceHolder1_txtDtNasc.focus();
            return false;
        }
   
        //VALIDAÇÃO DA SENHA

        if (senha.length < 5) {
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
        if (estado == "Escolha") {
            alert("Selecione um estado");
            ContentPlaceHolder1_DDLEstado.focus();
            return false;
        }

        //VALIDAÇÃO DA CIDADE
        if (cidade.length < 3) {
            alert("Insira uma cidade");
            ContentPlaceHolder1_txtCidade.focus();
            return false;
        }
        //VALIDAÇÃO DA RUA
        if (rua.length < 1) {
            alert("Insira um endereço válido");
            ContentPlaceHolder1_txtRua.focus();
            return false;
        }

        //VALIDAÇÃO DO NÚMERO DA CASA
        if (num_casa.length < 1) {
            alert("Número de endereço válido.");
            ContentPlaceHolder1_txtNumCasa.focus();
            return false;
        }
        if (isNaN(num_casa)) {
            alert("Número de endereço inválido.\nInsira apenas números");
            ContentPlaceHolder1_txtNumCasa.focus();
            return false;
        }

        //VALIDAÇÃO DO NÚMERO DO APARTAMENTO
        if (num_apart.length != 0) {
            if (isNaN(num_apart)) {
                alert("Número de apartamento inválido.\nInsira apenas números.");
                ContentPlaceHolder1_txtNumApart.focus();
                return false;
            }
        }

        //VALIDAÇÃO DO BAIRRO
        if (bairro.length < 4) {
            alert("Insira um nome de bairro válido.");
            ContentPlaceHolder1_txtBairro.focus();
            return false;
        }
        //VALIDAÇÃO DO CEP
        if (cep.length < 8) {
            alert("Insira um CEP válido.");
            ContentPlaceHolder1_txtCep.focus();
            return false;
        }
        if (isNaN(cep) && cep.length < 9) {
            alert("Insira um CEP válido.");
            ContentPlaceHolder1_txtCep.focus();
            return false;
        }
        if (isNan(cep) && cep.length == 9) {
            ContentPlaceHolder1_btnEnvia.focus();
        }*/

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
