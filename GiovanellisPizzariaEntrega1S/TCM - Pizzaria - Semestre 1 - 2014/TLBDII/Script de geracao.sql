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
Valor_Compra DECIMAL(10),
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
qdt_comprada int,
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
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** INSERT'S *** ------------------------ 
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

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

('João da Cunha','123.456.789-14','Rua das Caviunas',49,32,'Alphaville','78061-302','SP','Barueri','Edifício Pelicano','(11) 4972-1976',null,'joao.cunha@gmail.com','joaocunha123','27/07/1981','11/07/1980'),

('Maria Joaquina','814.198.872-68','Rua Canjeranas',574,null,'Jabaquara','04349-020','SP','São Paulo',null,'(11)3697-4567','(11)9-7419-9715','carrossel@sbt.com.br','cirilo123','04/10/1994','02/11/1998'),

('Sandra Costa da Silva','496.527.352-98','Rua dos Bobos',9,727,'Jardins','18949-850','SP','São Paulo',null,'(11)5789-1240','(11)9-8752-6714','sandra@gmail.com','costa123','16/12/1977','18/05/1975'),

('Gabriel Andrade Yamotsu','155.157.758-61','Rua das Laranjeiras',1785,null,'Capão Redondo','54189-206','SP','São Paulo','Em frente ao Habibs','(11)4972-1546',null,'andrade@yahoo.com','andrade123','12/05/1985','18/11/1982')

go
-----------------------------------------
insert into Permissao
(
Cargo
)
values
('Administrador'),
('Gerente'),
('Atendente'),
('Entregador'),
('Operador')
go
-----------------------------------------
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
Celular_Funcionario,
Login_Funcionario,
Senha_Funcionario,
Cod_Permissao
)
values
('Roberto Carlos','128.589.519-87','Rua Roberto Carlos', null,159,'12598-11','SP','São Paulo','Roberto Carlos','roberto@carlos.rob.ca','(11)4529-4196','(11)9-7988-4895','Roberto','123', 1),
('Maria do Carmo','128.589.519-87','Rua dos Funcionários',null,159,'12598-11','SP','São Paulo','Santa Cecília','maria_teste@hotmail.com','(11)4529-4196','(11)9-7988-4895','Maria','123', 4),
('Joana Figueiredo','932.571.495-28','Rua Coronel Justino','Bloco D',1050,'28984-79','SP','São Paulo','Suzano','joana.fig@terra.com.br','(11)7819-4898','(11)9-6187-8959','Admin','123', 4),
('Carlos Silva','475.427.106-85','Rua Juba da Jujuba',null,420,'59579-14','SP','São Paulo','Vila Mariana','carlos_silva@gmail.com','(11)4198-8274','(11)9-9658-9774','Carlos','123', 4),
('Alex Santos','399.305.868-22','Rua Pindamonhangaba',null,666,'023654-14','SP','São Paulo','Vila Tupiniquim','alexsantos@gmail.com','(11)4578-8274','(11)9-9852-9774','Alex','123', 1),
('Toninho Abreu','128.589.519-87','Rua das Dalágaras', null,159,'12598-11','SP','São Paulo','Vila Vira','tony@gmail.com','(11)4529-4196','(11)9-7988-4895','Tony','123', 2)

