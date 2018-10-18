USE AdventureWorks2014
GO

CREATE PROCEDURE sp_actualizar_departamentos(
		@nombre VARCHAR(50), @descripcion VARCHAR(50)
)
AS

UPDATE HumanResources.Department SET GroupName = @descripcion 
WHERE Name = @nombre 
GO