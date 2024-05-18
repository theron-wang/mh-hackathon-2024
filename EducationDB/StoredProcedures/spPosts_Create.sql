CREATE PROCEDURE [dbo].[spPosts_Create]
	@UserId int,
    @Text ntext
AS
    INSERT INTO Posts (UserId, Text)
    VALUES (@UserId, @Text);
RETURN 0