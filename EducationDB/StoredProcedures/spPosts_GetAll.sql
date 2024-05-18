CREATE PROCEDURE [dbo].[spPosts_GetAll]
AS
	SELECT Posts.*, Responses.*, Users.Id, Users.Username, Users.Email, Users.PasswordHash, Tags.* FROM Posts
	inner join Users on Posts.UserId = Users.Id
	inner join Tags on Users.Industry = Tags.Id
	left join ResponsesPostsLink on ResponsesPostsLink.PostId = Posts.Id
	left join Responses on Responses.Id = ResponsesPostsLink.ResponseId
	order by Posts.Id desc;
RETURN 0
