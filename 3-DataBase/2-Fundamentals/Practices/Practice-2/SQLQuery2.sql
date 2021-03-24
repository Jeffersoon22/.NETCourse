--create table ReprocessingTransactions

--(
--	Id int identity(1,1) primary key not null,
--	TransactionId int foreign key references Transactions(Id) not null,
--	ProcessAt date not null,
--	Reason text,
--	CreatedAt date default GetDate() not null,
--)

--alter table ReprocessingTransactions add Author varchar(50) not null

--insert into ReprocessingTransactions(TransactionId,ProcessAt,Reason, Author) values (1, '2022-11-22', 'Birthday','Jafara')

--insert into ReprocessingTransactions(TransactionId,ProcessAt,Reason, Author) values (2, '2022-11-22', 'Birthday','Elene')

--insert into ReprocessingTransactions(TransactionId,ProcessAt,Reason, Author) values (3, '2022-12-22', 'Christmas','Zhana')

--insert into ReprocessingTransactions(TransactionId,ProcessAt,Reason, Author) values (4, '2022-12-22', 'new year','Jino')

select * from ReprocessingTransactions as a join Transactions as b on b.Id=a.TransactionId


select * from ReprocessingTransactions