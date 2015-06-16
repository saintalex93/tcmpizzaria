-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** PROCEDURES *** ----------------------
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
use pizzaria
go
create proc sp_Select_cliente
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
--EMAIL_CLIENTE ,
SENHA_CLIENTE ,
DATANASCIMENTO

from Cliente where 
(NOME_CLIENTE = @NOME_CLIENTE or @NOME_CLIENTE IS Null)and
(CPF_CLIENTE=@CPF_CLIENTE or @CPF_CLIENTE is null) and
(ENDERECO_CLIENTE=@ENDERECO_CLIENTE or @ENDERECO_CLIENTE is null) and
(NUMERO_RESIDENCIA = @NUMERO_RESIDENCIA or @NUMERO_RESIDENCIA is null) and
(NUMERO_APARTAMENTO =@NUMERO_APARTAMENTO or @NUMERO_APARTAMENTO is null) and
(BAIRRO_CLIENTE =@BAIRRO_CLIENTE or @BAIRRO_CLIENTE is null) and
(CEP_CLIENTE =@CEP_CLIENTE or @CEP_CLIENTE is null) and
(ESTADO_CLIENTE =@ESTADO_CLIENTE  or @ESTADO_CLIENTE is null) and
(CIDADE_CLIENTE =@CIDADE_CLIENTE or @CIDADE_CLIENTE is null) and
(COMPLEMENTO_CLIENTE =@COMPLEMENTO_CLIENTE or @COMPLEMENTO_CLIENTE is null) and
(TELEFONE_CLIENTE =@TELEFONE_CLIENTE or @TELEFONE_CLIENTE is null) and
(CELULAR_CLIENTE =@CELULAR_CLIENTE or @CELULAR_CLIENTE is null) and
(SENHA_CLIENTE=@SENHA_CLIENTE  or @SENHA_CLIENTE is null) and
(DATANASCIMENTO =@DATA_NASCIMENTO or @DATA_NASCIMENTO is null)
end
go
-----------------------------------------
create proc sp_Select_pedido
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
go
-----------------------------------------
create proc USP_ANDROID_HOME_SelectPedidosAEntregar
(
	@Cod_Funcionario int = null
)
as
	Begin
		select 
		p.Cod_Pedido, 
		c.Endereco_Cliente, 
		c.Numero_Residencia, 
		c.Numero_Apartamento, 
		count(dp.Cod_Detalhe) as QtdeProdutos, 
		p.EnderecoAlt,
		p.NumeroResidencialAlt,
		p.NumeroApartamentoAlt
		
		from Detalhe_Pedido dp
		inner join Pedido p on
		p.Cod_Pedido = dp.Cod_Pedido and
		p.Cod_Funcionario = @Cod_Funcionario and
		p.Estado like 'A caminho'
		inner join Cliente c on
		c.Cod_Cliente = p.Cod_Cliente
		
		group by 
		p.Cod_Pedido, 
		c.Endereco_Cliente, 
		c.Numero_Residencia, 
		c.Numero_Apartamento, 
		p.EnderecoAlt,
		p.NumeroResidencialAlt,
		p.NumeroApartamentoAlt
	End
go
-----------------------------------------
create proc USP_ANDROID_CancelarPedido
(@CodPedido varChar(10))
as
	Begin
		update Pedido
		set Estado = 'Cancelado'
		where Cod_Pedido = @CodPedido
	End
go
----------------------------------------
create proc USP_ANDROID_RealizarPedido
(@CodPedido varChar(10))
as
	Begin
		update Pedido
		set Estado = 'Realizado'
		where Cod_Pedido = @CodPedido
	End
go
-----------------------------------------
create proc USP_ANDROID_HISTORICO_SelectHistorico
(
	@Cod_Funcionario int = null
)
as
	Begin
		select 
		p.Cod_Pedido, 
		c.Endereco_Cliente, 
		c.Numero_Residencia, 
		c.Numero_Apartamento, 
		convert(char(10),p.Data,121),
		p.Hora,
		p.Estado,
		count(dp.Cod_Detalhe) as QtdeProdutos, 
		p.EnderecoAlt,
		p.NumeroResidencialAlt,
		p.NumeroApartamentoAlt
		
		from Detalhe_Pedido dp
		inner join Pedido p on
			p.Cod_Pedido = dp.Cod_Pedido and
			p.Cod_Funcionario = @Cod_Funcionario and
			(
			p.Estado like 'Realizado' or
			p.Estado like 'Cancelado'
			)
		inner join Cliente c on
			c.Cod_Cliente = p.Cod_Cliente
		
		group by 
		p.Cod_Pedido, 
		c.Endereco_Cliente, 
		c.Numero_Residencia, 
		c.Numero_Apartamento, 
		p.Estado,
		p.EnderecoAlt,
		p.NumeroResidencialAlt,
		p.NumeroApartamentoAlt,
		p.Data,
		p.Hora 

		order by
		p.Cod_Pedido desc
	End
go
-----------------------------------------
create proc USP_ANDROID_HISTORICO_SelectEstadoPedido
(
	@Cod_Pedido int = null
)
as
	Begin
		select Estado from Pedido where Cod_Pedido = @Cod_Pedido
	End
go
-----------------------------------------
create proc USP_ANDROID_DetalhesPedido_SelectProdutosPedido
(
	@Cod_Pedido int = null
)
as
	Begin
		select 
			pr.Nome_Produto,
			(
				select pr.Nome_Produto
				from Produto pr
				where 
					dp.Cod_Pedido = p.Cod_Pedido and
					dp.Cod_Produto2 = pr.Cod_Produto
			) AS 'Meia'
			
		from Produto pr
		inner join Detalhe_Pedido dp on
			dp.Cod_Produto = pr.Cod_Produto
		inner join Pedido p on
			p.Cod_Pedido = @Cod_Pedido and 
			p.Cod_Pedido = dp.Cod_Pedido
	End
go
-----------------------------------------
create proc USP_ANDROID_DetalhesPedido_SelectInfoCLiente
(
	@Cod_Cliente int = null
)
as
	Begin
		select 
			Nome_Cliente, 
			Telefone_Cliente
		from Cliente
		where Cod_Cliente = @Cod_Cliente
	End
go
-----------------------------------------
create proc USP_ANDROID_DetalhesPedido_SelectFormaPagamento
(
	@Cod_Pedido int = null
)
as
	Begin
		select 
			FormaDePagamento,
			Valor,
			ValorPago
		from Pedido
		where Cod_Pedido = @Cod_Pedido
	End
go
-----------------------------------------
create proc USP_ANDROID_DetalhesPedido_SelectInfoPedido
(
	@Cod_Pedido int = null
)
as
	Begin
		select 
			p.FormaDePagamento,
			p.Valor,
			p.ValorPago,
			p.Hora,
			c.Nome_Cliente,
			c.Celular_Cliente,
			c.Telefone_Cliente
		
		from Pedido p

		inner join Cliente c on
			Cod_Pedido = @Cod_Pedido and
			p.Cod_Cliente = c.Cod_Cliente
	End
go
-----------------------------------------
create proc USP_ANDROID_Login
(
	@Login_Funcionario varchar(30) = null,
	@Senha_Funcionario varchar(10) = null
)
as
	Begin
		select 
			f.Nome_Func,
			f.Cod_Funcionario

		from Funcionario f

		inner join Permissao p on
			f.Login_Funcionario like @Login_Funcionario and
			f.Senha_Funcionario like @Senha_Funcionario and
			f.Cod_Permissao = p.Cod_Permissao and
			f.Cod_Permissao = 4
	End
go
-----------------------------------------
create proc USP_CSharp_LOGIN
(
	@Login varchar(20),
	@Senha varchar(20)
)
as
	begin
		select 
			Cod_Permissao,
			Login_Funcionario,
			Senha_Funcionario

		from Funcionario
		
		where
			Login_Funcionario = @Login and
			Senha_Funcionario = @Senha
	end
go
-----------------------------------------
create proc [dbo].[CSharp_Atualiza_Cliente]
(
	@Cod_CLiente int = null,
	@Nome_CLiente varchar(50) = null,
	@CPF_Cliente varchar(40) = null,
	@Endereco_Cliente varchar(40) = null,
	@Numero_Residencia int = null,
	@Numero_Apartamento int = null,
	@Bairro_Cliente varchar(40) = null,
	@CEP_Cliente varchar(15) = null,
	@Estado_Cliente varchar(5) = null,
	@Cidade_Cliente varchar(40) = null,
	@Complemento_Cliente varchar(40) = null,
	@Telefone_Cliente varchar(40) = null,
	@Celular_Cliente varchar(40) = null,
	@Login_Cliente varchar(40) = null,
	@Senha_Cliente varchar(40) = null,
	@DataNascimento date = null,
	@DataCadastro date = null
)
as
	begin
		update Cliente

		set 
		Nome_Cliente = @Nome_CLiente,
		CPF_Cliente = @CPF_Cliente,
		Endereco_Cliente  = @Endereco_Cliente ,
		Numero_Apartamento   =@Numero_Apartamento,
		Numero_Residencia  =@Numero_Residencia,
		Bairro_Cliente  =@Bairro_Cliente,
		CEP_Cliente  =@CEP_Cliente ,
		Estado_Cliente  = @Estado_Cliente  ,
		Cidade_Cliente   =@Cidade_Cliente  ,
		Complemento_Cliente  =@Complemento_Cliente ,
		Telefone_Cliente  =@Telefone_Cliente  ,
		Celular_Cliente  =@Celular_Cliente,
		Login_Cliente  =@Login_Cliente,
		Senha_Cliente  =@Senha_Cliente ,
		DataNascimento  =@DataNascimento ,
		DataCadastro   =@DataCadastro 

		where Cod_Cliente = @Cod_CLiente
	end
