CREATE TABLE [dbo].[ResponsesPostsLink]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ResponseId] INT NOT NULL,
	[PostId] INT NOT NULL
)
