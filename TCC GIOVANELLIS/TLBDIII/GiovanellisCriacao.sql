		-------------------------------------------------------------- 
		-------------------------------------------------------------- 
		-------------------- *** SETUP INICIAL *** -------------------
		-------------------------------------------------------------- 
		-------------------------------------------------------------- 

Use master
go
-----------------------------------
set nocount on
declare @databasename varchar(100)
declare @query varchar(max)
set @query = ''

set @databasename = 'Pizzaria'
if db_id(@databasename) < 4
begin
print 'system database connection cannot be killeed'
return
end
-----------------------------------
select @query=coalesce(@query,',' )+'kill '+convert(varchar, spid)+ '; '
from master..sysprocesses where dbid=db_id(@databasename)

if len(@query) > 0
begin
print @query
exec(@query)
end
go
-----------------------------------
IF EXISTS (SELECT * from sys.databases where name = 'Pizzaria')
DROP DATABASE Pizzaria
go

		-------------------------------------------------------------- 
		-------------------------------------------------------------- 
		-------------------- *** CRIAÇÕES *** ------------------------ 
		-------------------------------------------------------------- 
		-------------------------------------------------------------- 

create database Pizzaria
go

use Pizzaria
go
-----------------------------------------
create table Cliente
(
Cod_Cliente INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Cliente VARCHAR(40),
CPF_Cliente VARCHAR(15),
Endereco_Cliente VARCHAR(40),
Numero_Residencia int,
Numero_Apartamento int,
Bairro_Cliente Varchar(30),
CEP_Cliente VARCHAR(9),
Estado_Cliente VARCHAR(2),
Cidade_Cliente VARCHAR(20),
Complemento_Cliente VARCHAR(40),
Telefone_Cliente VARCHAR(14),
Celular_Cliente VarChar (15),
Login_Cliente VARCHAR(40),
Senha_Cliente Varchar (15),
DataNascimento DATE,
DataCadastro DATE
)
go
-----------------------------------------
create table TipoDespesa
(
codTipoDespesa INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NomeDespesa VARCHAR(50) unique,
SituacaoDespesa varchar(10)
)
go
-----------------------------------------
create table Despesa
(
codDespesa INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
ValorDespesa Decimal (6,2),
DataPagamento Date,
DataVencimento Date,
TipoDespesa INT FOREIGN KEY REFERENCES TipoDespesa(codTipoDespesa)
)
go
-----------------------------------------
create table Permissao
(
Cod_Permissao int IDENTITY (1,1) Primary Key,
Cargo Varchar (20)
)
go
-----------------------------------------
create table Funcionario
(
Cod_Funcionario INT IDENTITY(1,1) PRIMARY KEY,
Nome_Func VARCHAR(40),
CPF_Funcionario VARCHAR(15),
Endereco_Funcionario VARCHAR(40),
Complemento_Funcionario VARCHAR(40),
Numero_Residencia VARCHAR(6),
CEP_Funcionario VARCHAR(10),
Estado_Funcionario CHAR(2),
Cidade_Funcionario VARCHAR(20),
Bairro_Funcionario VarChar (30),
Email_Funcionario VARCHAR(40),
Celular_Funcionario VarChar (15),
Telefone_Funcionario VarChar (14),
Data_Nasc Date,
Salario decimal(6,2),
Login_Funcionario VARCHAR(30) unique,
Senha_Funcionario VARCHAR(20),
Cod_Permissao INT FOREIGN KEY REFERENCES 
Permissao(Cod_Permissao)
)
go
-----------------------------------------
create table Categoria
(
CodCategoria int identity (1,1) Primary Key,
NomeCategoria VarChar (40)
)
go
-----------------------------------------
create table Insumo
(
Cod_Insumo INT IDENTITY(1,1) PRIMARY KEY,
Nome_Insumo VARCHAR(40),
ValorDeCompra DECIMAL (6,2),
QtdeRecomendavel decimal (6,3),
QtdeEmEstoque decimal(6,3),
Fabricacao DATE,
Validade VarChar(10),
Medida VARCHAR(10)
)
go
-----------------------------------------
create table Produto
(
Cod_Produto INT IDENTITY(0,1) PRIMARY KEY,
Nome_Produto VARCHAR(40),
Valor_Venda DECIMAL(6,2),
Sobe_Site INT
)
go
-----------------------------------------
create table Pedido
(
Cod_Pedido INT IDENTITY(1,1) PRIMARY KEY,
Data date,
Hora VarChar(5),
Valor numeric (5,2),
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario),
Cod_Cliente INT FOREIGN KEY REFERENCES Cliente(Cod_Cliente),
Observacao VarChar (140),
Origem VarChar (10),
Estado VarChar(12),
EnderecoAlt VarChar(140),
NumeroResidencialAlt VarChar(5),
NumeroApartamentoAlt VarChar(5),
BairroAlt varchar(20),
FormaDePagamento varchar(10),
ValorPago dec (6,2)
)

