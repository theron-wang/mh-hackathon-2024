CREATE PROCEDURE [dbo].[spPosts_DeleteResponse]
	@Id int
AS
	delete from Responses
	where Id = @Id;
RETURN 0
