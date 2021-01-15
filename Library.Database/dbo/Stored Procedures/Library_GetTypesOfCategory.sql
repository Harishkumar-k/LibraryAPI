CREATE PROCEDURE [dbo].[Library_GetTypesOfCategory]
AS
BEGIN
	SELECT	[Category_Id],
			[Category_Name]
	From	[Library_CategoryMaster]
END
