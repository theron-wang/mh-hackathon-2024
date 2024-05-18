CREATE PROCEDURE [dbo].[spUsers_Create]
	@Username nvarchar(100),
	@Email varchar(100),
	@PasswordHash char(60),
	@Industry int
AS
	insert into Users
	(Username, Email, PasswordHash, Industry)
	values
	(@Username, @Email, @PasswordHash, @Industry);
RETURN 0
