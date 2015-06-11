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

set @databasename = 'GiovanelliEmpregos'
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
IF EXISTS (SELECT * from sys.databases where name = 'GiovanelliEmpregos')
DROP DATABASE GiovanelliEmpregos
go

	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** CRIAÇÕES *** ------------------------ 
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

create database GiovanelliEmpregos
go

use GiovanelliEmpregos
go

create table Empresas
(
codEmpresa INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome varchar (50),
Tefelhhy varchar(11)
)
go

create table Funcionarios
(
codFuncionario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
codEmpresa INT FOREIGN KEY REFERENCES Empresas(codEmpresa),
Nome varchar (50),
Email varchar(50) UNIQUE,
Senha varchar(20)
)
go

create table Categorias
(
codCategoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome varchar(40)
)
go

create table Areas
(
codArea INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome varchar (40),
codCategoria int foreign key references Categorias(codCategoria)
)
go

create table Vagas
(
codVaga INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Titulo varchar(50),
Descricao varchar (500),
codEmpresa  INT FOREIGN KEY REFERENCES Empresas(codEmpresa),
Endereco varchar(50),
codCategoria INT FOREIGN KEY REFERENCES Categorias(codCategoria),
codArea INT FOREIGN KEY REFERENCES Areas(codArea),
Data Date,
Estado int
)
go

create table AiDeMim
(
codAdmin int identity(1,1) primary key,
nomeAdmin varchar(40),
emailAdmin varchar(30),
senhaAdmin varchar(20)
)

	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** INSERÇÕES *** -----------------------
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

insert into Empresas values
('Giovanellis Empregos',1132321786),
('Microbloft', 1199993213),
('Giovanellis Engenharia', 1132165487)
go

insert into Funcionarios values
(1, 'Emerson Talarico', 'emerson.giovanelli@suzano.com.br', 'talaris')
go

insert into Categorias values
('Informática'),
('Administração'),
('Construção Civil')
go

insert into Areas values
('Banco de Dados',1),
('Técnico de Infra Estrutura',1),
('Help Desk',1),
('Analista de Sistema',1),
('Desenvolvimento',1),
('RH',2),
('Auxiliar Administrativo',2),
('Técnico Bancário',2),
('Almoxarifado',2),
('Arquiteto',3),
('Projetista',3),
('Engenheiro',3)

go

