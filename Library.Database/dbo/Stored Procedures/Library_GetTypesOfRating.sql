CREATE PROCEDURE [dbo].[Library_GetTypesOfRating]
AS
BEGIN
	Select	[Rating_id],
			[Rating]
	From	[Library_BookRatingMaster]
END
