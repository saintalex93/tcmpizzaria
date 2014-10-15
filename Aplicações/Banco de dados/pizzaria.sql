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
Nome_Cliente VARCHAR(40) NOT NULL,
CPF_Cliente VARCHAR(15)  NOT NULL,
Endereco_Cliente VARCHAR(40) NOT NULL,
Numero_Residencia int NOT NULL,
Numero_Apartamento int,
Bairro_Cliente Varchar(30) NOT NULL,
CEP_Cliente VARCHAR(9) NOT NULL,
Estado_Cliente VARCHAR(2) NOT NULL,
Cidade_Cliente VARCHAR(20) NOT NULL,
Complemento_Cliente VARCHAR(40),
Telefone_Cliente VARCHAR(14) NOT NULL,
Celular_Cliente VarChar (15),
Email_Cliente VARCHAR(40) NOT NULL,
Senha_Cliente Varchar (15) NOT NULL,
DataNascimento Varchar(10) NOT NULL
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
CEP_Funcionario VARCHAR(9),
Estado_Funcionario VARCHAR(2),
Cidade_Funcionario VARCHAR(20),
Email_Funcionario VARCHAR(40),
Bairro_Funcionario VarChar (30),
Celular_Funcionario VarChar (15),
Telefone_Funcionario VarChar (14),
Cod_Permissao INT FOREIGN KEY REFERENCES Permissao(Cod_Permissao),
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
Valor_Compra DECIMAL(6,2),
Validade DATE,
Qtd_Recomendavel INT,
Qtd_Estoque INT,
Sobe_Site INT,
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

insert into Cliente
(
Nome_Cliente,
CPF_Cliente,
Endereco_Cliente,
Numero_Residencia,
Numero_Apartamento,
Bairro_Cliente,
CEP_Cliente,
Estado_Cliente,
Cidade_Cliente,
Complemento_Cliente,
Telefone_Cliente,
Celular_Cliente,
Email_Cliente,
Senha_Cliente,
DataNascimento)
values

('João da Cunha','123.456.789-14','Rua das Caviúnas',49,32,'Alphaville','78061-302','SP','Barueri','Edifício Pelicano','(11)4972-1976',null,'joao.cunha@gmail.com','joaocunha123','12/05/1981'),
('Maria Joaquina','814.198.872-68','Rua Canjeranas',574,null,'Jabaquara','04349-020','SP','São Paulo',null,'(11)3697-4567','(11)9-7419-9715','carrossel@sbt.com.br','cirilo123','12/05/1994'),
('Sandra Costa da Silva','496.527.352-98','Rua dos Bobos',9,727,'Jardins','18949-850','SP','São Paulo',null,'(11)5789-1240','(11)9-8752-6714','sandra@gmail.com','costa123','12/05/1977'),
('Gabriel Andrade Yamotsu','155.157.758-61','Rua das Laranjeiras',1785,null,'Capão Redondo','54189-206','SP','São Paulo','Em frente ao Habibs','(11)4972-1546',null,'andrade@yahoo.com','andrade123','12/05/1985')

go

insert into Produto(Nome_Produto,Valor_Venda,Sobe_Site)
values
('Pizza Baiana',20.00,0),('Pizza Mussarela',18.40,1),('Pizza Bacon',22.20,1),
('Pizza Americana',24.00,1),('Pizza Bauru',23.50,1),('Pizza Calabresa',18.00,1),
('Pizza Catupiry',23.00,1),('Pizza Camarão',28.70,1),('Pizza Alemã',25.20,1)
go
