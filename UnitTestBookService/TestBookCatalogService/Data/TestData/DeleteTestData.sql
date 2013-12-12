  DELETE
  FROM [Book]
  
  DBCC CHECKIDENT ([Book], RESEED, 0)
  
  DELETE
  FROM [Author]
  
  DBCC CHECKIDENT ([Author], RESEED, 0)
  
  DELETE
  FROM [Collection]
  
  DBCC CHECKIDENT ([Collection], RESEED, 0)


