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

set @databasename = 'GiovanellisEmpregos'
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
IF EXISTS (SELECT * from sys.databases where name = 'GiovanellisEmpregos')
DROP DATABASE GiovanellisEmpregos
go

	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** CRIAÇÕES *** ------------------------ 
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

create database GiovanellisEmpregos
go

use GiovanellisEmpregos
go

create table Empresas
(
codEmpresa INT NOT NULL IDENTITY(1,1) PRIMARY KEY
, Nome varchar (50)
, Tefelhhy varchar(11)
)
go

create table Funcionarios
(
codFuncionario INT NOT NULL IDENTITY(1,1) PRIMARY KEY
, codEmpresa INT FOREIGN KEY REFERENCES Empresas(codEmpresa)
, Nome varchar (50)
, Email varchar(50) UNIQUE
, Senha varchar(20)
)
go

create table Categorias
(
codCategoria INT NOT NULL IDENTITY(1,1) PRIMARY KEY
, Nome varchar(20)
)

go

create table Areas
(
codArea INT NOT NULL IDENTITY(1,1) PRIMARY KEY
, Nome varchar (20)
)
go

create table Vagas
(
codVaga INT NOT NULL IDENTITY(1,1) PRIMARY KEY
, Titulo varchar(50)
, Descricao varchar (500)
, codEmpresa  INT FOREIGN KEY REFERENCES Empresas(codEmpresa)
, Endereco varchar(50)
, codCategoria INT FOREIGN KEY REFERENCES Categorias(codCategoria)
, codArea INT FOREIGN KEY REFERENCES Areas(codArea)
, Vigencia Date
, Estado int
)
go

	-------------------------------------------------------------- 
	-------------------------------------------------------------- 
	-------------------- *** INSERÇÕES *** -----------------------
	-------------------------------------------------------------- 
	-------------------------------------------------------------- 

insert into Empresas values
('Giovanellis Empregos',1132321786),
('Microbloft', 1199993213)

insert into Funcionarios values
(1, 'Emerson Talarico', 'emerson.giovanelli@suzano.com.br', 'talaris')

insert into Categorias values
('Informática'),
('Administração'),
('Construção Civil') 

insert into Areas values
('Informática'),
('Administração'),
('Construção Civil') 

insert into Vagas values
(
'Analista de sistemas',
'Análize, desenvolvimento, acompanhamento e evolução de sistemas em C#',
2,
'Alameda da Lambranda, 388, Vila Odin, São Paulo',
1,
1,
'2015-8-28',
1
)