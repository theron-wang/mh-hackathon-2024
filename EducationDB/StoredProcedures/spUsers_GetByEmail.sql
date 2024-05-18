CREATE PROCEDURE [dbo].[spUsers_GetByEmail]
	@Email VARCHAR(100)
AS
	select * from Users 
	inner join Tags on Users.Industry = Tags.Id
	where Email = @Email;
RETURN 0
