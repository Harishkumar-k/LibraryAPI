CREATE TABLE [dbo].[Library_BookData] (
    [Book_Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Book_Name]       NVARCHAR(MAX) NULL,
    [Author_Id]       INT          NULL,
    [Date_of_release] DATETIME     NULL,
    [Rating_id]       INT          NULL,
    [BookCount]       INT          NULL, 
    [BookImages] NVARCHAR(MAX) NULL
);

