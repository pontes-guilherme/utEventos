CREATE TABLE [dbo].[Evento]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome] VARCHAR(50) NOT NULL, 
    [data_inicio] DATE NOT NULL, 
    [data_fim] DATE NULL
)
