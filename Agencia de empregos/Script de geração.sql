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
Nome varchar(20)
)

go

create table Areas
(
codArea INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome varchar (20)
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
('Informática'),
('Administração'),
('Construção Civil') 
go

insert into Vagas values
('Analista de sistemas', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas em C#', 2, 'Alameda da Lambranda, 388, Vila Odin, São Paulo', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 50),103) , 1),
('Desenvolvedor de sistemas', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas em Java', 2, 'Alameda da Lambranda, 388, Vila Odin, São Paulo', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 50),103) , 1),
('Avalista de sistemas', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas em ASP.NET', 2, 'Alameda da Lambranda, 388, Vila Odin, São Paulo', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 50),103) , 1),
('Engenheiro de produção', 'Análise, desenvolvimento, acompanhamento e evolução de sistemas de produção', 3, 'Alameda Suzano, 388, Vila Suzano, Suzano', 1, 1, CONVERT(VARCHAR(10),GETDATE()- ABS(Checksum(NewID()) % 365),103) , 1)
go

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
			DATEDIFF(day,v.Data, GETDATE()) < 30

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
			v.Titulo like '%' + @Titulo + '%'
			
		order by
			v.Data 
				desc
	End
go