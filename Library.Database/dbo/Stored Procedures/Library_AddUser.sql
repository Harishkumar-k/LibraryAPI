CREATE PROCEDURE [dbo].[Library_AddUser]
	@User_Name nvarchar(50),
	@Password nvarchar(10),
	@Email nvarchar(50),
	@Mobile_Number nvarchar(10),
	@User_ID int,
	@User_Status varchar(20)="Active"

AS
BEGIN
	INSERT INTO [Library_UserData] (
				User_Name,
				Password,
				Email,
				Mobile_Number,
				User_Status) 
	Values		(@User_Name,
				@Password,
				@Email,
				@Mobile_Number,
				@User_Status)
END
