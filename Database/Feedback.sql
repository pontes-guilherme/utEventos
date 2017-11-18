CREATE TABLE [dbo].[Feedback]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [titulo] VARCHAR(50) NULL, 
    [descricao] TEXT NULL, 
    [data_criacao] DATETIME2 DEFAULT GETDATE()
)
