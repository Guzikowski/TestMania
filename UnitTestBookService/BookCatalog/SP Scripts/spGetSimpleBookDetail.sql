/****** Object:  StoredProcedure [dbo].[spGetSimpleBookDetail]    Script Date: 10/03/2009 10:34:27 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spGetSimpleBookDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spGetSimpleBookDetail]
GO

/****** Object:  StoredProcedure [dbo].[spGetSimpleBookDetail]    Script Date: 10/03/2009 10:34:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetSimpleBookDetail] 
	@BookId int
AS

 SELECT 
	   [Book].Id
      ,[Title]
      ,[FirstName]
      ,[LastName]
  FROM [Book] 
  LEFT OUTER JOIN [Author] ON [Book].AuthorId = [Author].Id
  WHERE [Book].Id = @BookId

GO