insert into Insumo
(
Nome_Insumo,
ValorDeCompra,
QtdeRecomendavel,
QtdeEmEstoque,
Medida
)
values
('Orégano', 20, 20, 12, 'Kg'),
('Queijo mussarela', 35, 30, 19, 'Kg'),
('Tomate', 15, 25, 20, 'Kg'),
('Calabresa Moída', 15, 30, 29, 'Kg'),
('Parmesão', 17, 20, 18, 'Kg'),
('Ovos', 12, 25, 17, 'Un.'),
('Presunto', 16, 15, 10, 'Kg'),
('Cebola', 9, 50, 12, 'Kg'),
('Catupiry', 16, 50, 23, 'Kg'),
('Pimenta', 8, 30, 1, 'Kg'),
('Lombo', 22, 25, 1, 'Kg'),
('Palmito', 19, 20, 1, 'Kg'),
('Champignon', 20, 15, 1, 'Kg'),
('Provolone', 19, 20, 18, 'Kg'),
('Bacon', 18, 25, 8, 'Kg'),
('Embalagem para Pizza', 31, 50, 70, 'Un.'),
('Massa para pizza', 50, 100, 200, 'Kg'),
('Molho de tomate', 8, 10, 20, 'Kg'),
('Azeitona', 15, 5, 15, 'Kg'),
('frango', 10, 10, 15, 'Kg'),
('Milho', 7, 5, 10, 'Kg'),
('Refrigerante', 2, 50, 70, 'Un.'),
('Cerveja', 2, 50, 90, 'Un.'),
('Vinho', 15, 10, 20, 'Un.'),
('Champagne', 15, 10, 20, 'Un.'),
('Camarão', 25, 2, 5, 'Kg')
go
-----------------------------------------
insert into Categoria
(
NomeCategoria
)
values
('Pizza'),
('Pizza Brotinho'),
('Bebidas não Alcóolicas'),
('Porções'),
('Embalagens'),
('Queijos'),
('Vegetais'),
('Massas'),
('Carnes'),
('Embutidos'),
('Frutas'),
('Temperos'),
('Carnes'),
('Peixes'),
('Frutos do Mar'),
('Embalagens'),
('Molhos'),
('Conservas'),
('Aves'),
('Bebidas Alcóolicas')
go
-----------------------------------------
insert into insumocategoria
(
codInsumo,
codCategoria
)
values
(1,12),
(2,6),
(3,11),
(4,10),
(5,6),
(6,9),
(7,10),
(8,7),
(9,6),
(10,12),
(11,10),
(12,7),
(13,7),
(14,6),
(15,9),
(16,16),
(17,8),
(18,17),
(19,18),
(20,19),
(21,18),
(22,3),
(23,20),
(24,20),
(25,20),
(26,15)

go
-----------------------------------------
insert into Produto
(
Nome_Produto,
Valor_Venda,
Sobe_Site
)
values
('(Campo vazio para utilização do sistema)',0,0),
('Pizza Baiana',20.00,1),
('Pizza Mussarela',18.40,1),
('Pizza Bacon',20.20,1),
('Pizza Americana',24.00,1),
('Pizza Bauru',23.50,1),
('Pizza Calabresa',18.00,1),
('Pizza Catupiry',23.00,1),
('Pizza Três Queijos',24.70,1),
('Pizza Alemã',25.20,1),
('Pizza Havaiana Brotinho',13.70,1),
('Pizza Baiana Brotinho',14.50,0),
('Pizza Palmito Brotinho',15.00,0),
('Pizza Peruana Brotinho',14.00,0),
('Refrigerante',7.00,0),
('Cerveja',9.40,0),
('Vinho',15.50,0),
('Champagne',17.00,0),
('Porção de Camarão',19.00,0),
('Porção de Calabresa',18.00,0),
('Porção de Provolone',17.00,0)
go
-----------------------------------------
insert into ProdutoCategoria
(
CodCategoria,
CodProduto
)
values
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(1,8),
(1,9),
(2,10),
(2,11),
(2,12),
(2,13),
(3,14),
(3,15),
(3,16),
(3,17),
(4,18),
(4,19),
(4,20)
go
-----------------------------------------
insert into Pedido
(Data,Hora,Valor,Cod_Funcionario,Cod_Cliente, Observacao,Origem,Estado, EnderecoAlt, BairroAlt, NumeroResidencialAlt, NumeroApartamentoAlt ,FormaDePagamento,ValorPago)
values
('05/01/2015','20:15',90.30,1,2,'','Site','A caminho','','','','','Cheque',90.30),
('05/01/2015','20:15',58.40,1,3,'','Site','A caminho','','','','','Dinheiro',58.40),
('05/01/2015','20:15',147.50,1,4,'','Site','A caminho','Alameda Itu','','32','21','Cartão',147.50),

