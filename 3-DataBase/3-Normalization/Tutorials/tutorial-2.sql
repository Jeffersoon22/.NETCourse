create database nato_japharidze_Normalization_Tutorial_2
go
use nato_japharidze_Normalization_Tutorial_2
go
create table Publisher(
	Id int Identity(1,1) Primary Key,
	[Name] nvarchar(MAX)
)
GO
create table Author(
	Id int Identity(1,1) Primary Key,
	[Name] nvarchar(MAX)
)
GO
create table Faculty(
	Id int Identity(1,1) Primary Key,
	[Name] nvarchar(MAX)
)
GO
create table Branch(
	Id int Identity(1,1) Primary Key,
	[Name] nvarchar(MAX)
)
GO
create table Student(
	Id int Identity(1,1) Primary Key,
	[Name] nvarchar(MAX),
	FacultyId int Foreign Key references Faculty(Id)
)
GO
create table Book(
	Id int Identity(1,1) Primary Key,
	[Name] nvarchar(MAX),
	[Year] int,
	Pages int,
	Illustrations int,
	PublisherId int Foreign key references Publisher(Id),
	BranchId int Foreign key references Branch(Id),
)
create table BookAuthor(
	Id int Identity(1,1) Primary Key,
	BookId int foreign key references Book(Id),
	AuthorId int foreign key references Author(Id),
)
create table Warehouse(
	Id int Identity(1,1) Primary Key,
	BookId int foreign key references Book(Id),
	[Count] int 
)
create table Bookpicking(
	Id int Identity(1,1) Primary Key,
	BookId int foreign key references Book(Id),
	StudentId int foreign key references Student(Id),
	StartDate datetime,
	EndDate datetime,
)