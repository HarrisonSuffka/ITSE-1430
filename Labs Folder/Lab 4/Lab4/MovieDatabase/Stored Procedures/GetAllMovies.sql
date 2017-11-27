CREATE PROCEDURE [dbo].[GetAllMovies]	
AS BEGIN
	SET NOCOUNT ON;

	SELECT Id, Title, Description, Length, isOwned
	FROM Movies
END