go
------------------------------------------------
create proc [dbo].[CSharp_Delete_Funcionario]
(
	@cod_Func int = null
)
as
	Begin
		delete from Funcionario where Cod_Funcionario = @cod_Func
	end
go
------------------------------------------------
create proc [dbo].[CSharp_Insere_Cliente]
(
	--@Cod_CLiente int = null,
	@Nome_CLiente varchar(50) = null,
	@CPF_Cliente varchar(40) = null,
	@Endereco_Cliente varchar(40) = null,
	@Numero_Residencia int = null,
	@Numero_Apartamento int = null,
	@Bairro_Cliente varchar(40) = null,
	@CEP_Cliente varchar(15) = null,
	@Estado_Cliente varchar(5) = null,
	@Cidade_Cliente varchar(40) = null,
	@Complemento_Cliente varchar(40) = null,
	@Telefone_Cliente varchar(40) = null,
	@Celular_Cliente varchar(40) = null,
	@Login_Cliente varchar(40) = null,
	@Senha_Cliente varchar(40) = null,
	@DataNascimento date = null,
	@DataCadastro date = null
)
as
	begin
		insert into Cliente
		(
			Nome_Cliente,
			CPF_Cliente ,
			Endereco_Cliente ,
			Numero_Residencia ,
			Numero_Apartamento ,
			Bairro_Cliente ,
			CEP_Cliente ,
			Estado_Cliente ,
			Cidade_Cliente ,
			Complemento_Cliente ,
			Telefone_Cliente ,
			Celular_Cliente ,
			Login_Cliente ,
			Senha_Cliente ,
			DataNascimento,
			DataCadastro 
		)
		Values
		(
			--@Cod_CLiente,
			@Nome_Cliente,
			@CPF_Cliente ,
			@Endereco_Cliente ,
			@Numero_Residencia ,
			@Numero_Apartamento ,
			@Bairro_Cliente ,
			@CEP_Cliente ,
			@Estado_Cliente ,
			@Cidade_Cliente ,
			@Complemento_Cliente ,
			@Telefone_Cliente ,
			@Celular_Cliente ,
			@Login_Cliente ,
			@Senha_Cliente ,
			@DataNascimento,
			@DataCadastro 
		)
	end
go
------------------------------------------------
create proc [dbo].[CSharp_Insere_Funcionario]
(
	@NOME_Funcionario VARCHAR(40) = null,
	@CPF_Funcionario VARCHAR(15) = null,
	@Cargo_Funcionario varchar(40) = null,
	@ENDERECO_Funcionario VARCHAR(40) = null,
	@NUMERO_RESIDENCIA INT  = null,
	@BAIRRO_Funcionario VARCHAR(30) = null,
	@CEP_Funcionario VARCHAR(9) = null,
	@ESTADO_Funcionario VARCHAR(2) = null,
	@CIDADE_Funcionario VARCHAR(20) = null,
	@COMPLEMENTO_Funcionario VARCHAR(40) = null,
	@TELEFONE_Funcionario VARCHAR(40) = null,
	@CELULAR_Funcionario VARCHAR(15) = null,
	@EMAIL_Funcionario VARCHAR(40) = null,
	@Login_Funcionario varchar(30) = null,
	@SENHA_Funcionario VARCHAR(15) = null,
	@DATA_NASC date = null,
	@Salario decimal(6,2) = null,
	@cod_Permissao int = null
)
as
	declare @testi int
	Begin
		set @testi = (select cod_permissao from Permissao where Cargo =  @Cargo_Funcionario)
			Insert into Funcionario
			(
				nome_Func,
				CPF_Funcionario ,
				ENDERECO_Funcionario ,
				COMPLEMENTO_Funcionario,
				NUMERO_RESIDENCIA  ,
				CEP_Funcionario,
				ESTADO_Funcionario,
				CIDADE_Funcionario,
				BAIRRO_Funcionario,
				EMAIL_Funcionario,
				CELULAR_Funcionario,
				TELEFONE_Funcionario,
				DATA_NASC,
				Salario,
				Login_Funcionario,
				SENHA_Funcionario,
				cod_Permissao
			)
			 values
			(
				@nome_Funcionario,
				@CPF_Funcionario ,
				@ENDERECO_Funcionario ,
				@COMPLEMENTO_Funcionario,
				@NUMERO_RESIDENCIA  ,
				@CEP_Funcionario,
				@ESTADO_Funcionario,
				@CIDADE_Funcionario,
				@BAIRRO_Funcionario,
				@EMAIL_Funcionario,
				@CELULAR_Funcionario,
				@TELEFONE_Funcionario,
				@DATA_NASC,
				@Salario,
				@Login_Funcionario,
				@SENHA_Funcionario,
				@testi
			)
		end
go
------------------------------------
create proc [dbo].[CSharp_Seleciona_Cargo]
(
	@teste int = null
)
as
	Begin
		select cargo 
		from Permissao
	end
go
------------------------------------------------
create proc [dbo].[CSharp_Seleciona_Cliente]
(
	@Cod_CLiente int = null,
	@Nome_CLiente varchar(50) = null,
	@CPF_Cliente varchar(40) = null,
	@Endereco_Cliente varchar(40) = null,
	@Numero_Residencia int = null,
	@Numero_Apartamento int = null,
	@Bairro_Cliente varchar(40) = null,
	@CEP_Cliente varchar(15) = null,
	@Estado_Cliente varchar(5) = null,
	@Cidade_Cliente varchar(40) = null,
	@Complemento_Cliente varchar(40) = null,
	@Telefone_Cliente varchar(40) = null,
	@Celular_Cliente varchar(40) = null,
	@Login_Cliente varchar(40) = null,
	@Senha_Cliente varchar(40) = null,
	@DataNascimento date = null,
	@DataCadastro date = null
)
as
	begin
		select * 
		
		from Cliente

		where
		(Cod_Cliente = @Cod_CLiente  or @Cod_CLiente  is null) and
		(Nome_Cliente  like ('%' + @Nome_CLiente  + '%') or @Nome_CLiente  IS Null)and
		(replace(replace(replace(CPF_Cliente,'.',''),'_',''),'-','') like ('%' +  replace(replace(replace(replace(@CPF_Cliente,'.',''),'_',''),'-',''),' ','') + '%') or @CPF_Cliente   is null) and
		(Endereco_Cliente = @Endereco_Cliente  or @Endereco_Cliente  is null) and
		(Numero_Apartamento = @Numero_Apartamento or @Numero_Apartamento is null) and
		(Numero_Residencia = @Numero_Residencia  or @Numero_Residencia  is null) and
		(Bairro_Cliente = @Bairro_Cliente  or @Bairro_Cliente  is null) and
		(CEP_Cliente = @CEP_Cliente  or @CEP_Cliente  is null) and
		(Estado_Cliente = @Estado_Cliente  or @Estado_Cliente  IS Null)and
		(Cidade_Cliente = @Cidade_Cliente  or @Cidade_Cliente   is null) and
		(Complemento_Cliente = @Complemento_Cliente  or @Complemento_Cliente  is null) and
		(Telefone_Cliente = @Telefone_Cliente  or @Telefone_Cliente  is null) and
		(Celular_Cliente = @Celular_Cliente  or @Celular_Cliente  is null) and
		(Login_Cliente = @Login_Cliente  or @Login_Cliente  is null) and
		(Senha_Cliente = @Senha_Cliente  or @Senha_Cliente  is null) and
		(DataNascimento = @DataNascimento  or @DataNascimento  is null) and
		(DataCadastro = @DataCadastro or @DataCadastro is null)
	end
go
-------------------------------------------------
create proc USP_CSharp_GerenciamentoEntregas_Seleciona_Produtos
(
	@cod_Pedido int = null
)
as
	begin

	select 
		prod.Cod_Produto,prod.Nome_Produto,
		prod.Valor_Venda, COUNT(det.cod_produto) 

	as 
		Quantidade from Produto as prod
		inner join Detalhe_Pedido as det
		on prod.Cod_Produto = det.Cod_Produto and det.Cod_Pedido = @cod_Pedido
		group by det.Cod_Pedido, prod.Cod_Produto,prod.Nome_Produto,prod.Valor_Venda
	end
