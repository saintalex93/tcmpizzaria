Use master
go

IF exists (SELECT name from master.dbo.sysdatabases where name = 'Pizzaria')
DROP DATABASE Pizzaria
go

create database Pizzaria
go

use Pizzaria
go

create table Cliente(
Cod_Cliente INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Cliente VARCHAR(40),
CPF_Cliente VARCHAR(15),
Endereco_Cliente VARCHAR(40),
Numero_Residencia INT,
Bairro_Cliente Varchar (30),
CEP_Cliente VARCHAR(9),
Estado_Cliente VARCHAR(2),
Cidade_Cliente VARCHAR(20),
Complemento_Cliente VARCHAR(40),
Telefone_Cliente VARCHAR(14),
Celular_Cliente VarChar (15),
Email_Cliente VARCHAR(40),
Senha_cliente Varchar (10),
DataNascimento DATE,
)
go

create table Permissao
(
Cod_Permissao int IDENTITY (1,1) Primary Key,
Cargo Varchar (30)
)
go

create table Funcionario
(
Cod_Funcionario INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(40),
CPF_Funcionario VARCHAR(15),
Endereco_Funcionario VARCHAR(40),
Complemento_Funcionario VARCHAR(40),
Numero_Residencia INT,
CEP_Funcionario VARCHAR(10),
Estado_Funcionario VARCHAR(2),
Cidade_Funcionario VARCHAR(20),
Email_Funcionario VARCHAR(40),
Bairro_Funcionario VarChar (30),
Celular_Funcionario VarChar (15),
Telefone_Funcionario VarChar (14),
Cod_Permissao INT FOREIGN KEY REFERENCES Permissao(Cod_Permissao),
Usuario_Funcionario varchar (15),
)
go

create table Insumo
(
Cod_Insumo INT IDENTITY(1,1) PRIMARY KEY,
Nome_Insumo VARCHAR(20),
ValorDeCompra DECIMAL,
QtdeRecomendavel INT,
QtdeEmEstoque INT,
Validade DATE,
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

create table Categoria
(
Cod_Categoria INT IDENTITY(1,1) PRIMARY KEY,
Nome_Categoria VARCHAR(30)
)
go

create table Produto
(
Cod_Produto INT IDENTITY(1,1) PRIMARY KEY,
Nome_Produto VARCHAR(40),
Valor_Venda DECIMAL(6,2),
Validade DATE,
Qtd_Recomendavel INT,
Qtd_Estoque INT,
Sobe_Site bit,
Cod_Categoria INT FOREIGN KEY REFERENCES Categoria(Cod_Categoria)
)
go

create table Pedido
(
Cod_Pedido INT IDENTITY(1,1) PRIMARY KEY,
Data DATE,
Hora time,
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario),
Cod_Cliente INT FOREIGN KEY REFERENCES Cliente(Cod_Cliente),
Cod_Produto INT FOREIGN KEY REFERENCES Produto (Cod_Produto),
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
Endereco_Fornecedor VarChar (40),
Numero_Residencia Int,
CEP_Fornecedor VarChar (10),
Estado_Fornecedor VarChar (2),
Cidade_Fornecedor VarChar (20),
Bairro_Fornecedor VarChar (30),
Complemento VarChar (40),
Cod_Produto INt Foreign Key References Pedido (Cod_Pedido),
)
go

create table Insumo_Fornecedor
(
Cod_Insumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
Cod_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(Cod_Fornecedor),
)
go

create table Produto_Insumo
(
Cod_Insumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
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
Valor_Venda DECIMAL(10),
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
go



use Pizzaria



insert into Funcionario (Nome,CPF_Funcionario,Endereco_Funcionario,Complemento_Funcionario,Numero_Residencia,CEP_Funcionario,Estado_Funcionario,Cidade_Funcionario ,Email_Funcionario ,Telefone_Funcionario,Celular_Funcionario ,Bairro_Funcionario) values ('EmersonGiovanelli','323.152.333-33','Endereco','COmple','232','444.44-444','-1','Cidade','email','(22) 2222-2222','(11) 11111-1111','Bairro')
delete funcionario where Cod_Funcionario=  9

select * from Funcionario
select * from Permissao
select * from FuncPermissao

select * from Produto
select * from Categoria


delete Funcionario where cod_Funcionario = '23'
update Funcionario
delete FuncPermissao where cod_Funcionario = '21'
delete Funcionario where cod_Funcionario = '21'
update FUncPermissao set Login_ = 'sadasdas',senha='12312312',cod_Permissao = '3' where cod_Funcionaro ='21'
insert into FuncPermissao (Login_,Senha,Cod_Funcionario,Cod_Permissao) values ('dasdasda','23132','17','1')
insert into Funcionario (Nome,CPF_Funcionario,Endereco_Funcionario,Complemento_Funcionario,Numero_Residencia,CEP_Funcionario,Estado_Funcionario,Cidade_Funcionario ,Email_Funcionario ,Telefone_Funcionario,Celular_Funcionario ,Bairro_Funcionario) values ('EmersonGiovanelli','333.333.333-33','Endereco','COmple','232','444.44-444','-1','Cidade','email','(22) 2222-2222','(11) 11111-1111','Bairro')

