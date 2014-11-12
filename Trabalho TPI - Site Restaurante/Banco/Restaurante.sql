Use master
go

IF exists (SELECT name from master.dbo.sysdatabases where name = 'Restaurante')
DROP DATABASE Restaurante
go

Create database Restaurante

go

Use Restaurante

go

create table Cliente(
Cod_Cliente INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Cliente VARCHAR(40),
CPF_Cliente VARCHAR(15),
Endereco_Cliente VARCHAR(40),
Numero_Residencia int,
Bairro_Cliente Varchar(30),
CEP_Cliente VARCHAR(10),
Complemento_Cliente VARCHAR(40),
Telefone_Cliente VARCHAR(14),
Celular_Cliente VarChar (15),
Login_Cliente VARCHAR(20),
Senha_Cliente Varchar (15)
)

create table Funcionario
(
Cod_Func INT IDENTITY(1,1) PRIMARY KEY,
Nome_Func VARCHAR(40),
Login_Func VARCHAR(20),
Senha_Func VARCHAR(15),
)

go

create table Pedido
(
Cod_Pedido INT IDENTITY(1,1) PRIMARY KEY,
Data VARCHAR(10),
Valor numeric (6,2),
Cod_Cliente int foreign key references Cliente(Cod_Cliente),
Situacao int--Boolean Pago
)

go

create table Produto
(
Cod_Produto INT IDENTITY(1,1) PRIMARY KEY,
Nome_Produto VARCHAR(40),
Valor_Venda DECIMAL(6,2)
)

go

Create table Pedido_Cliente
(
CodPedido_Cliente int Identity (1,1) primary key,
Cod_Cliente int foreign key references Cliente(Cod_Cliente),
Cod_Pedido int foreign key references Pedido(Cod_Pedido),
Cod_Produto int foreign key references Produto(Cod_Produto),
Qtd_Prod INT
)
go

Create table Produto_Pedido
(
Cod_ProdutoPedido int identity(1,1),
Cod_Produto int foreign key references Produto(cod_Produto),
Cod_Pedido int foreign key references Pedido(cod_Pedido),
Cod_Func int foreign key references Funcionario(Cod_Func)
)

go

insert into Cliente 

(
Nome_Cliente,
CPF_Cliente,
Endereco_Cliente,
Numero_Residencia,
Bairro_Cliente,
CEP_Cliente,
Complemento_Cliente,
Telefone_Cliente,
Celular_Cliente,
Login_Cliente,
Senha_Cliente
)
Values

(
'João de Souza', '398.562.321-21','Rua dos Andradas',107,'Centro','012253-000','Proximo a rua Santa Efigênia',
'(11) 2589-8547','(11) 96595-8549','Joao1234','Afonso24'
),

(
'Cleberson Gilberterson', '859.856.896-88','Rua Marconi',53,'Centro','01047-000','Proximo a Sete de Abril',
'(11) 3152-8596','(11) 98596-3231','Cleberson4321','Judith'
),
(
'Teste','111.111.111-00','Rua Teste',99,'Sul','99445-666','Próximo a sua mãe','(11)5507-3542',null,'a','a'
)

insert into Funcionario(Nome_Func,Login_Func,Senha_Func)
values
('João da Silva','joaosilva','1234'),('Pedro Massaranduba','massaranduba','gerente123')

go


Insert into Pedido
(Data,Valor,Situacao)
Values
('10/11/2014', 50.80,1),
('21/07/2014', 30.50,0),
('15/08/2014', 25.90,0)

go

Insert into Produto
(Nome_Produto,Valor_Venda)
Values
('Macarrão com Almôndega',12.00),
('Panqueca',10.00),
('Escondidinho de carne',15.00),
('Miojo',3.00),
('Tempurá de Camarão',8.00),
('Comercial com Fritas',15.00),
('Sopa de Legumes',10.00),
('Refrigerante Lata',3.00),
('Cerveja Lata',3.50),
('Tequila José Cuervo Ouro(Dose)',20.00)

insert into Pedido_Cliente
(Cod_Cliente, Cod_Pedido, Cod_Produto, Qtd_Prod)
Values
(1,1,6,4),(1,2,5,5),(1,3,1,8)

select * from Cliente

Select * from Pedido

Select * from Produto_Pedido

Select * from Funcionario

Select * from Pedido_Cliente


