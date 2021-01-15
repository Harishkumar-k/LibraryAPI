CREATE PROCEDURE [dbo].[Library_GetUserDetails]
	@User_ID int
AS
BEGIN
-- =============================================
-- Description	:	<To get the User Details>
-- =============================================
	SELECT  [User_ID],
			[User_Name],
			[Password],
			[Email],
			[Mobile_Number],
			[User_Status]	
	FROM	[Library_UserData] 
	WHERE   [User_ID]=@User_ID
END
GO
