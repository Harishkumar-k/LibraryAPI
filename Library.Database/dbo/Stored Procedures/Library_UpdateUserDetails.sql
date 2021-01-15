CREATE PROCEDURE [dbo].[Library_UpdateUserDetails]
	@User_Name nvarchar(50),
	@Password nvarchar(10),
	@Email nvarchar(50),
	@Mobile_Number nvarchar(10),
	@User_Status varchar(20),
	@User_ID int
AS
BEGIN
	UPDATE	[Library_UserData] 
			SET Password	=	@Password,
			Email			=	@Email,
			Mobile_Number	=	@Mobile_Number 
	WHERE	User_ID			=	@User_ID AND 
			User_Status		=	'Active'
END
