CREATE TABLE [dbo].[Library_UserData] (
    [User_ID]       INT NOT NULL IDENTITY(1,1),
    [User_Name]     NVARCHAR (50) NOT NULL,
    [Password]      NVARCHAR (10) NOT NULL,
    [Email]         NVARCHAR (50) NOT NULL,
    [Mobile_Number] nvarchar(10)  NULL,
    [User_Status]   VARCHAR (20)  NULL,
);