insert into Vagas values
('Analista de sistemas', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas em C#', 2, 'Alameda da Lambranda, 388, Vila Odin, São Paulo', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 50),103) , 1),
('Desenvolvedor de sistemas', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas em Java', 2, 'Alameda da Lambranda, 388, Vila Odin, São Paulo', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 50),103) , 1),
('Avalista de sistemas', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas em ASP.NET', 2, 'Alameda da Lambranda, 388, Vila Odin, São Paulo', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 50),103) , 1),
('Engenheiro de produção', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas de produção', 3, 'Alameda Suzano, 388, Vila Suzano, Suzano', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 365),103) , 1),
('Engenheiro de aplicação', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas de produção', 1, 'Alameda Suzano, 388, Vila Suzano, Suzano', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 365),103) , 1)
go

insert into AiDeMim values
('Emerson','emerson@sos.com.br','123456')

go
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** PROCS *** ---------------------------
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

create proc USP_BuscarVagas
AS
	Begin
		select
			e.Nome [Empresa],
			e.Tefelhhy [Telefone],
			v.Titulo [Título da vaga],
			v.Descricao [Descrição],
			v.Endereco [Endereço],
			CONVERT(VARCHAR(10), v.Data,103) [Data de publicação]
		
		from Vagas v
		inner join Empresas e on
			v.codEmpresa = e.codEmpresa and
			DATEDIFF(day,v.Data, GETDATE()) < 30 and
			v.Estado = 1

		order by
			v.Data
				desc
	End
go

create proc USP_BuscarVagasPorTitulo
(
	@Titulo varchar(50)
)
AS
	Begin
		select
			e.Nome [Empresa],
			e.Tefelhhy [Telefone],
			v.Titulo [Título da vaga],
			v.Descricao [Descrição],
			v.Endereco [Endereço],
			CONVERT(VARCHAR(10), v.Data,103) [Data de publicação]
		
		from Vagas v
		inner join Empresas e on
			v.codEmpresa = e.codEmpresa and
			DATEDIFF(day,v.Data, GETDATE()) < 30 and
			v.Titulo like '%' + @Titulo + '%' and
			v.Estado = 1
			
		order by
			v.Data 
				desc
	End
go

create procedure USP_AdicionarCategoria
(
	@nome varchar(40)
)
as
	Begin
		insert into Categorias values(@nome)
	End

go

create procedure USP_EditarCategoria
(
	@novoNome varchar(40),
	@codigoCategoria int
)
as
	Begin
		update Categorias set Nome = @novoNome where codCategoria = @codigoCategoria
	End

go

create procedure USP_RemoverCategoria
(
	@codigoCategoria int
)
as
	Begin
		delete from Categorias where codCategoria = @codigoCategoria
	End

go


create procedure USP_AdicionarArea
(
	@NomeArea varchar(40),
	@codigoCategoria int
)
as
	Begin
		insert into Areas (Nome,codCategoria) values (@NomeArea,@codigoCategoria)
	End

go


create procedure USP_DeletarArea

(
@codArea int
)

as

begin

delete from Areas where codArea = @codArea

end



go


create procedure USP_EditarNomeArea

(
@NomeArea varchar (40),
@codArea int
)

as

begin

	update Areas set Nome = @NomeArea where codArea = @codArea

end

go

create procedure USP_Login_Func
(
	@email varchar(40),
	@senha varchar(30)
)
as
	Declare @codigo as int
	
	Begin
		set @codigo = 0

		select @codigo = codFuncionario from Funcionarios where Email = @email and Senha = @senha

		if (@codigo > 0)
			Begin
				select codFuncionario, Nome, codEmpresa from Funcionarios where Email = @email and Senha = @senha
			End
	End

go

create procedure USP_Login_Admin
(
	@email varchar(40),
	@senha varchar(30)
)
as
	Declare @codigo as int
	
	Begin
		set @codigo = 0

		select @codigo = codAdmin from AiDeMim where emailAdmin = @email and senhaAdmin = @senha

		if (@codigo > 0)
			Begin
				select codAdmin, nomeAdmin from AiDeMim where emailAdmin = @email and senhaAdmin = @senha
			End
	End
	
	go
	
	create procedure USP_AdicionarVaga
(
	@Titulo varchar(50),
	@Descricao varchar (100),
	@CodEmpresa int,
	@Endereco varchar (100),
	@CodCategoria int,
	@CodArea int,
	@Data date
	
	
)

as
declare @Estado int
set @Estado = 1

	Begin
		insert into Vagas (Titulo, Descricao, codEmpresa, Endereco,codCategoria, codArea, Data, Estado)
		 values(@Titulo, @Descricao, @CodEmpresa, @Endereco, @CodCategoria, @CodArea, @Data, @Estado)
	End


go

create procedure USP_EditarVaga
(
	@CodVaga int,
	@NovoTitulo varchar(50),
	@NovaDescricao varchar (100),
	@CodEmpresa int,
	@NovoEndereco varchar (100),
	@CodCategoria int,
	@CodArea int,
	@NovaData date,
	@Estado int
)
as
	Begin
		update Vagas set Titulo = @NovoTitulo, Descricao = @NovaDescricao, codEmpresa = @CodEmpresa, Endereco = @NovoEndereco
		,codCategoria = @CodCategoria, codArea = @CodArea, Data = @NovaData, Estado = @Estado
		 where codVaga = @CodVaga
	End
	
	

go

create procedure USP_RemoverVaga
(
	@CodVaga int
)
as
	Begin
		delete from Vagas where codVaga = @CodVaga
	End
	
	
	go
	
	create procedure USP_AtivarInativarVagas
	
	(
	@CodVaga int,
	@Estado int
	)
	
	as
	declare @Estado2 int
	
	Begin
	
	set @Estado2 = (select Estado from Vagas where codVaga = @CodVaga)
	
	
	if (@Estado2 = 1)
		begin
			Update Vagas set Estado = 0 where codVaga = @CodVaga
		end
	else
		begin
			Update Vagas set Estado = 1 where codVaga = @CodVaga
		end
	end
	
go
	
	create proc USP_BuscarVagasEmpresa
	(
		@codEmpresa int
	)
AS
	Begin
		select v.Titulo, v.Descricao, v.Endereco, v.codCategoria, v.codArea from Vagas as v inner join Categorias as c on codEmpresa = 1 inner join Areas as a on a.codArea = v.codArea and c.codCategoria = v.codCategoria
	End
go