CREATE PROCEDURE [dbo].[spPosts_GetById]
	@Id int
AS
	SELECT Posts.*, Responses.*, Users.Id, Users.Username, Users.Email, Users.PasswordHash, Tags.* FROM Posts
	inner join Users on Posts.UserId = Users.Id
	inner join Tags on Users.Industry = Tags.Id
	left join ResponsesPostsLink on ResponsesPostsLink.PostId = Posts.Id
	left join Responses on Responses.Id = ResponsesPostsLink.ResponseId
	where Posts.Id = @Id;
RETURN 0
