--create database TransactionsDB

--create table Transactions

--(
--	Id int identity(1,1) primary key not null,
--	SourceUserName varchar(50) not null,
--	DestinationUserName varchar(50) not null,
--	Amount int not null,
--	CreatedAt date default GetDate() not null,

--)

--insert into Transactions(SourceUserName,DestinationUserName,Amount) 
--values ('Nato_Japharidze','Jafara_22',300)

--insert into Transactions(SourceUserName,DestinationUserName,Amount) 
--values ('Kvara','Jefferson',200)

--insert into Transactions(SourceUserName,DestinationUserName,Amount) 
--values ('Zhana','Elene',120)

--insert into Transactions(SourceUserName,DestinationUserName,Amount) 
--values ('Jino','Jemala',40)

--Update Transactions set SourceUserName='Daniel', Amount=15000 where id=4

select * from Transactions
Select SourceUserName , DestinationUserName , Amount from Transactions where Amount>100 and SourceUserName='Daniel'
