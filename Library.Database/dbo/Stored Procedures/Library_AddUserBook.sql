CREATE PROCEDURE [dbo].[Library_AddUserBook]
	@Book_id int,
	@Date_of_Issue smalldatetime,
	@User_ID int,
	@Status_Id int,	
	@Return_Date smalldatetime,
	@New_Book_Count int
AS
BEGIN
	--DECLARE @New_Book_Count bigint
	--EXEC @New_Book_Count = [dbo].[Library_GetNewBookCount] @Book_id
	--set @New_Book_Count = @New_Book_Count -1
	--if @New_Book_Count != 0
	--	BEGIN
			INSERT INTO [Library_UserBook] 
						(Book_id,
						Date_of_Issue,
						User_ID,
						Status_Id,
						Return_Date) 
			Values		(@Book_id,
						@Date_of_Issue,
						@User_ID,
						@Status_Id,
						@Return_Date)
			EXEC		[Library_UpdateNewBookCount] 
						@Book_id,
						@New_Book_Count
		--END
END
