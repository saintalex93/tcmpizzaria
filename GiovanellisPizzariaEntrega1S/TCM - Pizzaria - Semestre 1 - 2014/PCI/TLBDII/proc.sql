use Pizzaria 

create procedure sp_Select_cliente
(
@NOME_CLIENTE VARCHAR(40) = null,
@Param1 VARCHAR(40) = null, 
@CPF_CLIENTE VARCHAR(15) = null,
@ENDERECO_CLIENTE VARCHAR(40) = null,
@NUMERO_RESIDENCIA INT = null,
@NUMERO_APARTAMENTO INT = null,
@BAIRRO_CLIENTE VARCHAR(30)= null,
@CEP_CLIENTE VARCHAR(9)= null,
@ESTADO_CLIENTE VARCHAR(2)= null,
@CIDADE_CLIENTE VARCHAR(20)= null,
@COMPLEMENTO_CLIENTE VARCHAR(40)= null,
@TELEFONE_CLIENTE VARCHAR(40)= null,
@CELULAR_CLIENTE VARCHAR(15)= null,
@EMAIL_CLIENTE VARCHAR(40)= null,
@SENHA_CLIENTE VARCHAR(15)= null,
@DATA_NASCIMENTO VARCHAR(10)= null

)
as
Begin
select

NOME_CLIENTE ,
CPF_CLIENTE ,
ENDERECO_CLIENTE ,
NUMERO_RESIDENCIA  ,
NUMERO_APARTAMENTO  ,
BAIRRO_CLIENTE ,
CEP_CLIENTE ,
ESTADO_CLIENTE ,
CIDADE_CLIENTE ,
COMPLEMENTO_CLIENTE ,
TELEFONE_CLIENTE ,
CELULAR_CLIENTE ,
EMAIL_CLIENTE ,
SENHA_CLIENTE ,
DATANASCIMENTO


from Cliente where 
(NOME_CLIENTE = @NOME_CLIENTE or @NOME_CLIENTE IS Null)and
(CPF_CLIENTE=@CPF_CLIENTE or @CPF_CLIENTE is null) and
(ENDERECO_CLIENTE=@ENDERECO_CLIENTE or @ENDERECO_CLIENTE is null) and
(NUMERO_RESIDENCIA  =@NUMERO_RESIDENCIA or @NUMERO_RESIDENCIA  is null) and
(NUMERO_APARTAMENTO =@NUMERO_APARTAMENTO or @NUMERO_APARTAMENTO is null) and
(BAIRRO_CLIENTE =@BAIRRO_CLIENTE or @BAIRRO_CLIENTE is null) and
(CEP_CLIENTE =@CEP_CLIENTE or @CEP_CLIENTE is null) and
(ESTADO_CLIENTE =@ESTADO_CLIENTE  or @ESTADO_CLIENTE is null) and
(CIDADE_CLIENTE =@CIDADE_CLIENTE or @CIDADE_CLIENTE is null) and
(COMPLEMENTO_CLIENTE =@COMPLEMENTO_CLIENTE or @COMPLEMENTO_CLIENTE is null) and
(TELEFONE_CLIENTE =@TELEFONE_CLIENTE or @TELEFONE_CLIENTE is null) and
(CELULAR_CLIENTE =@CELULAR_CLIENTE or @CELULAR_CLIENTE is null) and
(EMAIL_CLIENTE =@EMAIL_CLIENTE or @EMAIL_CLIENTE is null) and
(SENHA_CLIENTE=@SENHA_CLIENTE  or @SENHA_CLIENTE is null) and
(DATANASCIMENTO =@DATA_NASCIMENTO or @DATA_NASCIMENTO is null)
end


create procedure [dbo].[sp_insert_cliente]
(
@NOME_CLIENTE VARCHAR(40)= null,
@CPF_CLIENTE VARCHAR(15)= null,
@ENDERECO_CLIENTE VARCHAR(40)= null,
@NUMERO_RESIDENCIA INT = null,
@NUMERO_APARTAMENTO INT = null,
@BAIRRO_CLIENTE VARCHAR(30)= null,
@CEP_CLIENTE VARCHAR(9)= null,
@ESTADO_CLIENTE VARCHAR(2)= null,
@CIDADE_CLIENTE VARCHAR(20)= null,
@COMPLEMENTO_CLIENTE VARCHAR(40)= null,
@TELEFONE_CLIENTE VARCHAR(40)= null,
@CELULAR_CLIENTE VARCHAR(15)= null,
@EMAIL_CLIENTE VARCHAR(40)= null,
@SENHA_CLIENTE VARCHAR(15)= null,
@DATA_NASCIMENTO VARCHAR(10)= null

)
as
Begin
Insert into Cliente
(
NOME_CLIENTE ,
CPF_CLIENTE ,
ENDERECO_CLIENTE ,
NUMERO_RESIDENCIA  ,
NUMERO_APARTAMENTO  ,
BAIRRO_CLIENTE ,
CEP_CLIENTE ,
ESTADO_CLIENTE ,
CIDADE_CLIENTE ,
COMPLEMENTO_CLIENTE ,
TELEFONE_CLIENTE ,
CELULAR_CLIENTE ,
EMAIL_CLIENTE ,
SENHA_CLIENTE ,
DATANASCIMENTO
)
values (@NOME_CLIENTE ,
@CPF_CLIENTE ,
@ENDERECO_CLIENTE ,
@NUMERO_RESIDENCIA  ,
@NUMERO_APARTAMENTO  ,
@BAIRRO_CLIENTE ,
@CEP_CLIENTE ,
@ESTADO_CLIENTE ,
@CIDADE_CLIENTE ,
@COMPLEMENTO_CLIENTE ,
@TELEFONE_CLIENTE ,
@CELULAR_CLIENTE ,
@EMAIL_CLIENTE ,
@SENHA_CLIENTE ,
@DATA_NASCIMENTO 

)

end



create procedure sp_Select_pedido
(
@Cod_Pedido int = null,
@Data DateTime = null, 
@Hora varchar(5) = null, 
@Valor numeric(5,2) = null,
@Cod_Funcionario int = null,
@Cod_Cliente INT = null

)
as
Begin
select

Cod_Pedido ,
Data ,
Hora,
Valor,
Cod_Funcionario,
Cod_CLiente

from Pedido where 
(Cod_Pedido = @Cod_Pedido or @Cod_Pedido IS Null)and
(Data=@Data or @Data is null) and
(Hora=@Hora or @Hora is null) and
(Valor  =@Valor or @Valor  is null) and
(Cod_Funcionario =@Cod_Funcionario or @Cod_Funcionario is null) and
(Cod_CLiente =@Cod_CLiente or @Cod_CLiente is null)

end










/*
exec sp_select_Cliente 'avulso',null,null,null,null,null,null,null,null,null,null,null,null,null,null
*/

