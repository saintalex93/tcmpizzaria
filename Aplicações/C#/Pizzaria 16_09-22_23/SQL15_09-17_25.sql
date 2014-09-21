Use master
GO
IF exists (SELECT name from master.dbo.sysdatabases where name = 'Pizzaria')
DROP DATABASE Pizzaria

GO

create database Pizzaria
go

use Pizzaria

go
create table Cliente(
Cod_Cliente INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Cliente VARCHAR(40),
CPF_Cliente VARCHAR(15),
Endereco_Cliente VARCHAR(40),
Complemento_Cliente VARCHAR(40),
Número_Cliente INT,
CEP_Cliente VARCHAR(10),
Estado_Cliente VARCHAR(2),
Cidade_Cliente VARCHAR(20),
Email_Cliente VARCHAR(40),
Telefone_Cliente VARCHAR(15),
Celular_Cliente VarChar(15),
Bairo_Cliente Varchar(40),

insert into Cliente (Nome_Cliente,CPF_Cliente,Endereco_Cliente,Complemento_Cliente ,Número_Cliente ,CEP_Cliente,Estado_Cliente,Cidade_Cliente ,Email_Cliente ,Telefone_Cliente ,Celular_Cliente ,Bairo_Cliente) values ('sdasdasdsadasdsa','222.22-222','sdadasdasd','dasdada22','2222','222.22-222','','dasdsadsa','1sddsdsd','(11) 1111-1111','(22) 22222-2222','dasdasd')




select * from cliente









)
go
create table Permissao
(
Cod_Permissao int IDENTITY (1,1) Primary Key,
Nome_Permissao Varchar (20)
)
go
create table Funcionario
(
Cod_Funcionario INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(40),
Cargo VARCHAR(40),
CPF_Cliente VARCHAR(15),
Endereco_Cliente VARCHAR(40),
Complemento_Cliente VARCHAR(40),
Número_Cliente INT,
CEP_Cliente VARCHAR(9),
Estado_Cliente VARCHAR(2),
Cidade_Cliente VARCHAR(20),
Email_Cliente VARCHAR(40),
Cod_Permissao INT FOREIGN KEY REFERENCES Permissao(Cod_Permissao)
)
go
create table FuncPermissao
(
Cod_Func_Perm INT IDENTITY(1,1) PRIMARY KEY,
Login_ VARCHAR(20),
Senha VARCHAR(20),
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario),
Cod_Permissao INT FOREIGN KEY REFERENCES Permissao(Cod_Permissao)
)
go
create table Pedido
(
Cod_Pedido INT IDENTITY(1,1) PRIMARY KEY,
Data DATE,
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario),
Cod_Cliente INT FOREIGN KEY REFERENCES Cliente(Cod_Cliente),
)
go
create table Categoria
(
Cod_Categoria INT IDENTITY(1,1) PRIMARY KEY,
Nome_Categoria VARCHAR(30)
)

create table Produto
(
Cod_Produto INT IDENTITY(1,1) PRIMARY KEY,
Nome_Produto VARCHAR(40),
Valor_Venda DECIMAL(6,2),
Valor_Compra DECIMAL(6,2),
Validade DATE,
Qtd_Recomendavel INT,
Qtd_Estoque INT,
Sobe_Site bit,
Cod_Categoria INT FOREIGN KEY REFERENCES Categoria(Cod_Categoria)
)
go
create table Fornecedor
(
Cod_Fornecedor INT IDENTITY(1,1) PRIMARY KEY,
CNPJ_CPF INT,
Razao_Social VARCHAR(50),
Nome_Fantasia VARCHAR(50),
Nome_Banco VARCHAR(30),
Agencia VARCHAR(15),
Conta_Corrente VARCHAR(20),
Responsavel VARCHAR(30),
Celular_Responsavel VARCHAR(15),
Email_Responsavel VARCHAR(50),
Telefone_Comercial VARCHAR(40),
)
go
create table Produto_Fornecedor
(
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(Cod_Fornecedor),
)
go
create table Promocao
(
Cod_Promocao INT IDENTITY(1,1) PRIMARY KEY,
Nome_Promocao VARCHAR(40),
Descricao VARCHAR(70),
Preco_Original DECIMAL(6,2),
Preco_Promocao DECIMAL(6,2),
Vigencia DATE,
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto)
)
go

create table PedidoFornecedor
(
Cod_PedidoF INT IDENTITY(1,1) PRIMARY KEY,
Valor_PedidoF DECIMAL(10),
Data_Venda DATE,
Cod_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(Cod_Fornecedor),
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario)
)
go
create table Detalhe_Pedido
(
Cod_Detalhe INT IDENTITY(1,1) PRIMARY KEY,
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Pedido INT FOREIGN KEY REFERENCES Pedido(Cod_Pedido),
)


