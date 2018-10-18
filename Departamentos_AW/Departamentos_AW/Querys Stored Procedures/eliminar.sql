USE AdventureWorks2014
GO

CREATE PROCEDURE sp_eliminar_departamentos(
		@nombre VARCHAR(50)
)
AS
DELETE FROM HumanResources.Department 
WHERE Name = @nombre 
GO