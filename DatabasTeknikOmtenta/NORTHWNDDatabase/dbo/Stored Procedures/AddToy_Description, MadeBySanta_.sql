CREATE PROCEDURE [dbo].[AddToy(Description, MadeBySanta)]
	@ToyID int,
	@description nchar(40),
	@MadeBySanta bit
AS
	INSERT INTO [dbo].[Toys]
	([ToyID]
	,[Description]
	,[MadeBySanta])

VALUES
	(@ToyID
	,@description
	,@MadeBySanta)