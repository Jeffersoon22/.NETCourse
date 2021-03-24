use normalization_tutorial_2
go

set transaction isolation level serializable
go

begin transaction
	
	declare @authorIdToDelete int = (select top 1 Id from Author where [Name] = 'Mark Twain')
	declare @bookIdToDelete int = (select top 1 b.Id from Book b
									inner join BookAuthor ba on b.Id = ba.BookId
									where ba.AuthorId = @authorIdToDelete)
	
	delete from BookAuthor where AuthorId = @authorIdToDelete
	delete from Book where Id = @bookIdToDelete
	delete from Author where Id = @authorIdToDelete

commit