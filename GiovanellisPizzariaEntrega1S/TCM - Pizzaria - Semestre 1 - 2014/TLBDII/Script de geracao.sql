Use master
go

--
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
--

--
select @query=coalesce(@query,',' )+'kill '+convert(varchar, spid)+ '; '
from master..sysprocesses where dbid=db_id(@databasename)

if len(@query) > 0
begin
print @query
	exec(@query)
end
go
--
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

create table TipoDespesa
(
codTipoDespesa INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NomeDespesa VARCHAR(50) unique,
SituacaoDespesa varchar(10)
)
go

create table Despesa
(
codDespesa INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
ValorDespesa Decimal (6,2),
DataPagamento Date,
DataVencimento Date,
TipoDespesa INT FOREIGN KEY REFERENCES TipoDespesa(codTipoDespesa)
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
Login_Funcionario VARCHAR(30) unique,
Senha_Funcionario VARCHAR(20),
Cod_Permissao INT FOREIGN KEY REFERENCES 
Permissao(Cod_Permissao)
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
Medida VARCHAR(10)
)
go

create table Produto
(
Cod_Produto INT IDENTITY(0,1) PRIMARY KEY,
Nome_Produto VARCHAR(40),
Valor_Venda DECIMAL(6,2),
Sobe_Site INT
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
Estado VarChar(12),
EnderecoAlt VarChar(140),
NumeroResidencialAlt VarChar(5),
NumeroApartamentoAlt VarChar(5),
FormaDePagamento varchar(10),
ValorPago dec (6,2)
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

create table ProdutoCategoria
(
CodProdutoCategoria int identity (1,1) Primary Key,
CodProduto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
CodCategoria INT FOREIGN KEY REFERENCES Categoria(CodCategoria)
)
go

create table InsumoCategoria
(
CodInsumoCategoria int identity (1,1) Primary Key,
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
PorcentagemDesconto DECIMAL(3,2),
Vigencia Date,
sobe_promocao INT,
AcessivelATodos INT
)
go

create table ProdutoPromocao
(
codPromocaoProduto INT IDENTITY(1,1) PRIMARY KEY,
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
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
Cod_Detalhe INT IDENTITY(0,1) PRIMARY KEY,
Cod_Produto INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Produto2 INT FOREIGN KEY REFERENCES Produto(Cod_Produto),
Cod_Pedido INT FOREIGN KEY REFERENCES Pedido(Cod_Pedido),
)
go

create table Pagamento
(
Cod_Pagamento INT IDENTITY(1,1) PRIMARY KEY,
ValorPagamento DECIMAL (6,2),
DataExpedido DATE,
TipoPagamento VARCHAR(20),
Cod_Funcionario INT FOREIGN KEY REFERENCES Funcionario(Cod_Funcionario)
)
go

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
('Alex Santos','399.305.868-22','Rua Pindamonhangaba',null,666,'023654-14','SP','São Paulo','Vila Tupiniquim','alexsantos@gmail.com','(11)4578-8274','(11)9-9852-9774','Alex','123', 4),
('Toninho Abreu','128.589.519-87','Rua das Dalágaras', null,159,'12598-11','SP','São Paulo','Vila Vira','tony@gmail.com','(11)4529-4196','(11)9-7988-4895','Tony','123', 2)


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
('Tomate',15.30,25,20),
('Calabresa Moída',15,30,29),
('Parmesão',17.20,20,18),
('Ovos',12,25,17),
('Presunto',16,15,10),
('Cebola',9,50,12),
('Catupiry',15.80,50,23),
('Pimenta',7.90,30,1),
('Lombo',21.70,25,1),
('Palmito',18.90,20,1),
('Champignon',19.60,15,1),
('Provolone',19,20,18),
('Bacon',18.30,25 ,8)
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
go

insert into Produto
(
Nome_Produto,
Valor_Venda,
Sobe_Site
)
values
('',0,0),
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

insert into Pedido
(Data,Hora,Valor,Cod_Funcionario,Cod_Cliente, Observacao,Origem,Estado, EnderecoAlt, NumeroResidencialAlt, NumeroApartamentoAlt ,FormaDePagamento,ValorPago)
values
('05/01/2015','20:15',31.00,1,2,'','Site','A caminho','','','','Cheque',31.00),
('05/01/2015','20:15',31.00,1,3,'','Site','A caminho','','','','Dinheiro',35.00),
('05/01/2015','20:15',31.00,1,4,'','Site','A caminho','Alameda Itu','32','21','Cartão',31.00),

('05/01/2015','20:15',31.00,2,2,'','Site','A caminho','','','','Cartão',31.00),
('05/01/2015','20:15',31.00,2,3,'','Site','A caminho','Travessa Dom Gaspar','666','','Cheque',31.00),
('05/01/2015','20:15',31.00,2,4,'','Site','A caminho','','','','Dinheiro',35.00),

('05/01/2015','20:15',31.00,3,2,'','Site','A caminho','Avenida Paulista','756','35','Cheque',31.00),
('05/01/2015','20:15',31.00,3,3,'','Site','A caminho','','','','Dinheiro',50.00),
('05/01/2015','20:15',31.00,3,4,'','Site','A caminho','','','','Cartão',31.00),

('05/01/2015','20:15',31.00,4,2,'','Site','A caminho','','','','Cartão',31.00),
('05/01/2015','20:15',31.00,4,3,'','Site','A caminho','','','','Cartão',31.00),
('05/01/2015','20:15',31.00,4,4,'','Site','A caminho','','','','Cartão',31.00),

('05/01/2015','23:56',22.00,2,3,'','Site','A caminho','','','','Cartão',22.00),
('05/01/2015','18:31',65.87,3,4,'','Site','A caminho','','','','Cartão',65.87),
('22/02/2015','19:14',25.25,2,2,'','In loco','Cancelado','','','','Dinheiro', 30),
('12/03/2015','22:57',38.89,3,3,'','Telefone','Realizado','Alameda Itu', '753', '', 'Cartão',38.89),
('05/04/2015','22:22',68.98,1,5,'','Site','Realizado','', '', '', 'Cartão',68.98),
('05/04/2015','21:40',78.98,4,3,'Manera na cebola','Site','Cancelado','' ,'' ,'','Cartão',78.98),
('05/04/2015','22:22',55.32,1,5,'','Site','Cancelado','', '', '','Cartão',55.32),
('06/04/2015','21:15',42.30,4,5,'','In loco','Cancelado', '', '', '','Cartão',42.30),
('07/04/2015','20:22',67.90,3,5,'Sem azeitonas, pelo amor de Deus','Site','Realizado','','','','Cartão',67.90),
('20/04/2015','22:57',84.20,2,5,'','In loco','Realizado','','','','Cartão',84.20),
('22/05/2015','18:49',76.00,1,4,'','Site','Realizado','Rebouças', '32', '','Dinheiro',80),
('06/06/2015','00:16',58.20,3,2,'Favor, ao chegar, ligar no meu celular e não pelo interfone nem campainha','Site','Cancelado','','','','Cartão',58.20),
('06/04/2015','21:15',42.30,2,5,'','In loco','Cancelado','','','','Cartão',42.30)
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
PorcentagemDesconto,
Vigencia,
sobe_promocao,
AcessivelATodos
)
values
('Final de semana','Pizzas com 15% de desconto até dia 23 de Maio!',0.85, '2015-05-23', 1,0),
('Super três queijos','Pizza de três queijos com 25% de desconto!.',0.75, '2016-01-01', 1,0),
('Olha o refrigerante','Refrigerante agora está mais barato',0.90, '2016-01-01', 1, 1)
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

