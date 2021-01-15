CREATE PROCEDURE [dbo].[Library_UpdateNewBookCount]
	@Book_id int,
	@New_Book_Count int
AS
BEGIN
	UPDATE	[Library_NewBookCount]
	SET		New_Book_Count		=	@New_Book_Count
	WHERE	Book_id				=	@Book_id
END
