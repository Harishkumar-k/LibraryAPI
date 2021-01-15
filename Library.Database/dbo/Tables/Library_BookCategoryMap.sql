
CREATE TABLE [dbo].[Library_BookCategoryMap]
(
	[Category_Id] INT NULL , 
    [Book_id] INT NULL, 
    [BookCategory_Id] INT NOT NULL, 
    PRIMARY KEY ([BookCategory_Id])
)
