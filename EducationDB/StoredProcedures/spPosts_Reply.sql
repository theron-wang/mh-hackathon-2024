CREATE PROCEDURE [dbo].[spPosts_Reply]
	@Id int,
	@UserId int,
	@Text ntext
AS
	insert into Posts
	(UserId, Text)
	values
	(@UserId, @Text);

	insert into ResponsesPostsLink
	(PostId, ResponseId)
	values
	(@Id, SCOPE_IDENTITY());
RETURN 0
