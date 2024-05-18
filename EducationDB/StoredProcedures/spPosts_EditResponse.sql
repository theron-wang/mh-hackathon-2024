CREATE PROCEDURE [dbo].[spPosts_EditResponse]
	@Id int,
	@Text ntext
AS
	update Posts
	set 
	Text = @Text
	where Id = @Id;
RETURN 0
