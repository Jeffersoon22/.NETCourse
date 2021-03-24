--create table ArchiveOperation(
--	Id int identity(1,1) primary key,
--	ClientId int foreign key references Clients(Id),
--	DispanserId int foreign key references Dispansers(Id),
--	DateOfOperation DateTime,
--	Amount decimal
--)
--GO



--use BankDb
--GO
--set transaction isolation level serializable
--Go



--begin transaction

--	declare @AmountToWithdraw decimal = 1
--	declare @ClientId int = 1


--	insert into Operations(ClientId, DispanserId, DateOfOperation, Amount)
--	values(@ClientId, 1, Getdate(), @AmountToWithdraw)

--	update Clients
--	set Balance -= @AmountToWithdraw
--	where Id = @ClientId


--commit



--begin transaction

--	set @AmountToWithdraw = 2
--	set @ClientId = 1


--	insert into Operations(ClientId, DispanserId, DateOfOperation, Amount)
--	values(@ClientId, 1, Getdate(), @AmountToWithdraw)

--	update Clients
--	set Balance -= @AmountToWithdraw
--	where Id = @ClientId

--commit


--begin transaction

--	set @AmountToWithdraw = 3
--	set @ClientId = 1


--	insert into Operations(ClientId, DispanserId, DateOfOperation, Amount)
--	values(@ClientId, 1, Getdate(), @AmountToWithdraw)

--	update Clients
--	set Balance -= @AmountToWithdraw
--	where Id = @ClientId


--commit




--begin transaction

--	set @AmountToWithdraw = 4
--	set @ClientId = 1


--	insert into Operations(ClientId, DispanserId, DateOfOperation, Amount)
--	values(@ClientId, 1, Getdate(), @AmountToWithdraw)

--	update Clients
--	set Balance -= @AmountToWithdraw
--	where Id = @ClientId

--commit


--begin transaction

--	set @AmountToWithdraw = 5
--	set @ClientId = 1


--	insert into Operations(ClientId, DispanserId, DateOfOperation, Amount)
--	values(@ClientId, 1, Getdate(), @AmountToWithdraw)

--	update Clients
--	set Balance -= @AmountToWithdraw
--	where Id = @ClientId

--commit




--use BankDb
--GO



--set transaction isolation level serializable
--GO



--begin transaction

--insert into ArchiveOperation
--select top 3 ClientId, DispanserId, DateOfOperation, Amount 
--from Operations 
--order by DateOfOperation desc

delete top (3) from Operations

commit