('05/01/2015','20:15',65.60,2,2,'','Site','A caminho','','','','','Cartão',65.60),
('05/01/2015','20:15',65.60,2,3,'','Site','A caminho','Travessa Dom Gaspar','','666','','Cheque',65.60),
('05/01/2015','20:15',56.80,2,4,'','Site','A caminho','','','','','Dinheiro',56.80),

('05/01/2015','20:15',75.00,3,2,'','Site','Na Fila','Avenida Paulista', '','756','35','Cheque',75.00),
('05/01/2015','20:15',65.60,3,3,'','Site','A caminho','','','','','Dinheiro',65.60),
('05/01/2015','20:15',65.60,3,4,'','Site','Em Preparo','','','','','Cartão',65.60),

('05/01/2015','20:15',204.30,4,2,'','Site','Na Fila','','','','','Cartão',204.30),
('05/01/2015','20:15',65.60,4,3,'','Site','Em Preparo','','','','','Cartão',65.60),
('05/01/2015','20:15',65.60,4,4,'','Site','A caminho','','','','','Cartão',65.60),

('05/01/2015','23:56',22.00,2,3,'','Site','Em Preparo','','','','','Cartão',56.80),
('05/01/2015','18:31',65.87,3,4,'','Site','Na Fila','','','','','Cartão',75.00),
('22/02/2015','19:14',65.60,2,2,'','In loco','Cancelado','','','','','Dinheiro', 65.60),
('12/03/2015','22:57',38.89,3,3,'','Telefone','Realizado','Alameda Itu','', '753', '', 'Cartão',65.60),
('05/04/2015','22:22',68.98,1,5,'','Site','Realizado','', '', '', '', 'Cartão',56.80),
('05/04/2015','21:40',78.98,4,3,'Manera na cebola','Site','Cancelado','' ,'' , '','','Cartão',147.50),
('05/04/2015','22:22',65.60,1,5,'','Site','Cancelado','', '', '', '','Cartão',65.60),
('06/04/2015','21:15',65.60,4,5,'','In loco','Cancelado', '', '', '', '','Cartão',65.60),
('07/04/2015','20:22',65.60,3,5,'Sem azeitonas, pelo amor de Deus','Site','Realizado','','','', '','Cartão',65.60),
('20/04/2015','22:57',56.60,2,5,'','In loco','Realizado','','','', '','Cartão',56.80),
('22/05/2015','18:49',70.00,1,4,'','Site','Realizado','Rebouças', '', '32', '','Dinheiro',75.00),
('06/06/2015','00:16',75.00,3,2,'Favor, ao chegar, ligar no meu celular e não pelo interfone nem campainha','Site','Cancelado','','','', '','Cartão',75.00),
('06/04/2015','21:15',75.00,2,5,'','In loco','Cancelado','','','', '','Cartão',75.00)
go
-----------------------------------------
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
-----------------------------------------
insert into Promocao
(
Nome_Promocao,
Descricao,
PorcentagemDesconto,
Vigencia,
sobe_promocao,
AcessivelATodos
)
values
('Final de semana','Pizzas com 15% de desconto até dia 23 de Maio!',85, '2015-05-23', 1,0),
('Super três queijos','Pizza de três queijos com 25% de desconto!.',75, '2016-01-01', 1,0),
('Olha o refrigerante','Refrigerante agora está mais barato',90, '2016-01-01', 1, 1)
go
-----------------------------------------
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
-----------------------------------------
insert into Consumo
(
CodProduto,
CodInsumo,
Quantidade
)
values
(1,4,0.300),
(1,10,0.50),
(1,17,0.400),
(1,18,0.100),
(1,8,0.100),
(1,19,0.050),
(1,16,1),

(2,2,0.400),
(2,19,0.050),
(2,1,0.50),
(2,16,1),
(2,17,0.400),
(2,18,0.100),

(3,2,0.300),
(3,15,0.300),
(3,19,0.050),
(3,8,0.100),
(3,16,1),
(3,3,0.100),
(3,13,0.100),
(3,17,0.400),
(3,18,0.100),

