CREATE PROCEDURE [dbo].[Library_UpdateUserBook]
	@Book_id int,
	@UserBook_id int,
	@User_ID int,
	@User_Return_Date datetime,
	@New_Book_Count int
AS
BEGIN
	UPDATE	[Library_UserBook] 
	SET		[User_Return_Date]	= @UserBook_id,
			[Status_Id]		= 2
	WHERE	[Library_UserBook].[UserBook_id]	=	@UserBook_id AND
			[Library_UserBook].[User_ID]		=	@User_ID
	EXEC	[Library_UpdateNewBookCount] 
				@Book_id,
				@New_Book_Count
END