go
-----------------------------------------
create table Fornecedor
(
Cod_Fornecedor INT IDENTITY(1,1) PRIMARY KEY,
CNPJ_CPF varchar(18),
Razao_Social VARCHAR(50),
Nome_Fantasia VARCHAR(50),
Nome_Banco VARCHAR(30),
Agencia VARCHAR(15),
Conta_Corrente VARCHAR(20),
Responsavel VARCHAR(30),
Celular_Responsavel VARCHAR(15),
Email_Responsavel VARCHAR(50),
Telefone_Comercial VARCHAR(40),
Endereco_Fornecedor VarChar (40),
Numero_Residencia VarChar (5),
CEP_Fornecedor VarChar (10),
Estado_Fornecedor VarChar (2),
Cidade_Fornecedor VarChar (20),
Bairro_Fornecedor VarChar (30),
Complemento VarChar (40),
)
go
-----------------------------------------
create table Insumo_Fornecedor
(
Cod_InsumoFornecedor int identity (1,1) Primary Key,
Cod_Insumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
Cod_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(Cod_Fornecedor),
)
go
-----------------------------------------
create table ProdutoCategoria
(
CodProdutoCategoria int identity (1,1) Primary Key,
CodProduto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go
-----------------------------------------
create table InsumoCategoria
(
CodInsumoCategoria int identity (1,1) Primary Key,
CodInsumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go
-----------------------------------------
create table Consumo
(
CodConsumo int identity (1,1) Primary Key,
CodInsumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
CodProduto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Quantidade DECIMAL (6,3)
)
go
-----------------------------------------
create table Promocao
(
Cod_Promocao INT IDENTITY(1,1) PRIMARY KEY,
Nome_Promocao VARCHAR(40),
Descricao VARCHAR(150),
PorcentagemDesconto int,
Vigencia Date,
sobe_promocao INT,
AcessivelATodos INT
)
go
-----------------------------------------
create table ProdutoPromocao
(
codPromocaoProduto INT IDENTITY(1,1) PRIMARY KEY,
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Promocao INT FOREIGN KEY REFERENCES Promocao(Cod_Promocao)
)
go
-----------------------------------------
create table CompraFornecedor
(
Cod_Compra INT IDENTITY(1,1) PRIMARY KEY,
Valor_Compra DECIMAL(10,2),
Data_Venda DATE,
Cod_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(Cod_Fornecedor),
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario)
)
go
-----------------------------------------
create table Detalhe_Pedido
(
Cod_Detalhe INT IDENTITY(0,1) PRIMARY KEY,
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Produto2 INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Pedido INT FOREIGN KEY REFERENCES Pedido(Cod_Pedido),
)
go
-----------------------------------------
create table Pagamento
(
Cod_Pagamento INT IDENTITY(1,1) PRIMARY KEY,
ValorPagamento DECIMAL (6,2),
DataExpedido DATE,
TipoPagamento VARCHAR(20),
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario)
)
go
-----------------------------------------
create table DetalheCompra
(
codcomprainsumo int identity (1,1) primary key,
cod_compra int foreign key references comprafornecedor (cod_compra),
cod_fornecedor int foreign key references Fornecedor (cod_fornecedor),
cod_insumo int foreign key references insumo (cod_insumo),
valor_insumo decimal (6,2),
qdt_comprada decimal (6,2)
)
go
-----------------------------------------
create table Lembretes
(
codLembrete int identity (1,1) primary key,
codFuncionario int foreign key references Funcionario (Cod_Funcionario),
Assunto varchar (100),
Mensagem varchar (1000),
DataCriacao date,
DataAviso date, 
Aviso int

)
go
-----------------------------------------
create table Mensagens
(
CodMensagem int identity (1,1) primary key,
CodRemetente int foreign key references Funcionario (Cod_Funcionario),
CodDestinatario int foreign key references Funcionario (Cod_Funcionario),
Assunto varchar (100),
Mensagem varchar (1000),
DataCriacao date,
HoraCriacao time,
Aviso int
)
go