Use master
go

IF EXISTS (SELECT * from sys.databases where name = 'Pizzaria')
DROP DATABASE Pizzaria
go

create database Pizzaria
go

use Pizzaria
go

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

create table Despesa
(
codDespesa INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NomeDespesa VarChar (15),
ValorDespesa Decimal (6,2),
DataPagamento Date
)
go

create table Permissao
(
Cod_Permissao int IDENTITY (1,1) Primary Key,
Cargo Varchar (20)
)
go

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
Login_Funcionario VARCHAR(30),
Senha_Funcionario VARCHAR(20),
Cod_Permissao INT FOREIGN KEY REFERENCES 
Permissao(Cod_Permissao),
)
go

create table Categoria
(
CodCategoria int identity (1,1) Primary Key,
NomeCategoria VarChar (20)
)
go

create table Insumo
(
Cod_Insumo INT IDENTITY(1,1) PRIMARY KEY,
Nome_Insumo VARCHAR(20),
ValorDeCompra DECIMAL,
QtdeRecomendavel INT,
QtdeEmEstoque INT,
Fabricacao DATE,
Validade VarChar(10),
Medida VARCHAR(10),
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go

create table Produto
(
Cod_Produto INT IDENTITY(1,1) PRIMARY KEY,
Nome_Produto VARCHAR(40),
Valor_Venda DECIMAL(6,2),
Sobe_Site INT,
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go

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
Estado VarChar(12)
)

go

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

create table Insumo_Fornecedor
(
Cod_InsumoFornecedor int identity (1,1) Primary Key,
Cod_Insumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
Cod_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(Cod_Fornecedor),
)
go
select * from ProdutoCategoria
create table ProdutoCategoria
(
CodProdutoCategoria int identity (1,1) Primary Key,
CodProduto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go

create table InsumoCategoria
(
CodInsumoCat int identity (1,1) Primary Key,
CodInsumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go

create table Consumo
(
CodProdutoInsumo int identity (1,1) Primary Key,
CodInsumo INT FOREIGN KEY REFERENCES Insumo(Cod_Insumo),
CodProduto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Quantidade DECIMAL (6,4)
)
go

create table Promocao
(
Cod_Promocao INT IDENTITY(1,1) PRIMARY KEY,
Nome_Promocao VARCHAR(40),
Descricao VARCHAR(150),
Preco_Original DECIMAL(6,2),
Preco_Promocao DECIMAL(6,2),
Vigencia VARCHAR(10),
sobe_promocao INT,
AcessivelATodos INT
)
go

create table PedidoPromocao
(
codPromoPedido INT IDENTITY(1,1) PRIMARY KEY,
Cod_Pedido INT FOREIGN KEY REFERENCES Pedido(Cod_Pedido),
Cod_Promocao INT FOREIGN KEY REFERENCES Promocao(Cod_Promocao)
)
go

create table CompraFornecedor
(
Cod_Compra INT IDENTITY(1,1) PRIMARY KEY,
Valor_Compra DECIMAL(10),
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

create table Pagamento
(
Cod_Pagamento INT IDENTITY(1,1) PRIMARY KEY,
ValorPagamento DECIMAL (6,2),
DataExpedido DATE,
TipoPagamento VARCHAR(20)
)
go


	-------------------- *** INSERT'S *** ------------------------ 
		
	
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
Login_Cliente,
Senha_Cliente,
DataNascimento,
DataCadastro
)
values
('Avulso','111.111.111-11','',1,null,'a','1','aa','aaa','aaa','1',null,'a','a','19/03/1908','19/07/1907'),

('João da Cunha','123.456.789-14','Rua das Caviúnas',49,32,'Alphaville','78061-302','SP','Barueri','Edifício Pelicano','(11)4972-1976',null,'joao.cunha@gmail.com','joaocunha123','27/07/1981','11/07/1980'),

('Maria Joaquina','814.198.872-68','Rua Canjeranas',574,null,'Jabaquara','04349-020','SP','São Paulo',null,'(11)3697-4567','(11)9-7419-9715','carrossel@sbt.com.br','cirilo123','04/10/1994','02/11/1998'),

('Sandra Costa da Silva','496.527.352-98','Rua dos Bobos',9,727,'Jardins','18949-850','SP','São Paulo',null,'(11)5789-1240','(11)9-8752-6714','sandra@gmail.com','costa123','16/12/1977','18/05/1975'),

('Gabriel Andrade Yamotsu','155.157.758-61','Rua das Laranjeiras',1785,null,'Capão Redondo','54189-206','SP','São Paulo','Em frente ao Habibs','(11)4972-1546',null,'andrade@yahoo.com','andrade123','12/05/1985','18/11/1982')

go

insert into Permissao
(
Cargo
)
values
('Administrador'),
('Gerente'),
('Atendente')
go

insert into Funcionario
(
Nome_Func,
CPF_Funcionario,
Endereco_Funcionario,
Complemento_Funcionario,
Numero_Residencia,
CEP_Funcionario,
Estado_Funcionario,
Cidade_Funcionario,
Bairro_Funcionario,
Email_Funcionario,
Telefone_Funcionario,
Celular_Funcionario
)
values
('Maria do Carmo','128.589.519-87','Rua dos Funcionários',null,159,'12598-11','SP','São Paulo','Santa Cecília','maria_teste@hotmail.com','(11)4529-4196','(11)9-7988-4895'),
('Joana Figueiredo','932.571.495-28','Rua Coronel Justino','Bloco D',1050,'28984-79','SP','São Paulo','Suzano','joana.fig@terra.com.br','(11)7819-4898','(11)9-6187-8959'),
('Carlos Silva','475.427.106-85','Rua Juba da Jujuba',null,420,'59579-14','SP','São Paulo','Vila Mariana','carlos_silva@gmail.com','(11)4198-8274','(11)9-9488-9774')

insert into Insumo
(
Nome_Insumo,
ValorDeCompra,
QtdeRecomendavel,
QtdeEmEstoque
)
values
('Orégano',20.00,20,12),
('Queijo mussarela',35.00,30,19),
('Tomate',15.30,25,20)
go

insert into Categoria
(
NomeCategoria
)
values
('Pizza'),
('Pizza Brotinho'),
('Bebidas'),
('Porções'),
('Embalagens'),
('Queijos'),
('Vegetais'),
('Massas')

insert into Produto
(
Nome_Produto,
Valor_Venda,
Sobe_Site,
CodCategoria
)
values
('Baiana',20.00,1,1),
('Mussarela',18.40,1,1),
('Bacon',20.20,1,1),
('Americana',24.00,1,1),
('Bauru',23.50,1,1),
('Calabresa',18.00,1,1),
('Catupiry',23.00,1,1),
('Três Queijos',24.70,1,1),
('Alemã',25.20,1,1),
('Pizza Havaiana Brotinho',13.70,1,2),
('Pizza Baiana Brotinho',14.50,0,2),
('Pizza Palmito Brotinho',15.00,0,2),
('Pizza Peruana Brotinho',14.00,0,2),
('Refrigerante',7.00,0,3),
('Cerveja',9.40,0,3),
('Vinho',15.50,0,3),
('Champagne',17.00,0,3),
('Porção de Camarão',19.00,0,4),
('Porção de Calabresa',18.00,0,4),
('Porção de Provolone',17.00,0,4),
('Porção de Cu',19.00,1,4)
go

insert into Pedido(Cod_Cliente,Cod_Funcionario,Data,Hora,Valor)
values
(1,1,'2014-01-05','20:15',31.00),
(2,2,'2014-07-22','19:14',25.25),
(3,3,'2014-08-12','22:57',38.89),
(3,1,'2014-10-04','21:40',78.98),
(5,2,'2014-07-02','21:15',42.30),
(5,3,'2014-02-05','20:22',67.90),
(5,2,'2014-06-15','22:57',84.20),
(4,1,'2014-04-29','18:49',76.00),
(2,3,'2014-02-15','19:16',58.20)
go


insert into Fornecedor
(
CNPJ_CPF,
Razao_Social,
Nome_Fantasia,
Nome_Banco,
Agencia,
Conta_Corrente,
Responsavel,
Celular_Responsavel,
Email_Responsavel,
Telefone_Comercial,
Endereco_Fornecedor,
Numero_Residencia,
CEP_Fornecedor,
Estado_Fornecedor,
Cidade_Fornecedor,
Bairro_Fornecedor,
Complemento
)
values
('222-222-222-22', 'Caixa de Queijo Ltda', 'Queijo in Box', 'Itaú', '0000', '1111-0', 'John Cheese', '91111-1111', 'jc_queijos@jc.com', '(11)2222-3333', 'Rua dos Tupinambás', '456', '01234-000', 'SP', 'São Paulo', 'Jardim Mundial', '6º Andar'),

('333-333-333-33', 'Embalagens São Paulo EPP', 'SP Embalagens', 'Banco do Brasil', '1234', '4321-5', 'Josué Alvarenga', '95555-6666', 'embalagens@sp.com.br', '(11)1111-9999', 'Avenida Cascatinhas', '881', '09876-123', 'SP', 'Suzano', 'Vila Emerson', 'Sobreloja'),

('111-111-111-11', 'Na Lata - Enlatados em geral Ltda', 'Na Lata!', 'Bradesco', '0055', '055678-2', 'Clóvis Ribeiro', '98888-4444', 'enlatados@clovis.com', '(13)3456-7890', 'Avenida da Orla', '200', '02345-987', 'SP', 'Santos', 'Paquetá', 'Zona Portuária'),

('444-444-444-44', 'Hortaliças Hortolândia EPP', 'Viva Verde Hortaliças', 'Santander', '9966', '013568-7', 'Romualdo Nunes', '97777-5501', 'rn@vivaverde.com.br', '(11)2233-5678', 'Rua do Chá', '56', '03456-321', 'SP', 'São Paulo', 'Ceasa', 'Box 100')
go

insert into Promocao
(
Nome_Promocao,
Descricao,
sobe_promocao,
AcessivelATodos
)
values
('Final de semana','Nos finais de semana deste mês(Novembro), as pizzas de Mussarela,Calabresa e Baiana terão seu preço reduzido a R$16,00.<br /> Aproveite !!',1,0),
('Cookie Promocional','Compras acima de R$25,00, você ganha dois deliciosos cookies de chocolate.',1,0),
('Compras acima de R$50,00','Ao gastar R$50,00 ou mais em nossa Pizzaria, você concorre a um Iphone 9 !!',1,1)
go

insert into insumo_fornecedor
(
Cod_Insumo,
Cod_Fornecedor
)
values
(2, 1),
(3, 4),
(1, 4)
go

insert into Consumo
(
CodInsumo,
CodProduto,
Quantidade
)
values
(1, 4,0.01),
(2, 2,0.40),
(3, 5,1)
go

insert into PedidoPromocao
(
Cod_Promocao,
Cod_Pedido
)
values
(1, 1),
(2, 7),
(3, 4)
go

select * from Promocao
select * from Pedido

insert into CompraFornecedor
(
Valor_Compra,
Data_venda,
Cod_Fornecedor,
Cod_Funcionario
)
values
(170.00, '17/09/2014', 2,3),
(235.00, '20/09/2014', 3,2),
(150.00, '22/10/2014', 4,3),
(199.00, '15/10/2014', 1,1)
go

insert into Detalhe_Pedido
(
cod_pedido,
cod_produto
)
values
(1,1),
(1,2),
(1,2),
(1,6),
(1,5),
(1,7),
(1,7),
(1,7),
(1,8),
(1,2),
(1,2),
(2,2),
(3,3)

go

/* Deixar 3 ou mais dados em cada tabela por favor.

TABELAS				  STATUS

cliente				|   OK
permissao			|   OK
funcionario			|   OK
insumo				|   OK
funcpermissao		|   OK
categoria			|   OK
produto				|   OK
pedido				|   OK
fornecedor			|   faltam dados
insumo_fornecedor	|   OK
produto_insumo		|   OK
promocao 			|   OK
produto_promocao	|   OK
pedido_fornecedor	|   OK
detalhe_pedido		|   Faltam dados
*/