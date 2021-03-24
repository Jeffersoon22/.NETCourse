--create database BankDb

--create table Clients (
--	Id int identity(1,1) primary key,
--	[Name] varchar(30),
--	CardNumber varchar(30),
--	Balance decimal
--)
--GO
--create table Dispansers(
--	Id int identity(1,1) primary key,
--	[Address] varchar(100)
--)
--GO
--create table Operations(
--	Id int identity(1,1) primary key,
--	ClientId int foreign key references Clients(Id),
--	DispanserId int foreign key references Dispansers(Id),
--	DateOfOperation DateTime,
--	Amount decimal
--)
--GO



--insert into Clients([Name], CardNumber, Balance)
--values('Natali', '47001041260', 150)

--insert into Dispansers([Address])
--values('99 A.Tsereteli Avenue')



--use BankDb
--GO



--set transaction isolation level serializable
--GO


begin transaction

	declare @AmountToWithdraw decimal = 50
	declare @ClientId int = 1


	insert into Operations(ClientId, DispanserId, DateOfOperation, Amount)
	values(@ClientId, 1, Getdate(), @AmountToWithdraw)

	update Clients
	set Balance -= @AmountToWithdraw
	where Id = @ClientId

commit