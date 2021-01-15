CREATE PROCEDURE [dbo].[Library_UserBookDataStatus]
	@User_ID int
AS
BEGIN
	SELECT  [Library_BookData].[Book_Id],
			[Library_BookData].[Book_Name],
			[Library_UserBook].[UserBook_id],
			[Library_AuthorMaster].[Author_Name],
			[Date_of_Issue],
			[Return_Date],
			[Library_NewBookCount].[New_Book_Count],
			[Library_UserBookStatus].[UserBookStatus]
	FROM	[Library_UserBook]
			INNER JOIN [Library_UserBookStatus] 
			ON [Library_UserBook].Status_Id			=	[Library_UserBookStatus].[UserBookStatus_Id]
			INNER JOIN [Library_BookData] 
			ON [Library_UserBook].Book_Id			=	[Library_BookData].Book_Id
			INNER JOIN [Library_NewBookCount]
			ON [Library_NewBookCount].[Book_id]		=	[Library_BookData].Book_Id
			INNER JOIN [Library_AuthorMaster]
			ON [Library_AuthorMaster].[Author_Id]	=	[Library_BookData].[Author_Id]
	WHERE	[User_ID]								=	@User_ID AND 
			[UserBookStatus_Id]						=	1
END
