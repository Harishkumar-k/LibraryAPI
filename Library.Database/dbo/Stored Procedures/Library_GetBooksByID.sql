CREATE PROCEDURE [dbo].[Library_GetBooksByID]
	@Book_id int
AS
BEGIN
	SELECT  [Library_BookData].[Book_Id],
			[Book_Name],
			[Author_Name],
			[Date_of_release],
			[Rating],
			[Library_BookData].[Rating_id],
			[BookCount],
			[BookImages],
			[New_Book_Count]
	FROM	[Library_BookData] 
			INNER JOIN [Library_BookRatingMaster] 
				ON  [Library_BookData].Rating_id	=	[Library_BookRatingMaster].Rating_id
			INNER JOIN [Library_AuthorMaster]
				ON [Library_BookData].Author_Id		=	[Library_AuthorMaster].Author_Id
			INNER JOIN [Library_NewBookCount] 
				ON [Library_BookData].Book_Id		=	[Library_NewBookCount].Book_id
	Where	[Library_BookData].[Book_Id]			=	@Book_id
	SELECT	Book_id,
			[Library_BookCategoryMap].Category_Id,
			Category_Name
	FROM	[Library_BookCategoryMap]
			INNER JOIN [Library_CategoryMaster] ON
			[Library_CategoryMaster].Category_Id	=	[Library_BookCategoryMap].Category_Id
	Where	Book_id									=	@Book_id
END
