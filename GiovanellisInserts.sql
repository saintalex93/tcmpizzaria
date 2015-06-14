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
('Final de semana','Pizzas com 15% de desconto até dia 23 de Maio!',85, '2015-05-23', 1,0),
('Super três queijos','Pizza de três queijos com 25% de desconto!.',75, '2016-01-01', 1,0),
('Olha o refrigerante','Refrigerante agora está mais barato',90, '2016-01-01', 1, 1)
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
(450.00, '15/10/2015', 1,1),
(290.00, '20/09/2015', 3,2),
(200.00, '17/09/2015', 2,3),
(350.00, '22/10/2015', 4,3)
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

insert into DetalheCompra 
values
(1,1,2,35,6),
(1,1,9,16,15),
(3,2,16,50,4),
(4,4,3,15,10),
(4,4,1,20,10),
(2,3,13,20,10),
(2,3,8,9,10)