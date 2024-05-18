CREATE PROCEDURE [dbo].[spPosts_Delete]
	@Id int
AS
	delete from Posts where Id = @Id;
	delete from Responses where Id in (select ResponseId from ResponsesPostsLink where PostId = @Id);
	delete from ResponsesPostsLink where PostId = @Id;
RETURN 0