go
------------------------------------------------
create proc [dbo].[CSharp_Select_Funcionario]
(
	@Cod_Funcionario int = null,
	@NOME_Funcionario VARCHAR(40) = null,
	@CPF_Funcionario VARCHAR(15) = null,
	@ENDERECO_Funcionario VARCHAR(40) = null,
	@NUMERO_RESIDENCIA INT  = null,
	@BAIRRO_Funcionario VARCHAR(30) = null,
	@CEP_Funcionario VARCHAR(9) = null,
	@ESTADO_Funcionario VARCHAR(2) = null,
	@CIDADE_Funcionario VARCHAR(20) = null,
	@COMPLEMENTO_Funcionario VARCHAR(40) = null,
	@TELEFONE_Funcionario VARCHAR(40) = null,
	@CELULAR_Funcionario VARCHAR(15) = null,
	@EMAIL_Funcionario VARCHAR(40) = null,
	@Login_Funcionario varchar(30) = null,
	@SENHA_Funcionario VARCHAR(15) = null,
	@DATA_NASC date = null,
	@Salario decimal(6,2) = null,
	@cod_Permissao int = null
)
as
	Begin
		select
			Cod_Funcionario,
			NOME_Func ,
			CPF_Funcionario ,
			ENDERECO_Funcionario,
			NUMERO_RESIDENCIA ,
			BAIRRO_Funcionario ,
			CEP_Funcionario ,
			ESTADO_Funcionario ,
			CIDADE_Funcionario ,
			COMPLEMENTO_Funcionario,
			TELEFONE_Funcionario ,
			CELULAR_Funcionario ,
			EMAIL_Funcionario ,
			Login_Funcionario ,
			SENHA_Funcionario,
			DATA_NASC ,
			Salario ,
			cod_Permissao 

		from Funcionario
		
		where 
			(Cod_Funcionario = @Cod_Funcionario or @Cod_Funcionario is null) and
			(NOME_Func like ('%' + @NOME_Funcionario + '%') or @NOME_Funcionario IS Null)and
			(replace(replace(replace(CPF_Funcionario,'.',''),'_',''),'-','') like ('%' +  replace(replace(replace(replace(@CPF_Funcionario,'.',''),'_',''),'-',''),' ','') + '%') or @CPF_Funcionario  is null) and
			(ENDERECO_Funcionario =@ENDERECO_Funcionario or @ENDERECO_Funcionario is null) and
			(NUMERO_RESIDENCIA =@NUMERO_RESIDENCIA or @NUMERO_RESIDENCIA is null) and
			(BAIRRO_Funcionario =@BAIRRO_Funcionario or @BAIRRO_Funcionario is null) and
			(CEP_Funcionario =@CEP_Funcionario or @CEP_Funcionario is null) and
			(ESTADO_Funcionario = @ESTADO_Funcionario or @ESTADO_Funcionario IS Null)and
			(CIDADE_Funcionario  =@CIDADE_Funcionario or @CIDADE_Funcionario  is null) and
			(COMPLEMENTO_Funcionario =@COMPLEMENTO_Funcionario or @COMPLEMENTO_Funcionario is null) and
			(TELEFONE_Funcionario =@TELEFONE_Funcionario or @TELEFONE_Funcionario is null) and
			(CELULAR_Funcionario =@CELULAR_Funcionario or @CELULAR_Funcionario is null) and
			(EMAIL_Funcionario =@EMAIL_Funcionario or @EMAIL_Funcionario is null) and
			(Login_Funcionario  =@Login_Funcionario or @Login_Funcionario  is null) and
			(SENHA_Funcionario =@SENHA_Funcionario or @SENHA_Funcionario is null) and
			(DATA_NASC =@DATA_NASC or @DATA_NASC is null) and
			(Salario =@Salario or @Salario is null) and
			(cod_Permissao =@cod_Permissao or @cod_Permissao is null) 
	end
go
------------------------------------------------
create proc USP_CSharp_Entregas_SelectPedidos
(
	@Cod_Pedido int = null,
	@Data date = null, 
	@DataFim date = null, 
	@Hora varchar(5) = null, 
	@HoraFim varchar(5) = null, 
	@Valor numeric(5,2) = null,
	@Cod_Funcionario int = null,
	@Cod_Cliente INT = null,
	@FormaDePagamento varchar(40) = null,
	@Observacao varchar(40) = null,
	@Estado_Entregue varchar(40) = null,
	@Estado_Caminho varchar(40) = null,
	@Estado_Preparo varchar(40) = null,
	@Estado_Cancelado varchar(40) = null,
	@Estado_Novo varchar(40) = null
)
as
	Begin
		select
			Cod_Pedido ,
			Data ,
			Hora,
			Valor,
			Cod_Funcionario,
			Cod_CLiente,
			Estado
		from Pedido 
		where 
			(Cod_Pedido = @Cod_Pedido or @Cod_Pedido IS Null)and
			(Data>=@Data and Data <= @DataFim or @Data is null) and
			(Hora>=@Hora and Hora <=@HoraFim or @Hora is null) and
			(Valor  =@Valor or @Valor  is null) and
			(Cod_Funcionario =@Cod_Funcionario or @Cod_Funcionario is null) and
			(Cod_CLiente =@Cod_CLiente or @Cod_CLiente is null) and
			(Observacao =@Observacao or @Observacao is null) and
			(FormaDePagamento =@FormaDePagamento or @FormaDePagamento is null) and (
			(Estado like @Estado_Entregue) or
			(Estado like @Estado_Caminho) or
			(Estado like @Estado_Preparo) or
			(Estado like @Estado_Cancelado) or
			(Estado like @Estado_Novo))
	end
go
------------------------------------------------
create proc [dbo].[CSharp_Update_Funcionario]
(
	@cod_Funcionario int = null,
	@NOME_Funcionario VARCHAR(40) = null,
	@CPF_Funcionario VARCHAR(15) = null,
	@Cargo_Funcionario varchar(40) = null,
	@ENDERECO_Funcionario VARCHAR(40) = null,
	@NUMERO_RESIDENCIA INT  = null,
	@BAIRRO_Funcionario VARCHAR(30) = null,
	@CEP_Funcionario VARCHAR(9) = null,
	@ESTADO_Funcionario VARCHAR(2) = null,
	@CIDADE_Funcionario VARCHAR(20) = null,
	@COMPLEMENTO_Funcionario VARCHAR(40) = null,
	@TELEFONE_Funcionario VARCHAR(40) = null,
	@CELULAR_Funcionario VARCHAR(15) = null,
	@EMAIL_Funcionario VARCHAR(40) = null,
	@Login_Funcionario varchar(30) = null,
	@SENHA_Funcionario VARCHAR(15) = null,
	@DATA_NASC date = null,
	@Salario decimal(6,2) = null,
	@cod_Permissao int = null
)
as
	Begin
		declare @testi int
		set @testi = (select cod_permissao from Permissao where Cargo =  @Cargo_Funcionario)

		update Funcionario

		Set 
			Nome_Func = @NOME_Funcionario,
			CPF_Funcionario = @CPF_Funcionario ,
			ENDERECO_Funcionario = @ENDERECO_Funcionario,
			COMPLEMENTO_Funcionario = @COMPLEMENTO_Funcionario,
			NUMERO_RESIDENCIA  = @NUMERO_RESIDENCIA,
			CEP_Funcionario = @CEP_Funcionario,
			ESTADO_Funcionario = @ESTADO_Funcionario,
			CIDADE_Funcionario = @CIDADE_Funcionario,
			BAIRRO_Funcionario = @BAIRRO_Funcionario,
			EMAIL_Funcionario = @EMAIL_Funcionario,
			CELULAR_Funcionario = @CELULAR_Funcionario,
			TELEFONE_Funcionario = @TELEFONE_Funcionario,
			DATA_NASC = @DATA_NASC,
			Salario = @Salario,
			Login_Funcionario = @Login_Funcionario,
			SENHA_Funcionario = @SENHA_Funcionario,
			cod_Permissao = @testi

		where Cod_Funcionario = @cod_Funcionario
	end
go
------------------------------------------------
create proc USP_CSharp_GerenciamentoEntrega_UpdatePedido
(
	@Estado varchar(20) = null,
	@cod_pedido int = null
)
as 
	begin
		update Pedido 
		set Estado = @Estado 
		where Cod_Pedido = @cod_pedido
	end
go
------------------------------------------------
create proc SP_SelecionaCod
		
		@Nome_Funcionario Varchar (40)
		
		As
		Begin
		select cod_funcionario from funcionario
		where nome_func like '%' + @Nome_Funcionario + '%'
	End
go
------------------------------------------------

