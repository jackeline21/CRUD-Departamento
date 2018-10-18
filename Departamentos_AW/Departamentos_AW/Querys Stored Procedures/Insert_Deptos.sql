USE AdventureWorks2014
GO

CREATE PROCEDURE sp_insertar_departamentos(
		@nombre VARCHAR(50), @descripcion VARCHAR(50)
)
AS

INSERT INTO HumanResources.Department (Name, GroupName) VALUES (@nombre, @descripcion)
GO

	

	