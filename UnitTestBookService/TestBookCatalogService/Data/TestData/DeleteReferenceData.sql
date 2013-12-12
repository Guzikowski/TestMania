  DELETE
  FROM [Series]
  
  DBCC CHECKIDENT ([Series], RESEED, 0)
  
  DELETE
  FROM [BookType]
  
  DBCC CHECKIDENT ([BookType], RESEED, 0)
  
  DELETE
  FROM [GenreType]
  
  DBCC CHECKIDENT ([GenreType], RESEED, 0)


