use normalization_tutorial_2
go

set transaction isolation level serializable
go

begin transaction

	insert into Author ([Name])
	values 
	('F. Scott Fitzgerald'), 
	('Mark Twain')

	insert into Branch([Name])
	values 
	('Main'),
	('Common')

	insert into Publisher([Name])
	values 
	('Charles Scribner''s Sons'), 
	('James R. Osgood & Co.')

commit

begin transaction
	
	insert into Book([Name], PublisherId, [year], Pages, Illustrations, BranchId)
	values('The great Gatsby', 1, 1925, 200, 0, 1)

	insert into Book([Name], PublisherId, [year], Pages, Illustrations, BranchId)
	values('Flappers and Philosophers', 1, 1920, 120, 6, 1)
	
rollback


begin transaction
	insert into Book([Name], PublisherId, [year], Pages, Illustrations, BranchId)
	values('The great Gatsby', 1, 1925, 200, 0, 1)

	insert into BookAuthor(BookId, AuthorId)
	values
	((select top 1 Id from Book where [Name]='The great Gatsby'),
	(select top 1 Id from Author where [Name] = 'F. Scott Fitzgerald'))

	insert into BookAuthor(BookId, AuthorId)
	values
	((select top 1 Id from Book where [Name]='Flappers and Philosophers'),
	(select top 1 Id from Author where [Name] = 'F. Scott Fitzgerald'))

commit

begin transaction

	insert into Book([Name], [year], Pages,  PublisherId, Illustrations, BranchId)
	values
	('The Adventures of Tom Sawyer', 1876, 298, 2, 23,  1),
	('The Prince and the Pauper', 1881, 85, 2, 0,  2)

	insert into BookAuthor(BookId, AuthorId)
	values
	((select top 1 Id from Book where [Name]='The Adventures of Tom Sawyer'),
	(select top 1 Id from Author where [Name] = 'Mark Twain'))

	insert into BookAuthor(BookId, AuthorId)
	values
	((select top 1 Id from Book where [Name]='The Prince and the Pauper'),
	(select top 1 Id from Author where [Name] = 'Mark Twain'))

commit



