CREATE TABLE [dbo].[Library_UserBook](
	[UserBook_id] [int] IDENTITY(1,1) NOT NULL,
	[Book_id] [int] NOT NULL,
	[Date_of_Issue] [datetime] NULL,
	[User_ID] [int] NULL,
	[Status_Id] [int] NULL,
	[Return_Date] [datetime] NULL,
	[User_Return_Date] [datetime] NULL,
[Rating] INT NULL, 
    PRIMARY KEY CLUSTERED 
(
	[UserBook_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]