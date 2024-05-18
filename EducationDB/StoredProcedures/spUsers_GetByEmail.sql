CREATE PROCEDURE [dbo].[spUsers_GetByEmail]
	@Email VARCHAR(100)
AS
	select Users.Id, Users.Username, Users.Email, Users.PasswordHash, Tags.* from Users 
	inner join Tags on Users.Industry = Tags.Id
	where Email = @Email;
RETURN 0
