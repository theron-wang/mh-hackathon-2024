CREATE PROCEDURE [dbo].[spUsers_Update]
	@Id int,
	@Username nvarchar(100),
	@Email varchar(100),
	@Industry int
AS
	update Users set
	Username=@Username,
	Email=@Email,
	Industry=@Industry
	where Id=@Id;
RETURN 0
