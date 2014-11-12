function formatar(mascara, documento)
{
    var i = documento.value.length;
    var saida = mascara.substring(0, 1);
    var texto = mascara.substring(i)

    if (texto.substring(0, 1) != saida) {
        documento.value += texto.substring(0, 1);
    }

}
function validaCampos()
{
    var data = document.getElementById("ContentPlaceHolder1_txtData").value;
    var prod = dopcument.getElementById("ContentPlaceHolder1_txtProduto").value;
    var valor = document.getElementById("ContentPlaceHolder1_txtValor").value;
    var quantidade = document.getElementById("ContentPlaceHolder1_txtQtd").value;

    if (data.length != 10)
    {
        alert("Data inválida.");
        ContentPlaceHolder1_txtData.focus();
        return false;
    }
    if (prod.length != 0)
    {
        try
        {
            parseInt(prod);
        }
        catch (erro)
        {
            alert("Produto deve ser um número");
            return false;
        };
    }
    if (valor.length != 0) {
        try {
            parseFloat(valor);
        }
        catch (error) {
            alert("Digite apenas números no valor do pedido !!");
            return false;
        }
    }
    else
    {
        alert("Valor do pedido inválido !!");
        return false;
    }
    
    if (valor.length < 3)
    {
        alert("Insira um preço válido");
        ContentPlaceHolder1_txtValor.focus();
        return false;
    }
    if (quantidade.length == null)
    {
        alert("Quantidade inválida");
        ContentPlaceHolder1_txtQtd.focus();
        return false;
    }
}