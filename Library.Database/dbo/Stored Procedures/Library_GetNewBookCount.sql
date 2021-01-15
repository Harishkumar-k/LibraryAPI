CREATE PROCEDURE [dbo].[Library_GetNewBookCount]
	@Book_id int
AS
BEGIN
	RETURN (SELECT New_Book_Count FROM Library_NewBookCount WHERE Book_id=@Book_id)
END
