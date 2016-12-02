CREATE PROCEDURE [dbo].[test_Proc]
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2
RETURN 0
