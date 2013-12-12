/****** 
* Input Parameters
*		@BookId int
 ******/

 SELECT
       [Book].Id 
      ,[Title]
      ,[FirstName]
      ,[LastName]
  FROM [Book]
  LEFT OUTER JOIN [Author] ON [Book].AuthorId = [Author].Id
  WHERE [Book].Id = @BookId


