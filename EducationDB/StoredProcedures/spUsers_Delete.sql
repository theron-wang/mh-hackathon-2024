CREATE PROCEDURE [dbo].[spUsers_Delete]
	@Id int
AS
	delete from Users where Id=@Id;
RETURN 0
