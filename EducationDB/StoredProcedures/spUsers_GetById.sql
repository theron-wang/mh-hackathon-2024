CREATE PROCEDURE [dbo].[spUsers_GetById]
	@Id int
AS
	select Users.Id, Users.Username, Users.Email, Users.PasswordHash, Tags.* from Users 
	inner join Tags on Users.Industry = Tags.Id
	where Users.Id = @Id;
RETURN 0