(4,2,0.300),
(4,4,0.300),
(4,19,0.050),
(4,10,0.100),
(4,8,0.100),
(4,16,1),
(4,17,0.400),
(4,18,0.100),

(5,2,0.300),
(5,7,0.300),
(5,8,0.100),
(5,16,1),
(5,17,0.400),
(5,18,0.100),
(5,19,0.050),

(6,4,0.300),
(6,8,0.100),
(6,16,1),
(6,17,0.400),
(6,18,0.100),
(6,19,0.050),

(7,2,0.300),
(7,9,0.200),
(7,16,1),
(7,17,0.400),
(7,18,0.100),
(7,19,0.050),

(8,2,0.300),
(8,9,0.200),
(8,5,0.200),
(8,16,1),
(8,17,0.400),
(8,18,0.100),
(8,19,0.050),

(9,8,0.100),
(9,11,0.300),
(9,2,0.300),
(9,1,0.50),
(9,16,1),
(9,17,0.400),
(9,18,0.100),
(9,19,0.050),

(10,20,0.300),
(10,21,0.200),
(10,12,0.200),
(10,16,1),
(10,17,0.400),
(10,18,0.100),
(10,19,0.050),

(11,4,0.300),
(11,10,0.100),
(11,16,1),
(11,17,0.400),
(11,18,0.100),
(11,19,0.050),

(12,2,0.200),
(12,1,0.50),
(12,12,0.200),
(12,5,0.300),
(12,16,1),
(12,17,0.400),
(12,18,0.100),
(12,19,0.050),

(13,7,0.300),
(13,6,3),
(13,11,0.300),
(13,2,0.300),
(13,1,0.050),
(13,16,1),
(13,17,0.400),
(13,18,0.100),
(13,19,0.050),

(14,22,1),

(15,23,1),

(16,24,1),

(17,25,1),

(18,26,0.400),

(19,4,0.400),

(20,14,0.400)
go
-----------------------------------------
insert into ProdutoPromocao
(
Cod_Promocao,
Cod_Produto
)
values
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 7),
(1, 9),
(2, 8),
(3, 14)
go
-----------------------------------------
insert into CompraFornecedor
(
Valor_Compra,
Data_venda,
Cod_Fornecedor,
Cod_Funcionario
)
values
(450.00, '15/10/2015', 1,1),
(290.00, '20/09/2015', 3,2),
(200.00, '17/09/2015', 2,3),
(350.00, '22/10/2015', 4,3)
go
-----------------------------------------
insert into Detalhe_Pedido
(
cod_pedido,
cod_produto2,
cod_produto
)
values
(1,5,1),
(1,0,2),
(1,4,3),
(1,0,14),
(1,0,8),

(2,0,1),
(2,5,1),
(2,0,2),

(3,0,1),
(3,0,2),
(3,5,3),
(3,0,4),
(3,9,5),
(3,0,6),
(3,0,14),
(3,0,14),
(3,0,15),

(4,0,1),
(4,0,2),
(4,6,3),
(4,0,14),

(5,0,1),
(5,0,2),
(5,7,3),
(5,0,14),

(6,0,1),
(6,0,2),
(6,0,2),

(7,0,1),
(7,0,2),
(7,0,3),
(7,0,14),
(7,0,15),

(8,0,1),
(8,0,2),
(8,0,3),
(8,0,14),

(9,0,1),
(9,0,2),
(9,0,3),
(9,0,14),

(10,0,1),
(10,0,2),
(10,0,2),

(10,0,1),
(10,0,2),
(10,0,3),
(10,0,4),
(10,0,5),
(10,0,6),
(10,0,14),
(10,0,14),
(10,0,15),

(11,0,1),
(11,0,2),
(11,0,3),
(11,0,14),

(12,0,1),
(12,0,2),
(12,0,3),
(12,0,14),

(13,0,1),
(13,0,2),
(13,0,2),

