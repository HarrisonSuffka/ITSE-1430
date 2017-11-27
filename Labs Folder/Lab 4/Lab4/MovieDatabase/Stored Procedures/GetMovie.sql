CREATE PROCEDURE [dbo].[GetMovie]
	@id INT
AS BEGIN
	SET NOCOUNT ON;

	SELECT Id, Title, Description, Length, isOwned
	FROM Movies
	WHERE Id = @id
END