------------------------------------------------
create proc USP_CSharp_Promocao_BuscarPromocoesPorPalavraChave
(
	@Palavra varchar(50)
)
as
	Begin
		select 
			Cod_Promocao as [ID],
			Nome_Promocao as [Título],
			Descricao as [Descrição],
			PorcentagemDesconto as [% Desconto],
			Vigencia as [Vigência],
			sobe_promocao as [Sobe para o site],
			AcessivelATodos as [Acessível a todos] 

		from Promocao

		where
			Nome_Promocao like '%' + @Palavra + '%' 
			or
			Descricao like '%' + @Palavra + '%' 
	End
go
------------------------------------------------
create proc USP_CSharp_Promocao_BuscarPromocoesPorID
(
	@ID int
)
as
	Begin
		select 
			Cod_Promocao as [ID],
			Nome_Promocao as [Título],
			Descricao as [Descrição],
			PorcentagemDesconto as [% Desconto],
			Vigencia as [Vigência],
			sobe_promocao as [Sobe para o site],
			AcessivelATodos as [Acessível a todos] 

		from Promocao

		where Cod_Promocao = @ID
	End
go
------------------------------------------------
create proc USP_CSharp_Promocao_BuscarProdutosNaPromocao
(
	@codPromocao int
)
as
	Begin
		select 
			pd.Cod_Produto as [ID],
			pd.Nome_Produto as [Produto], 
			pd.Valor_Venda as [Preço original],
			cast(round(pd.Valor_Venda * pm.PorcentagemDesconto/100,2) as decimal(4,2)) as [Preço promocional]

		from 
			Promocao pm
			inner join ProdutoPromocao pp  on 
				pm.Cod_Promocao = pp.Cod_Promocao 
			inner join Produto pd on 
				pp.Cod_Produto = pd.Cod_Produto 
		
		where pp.Cod_Promocao = @codPromocao
	End
go
------------------------------------------------
create proc USP_CSharp_Promocao_RemoverProdutoDePromocao
(
	@CodProduto int,
	@CodPromocao int
)
as
	Begin
		delete from ProdutoPromocao 
			where 
				Cod_Produto = @CodProduto and
				Cod_Promocao = @CodPromocao
	End
go
------------------------------------------------
create proc USP_CSharp_Promocao_BuscarTodasPromocoes
As
	Begin
		select 
			Cod_Promocao as [ID],
			Nome_Promocao as [Título],
			Descricao as [Descrição],
			PorcentagemDesconto as [% Desconto],
			Vigencia as [Vigência],
			sobe_promocao as [Sobe para o site],
			AcessivelATodos as [Acessível a todos] 
			
			from Promocao
	End
Go
------------------------------------------------
create proc USP_CSharp_Promocao_InserirPromocao
(
	@Nome VARCHAR(40),
	@Descricao VARCHAR(150),
	@PorcentagemDesconto int,
	@Vigencia Date,
	@sobe_promocao INT,
	@AcessivelATodos INT
)
As
	Begin
		Insert into Promocao values
		(
			@Nome,
			@Descricao,
			@PorcentagemDesconto,
			@Vigencia,
			@sobe_promocao,
			@AcessivelATodos
		)
	End
Go
------------------------------------------------
create proc USP_CSharp_Promocao_BuscarPromocaoInserida
As
	Begin
		select 
			Cod_Promocao as [ID],
			Nome_Promocao as [Título],
			Descricao as [Descrição],
			PorcentagemDesconto as [% Desconto],
			Vigencia as [Vigência],
			sobe_promocao as [Visível no site],
			AcessivelATodos as [Acessível a todos] 
			
			from Promocao

			where Cod_Promocao = (select max(Cod_Promocao) from Promocao)
	End
Go
------------------------------------------------
create proc USP_CSharp_Promocao_AtualizarPromocao
(
	@Nome VARCHAR(40),
	@Descricao VARCHAR(150),
	@PorcentagemDesconto int,
	@Vigencia Date,
	@sobe_promocao INT,
	@AcessivelATodos INT,
	@CodPromocao int
)
As
	Begin
		Update Promocao 

		set 
			Nome_Promocao = @Nome,
			Descricao = @Descricao,
			Vigencia = @Vigencia,
			PorcentagemDesconto = @PorcentagemDesconto,
			sobe_promocao = @sobe_promocao,
			AcessivelATodos = @AcessivelATodos
			
		where cod_Promocao = @CodPromocao
	End
Go
------------------------------------------------
create proc USP_CSharp_Promocao_BuscarProdutoPalavraChave
(
	@PalavraChave VARCHAR(40)
)
As
	Begin
		select 
			cod_Produto as [ID], 
			Nome_Produto as [Produto], 
			Valor_Venda as [Preço] 
			
			from Produto 
			
			where Nome_Produto LIKE ('%' + @PalavraChave + '%')
	End
Go
------------------------------------------------
create proc USP_CSharp_Promocao_InserirProdutoEmPromocao
(
	@codProduto int,
	@codPromocao int
)
As
	Begin
		insert into ProdutoPromocao (Cod_Produto, Cod_Promocao) values (@codProduto, @codPromocao) 
	End
Go
------------------------------------------------
create proc USP_CSharp_Promocao_ExcluirPromocao
(
	@codPromocao int
)
As
	Begin
		delete from ProdutoPromocao where cod_Promocao = @codPromocao
		delete from Promocao where cod_Promocao = @codPromocao
	End
