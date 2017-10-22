CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL, 
    [senha] VARCHAR(50) NOT NULL, 
    [data_nascimento] DATE NULL
)
