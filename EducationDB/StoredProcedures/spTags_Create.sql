﻿CREATE PROCEDURE [dbo].[spTags_Create]
	@Name NVARCHAR(100)
AS
	insert into Tags (Name) values (@Name);
RETURN 0