(14,0,1),
(14,0,2),
(14,0,3),
(14,0,14),
(14,0,15),

(15,0,1),
(15,0,2),
(15,0,3),
(15,0,14),

(16,0,1),
(16,0,2),
(16,0,3),
(16,0,14),

(17,0,1),
(17,0,2),
(17,0,2),

(18,0,1),
(18,0,2),
(18,0,3),
(18,0,4),
(18,0,5),
(18,0,6),
(18,0,14),
(18,0,14),
(18,0,15),

(19,0,1),
(19,0,2),
(19,0,3),
(19,0,14),

(21,0,1),
(21,0,2),
(21,0,3),
(21,0,14),

(22,0,1),
(22,0,2),
(22,0,2),

(23,0,1),
(23,0,2),
(23,0,3),
(23,0,14),
(23,0,15),

(24,0,1),
(24,0,2),
(24,0,3),
(24,0,14),
(24,0,15)

go
-----------------------------------------
insert into TipoDespesa
(
NomeDespesa,
SituacaoDespesa
)
values
('Gás encanado','Ativo'),
('Butijão de gás','Inativo'),
('Água','Ativo'),
('Energia elétrica','Ativo'),
('Telefone','Ativo')
go
-----------------------------------------
insert into Despesa
(
ValorDespesa,
DataPagamento,
DataVencimento,
TipoDespesa
)
values
(112.35, '17/02/2015', '17/02/2015', 1),
(87.35, '15/04/2015', '17/04/2015', 4),
(182.35, '14/05/2015', '17/05/2015', 5),
(120.35, '13/06/2015', '17/06/2015', 3)
go
-----------------------------------------
insert into Pagamento
(
ValorPagamento,
DataExpedido,
TipoPagamento,
Cod_Funcionario
)
Values
(
2500.00,'2015-01-11', 'Salário', 2
)
go
-----------------------------------------
insert into DetalheCompra 
values
(1,1,2,35,6),
(1,1,9,16,15),
(3,2,16,50,4),
(4,4,3,15,10),
(4,4,1,20,10),
(2,3,13,20,10),
(2,3,8,9,10)
go
-----------------------------------------
insert into Mensagens (CodRemetente, CodDestinatario, Assunto, Mensagem, DataCriacao, HoraCriacao, Aviso)
values
(5,2,'Pizza doce','Lembrar de inserir Pizza doce no cardápio','2015-06-15','15:12:27',1),
(5,1,'Teleffy','Favor pegar o Teleffy do Talaris','2015-06-15','15:12:27',1),
(5,3,'Integrante','Lembrar de lembrar','2015-06-14','15:12:27',1),
(5,4,'Insumos','Checkar Insumos','2015-06-14','16:12:27',1),
(2,5,'Relatórios','Favor enviar relatório do mês de Abril','2015-06-15','18:12:27',1),
(3,5,'Despesas','Favor cadastrar despesas das novas contas','2015-06-15','15:12:27',1),
(1,5,'Salário','Efetuar o Pagamento do Sr João','2015-06-14','18:12:27',1),
(3,5,'Encontro','Hoje, às 21h?','2015-06-14','15:12:27',1)
go

	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** PROCEDURES *** ----------------------
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

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
--(EMAIL_CLIENTE =@EMAIL_CLIENTE or @EMAIL_CLIENTE is null) and
(SENHA_CLIENTE=@SENHA_CLIENTE  or @SENHA_CLIENTE is null) and
(DATANASCIMENTO =@DATA_NASCIMENTO or @DATA_NASCIMENTO is null)
end
go
-----------------------------------------
/*
create proc [dbo].[sp_insert_cliente]
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
go
*/
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
@Mensagem varchar (1000)
)

as

begin

update Mensagens set Mensagem = @Mensagem where CodMensagem = @CodMensagem

end

go
--------------------------------------------------------------------------------------------------------------------------------------
Create procedure USP_JAVA_DELETARMENSAGEM
@CodMensagem int

as

begin

delete from Mensagens where CodMensagem = @CodMensagem

end
