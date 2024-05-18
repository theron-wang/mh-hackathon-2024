CREATE PROCEDURE [dbo].[spUsers_GetByUsername]
	@Username NVARCHAR(100)
AS
	select Users.Id, Users.Username, Users.Email, Users.PasswordHash, Tags.* from Users 
	inner join Tags on Users.Industry = Tags.Id
	where Username = @Username;
RETURN 0