Go
------------------------------------------------
create proc USP_CSharp_Consumo_MostrarConsumo
As
	Begin
		select 
			CodConsumo as [ID],
			CodProduto as [#],
			Nome_Produto as [Produto],
			CodInsumo as [#],
			Nome_Insumo as [Insumo],
			Quantidade as [Qtde]

		from Consumo c
		inner join Produto p on c.CodProduto = p.Cod_Produto
		inner join Insumo i on i.Cod_Insumo = c.CodInsumo

		order by CodConsumo
	End
Go
------------------------------------------------
create proc USP_CSharp_Consumo_MostrarConsumoDesc
As
	Begin
		select 
			CodConsumo as [ID],
			CodProduto as [#],
			Nome_Produto as [Produto],
			CodInsumo as [#],
			Nome_Insumo as [Insumo],
			Quantidade as [Qtde]

		from Consumo c
		inner join Produto p on c.CodProduto = p.Cod_Produto
		inner join Insumo i on i.Cod_Insumo = c.CodInsumo

		order by CodConsumo desc
	End
Go
------------------------------------------------
create proc USP_CSharp_Produto_InserirProduto
(
	@Nome varchar(30),
	@Preco decimal (4,2),
	@SobeSite int
)
As
	Begin
		Insert into Produto values (@Nome, @Preco, @SobeSite)
	End
Go
------------------------------------------------
create proc USP_CSharp_Produto_ValidaExistenciaNoBanco

(
	@CodProduto int,
	@Nome varchar(30)
)
As
	Begin
		IF @CodProduto > 0
			BEGIN
    			select count(*) 
				from Produto 
				where 
					Nome_Produto like @Nome and
					Cod_Produto != @CodProduto
			END
		ELSE
			select count(*) 
			from Produto 
			where Nome_Produto = @Nome
	End
Go
------------------------------------------------
create proc USP_CSharp_Produto_MostrarTodosProdutosDesc
As
	Begin
		select 			
			Cod_Produto as [ID],
			Nome_Produto as [Produto],
			Valor_Venda as [Preço],
			Sobe_Site as [Sobe para o site]
		from Produto 
		where Cod_Produto > 0
		order by Nome_Produto
	End
Go
------------------------------------------------
create proc USP_CSharp_Produto_BuscarProdutoPorNome
(
	@Palavra varchar(50)
)
as
	Begin
		select 
			Cod_Produto as [ID],
			Nome_Produto as [Produto],
			Valor_Venda as [Preço],
			Sobe_Site as [Sobe para o site]

		from Produto

		where
			Nome_Produto like '%' + @Palavra + '%' and
			Cod_Produto > 0

		order by Nome_Produto
	End
go
------------------------------------------------
create proc USP_CSharp_Produto_BuscarProdutoPorID
(
	@ID int
)
as
	Begin
		select 
			Cod_Produto as [ID],
			Nome_Produto as [Produto],
			Valor_Venda as [Preço],
			Sobe_Site as [Sobe para o site]

		from Produto

		where
			Cod_Produto = @ID and
			Cod_Produto > 0

		order by Nome_Produto
	End
go
------------------------------------------------
create proc USP_ASP_Pedidos_FiltraPedido
(
	@botaoClicado int,
	@codCliente int
)
as
	Begin
		if @botaoClicado = 1
			Begin
				select Data,Valor,Observacao from Pedido where Cod_Cliente = @codCliente and Estado ='Realizado' order by Data desc
			End
		else if(@botaoClicado = 2)
			Begin
				select Data,Valor,Observacao from Pedido where Cod_Cliente = @codCliente and Estado = 'Realizado' order by Data
			End
		else if(@botaoClicado = 3)
			Begin
				select Data,Valor,Observacao from Pedido where Cod_Cliente = @codCliente and Estado = 'Realizado' order by Valor desc
			End
		else if(@botaoClicado = 4)
			Begin
				select Data,Valor,Observacao from Pedido where Cod_Cliente = @codCliente and Estado = 'Realizado' order by Valor
			End
	End
go
------------------------------------------------
create proc USP_ASP_Pedidos_PedidoAtual
(
	@codCliente int
)
as
	Begin
		select prod.Nome_Produto, dp.Cod_Produto, dp.Cod_Produto2 from Detalhe_Pedido as dp inner join Pedido as p on dp.Cod_Pedido = p.Cod_Pedido and p.Cod_Cliente = @codCliente and p.Estado = 'Na Fila'  inner join Produto as prod on prod.Cod_Produto = dp.Cod_Produto
	End
	
go
------------------------------------------------
create proc USP_CSharp_Produto_MostrarTodosProdutos
As
	Begin
		select 			
			Cod_Produto as [ID],
			Nome_Produto as [Produto],
			Valor_Venda as [Preço],
			Sobe_Site as [Sobe para o site]
		from Produto 
		where Cod_Produto > 0
		order by Nome_Produto
	End
Go
------------------------------------------------
create proc USP_CSharp_Produto_AtualizarProduto
(
	@CodProduto int,
	@Nome varchar(20),
    @Preco decimal(4,2),
	@SobeSite int
)
As
	Begin
		update Produto

		set 
			Nome_Produto = @Nome,
			Valor_Venda = @Preco,
			Sobe_Site = @SobeSite

		where Cod_Produto = @CodProduto
	End
Go
------------------------------------------------
create proc USP_CSharp_Produto_RemoverProduto
(
	@codProduto int
)
as
	Begin
		/*
		O código comentado abaixo foi mantido para caso seja decido
		mudar os valores do produto nas outras tabelas ao invés de
		deletar os registros com o código do produto
		
		update ProdutoCategoria set CodProduto = 0
		update Consumo set CodProduto = 0
		update ProdutoPromocao set Cod_Produto = 0
		update Detalhe_Pedido set Cod_Produto = 0
		*/

		delete from ProdutoCategoria where CodProduto = @codProduto
		delete from Consumo where CodProduto = @codProduto
		delete from ProdutoPromocao where Cod_Produto = @codProduto
		delete from Detalhe_Pedido where Cod_Produto = @codProduto or Cod_Produto2 = @codProduto

		delete from Produto where Cod_Produto = @codProduto
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_BuscarUltimoProduto
as
	Begin
		select Nome_Produto from Produto
			where Cod_Produto = (select max(Cod_Produto) from Produto)
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_PreencherProdutos
as
	Begin
		select Nome_Produto, Cod_Produto
		from Produto
		where Cod_Produto > 0
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_PreencherInsumos
as
	Begin
		select Nome_Insumo, Cod_Insumo
		from Insumo
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_InserirConsumo
(
	@CodProduto int,
	@CodInsumo int,
	@Quantidade decimal (6,3)
)
as
	Begin
		Insert into Consumo Values
		(
			@CodInsumo,
			@CodProduto,
			@Quantidade
		)
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_BuscarConsumosPorNomeProduto
(
	@Nome varchar(20)
)
as
	Begin
		select 
			CodConsumo as [ID],
			CodProduto as [#],
			Nome_Produto as [Produto],
			CodInsumo as [#],
			Nome_Insumo as [Insumo],
			Quantidade as [Qtde]

		from Consumo c
		
		inner join 
			Produto p on c.CodProduto = p.Cod_Produto
		inner join 
			Insumo i on i.Cod_Insumo = c.CodInsumo and
			p.Nome_Produto like '%' + @Nome + '%'

	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_BuscarConsumosPorIDProduto
(
	@id int
)
as
	Begin
		select 
			CodConsumo as [ID],
			CodProduto as [#],
			Nome_Produto as [Produto],
			CodInsumo as [#],
			Nome_Insumo as [Insumo],
			Quantidade as [Qtde]

		from Consumo c
		
		inner join 
			Produto p on c.CodProduto = p.Cod_Produto
		inner join 
			Insumo i on i.Cod_Insumo = c.CodInsumo and
			p.Cod_Produto = @id

	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_BuscarConsumosPorNomeInsumo
(
	@Nome varchar(20)
)
as
	Begin
		select 
			CodConsumo as [ID],
			CodProduto as [#],
			Nome_Produto as [Produto],
			CodInsumo as [#],
			Nome_Insumo as [Insumo],
			Quantidade as [Qtde]

		from Consumo c
		
		inner join 
			Produto p on c.CodProduto = p.Cod_Produto
		inner join 
			Insumo i on i.Cod_Insumo = c.CodInsumo and
			i.Nome_Insumo like '%' + @Nome + '%'

	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_BuscarConsumosPorIdInsumo
(
	@id int
)
as
	Begin
		select 
			CodConsumo as [ID],
			CodProduto as [#],
			Nome_Produto as [Produto],
			CodInsumo as [#],
			Nome_Insumo as [Insumo],
			Quantidade as [Qtde]

		from Consumo c
		
		inner join 
			Produto p on c.CodProduto = p.Cod_Produto
		inner join 
			Insumo i on i.Cod_Insumo = c.CodInsumo and
			i.Cod_Insumo = @id

	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_ValidaExistenciaNoBanco

(
	@CodConsumo int,
	@CodProduto int,
	@CodInsumo int
)
As
	Begin
		IF @CodConsumo = 0
			BEGIN
    			select count(*) 
				from Consumo
				where 
					CodInsumo = @CodInsumo and
					CodProduto = @CodProduto
			END
		ELSE
			select count(*) 
			from Consumo
				where 
					CodConsumo != @CodConsumo and
					CodInsumo = @CodInsumo and
					CodProduto = @CodProduto
	End
Go
------------------------------------------------
create proc USP_CSharp_Consumo_AtualizarConsumo
(
	@CodConsumo int,
	@CodProduto int,
	@CodInsumo int,
	@Quantidade decimal (6,3)
)
as
	Begin
		update Consumo
		
		set 
			CodInsumo = @CodInsumo,
			CodProduto = @CodProduto,
			Quantidade = @Quantidade

		where CodConsumo = @CodConsumo
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_RemoverConsumo
(
	@id int
)
as
	Begin
		delete from Consumo where CodConsumo = @id
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_VerificaProdutoSemConsumo
as
	Begin
		SELECT count(*)

		FROM Produto p

		WHERE p.Cod_Produto NOT IN
		(
			SELECT c.CodProduto

			FROM Consumo c
		)
		and p.Cod_Produto != 0
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_VerificaConsumoVazio
as
	Begin
		SELECT count(*)

		FROM Consumo

		WHERE 
			CodProduto is null or
			CodInsumo is null
	End
go
------------------------------------------------
create proc USP_CSharp_Consumo_MostrarProdutoInserido
as
	Begin
		SELECT Cod_Produto

		FROM Produto

		WHERE 
			Cod_Produto = (select max(Cod_Produto) from Produto)
	End
go
------------------------------------------------
create proc USP_CSharp_Categoria_BuscarCategorias
as
	Begin
		SELECT NomeCategoria, CodCategoria FROM Categoria order by NomeCategoria
	End
go
------------------------------------------------
create proc USP_CSharp_Categoria_InserirCategoria
(
	@NomeCategoria varchar (20)
)

as
	Begin
		insert into Categoria values(@NomeCategoria)
	End
go
------------------------------------------------
create proc USP_CSharp_Categoria_RemoverCategoria

	@codCategoria int

as
	Begin
		delete from Categoria where CodCategoria = @codCategoria
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_PreencherProdutos
as
	Begin
		select Nome_Produto, Cod_Produto from Produto where Cod_Produto > 0
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_PreencherInsumos
as
	Begin
		select Nome_Insumo, Cod_Insumo from Insumo 
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_AlterarCategoria

	@NomeCategoria varchar(20),
	@CodCategoria int

as
	Begin
		update Categoria 
		
		set NomeCategoria = @NomeCategoria 
		
		where CodCategoria = @CodCategoria
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_PreencherProdutosNaCategoria

	@CodCategoria int

as
	Begin
		select p.Nome_Produto, p.Cod_Produto 
		
		from ProdutoCategoria pc

		inner join Produto p on
			pc.CodCategoria = @CodCategoria and
			p.Cod_Produto = pc.CodProduto

			order by Nome_Produto
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_PreencherInsumosNaCategoria

	@CodCategoria int

as
	Begin
		select i.Nome_Insumo, i.Cod_Insumo
		
		from InsumoCategoria ic

		inner join Insumo i on
			ic.CodCategoria = @CodCategoria and
			i.Cod_Insumo = ic.CodInsumo 
			
		order by Nome_Insumo
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_InserirProdutoNaCategoria

	@CodProduto int,
	@CodCategoria int

as
	Begin
		insert into ProdutoCategoria values (@CodProduto, @CodCategoria)
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_ValidaProdutoCategoria

	@CodProduto int,
	@CodCategoria int

as
	Begin
		select count(*)
		From ProdutoCategoria
		where 
			CodCategoria = @CodCategoria and
			CodProduto = @CodProduto
	End
go
---------------------------------------------------
create proc USP_CSharp_Login_ValidarUsuario

	@Login varchar (20),
	@Senha varchar (20)

as
	Begin
		select Cod_Funcionario
		from Funcionario
		where 
			Login_Funcionario = @Login and 
			Senha_Funcionario = @Senha
	End
go
---------------------------------------------------
create proc USP_CSharp_Consumo_CancelarInsercao
as
	Begin
		delete from Consumo where CodProduto = (select max(Cod_Produto) from Produto)
		delete from Produto where Cod_Produto = (select max(Cod_Produto) from Produto)
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_ValidarCategoriaNoBanco

	@CodCategoria int,
	@NomeCategoria varchar(20)

as
	Begin
		if @CodCategoria = 0
			select count(*) 
			from Categoria 
			where NomeCategoria = @NomeCategoria
		else
			select count(*) 
			from Categoria 
			where 
				NomeCategoria = @NomeCategoria and
				CodCategoria != @CodCategoria
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_ValidaProdutoNaCategoria

	@CodProduto int,
	@CodCategoria int

as
	Begin
		select count(*)
		From ProdutoCategoria
		where 
			CodCategoria = @CodCategoria and
			CodProduto = @CodProduto
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_RemoverProdutoDaCategoria

	@CodCategoria int,
	@CodProduto int

as
	Begin
		delete from ProdutoCategoria
		where 
			CodProduto = @CodProduto and
			CodCategoria = @CodCategoria
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_ValidaExclusaoCategoria

	@CodCategoria int

as
	Begin
		select
		(select count(*) from ProdutoCategoria where CodCategoria = @CodCategoria)
		+
		(select count(*) from InsumoCategoria where CodCategoria = @CodCategoria)
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_ValidaInsumoNaCategoria

	@CodInsumo int,
	@CodCategoria int

as
	Begin
		select count(*)
		From InsumoCategoria
		where 
			CodCategoria = @CodCategoria and
			CodInsumo = @CodInsumo
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_InserirInsumoNaCategoria

	@CodInsumo int,
	@CodCategoria int

as
	Begin
		insert into InsumoCategoria values (@CodInsumo, @CodCategoria)
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_RemoverInsumoDaCategoria

	@CodCategoria int,
	@CodInsumo int

as
	Begin
		delete from InsumoCategoria
		where 
			CodInsumo = @CodInsumo and
			CodCategoria = @CodCategoria
	End
go
---------------------------------------------------
create proc USP_CSharp_Categoria_CancelarSequenciaDeCadastroDeProduto
as
	Begin
		delete from ProdutoCategoria where CodProduto = (select max(Cod_Produto) from Produto)
		delete from Consumo where CodProduto = (select max(Cod_Produto) from Produto)
		delete from Produto where Cod_Produto = (select max(Cod_Produto) from Produto)
	End
go
---------------------------------------------------
create proc USP_CSharp_ConfirmacaoAlterarStatus_AbaterInsumo

	@CodProduto int

as
	Begin
		update i
		set QtdeEmEstoque -= c.Quantidade
		from Insumo i
		inner join Consumo c on
			i.Cod_Insumo = c.CodConsumo and c.CodProduto = @CodProduto
	End
go
---------------------------------------------------
create proc USP_CSharp_ConfirmacaoAlterarStatus_ProdutosNoPedido

	@CodPedido int

as
	Begin
		Select Cod_Produto From Detalhe_Pedido where Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_ConfirmacaoAlterarStatus_ChecarEstadoPedido

	@CodPedido int

as
	Begin
		Select Estado From Pedido where Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_Entregas_SelecionaEntregadores
as
	Begin
		Select Nome_Func, Cod_Funcionario 
		From Funcionario 
		where Cod_Permissao = 4
		order by Nome_Func
	End
go
---------------------------------------------------
create proc USP_CSharp_Entregas_AtribuirEntregador

	@CodPedido int,
	@CodFuncionario int

as
	Begin
		update Pedido set Cod_Funcionario = @CodFuncionario where Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarClientesPorNome

	@Nome varchar(30)

as
	Begin
		select 
			Cod_Cliente [ID],
			Nome_Cliente [Nome],
			CPF_Cliente [CPF]
			
		From Cliente 
		
		where Nome_Cliente like '%' + @Nome + '%'
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarClientesPorCPF

	@CPF varchar(15)

as
	Begin
		select 
			Cod_Cliente [ID],
			Nome_Cliente [Nome],
			CPF_Cliente [CPF]
			
		From Cliente 
		
		where CPF_Cliente like '%' + @cpf + '%'
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarPedidosDoCliente

	@CodCliente int

as
	Begin
		select 
			Cod_Pedido [ID],
			Data,
			Hora
		
		from Pedido
		
		where Cod_Cliente = @CodCliente
		order by Data desc
	End
go
---------------------------------------------------
create proc CSharp_Seleciona_pedido
(
	@data_inicial varchar(50) = null,
	@data_final varchar(50) = null
)
as
begin
	
	select * from Pedido
	where
	Data between @data_inicial and @data_final or @data_inicial is null and @data_final is null
	
end
---------------------------------------------------
go
create proc USP_CSharp_Pedidos_InserirNovoPedido

	@CodCliente int,
	@Data date,
	@Hora time

as
	Begin
	insert into Pedido 
	(
		Cod_Cliente,
		Data,
		Hora,
		Valor
	)
	values
	(
		@CodCliente,
		@Data,
		@Hora,
		0
	)
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_ValidarExclusaoDePedido	

	@CodPedido int

as
	Begin
		select count(*)

		from Detalhe_Pedido

		where Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_ExcluirPedido

	@CodPedido int

as
	Begin
		delete from Pedido where Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarProdutosDoPedido

	@CodPedido int

as
	Begin
		select 
			
			pr.Cod_Produto [ID Produto], 
			pr.Nome_Produto [Produto], 
			pr.Valor_Venda [Preço] 
			
			From Pedido pe
			inner join Detalhe_Pedido dp on 
				pe.Cod_Pedido = dp.Cod_Pedido 
			inner join Produto pr on 
				dp.Cod_Produto = pr.Cod_Produto and
				dp.Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarProdutosPorPalavraChave

	@Nome varchar(20)

as
	Begin
		select 
			Cod_Produto [ID], 
			Nome_Produto [Produto], 
			Valor_Venda [Preço] 
			
			From Produto

			Where 
				Nome_Produto like '%' + @Nome + '%' and
				Cod_Produto > 0

	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarProdutosPorID

	@ID int
	
as
	Begin
		select 
			Cod_Produto [ID], 
			Nome_Produto [Produto], 
			Valor_Venda [Preço] 
			
			From Produto

			Where 
				Cod_Produto like @ID and
				Cod_Produto > 0
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_BuscarTodosProdutos
as
	Begin
		select 
			Cod_Produto [ID], 
			Nome_Produto [Produto], 
			Valor_Venda [Preço] 
			
			From Produto

			Where Cod_Produto > 0
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_InserirProdutoNoPedido

	@CodProduto int,
	@CodPedido int

as
	Begin
		Insert into Detalhe_Pedido 
		(
			Cod_Produto,
			Cod_Pedido
		)
		values
		(
			@CodProduto,
			@CodPedido
		)
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_AtualizarValor

	@CodPedido int,
	@Valor decimal(5,2)

as
	Begin
		Update Pedido 
		
		Set Valor = @Valor

		Where Cod_Pedido = @CodPedido
	End
go
---------------------------------------------------
create proc USP_CSharp_Pedidos_ExcluirProdutoDoPedido

	@CodPedido int,
	@CodProduto int

as
	Begin
		Delete From Detalhe_Pedido
		Where 
			Cod_Pedido = @CodPedido and
			Cod_Produto = @CodProduto
	End
go
---------------------------------------------------
create proc USP_CSharp_Funcionarios_BuscarCargos
as
	Begin
		Select Cargo, Cod_Permissao
		From Permissao
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_BuscarFornecedoresPorPalavraChave

	@Palavra varchar(20)

as
	Begin
		Select 
			Cod_Fornecedor [ID],
			Razao_Social [Razão social],
			Nome_Fantasia [Nome fantasia],
			Telefone_Comercial [Telefone],
			Responsavel [Contato],
			Celular_Responsavel [Celular contato]

		From Fornecedor

		Where 
			Nome_Fantasia like '%' + @Palavra + '%' or
			Razao_Social like '%' + @Palavra + '%' or
			Responsavel like '%' + @Palavra + '%'
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_BuscarFornecedoresPorID

	@CodFornecedor int

as
	Begin
		Select 
			Cod_Fornecedor [ID],
			Razao_Social [Razão social],
			Nome_Fantasia [Nome fantasia],
			Telefone_Comercial [Telefone],
			Responsavel [Contato],
			Celular_Responsavel [Celular contato]

		From Fornecedor

		Where 
			Cod_Fornecedor = @CodFornecedor
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_SelectFornecedores
as
	Begin
		Select 
			Cod_Fornecedor [ID],
			Razao_Social [Razão social],
			Nome_Fantasia [Nome fantasia],
			Telefone_Comercial [Telefone],
			Responsavel [Contato],
			Celular_Responsavel [Celular contato]

		From Fornecedor
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_SelectFuncionarios
as
	Begin
		Select 
			Cod_Funcionario,
			Nome_Func

		From Funcionario

		Order by Nome_Func
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_BuscarComprasComFornecedor

	@CodFornecedor int

as
	Begin
		Select 
		cf.Cod_Compra [ID],
		cf.Valor_Compra [Valor],
		cf.Data_Venda [Data],
		f.Nome_Func [Funcionário]
		
		
		From CompraFornecedor cf

		Inner join Funcionario f on
			Cod_Fornecedor = @CodFornecedor and
			cf.Cod_Funcionario = f.Cod_Funcionario

		order by cf.Cod_Compra desc
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_PreencherComboBoxFornecedores
as
	Begin
		Select 
			Cod_Fornecedor,
			Nome_Fantasia

		From Fornecedor
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_RegistrarCompra

	@CodFuncionario int,
	@CodFornecedor int,
	@Data Date

as
	Begin
		Insert Into CompraFornecedor
		(
			Cod_Fornecedor,
			Cod_Funcionario,
			Data_Venda,
			Valor_Compra
		)
		Values
		(
			@CodFornecedor,
			@CodFuncionario,
			@Data,
			0
		)
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_SelectInsumos
as
	Begin
		Select
			Cod_Insumo,
			Nome_Insumo

		From Insumo
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_BuscarInsumosNaCompra

	@CodCompra int

as
	Begin
		Select
			i.Cod_Insumo [ID Insumo],
			i.Nome_Insumo [Insumo],
			dc.valor_insumo [Valor],
			dc.qdt_comprada [Qtde],
			i.Medida

		From DetalheCompra dc

		Inner join Insumo i on
		 i.Cod_Insumo = dc.cod_insumo and
		 Cod_Compra = @CodCompra

		 order by i.Nome_Insumo
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_InserirInsumoNaCompra

	@CodCompra int,
	@CodFornecedor int,
	@CodInsumo int,
	@Quantidade decimal (7,2),
	@Valor decimal (7,2)

as
	Begin
		Insert Into DetalheCompra
		(
			cod_compra,
			cod_fornecedor,
			cod_insumo,
			qdt_comprada,
			valor_insumo
		)
		Values
		(
			@CodCompra,
			@CodFornecedor,
			@CodInsumo,
			@Quantidade,
			@Valor
		)
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_ValidarAssociacoesNoBanco

	@CodCompra int

as
	Begin
		Select count(*)

		From DetalheCompra

		Where cod_compra = @CodCompra
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_ExcluirCompra

	@CodCompra int

as
	Begin
		Delete From CompraFornecedor Where Cod_Compra = @CodCompra
	End
go
---------------------------------------------------
create proc USP_CSharp_Compras_AtualizarCompra

	@CodCompra int,
	@CodFuncionario int,
	@Data Date

as
	Begin
		Update CompraFornecedor 
		
		Set
			Cod_Funcionario	=	@CodFuncionario,
			Data_Venda		=	@Data

		Where Cod_Compra = @CodCompra

/*		Update DetalheCompra

		Set
			cod_fornecedor
	*/End
go
---------------------------------------------------
create proc USP_CSharp_Compras_AtualizarPrecoCompra

	@CodCompra int,
	@ValorCompra decimal (7,2)
as
	Begin
		Update CompraFornecedor 
		
		Set Valor_Compra = @ValorCompra

		Where Cod_Compra = @CodCompra

		End
go
---------------------------------------------------
create proc USP_CSharp_Compras_ValidarExistenciaInsumoNaCompra

	@CodCompra int,
	@CodInsumo int

as
	Begin
		Select count(*)
		
		From DetalheCompra

		Where 
			Cod_Compra = @CodCompra and
			cod_insumo = @CodInsumo

		End
go
---------------------------------------------------
create proc USP_CSharp_Compras_ExcluirInsumoDaCompra

	@CodCompra int,
	@CodInsumo int

as
	Begin
		Delete DetalheCompra
		
		Where 
			Cod_Compra = @CodCompra and
			cod_insumo = @CodInsumo

		End
go
---------------------------------------------------
create proc USP_CSharp_Insumos_ValidaExistente

	@Nome varchar(20)

as
	Begin
		Select count(*) 

		From Insumo
		
		Where 
			Nome_Insumo = @Nome
	End
go
---------------------------------------------------
create proc USP_CSharp_Insumos_InserirInsumo

	@Nome				varchar(20),
    @Medida				varchar(20),
    @Validade			varchar(20),
    @Fabricacao			Date,
    @QtdEstoque			decimal(7,2),
    @QtdRecomendavel	decimal (7,2)

as
	Begin
		Insert Into Insumo
		(
			Nome_Insumo,
			Medida,
			Validade,
			Fabricacao,
			QtdeEmEstoque,
			QtdeRecomendavel
		)
		Values
		(
			@Nome,
			@Medida,
			@Validade,
			@Fabricacao,
			@QtdEstoque,
			@QtdRecomendavel		
		)
	End
go
---------------------------------------------------
create proc USP_CSharp_Insumos_CarregaInsumos
as
	Begin
		Select
			Cod_Insumo			[ID],
			Nome_Insumo			[Insumo],
			QtdeRecomendavel	[Qtd Recomendavel],
			QtdeEmEstoque		[Qtd Em Estoque],
			Medida,
			Fabricacao			[Data de fabricação],
			Validade
		
		From Insumo

		Order By Cod_Insumo Desc
	End
go
---------------------------------------------------
create proc USP_CSharp_Insumos_SelecionaInsumoPorNome

	@Nome varchar(20)

as
	Begin
		Select 
			Cod_Insumo			[ID],
			Nome_Insumo			[Insumo],
			QtdeRecomendavel	[Qtd Recomendavel],
			QtdeEmEstoque		[Qtd Em Estoque],
			Medida,
			Fabricacao			[Data de fabricação],
			Validade
		
		From Insumo

		Where Nome_Insumo like '%' + @Nome + '%'

		Order By Cod_Insumo Desc
	End
go
---------------------------------------------------
create proc USP_CSharp_Insumos_SelecionaInsumoPorID

	@ID int

as
	Begin
		Select 
			Cod_Insumo			[ID],
			Nome_Insumo			[Insumo],
			QtdeRecomendavel	[Qtd Recomendavel],
			QtdeEmEstoque		[Qtd Em Estoque],
			Medida,
			Fabricacao			[Data de fabricação],
			Validade
		
		From Insumo

		Where Cod_Insumo = @ID

		Order By Cod_Insumo Desc
	End
go
---------------------------------------------------
create proc USP_CSharp_Insumos_AtualizarInsumo

	@CodInsumo int,
	@Nome				varchar(20),
    @Medida				varchar(20),
    @Validade			varchar(20),
    @Fabricacao			Date,
    @QtdEstoque			decimal(7,2),
    @QtdRecomendavel	decimal (7,2)

as
	Begin
		Update Insumo
		Set
			Nome_Insumo = @Nome,
			Medida = @Medida,
			Validade = @Validade,
			Fabricacao = @Fabricacao,
			QtdeEmEstoque = @QtdEstoque,
			QtdeRecomendavel = @QtdRecomendavel

		Where Cod_Insumo = @CodInsumo
	End
go


---------------------------------------Procedures Java------------------------------------------------
--------------------------------------RELATÓRIO---------------------------------------------
---TODO: mudar nome dessa proc pra se adequar à nomenclatura de entrega do Professor Luiz Ricardo
create proc USP_JAVA_Relatorios
(
	@DataInicial Date,
	@DataFinal Date,
	@BinarioFuncionario Int,
	@BinarioDespesa Int,
	@BinarioCompras Int,
	@BinarioPedidos Int,
	@BinarioPromocao Int
)	
as

declare 

	@TotalDespesa float =0.00,
	@TotalFuncionario float =0.00,
	@TotalCompras float =0.00,
	@TotalPedidos float =0.00,
	@TotalPromocao float =0.00,
	@TotalGeral float =0.00,
	@TotalPrejuizo float =0.00,
	@TotalReceita float =0.00

begin
	
	if @BinarioFuncionario = 1
	begin
			set @TotalFuncionario = (select SUM  (ValorPagamento) from Pagamento where DataExpedido between @DataInicial and @DataFinal)

			if @TotalFuncionario is null
			begin
			set @TotalFuncionario = 0
			end

	end
	

	if @BinarioDespesa = 1
	begin

			set @TotalDespesa = (select  sum(ValorDespesa) from despesa where DataPagamento between @DataInicial and @DataFinal)

			if @TotalDespesa is null
			begin
			set @TotalDespesa = 0
			end

	end

	if @BinarioCompras = 1
	begin

			set @TotalCompras = (select SUM (Valor_Compra) from CompraFornecedor where Data_Venda between @DataInicial and @DataFinal)

			if @TotalCompras is null
			begin
			set @TotalCompras = 0
			end

	end

	if @BinarioPedidos = 1
	begin
			set @TotalPedidos = (select SUM (ValorPago) from Pedido where estado <>  'Cancelado' and Data between @DataInicial and @DataFinal)

			if @TotalPedidos is null
			begin
			set @TotalPedidos = 0
			end

	end

	if @BinarioPromocao = 1
	begin
			set @TotalPromocao = (select sum (produtos.Valor_Venda) as ValorTotal from Promocao as promocao inner join ProdutoPromocao as produtoPromo on
                        produtoPromo.Cod_Promocao = promocao.Cod_Promocao inner join Produto as produtos on produtos.Cod_Produto = 
                        produtoPromo.Cod_Produto inner join Detalhe_Pedido as Dp on Dp.Cod_Produto = produtos.Cod_Produto inner join Pedido
                        as pedido on pedido.Cod_Pedido = Dp.Cod_Pedido and Data Between @DataInicial and @DataFinal)


			if @TotalPromocao is null
			begin
			set @TotalPromocao = 0
			end
			
	end

	set @TotalPrejuizo = (@TotalDespesa + @TotalFuncionario + @TotalCompras) 
	Set @TotalReceita = @TotalPedidos
	set @TotalGeral = @TotalReceita - @TotalPrejuizo 
	

		Select 

		@TotalPromocao as Promocoes,
		@TotalPedidos as Pedidos,
		@TotalCompras as Compras,
		@TotalFuncionario as Funcionario,
		@TotalDespesa as Despesa,
		
		@TotalPrejuizo as Prejuizo, 
		@TotalReceita as Receita, 
		@TotalGeral as TotalGeral
		
		
		end
go
-------------------------------------------------------ProcInserirTipoDespesa------------------------------------------------------------
create proc JAVA_USP_InserirTipoDespesa
 @NomeDespesa varchar (40)
 
 
 AS
 
 declare @SituacaoDespesa varchar (20)
 
 begin
 
 
 set @SituacaoDespesa = 'Ativo'
 
 insert into TipoDespesa (NomeDespesa, SituacaoDespesa) values (@NomeDespesa, @SituacaoDespesa)
 
 end
go
-------------------------------------------------------ProcAlterarTipoDespesa------------------------------------------------------------
create proc JAVA_USP_AlterarTipoDespesa

@CodDespesa int,
@NomeDespesa varchar (30),
@SituacaoDespesa varchar (20)

as
begin

update TipoDespesa set NomeDespesa = @NomeDespesa, SituacaoDespesa = @SituacaoDespesa where codTipoDespesa = @CodDespesa

end
go
--------------------------------------------------ProcAlterarSenha------------------------------------------------------------------- 
create proc JAVA_USP_AlterarSenha
 @Cod_Funcionario int,
 @Login_funcionario Varchar (50),
 @Senha_Funcionario Varchar (20),
 @Cod_Permissao int
 as
 begin
 
 Update Funcionario set Login_funcionario = @Login_funcionario, Senha_Funcionario = @Senha_Funcionario, Cod_Permissao = @Cod_Permissao where Cod_Funcionario = @Cod_Funcionario
 
 
 end
 
 
 


go
--------------------------------------------------------ProcLançaValores------------------------------------------------------------------
create proc JAVA_USP_LancarDespesa
(
@TipoDespesa int,
@ValorDespesa float,
@DataPagamento date,
@DataVencimento date
)
as
begin

Insert into Despesa(TipoDespesa, ValorDespesa, DataPagamento, DataVencimento) values (@TipoDespesa,@ValorDespesa,@DataPagamento,@DataVencimento)

end
go
---------------------------------------------------------PagamentoFuncionario-------------------------------------------------------------
create proc JAVA_USP_LancamentoFuncionario
@ValorPagamento float,
@DataExpedido date,
@TipoPagamento varchar (30),
@CodFuncionario int
as
begin
	insert into Pagamento (ValorPagamento, DataExpedido, TipoPagamento, Cod_Funcionario)
	Values (@ValorPagamento, @DataExpedido, @TipoPagamento, @CodFuncionario)
end
go

----------------------------------------------------------------------------------------------------------------------------------------------
create proc JAVA_USP_AlteracaoFuncionario
@ValorPagamento float,
@DataExpedido date,
@TipoPagamento varchar (30),
@CodFuncionario int,
@codDespesa int
as
begin
	update Pagamento set ValorPagamento = @ValorPagamento, DataExpedido = @DataExpedido, TipoPagamento = @TipoPagamento, Cod_Funcionario = @CodFuncionario
	where cod_pagamento = @codDespesa
end
go
---------------------------------------------------------Lembretes-------------------------------------------------------------
create procedure USP_JAVA_INSERELEMBRETE
(

@codFuncionario int,
@Assunto varchar (100),
@Mensagem varchar (500),
@DataCriacao date,
@DataAviso date, 
@Aviso int


)
as

begin

insert into Lembretes (codFuncionario,Assunto,Mensagem,DataCriacao,DataAviso,Aviso) 
values (@codFuncionario, @Assunto, @Mensagem, @DataCriacao, @DataAviso, @Aviso )

end
go
---------------------------------------------------------Lembretes-------------------------------------------------------------
create procedure USP_JAVA_ALTERALEMBRETE
(
@codLembrete int,
@codFuncionario int,
@Assunto varchar (100),
@Mensagem varchar (500),
@DataAviso date, 
@Aviso int

)
as

begin

Update Lembretes set codFuncionario = @codFuncionario,Assunto = @Assunto,
Mensagem = @Mensagem,DataAviso = @DataAviso, Aviso = @Aviso where codLembrete = @codLembrete


end

---------------------------------------------------------Lembretes-------------------------------------------------------------

go
----------------
create procedure USP_JAVA_EXCLUILEMBRETE
(
@codLembrete int

)
as

begin

delete Lembretes where codLembrete = @codLembrete

end


go
---------------------------------------------------------Backup-------------------------------------------------------------
create procedure USP_JAVA_BACKUP
(@Caminho varchar (200))

as

begin


BACKUP DATABASE Pizzaria TO DISK = @Caminho
 WITH FORMAT, MEDIANAME = 'GiovanellisBackup', NAME = 'GiovanellisBackup';

end

go
--------------------------------------------------------Mensagens----------------------------------------------------------
create procedure USP_JAVA_ENVIARMENSAGEM
(
@codRemetente int,
@CodDestinatario int,
@Assunto varchar (100),
@Mensagem varchar (1000)
)

as
declare @Aviso int
set @Aviso = 1
Declare @DataCriacao date
set @DataCriacao = GETDATE()
Declare @HoraCriacao time
set @HoraCriacao =  Convert(Char(8),GetDate(),114)

begin

insert into Mensagens 
(
CodRemetente, CodDestinatario, Assunto, Mensagem, DataCriacao,HoraCriacao, Aviso
)
values
(
@codRemetente, @CodDestinatario, @Assunto, @Mensagem, @DataCriacao,@HoraCriacao, @Aviso
)

End


go
-----------------------------------------------------------------------------------------------------------------------------------
create procedure USP_JAVA_RESPONDERMENSAGEM
(
@CodMensagem int,
@Mensagem varchar (1000),
@Assunto varchar (100),
@codRemetente int,
@CodDestinatario int
)

as
declare @Aviso int
set @Aviso = 1
Declare @DataCriacao date
set @DataCriacao = GETDATE()
Declare @HoraCriacao time
set @HoraCriacao =  Convert(Char(8),GetDate(),114)

begin


update Mensagens set CodRemetente = @codRemetente, CodDestinatario = @CodDestinatario, Mensagem = @Mensagem, Assunto = @Assunto, Aviso =@Aviso, DataCriacao = @DataCriacao,  HoraCriacao = @HoraCriacao
where CodMensagem = @CodMensagem

end

go
--------------------------------------------------------------------------------------------------------------------------------------
create procedure USP_JAVA_ENCAMINHARMENSAGEM
(
@codRemetente int,
@CodDestinatario int,
@Assunto varchar (100),
@Mensagem varchar (1000)
)

as
declare @Aviso int
set @Aviso = 1
Declare @DataCriacao date
set @DataCriacao = GETDATE()
Declare @HoraCriacao time
set @HoraCriacao =  Convert(Char(8),GetDate(),114)

begin

insert into Mensagens 
(
CodRemetente, CodDestinatario, Assunto, Mensagem, DataCriacao,HoraCriacao, Aviso
)
values
(
@codRemetente, @CodDestinatario, @Assunto, @Mensagem, @DataCriacao,@HoraCriacao, @Aviso
)

End

go

-----------------------------------------------------------------------------------------------
Create procedure USP_JAVA_DELETARMENSAGEM
@CodMensagem int

as

begin

delete from Mensagens where CodMensagem = @CodMensagem

end

