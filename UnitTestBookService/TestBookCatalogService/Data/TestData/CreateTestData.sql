  INSERT INTO [Author] ([FirstName], [LastName])     
       VALUES  ('John', 'Doe')
 
  INSERT INTO [Author] ([FirstName], [LastName])     
       VALUES  ('Thomas', 'Harris')
       
  INSERT INTO [Author] ([FirstName], [LastName], [AliasId])     
       VALUES  ('Mark', 'Wright', 1)
       
   INSERT INTO [Collection] ([BookTypeId], [DateAdded])
       VALUES  (1, GETDATE())

   INSERT INTO [Collection] ([BookTypeId], [DateAdded])
       VALUES  (2, GETDATE())
       
   INSERT INTO [Collection] ([BookTypeId], [DateAdded])
       VALUES  (3, GETDATE())
       
       
  INSERT INTO [Book]
           ([Title], [AuthorId], [ISBN], [SeriesId], [GenreTypeId], [CollectionId])
     VALUES
           ('Four Minutes Past Yesterday', 1, '123-1223121-000', 1, 1, 1)
  INSERT INTO [Book]
           ([Title], [AuthorId], [ISBN], [SeriesId], [GenreTypeId], [CollectionId])
     VALUES
           ('Moon Glorious', 2, '123-5454545-000', 2, 2, 2)

  INSERT INTO [Book]
           ([Title], [AuthorId], [ISBN], [SeriesId], [GenreTypeId], [CollectionId])
     VALUES
           ('Blind as a Mime', 3, '123-9898898-000', 3, 3, 3)
  
  INSERT INTO [Book]
           ([Title], [AuthorId], [ISBN], [SeriesId], [GenreTypeId])
     VALUES
           ('Tomorrow is Today, Yesterday', 1, '123-766766-000', 1, 1)
