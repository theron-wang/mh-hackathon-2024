CREATE PROCEDURE [dbo].[spUsers_GetById]
	@Id int
AS
	select * from Users 
	inner join Tags on Users.Industry = Tags.Id
	where Users.Id = @Id;
RETURN 0