/*select distinct p.Nome_Produto,i.Nome_Insumo,p.Valor_Venda 
from Consumo as c
inner join Produto as p on p.Cod_Produto = c.CodProduto and p.Sobe_Site = 1
		inner join Insumo as i on c.CodInsumo = i.Cod_Insumo
			inner join ProdutoCategoria as pc on pc.CodProduto = p.Cod_Produto and pc.CodCategoria = 1 
			order by p.Nome_Produto
			*/

insert into Consumo
(
CodProduto,
CodInsumo,
Quantidade
)
values
(1, 2, 0.30),
(1, 4, 0.01),
(1, 6, 0.5),
(1, 8, 0.90),
(1, 10, 0.2),
(2, 1, 0.20),
(2, 2, 0.30),
(2, 8, 0.60),
(3, 2, 0.30),
(3, 6, 1),
(3, 15, 0.7),
(4, 2, 0.30),
(4, 11, 1),
(4, 12, 1),
(4, 13, 1),
(5, 2, 0.30),
(5, 3, 1),
(5, 7, 1),
(6, 2, 0.30),
(6, 4, 1),
(6, 8, 1),
(7, 2, 0.30),
(7, 9, 0.50),
(8, 2, 0.30),
(8, 9, 1),
(8, 14, 1),
(9, 2, 0.30),
(9, 4, 1),
(9, 5, 1)
go

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

insert into CompraFornecedor
(
Valor_Compra,
Data_venda,
Cod_Fornecedor,
Cod_Funcionario
)
values
(170.00, '17/09/2015', 2,3),
(235.00, '20/09/2015', 3,2),
(150.00, '22/10/2015', 4,3),
(199.00, '15/10/2015', 1,1)
go

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

insert into DetalheCompra 
values
(
1,2,2,35,2
)
go

insert into DetalheCompra 
values
(
3,3,3,35,3
)
go
	-------------------- *** PROCEDURES *** ------------------------ 

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
--EMAIL_CLIENTE ,
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
--(EMAIL_CLIENTE =@EMAIL_CLIENTE or @EMAIL_CLIENTE is null) and
(SENHA_CLIENTE=@SENHA_CLIENTE  or @SENHA_CLIENTE is null) and
(DATANASCIMENTO =@DATA_NASCIMENTO or @DATA_NASCIMENTO is null)
end
go

print 'Proc sp_Select_cliente criada'
go
-----------------------------------------
/*
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
go
*/
-----------------------------------------
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
go

print 'Proc sp_Select_pedido criada'
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

print 'Proc USP_ANDROID_HOME_SelectPedidosAEntregar criada'
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

print 'Proc USP_ANDROID_CancelarPedido criada'
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

print 'Proc USP_ANDROID_RealizarPedido criada'
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

print 'Proc USP_ANDROID_HISTORICO_SelectHistorico criada'
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

print 'Proc USP_ANDROID_HISTORICO_SelectEstadoPedido criada'
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

	print 'Proc USP_ANDROID_DetalhesPedido_SelectProdutosPedido criada'
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
print 'Proc USP_ANDROID_DetalhesPedido_SelectInfoCLiente criada'
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

print 'Proc USP_ANDROID_DetalhesPedido_SelectFormaPagamento criada'
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
			f.Cod_Funcionario,
			p.Cod_Permissao

		from Funcionario f

		inner join Permissao p on
			f.Login_Funcionario like @Login_Funcionario and
			f.Senha_Funcionario like @Senha_Funcionario and
			f.Cod_Permissao = p.Cod_Permissao
	End
go