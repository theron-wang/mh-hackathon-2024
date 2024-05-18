CREATE PROCEDURE [dbo].[spUsers_GetByUsername]
	@Username NVARCHAR(100)
AS
	select * from Users 
	inner join Tags on Users.Industry = Tags.Id
	where Username = @Username;
RETURN 0
