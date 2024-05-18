CREATE PROCEDURE [dbo].[spPosts_GetAll]
AS
	SELECT Posts.*, Responses.*, Users.*, Tags.* FROM Posts
	inner join Users on Posts.UserId = Users.Id
	inner join Tags on Users.Industry = Tags.Id
	inner join ResponsesPostsLink on ResponsesPostsLink.PostId = Posts.Id
	inner join Responses on Responses.Id = ResponsesPostsLink.ResponseId;
RETURN 0
