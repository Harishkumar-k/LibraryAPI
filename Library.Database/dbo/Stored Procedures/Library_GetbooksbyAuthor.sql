CREATE PROCEDURE [dbo].[Library_GetbooksbyAuthor]
	@Author_Id int
AS
BEGIN
	SELECT  [Library_BookData].[Book_Id],
			[Book_Name],
			[Author_Name],
			[Date_of_release],
			[Rating],
			[BookCount],
			[New_Book_Count]
	FROM	[Library_BookData] 
			INNER JOIN [Library_BookRatingMaster] 
				ON  [Library_BookData].Rating_id	=	[Library_BookRatingMaster].Rating_id
			INNER JOIN [Library_AuthorMaster]
				ON [Library_BookData].Author_Id		=	[Library_AuthorMaster].Author_Id
			INNER JOIN [Library_NewBookCount] 
				ON [Library_BookData].Book_Id		=	[Library_NewBookCount].Book_id
	Where	[Library_BookData].[Author_Id]			=	@Author_Id
END