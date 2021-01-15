CREATE PROCEDURE [dbo].[Library_CheckUser]
	@Email nvarchar(50),
	@Password nvarchar(10)
AS
Begin
	SELECT	[User_ID],
			[User_Name],
			[Password],
			[Email],
			[Mobile_Number],
			[User_Status]
	FROM	[Library_UserData] 
	WHERE	[Email]		=	@Email AND 
			[Password]	=	@Password
End
